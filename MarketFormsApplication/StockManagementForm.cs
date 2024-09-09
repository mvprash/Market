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
    public partial class StockManagementForm : Form
    {


        public string connectionString { get; set; }      
        
        

        public StockManagementForm()
        {
            InitializeComponent();
            this.connectionString = @"Server=EGOVLN18\SQLEXPRESS;Database=MARKET;Trusted_Connection=True;";
        }

        private void StockManagementForm_Load(object sender, EventArgs e)
        {
            LoadStockData();
        }

        private void LoadStockData()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM STOCKS", connection))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataGridViewStocks.DataSource = dataTable;
                }
            }
        }

        
        private void btnSaveChanges_Click_1(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.Text;

                    foreach (DataGridViewRow row in dataGridViewStocks.Rows)
                    {
                        if (row.IsNewRow) continue;

                        int stockID = Convert.ToInt32(row.Cells["StockID"].Value);
                        string stockName = row.Cells["StockName"].Value.ToString();
                        int currentPrice = Convert.ToInt32(row.Cells["CurrentPrice"].Value);

                        command.CommandText = "UPDATE STOCKS SET StockName = @StockName, CurrentPrice = @CurrentPrice WHERE StockID = @StockID";
                        command.Parameters.Clear();
                        command.Parameters.AddWithValue("@StockID", stockID);
                        command.Parameters.AddWithValue("@StockName", stockName);
                        command.Parameters.AddWithValue("@CurrentPrice", currentPrice);

                        connection.Open();
                        command.ExecuteNonQuery();
                        connection.Close();
                    }

                    MessageBox.Show("Stock data updated successfully.");
                }
            }

        }

        
    }
}
