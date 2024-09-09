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
    public partial class EditStockTradesForm : Form
    {

        
     public string connectionString { get; set; }

    

        public EditStockTradesForm()
        {
            InitializeComponent();
            this.connectionString = @"Server=EGOVLN18\SQLEXPRESS;Database=MARKET;Trusted_Connection=True;";
        }

        private void EditStockTradesForm_Load(object sender, EventArgs e)
        {
            LoadStockTrades();
            SetupDataGridView();
        }
        private void SetupDataGridView()
        {
        dataGridView1.AutoGenerateColumns = false;


        // Define columns
        dataGridView1.Columns.Clear();

        dataGridView1.Columns.Add(new DataGridViewComboBoxColumn
        {
            Name = "StockID",
            HeaderText = "StockID",
            DataPropertyName = "StockID",
            DataSource = GetStockList(),
            DisplayMember = "Text",
            ValueMember = "Value"
        });

        dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
        {
            Name = "DateOfEntry",
            HeaderText = "Date Of Entry",
            DataPropertyName = "DateOfEntry"
        });

        dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
        {
            Name = "EntryPrice",
            HeaderText = "Entry Price",
            DataPropertyName = "EntryPrice"
        });

        dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
        {
            Name = "ExitPrice",
            HeaderText = "Exit Price",
            DataPropertyName = "ExitPrice"
        });

        
    }

private DataTable GetStockList()
{
    DataTable dataTable = new DataTable();
    dataTable.Columns.Add("Value", typeof(int));
    dataTable.Columns.Add("Text", typeof(string));

    using (SqlConnection connection = new SqlConnection(connectionString))
    {
        try
        {
            connection.Open();
            string query = "SELECT StockID, StockName FROM STOCKS";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    dataTable.Rows.Add(reader["StockID"], reader["StockName"]);
                }
            }
        }
        catch (Exception ex)
        {
            lblStatus.Text="Error loading stock list:" + ex.Message;
        }
    }

    return dataTable;
}

private void LoadStockTrades()
{
    using (SqlConnection connection = new SqlConnection(connectionString))
    {
        try
        {
            connection.Open();
            string query = "SELECT TradeID, StockID, DateOfEntry, EntryPrice, ExitPrice FROM STOCK_TRADES";

            using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
            {
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
            }
        }
        catch (Exception ex)
        {
            lblStatus.Text="Error loading stock trades: "+ex.Message;
        }
    }
}

    private void btnSaveChanges_Click(object sender, EventArgs e)
    {
         using (SqlConnection connection = new SqlConnection(connectionString))
    {
        try
        {
            connection.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM STOCK_TRADES", connection);
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(adapter);

            DataTable changes = ((DataTable)dataGridView1.DataSource).GetChanges();
            if (changes != null)
            {
                adapter.Update(changes);
                 lblStatus.Text= "Changes saved successfully.";
                ((DataTable)dataGridView1.DataSource).AcceptChanges();
            }
            else
            {
                MessageBox.Show("No changes to save.");
            }
        }
        catch (Exception ex)
        {
            lblStatus.Text="Error saving changes:" + ex.Message;
        }
    }
    }
    }
}
