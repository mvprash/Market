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
    public partial class AddStockForm : Form
    {
        public string connectionString { get; set; }
        public AddStockForm()
        {
            InitializeComponent();
            this.connectionString = @"Server=EGOVLN18\SQLEXPRESS;Database=MARKET;Trusted_Connection=True;";

        }

        private void cmdButton_Click(object sender, EventArgs e)
        {
                            // Retrieve input
                    string stockName = txtStockName.Text;

                    // Validate input
                    if (string.IsNullOrWhiteSpace(stockName))
                    {
                        lblStatus.Text = "Stock Name cannot be empty.";
                        return;
                    }

                    // Insert data into the database
                    using (SqlConnection connection = new SqlConnection(this.connectionString))
                    {
                        try
                        {
                            connection.Open();
                            string query = "INSERT INTO STOCKS (StockName) VALUES (@StockName)";
            
                            using (SqlCommand command = new SqlCommand(query, connection))
                            {
                                command.Parameters.AddWithValue("@StockName", stockName);
                
                                int rowsAffected = command.ExecuteNonQuery();
                                if (rowsAffected > 0)
                                {
                                    lblStatus.Text = "Stock added successfully.";
                                }
                                else
                                {
                                    lblStatus.Text = "Failed to add stock.";
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            lblStatus.Text = "Error:" + ex.Message;
                        }
                    }   
        }

        private void AddStockForm_Load(object sender, EventArgs e)
        {

        }
    }
}
