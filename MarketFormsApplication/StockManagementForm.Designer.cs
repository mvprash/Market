namespace MarketFormsApplication
{
    partial class StockManagementForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSaveChanges = new System.Windows.Forms.Button();
            this.dataGridViewStocks = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStocks)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.Location = new System.Drawing.Point(73, 174);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(75, 23);
            this.btnSaveChanges.TabIndex = 6;
            this.btnSaveChanges.Text = "Update";
            this.btnSaveChanges.UseVisualStyleBackColor = true;
            this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click_1);
            // 
            // dataGridViewStocks
            // 
            this.dataGridViewStocks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStocks.Location = new System.Drawing.Point(73, 18);
            this.dataGridViewStocks.Name = "dataGridViewStocks";
            this.dataGridViewStocks.Size = new System.Drawing.Size(797, 150);
            this.dataGridViewStocks.TabIndex = 7;
            // 
            // StockManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 261);
            this.Controls.Add(this.dataGridViewStocks);
            this.Controls.Add(this.btnSaveChanges);
            this.Name = "StockManagementForm";
            this.Text = "EditStockForm";
            this.Load += new System.EventHandler(this.StockManagementForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStocks)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSaveChanges;
        private System.Windows.Forms.DataGridView dataGridViewStocks;
    }
}