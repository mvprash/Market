using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarketFormsApplication
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void addStockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                // Create an instance of the AddStockForm (assuming it's another form you created)
                AddStockForm addStockForm = new AddStockForm();
                addStockForm.MdiParent = this; // If using MDI (Multiple Document Interface), set the parent
                addStockForm.Show(); // Show the AddStockForm
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void addOptionToolStripMenuItem_Click(object sender, EventArgs e)
        {

            try
            {
                // Create an instance of the AddStockForm (assuming it's another form you created)
                AddOptionTradeTypes addOptionTypeForm = new AddOptionTradeTypes();
                addOptionTypeForm.MdiParent = this; // If using MDI (Multiple Document Interface), set the parent
                addOptionTypeForm.Show(); // Show the AddStockForm
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void addOptionToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                // Create an instance of the AddStockForm (assuming it's another form you created)
                AddOptionTrade addOptionTradeForm = new AddOptionTrade();
                addOptionTradeForm.MdiParent = this; // If using MDI (Multiple Document Interface), set the parent
                addOptionTradeForm.Show(); // Show the AddStockForm
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void updateOptionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                // Create an instance of the AddStockForm (assuming it's another form you created)
                EditOptionTradesForm editOptionTradeForm = new EditOptionTradesForm();
                editOptionTradeForm.MdiParent = this; // If using MDI (Multiple Document Interface), set the parent
                editOptionTradeForm.Show(); // Show the AddStockForm
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void addStockToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                // Create an instance of the AddStockForm (assuming it's another form you created)
                AddStockTradesForm addStockTrade = new AddStockTradesForm();
                addStockTrade.MdiParent = this; // If using MDI (Multiple Document Interface), set the parent
                addStockTrade.Show(); // Show the AddStockForm
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void updateStockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                // Create an instance of the AddStockForm (assuming it's another form you created)
                EditStockTradesForm editStockTradeForm = new EditStockTradesForm();
                editStockTradeForm.MdiParent = this; // If using MDI (Multiple Document Interface), set the parent
                editStockTradeForm.Show(); // Show the AddStockForm
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void summaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                // Create an instance of the AddStockForm (assuming it's another form you created)
                Summary summaryForm = new Summary();
                summaryForm.MdiParent = this; // If using MDI (Multiple Document Interface), set the parent
                summaryForm.Show(); // Show the AddStockForm
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void updateStockToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                // Create an instance of the AddStockForm (assuming it's another form you created)
                StockManagementForm stockEditForm = new StockManagementForm();
                stockEditForm.MdiParent = this; // If using MDI (Multiple Document Interface), set the parent
                stockEditForm.Show(); // Show the AddStockForm
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
