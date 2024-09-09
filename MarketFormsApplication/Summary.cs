using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarketFormsApplication
{
    public partial class Summary : Form
    {
        public string connectionString { get; set; }
        public string EffectivePriceAfterProfitBooking { get; set; }
        public Summary()
        {
            InitializeComponent();
            this.connectionString = @"Server=EGOVLN18\SQLEXPRESS;Database=MARKET;Trusted_Connection=True;";
        }

        private void Summary_Load(object sender, EventArgs e)
        {
            PopulateComboBox();
        }
        private void PopulateComboBox()
        {
            
            string query = "SELECT StockID, StockName FROM STOCKS";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    DataTable dt = new DataTable();
                    dt.Load(reader);

                    comboBox1.DataSource = dt;
                    comboBox1.DisplayMember = "StockName";
                    comboBox1.ValueMember = "StockID";
                }
            }
        }

        public void ExecuteQuery(int StockID)
        {
            
            string query = @"
                IF OBJECT_ID('tempdb..#TempPriceDifference') IS NOT NULL
                    DROP TABLE #TempPriceDifference;

                CREATE TABLE #TempPriceDifference (
                    TotalPriceDifference DECIMAL(18, 0)
                );

                INSERT INTO #TempPriceDifference
                EXEC CalculatePriceDifferences " + StockID + @";

                SELECT 
                    (SELECT EntryPrice FROM [dbo].[STOCK_TRADES] WHERE StockID=" + StockID + @" and TradeID = (SELECT MIN(TradeID) FROM [STOCK_TRADES] WHERE StockID=" + StockID + @")) AS EntryPrice,
                    (SELECT SUM(PremiumEntryPrice) - SUM(PremiumexitPrice) FROM [dbo].[OPTION_TRADES] WHERE StockID=" + StockID + @") AS PremiumDifference,                    
                    (SELECT TotalPriceDifference FROM #TempPriceDifference) AS TotalPriceDifference,                    
                    (SELECT CurrentPrice FROM [dbo].[STOCKS] WHERE StockID=" + StockID + @") AS CurrentPrice,
                    (select ExitPrice from STOCK_TRADES where StockID=" + StockID + @" and TradeID=(select MAX(TradeID) from STOCK_TRADES where StockID=" + StockID + @")) as StockExitPrice;

                DROP TABLE #TempPriceDifference;
            ";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        decimal entryPrice = reader.GetDecimal(0);
                        decimal premiumDifference = reader.GetDecimal(1);
                        decimal totalPriceDifference = reader.GetDecimal(2);
                        decimal currentPrice = reader.GetInt32(3);
                        decimal stockExitPrice = reader.GetDecimal(4);

                        lblEntryPrice.Text=entryPrice.ToString();
                        lblOPPremium.Text = premiumDifference.ToString();
                        lblCurrentPrice.Text = currentPrice.ToString();
                        GetEffectivePrice(StockID);

                        lblPLBooked.Text = this.EffectivePriceAfterProfitBooking;

                        //lblEffectivePrice.Text = (entryPrice + (-1 * premiumDifference) + (-1 * totalPriceDifference)).ToString();
                        lblEffectivePrice.Text = ( Convert.ToDecimal(this.EffectivePriceAfterProfitBooking) + (-1 * premiumDifference)).ToString();

                        if (stockExitPrice == 0)
                        {
                            lblOverallProfit.Text = (currentPrice - Convert.ToDecimal(lblEffectivePrice.Text)).ToString();
                            lblStockExitPrice.Text = "Not Squared OFF";
                        }
                        else
                        {
                            lblOverallProfit.Text = (stockExitPrice - Convert.ToDecimal(lblEffectivePrice.Text)).ToString();
                            lblStockExitPrice.Text = stockExitPrice.ToString();
                        }
                        // Change color based on value for lblOPPremium
                        if (premiumDifference >= 0)
                        {
                            lblOPPremium.ForeColor = System.Drawing.Color.Green;
                        }
                        else
                        {
                            lblOPPremium.ForeColor = System.Drawing.Color.Red;
                        }

                        // Change color based on value for lblPLBooked
                        if (currentPrice > Convert.ToDecimal(this.EffectivePriceAfterProfitBooking))
                        {
                            lblPLBooked.ForeColor = System.Drawing.Color.Green;
                        }
                        else
                        {
                            lblPLBooked.ForeColor = System.Drawing.Color.Red;
                        }

                        // Change color based on value for lblEffectivePrice
                        decimal effectivePrice = entryPrice + (-1 * premiumDifference) + (-1 * totalPriceDifference);
                        if (effectivePrice >= 0)
                        {
                            lblEffectivePrice.ForeColor = System.Drawing.Color.Green;
                        }
                        else
                        {
                            lblEffectivePrice.ForeColor = System.Drawing.Color.Red;
                        }
                        if (currentPrice > Convert.ToDecimal(this.EffectivePriceAfterProfitBooking))
                        {
                            lblOverallProfit.ForeColor = System.Drawing.Color.Green;
                        }
                        else
                        {
                            lblOverallProfit.ForeColor = System.Drawing.Color.Red;
                        }
                    }
                }
            }
        }
        private void GetEffectivePrice(int stockID)
            {
                // Define the connection string (adjust as needed)
                

                // Create the SQL connection
                using (SqlConnection connection = new SqlConnection(this.connectionString))
                {
                    // Create the SQL command
                    using (SqlCommand command = new SqlCommand("GetEffectivePrice", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        // Add input parameter for StockID
                        command.Parameters.AddWithValue("@StockID", stockID);

                        // Add output parameters
                        SqlParameter avgEntryPriceParam = new SqlParameter("@AverageEntryPrice", SqlDbType.Decimal)
                        {
                            Direction = ParameterDirection.Output,
                            Precision = 18,
                            Scale = 0
                        };
                        command.Parameters.Add(avgEntryPriceParam);

                        SqlParameter avgExitPriceParam = new SqlParameter("@AverageExitPrice", SqlDbType.Decimal)
                        {
                            Direction = ParameterDirection.Output,
                            Precision = 18,
                            Scale = 0
                        };
                        command.Parameters.Add(avgExitPriceParam);

                        SqlParameter effectiveAvgPriceParam = new SqlParameter("@EffectiveAveragePrice", SqlDbType.Decimal)
                        {
                            Direction = ParameterDirection.Output,
                            Precision = 18,
                            Scale = 0
                        };
                        command.Parameters.Add(effectiveAvgPriceParam);

                        SqlParameter effectiveEntryPriceParam = new SqlParameter("@EffectiveEntryPrice", SqlDbType.Decimal)
                        {
                            Direction = ParameterDirection.Output,
                            Precision = 18,
                            Scale = 0
                        };
                        command.Parameters.Add(effectiveEntryPriceParam);

                        // Open the connection
                        connection.Open();

                        // Execute the stored procedure
                        command.ExecuteNonQuery();

                        // Retrieve the output parameter values
                        decimal averageEntryPrice = (decimal)command.Parameters["@AverageEntryPrice"].Value;
                        decimal averageExitPrice = (decimal)command.Parameters["@AverageExitPrice"].Value;
                        decimal effectiveAveragePrice = (decimal)command.Parameters["@EffectiveAveragePrice"].Value;
                        decimal effectiveEntryPrice = (decimal)command.Parameters["@EffectiveEntryPrice"].Value;

                        this.EffectivePriceAfterProfitBooking = effectiveEntryPrice.ToString();
                        // Display the results (for example purposes)
                        //Console.WriteLine($"Average Entry Price: {averageEntryPrice}");
                        //Console.WriteLine($"Average Exit Price: {averageExitPrice}");
                        //Console.WriteLine($"Effective Average Price: {effectiveAveragePrice}");
                        //Console.WriteLine($"Effective Entry Price: {effectiveEntryPrice}");
                    }
                }
            }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                int StockID;
                //if (int.TryParse(comboBox1.SelectedItem.ToString(), out StockID))
                if (int.TryParse(comboBox1.SelectedValue.ToString(), out StockID))
                {
                    ExecuteQuery(StockID);
                }
                else
                {
                    MessageBox.Show("Invalid StockID selected.");
                }
            }
            else
            {
                MessageBox.Show("Please select a StockID.");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}
