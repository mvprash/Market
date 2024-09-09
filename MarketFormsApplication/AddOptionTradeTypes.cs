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
    public partial class AddOptionTradeTypes : Form
    {
        public string connectionString { get; set; }
        public AddOptionTradeTypes()
        {
            InitializeComponent();
            this.connectionString = @"Server=EGOVLN18\SQLEXPRESS;Database=MARKET;Trusted_Connection=True;";
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
             // Retrieve input
        string typeDesc = txtTypeDesc.Text;

        // Validate input
        if (string.IsNullOrWhiteSpace(typeDesc) || typeDesc.Length > 5)
        {
            MessageBox.Show("TypeDesc must be non-empty and up to 5 characters long.");
            return;
        }

        // Insert data into the database
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            try
            {
                connection.Open();
                string query = "INSERT INTO OPTION_TRADE_TYPES (TypeDesc) VALUES (@TypeDesc)";
                
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@TypeDesc", typeDesc);
                    
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                         lblStatus.Text ="Trade Type added successfully.";
                        txtTypeDesc.Clear(); // Clear the input field after successful insert
                    }
                    else
                    {
                          lblStatus.Text ="Failed to add Trade Type.";
                    }
                }
            }
            catch (Exception ex)
            {
                  lblStatus.Text ="Error:" + ex.Message;
            }
         }
        }
    }
}
