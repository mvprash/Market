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
 public partial class EditOptionTradesForm : Form
{
     public string connectionString { get; set; }

    public EditOptionTradesForm()
    {
        InitializeComponent();
        this.connectionString = @"Server=EGOVLN18\SQLEXPRESS;Database=MARKET;Trusted_Connection=True;";
    }

    private void EditOptionTradesForm_Load(object sender, EventArgs e)
    {
        LoadOptionTrades();
        SetupDataGridView();
    }

     private void SetupDataGridView()
{
    // Ensure DataGridView columns are set up correctly
    dataGridView1.AutoGenerateColumns = false;

    // Define columns
    dataGridView1.Columns.Clear();

    // Add columns
    dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
    {
        Name = "TradeID",
        HeaderText = "TradeID",
        DataPropertyName = "TradeID",
        ReadOnly = true
    });

    dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
    {
        Name = "Month",
        HeaderText = "Month",
        DataPropertyName = "Month"
    });

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
        Name = "PremiumEntryPrice",
        HeaderText = "Premium Entry Price",
        DataPropertyName = "PremiumEntryPrice"
    });

    dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
    {
        Name = "PremiumExitPrice",
        HeaderText = "Premium Exit Price",
        DataPropertyName = "PremiumExitPrice"
    });

    dataGridView1.Columns.Add(new DataGridViewComboBoxColumn
    {
        Name = "OptionTradeTypeID",
        HeaderText = "Option Trade Type ID",
        DataPropertyName = "OptionTradeTypeID",
        DataSource = GetOptionTradeTypeList(),
        DisplayMember = "Text",
        ValueMember = "Value"
    });

    dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
    {
        Name = "LotSize",
        HeaderText = "Lot Size",
        DataPropertyName = "LotSize"
    });

  
    dataGridView1.Columns["StockID"].CellTemplate = new DataGridViewComboBoxCell
    {
        DataSource = GetStockList(),
        DisplayMember = "Text",
        ValueMember = "Value"
    };

    dataGridView1.Columns["OptionTradeTypeID"].CellTemplate = new DataGridViewComboBoxCell
    {
        DataSource = GetOptionTradeTypeList(),
        DisplayMember = "Text",
        ValueMember = "Value"
    };
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
            lblStatus.Text="Error loading stock list" + ex.Message;
        }
    }

    return dataTable;
}

private DataTable GetOptionTradeTypeList()
{
    DataTable dataTable = new DataTable();
    dataTable.Columns.Add("Value", typeof(int));
    dataTable.Columns.Add("Text", typeof(string));

    using (SqlConnection connection = new SqlConnection(connectionString))
    {
        try
        {
            connection.Open();
            string query = "SELECT TradeTypeID, TypeDesc FROM OPTION_TRADE_TYPES";
            
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    dataTable.Rows.Add(reader["TradeTypeID"], reader["TypeDesc"]);
                }
            }
        }
        catch (Exception ex)
        {
            lblStatus.Text="Error loading option trade type list" +ex.Message;
        }
    }

    return dataTable;
}

    private void LoadOptionTrades()
    {
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            try
            {
                connection.Open();
                string query = "SELECT TradeID, Month, StockID, PremiumEntryPrice, PremiumExitPrice, OptionTradeTypeID, LotSize FROM OPTION_TRADES";
                
                using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataGridView1.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                 lblStatus.Text="Error loading data" + ex.Message;
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
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM OPTION_TRADES", connection);
                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(adapter);
                
                DataTable changes = ((DataTable)dataGridView1.DataSource).GetChanges();
                if (changes != null)
                {
                    adapter.Update(changes);
                    MessageBox.Show("Changes saved successfully.");
                    ((DataTable)dataGridView1.DataSource).AcceptChanges();
                }
                else
                {
                    MessageBox.Show("No changes to save.");
                }
            }
            catch (Exception ex)
            {
                lblStatus.Text="Error saving changes"+ ex.Message;
            }
        }
    }

  
}
}
