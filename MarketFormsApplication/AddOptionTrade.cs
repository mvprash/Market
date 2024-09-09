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
    public partial class AddOptionTrade : Form
    {
        
        public string connectionString { get; set; }
        
        public AddOptionTrade()
        {
            InitializeComponent();
            this.connectionString = @"Server=EGOVLN18\SQLEXPRESS;Database=MARKET;Trusted_Connection=True;";
        }

       private void btnAddOptionTrade_Click(object sender, EventArgs e)
            {
                int stockID = ((ComboBoxItem)cmbStockID.SelectedItem).Value;
                int optionTradeTypeID = ((ComboBoxItem)cmbOptionTradeTypeID.SelectedItem).Value;
                decimal premiumEntryPrice, premiumExitPrice;
                int lotSize;
                DateTime month;

                // Validate and parse inputs
                if (!decimal.TryParse(txtPremiumEntryPrice.Text, out premiumEntryPrice) ||
                    !decimal.TryParse(txtPremiumExitPrice.Text, out premiumExitPrice))
                {
                     lblStatus.Text="Invalid Premium Entry/Exit Price.";
                    return;
                }

                if (!int.TryParse(txtLotSize.Text, out lotSize))
                {
                     lblStatus.Text="Invalid LotSize.";
                    return;
                }

                month = dtpMonth.Value; // Get the date from DateTimePicker

                // Insert data into the database
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();
                        string query = "INSERT INTO OPTION_TRADES (Month, StockID, PremiumEntryPrice, PremiumExitPrice, OptionTradeTypeID, LotSize) " +
                                       "VALUES (@Month, @StockID, @PremiumEntryPrice, @PremiumExitPrice, @OptionTradeTypeID, @LotSize)";
            
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@Month", month);
                            command.Parameters.AddWithValue("@StockID", stockID);
                            command.Parameters.AddWithValue("@PremiumEntryPrice", premiumEntryPrice);
                            command.Parameters.AddWithValue("@PremiumExitPrice", premiumExitPrice);
                            command.Parameters.AddWithValue("@OptionTradeTypeID", optionTradeTypeID);
                            command.Parameters.AddWithValue("@LotSize", lotSize);
                
                            int rowsAffected = command.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                 lblStatus.Text="Option Trade added successfully.";
                                ClearFields(); // Clear input fields after successful insert
                            }
                            else
                            {
                                lblStatus.Text = "Failed to add Option Trade.";
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                         lblStatus.Text="Error"+ ex.Message;
                    }
                }
            }

       private void ClearFields()
       {
           cmbStockID.SelectedIndex = -1;
           cmbOptionTradeTypeID.SelectedIndex = -1;
           txtPremiumEntryPrice.Clear();
           txtPremiumExitPrice.Clear();
           txtLotSize.Clear();
           dtpMonth.Value = DateTime.Now; // Reset to current date
       }

        private void LoadStockIDs()
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();
                        string query = "SELECT StockID, StockName FROM STOCKS";
            
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            SqlDataReader reader = command.ExecuteReader();
                            cmbStockID.Items.Clear(); // Clear previous items
                            while (reader.Read())
                            {
                                cmbStockID.Items.Add(new ComboBoxItem
                                {
                                    Text = reader["StockName"].ToString(),
                                    Value = (int)reader["StockID"]
                                });
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        lblStatus.Text= "Error:" +ex.Message;
                    }
                }
            }

            private void LoadOptionTradeTypes()
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();
                        string query = "SELECT TradeTypeID, TypeDesc FROM OPTION_TRADE_TYPES";
            
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            SqlDataReader reader = command.ExecuteReader();
                            cmbOptionTradeTypeID.Items.Clear(); // Clear previous items
                            while (reader.Read())
                            {
                                cmbOptionTradeTypeID.Items.Add(new ComboBoxItem
                                {
                                    Text = reader["TypeDesc"].ToString(),
                                    Value = (int)reader["TradeTypeID"]
                                });
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        lblStatus.Text = "Error:" + ex.Message;
                    }
                }
            }

            private void AddOptionTrade_Load(object sender, EventArgs e)
            {
                LoadStockIDs();
                LoadOptionTradeTypes();
            }

    }

    public class ComboBoxItem
    {
        public int Value { get; set; }
        public string Text { get; set; }

        public override string ToString()
        {
            return Text;
        }
    }

}
