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
    public partial class AddStockTradesForm : Form
    {
        
        public string connectionString { get; set; }      
        

        public AddStockTradesForm()
        {
            InitializeComponent();
            this.connectionString = @"Server=EGOVLN18\SQLEXPRESS;Database=MARKET;Trusted_Connection=True;";
        }

        private void AddStockTradesForm_Load(object sender, EventArgs e)
        {
            LoadStockIDs();
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
                    cmbStockID.Items.Clear();
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
                lblStatus.Text="Error loading stock IDs:"+ ex.Message;
            }
        }
    }

       

        private void ClearFields()
        {
            cmbStockID.SelectedIndex = -1;
            txtEntryPrice.Clear();
            txtExitPrice.Clear();
            dtpDateOfEntry.Value = DateTime.Now; // Reset to current date
        }

        private void btnAddStockTrade_Click_1(object sender, EventArgs e)
        {
            if (cmbStockID.SelectedItem == null)
            {
                MessageBox.Show("Please select a valid StockID.");
                return;
            }

            int stockID = ((ComboBoxItem)cmbStockID.SelectedItem).Value;
            decimal entryPrice, exitPrice;
            DateTime dateOfEntry = dtpDateOfEntry.Value;

            // Validate and parse inputs
            if (!decimal.TryParse(txtEntryPrice.Text, out entryPrice))
            {
                MessageBox.Show("Invalid Entry Price.");
                return;
            }

            if (!decimal.TryParse(txtExitPrice.Text, out exitPrice))
            {
                MessageBox.Show("Invalid Exit Price.");
                return;
            }

            // Insert data into the database
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "INSERT INTO STOCK_TRADES (StockID, DateOfEntry, EntryPrice, ExitPrice) " +
                                   "VALUES (@StockID, @DateOfEntry, @EntryPrice, @ExitPrice)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@StockID", stockID);
                        command.Parameters.AddWithValue("@DateOfEntry", dateOfEntry);
                        command.Parameters.AddWithValue("@EntryPrice", entryPrice);
                        command.Parameters.AddWithValue("@ExitPrice", exitPrice);

                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Stock trade added successfully.");
                            ClearFields(); // Clear input fields after successful insert
                        }
                        else
                        {
                            MessageBox.Show("Failed to add stock trade.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    lblStatus.Text = "Error:" + ex.Message;
                }
            }

        }
    }


}
