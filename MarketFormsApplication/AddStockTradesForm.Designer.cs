namespace MarketFormsApplication
{
    partial class AddStockTradesForm
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtExitPrice = new System.Windows.Forms.TextBox();
            this.txtEntryPrice = new System.Windows.Forms.TextBox();
            this.labelStock = new System.Windows.Forms.Label();
            this.cmbStockID = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpDateOfEntry = new System.Windows.Forms.DateTimePicker();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnAddStockTrade = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label4.Location = new System.Drawing.Point(403, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "Exit Price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label3.Location = new System.Drawing.Point(403, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Entry Price";
            // 
            // txtExitPrice
            // 
            this.txtExitPrice.Location = new System.Drawing.Point(542, 134);
            this.txtExitPrice.Name = "txtExitPrice";
            this.txtExitPrice.Size = new System.Drawing.Size(159, 20);
            this.txtExitPrice.TabIndex = 12;
            // 
            // txtEntryPrice
            // 
            this.txtEntryPrice.Location = new System.Drawing.Point(542, 108);
            this.txtEntryPrice.Name = "txtEntryPrice";
            this.txtEntryPrice.Size = new System.Drawing.Size(159, 20);
            this.txtEntryPrice.TabIndex = 11;
            // 
            // labelStock
            // 
            this.labelStock.AutoSize = true;
            this.labelStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStock.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelStock.Location = new System.Drawing.Point(403, 48);
            this.labelStock.Name = "labelStock";
            this.labelStock.Size = new System.Drawing.Size(50, 20);
            this.labelStock.TabIndex = 18;
            this.labelStock.Text = "Stock";
            // 
            // cmbStockID
            // 
            this.cmbStockID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStockID.FormattingEnabled = true;
            this.cmbStockID.Location = new System.Drawing.Point(542, 51);
            this.cmbStockID.Name = "cmbStockID";
            this.cmbStockID.Size = new System.Drawing.Size(159, 21);
            this.cmbStockID.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(403, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "Date Of Trade";
            // 
            // dtpDateOfEntry
            // 
            this.dtpDateOfEntry.Location = new System.Drawing.Point(542, 83);
            this.dtpDateOfEntry.Name = "dtpDateOfEntry";
            this.dtpDateOfEntry.Size = new System.Drawing.Size(159, 20);
            this.dtpDateOfEntry.TabIndex = 15;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.Maroon;
            this.lblStatus.Location = new System.Drawing.Point(538, 206);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 24);
            this.lblStatus.TabIndex = 19;
            // 
            // btnAddStockTrade
            // 
            this.btnAddStockTrade.Location = new System.Drawing.Point(542, 171);
            this.btnAddStockTrade.Name = "btnAddStockTrade";
            this.btnAddStockTrade.Size = new System.Drawing.Size(75, 23);
            this.btnAddStockTrade.TabIndex = 20;
            this.btnAddStockTrade.Text = "Add";
            this.btnAddStockTrade.UseVisualStyleBackColor = true;
            this.btnAddStockTrade.Click += new System.EventHandler(this.btnAddStockTrade_Click_1);
            // 
            // AddStockTradesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 261);
            this.Controls.Add(this.btnAddStockTrade);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.labelStock);
            this.Controls.Add(this.cmbStockID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpDateOfEntry);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtExitPrice);
            this.Controls.Add(this.txtEntryPrice);
            this.Name = "AddStockTradesForm";
            this.Text = "AddStockTrade";
            this.Load += new System.EventHandler(this.AddStockTradesForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtExitPrice;
        private System.Windows.Forms.TextBox txtEntryPrice;
        private System.Windows.Forms.Label labelStock;
        private System.Windows.Forms.ComboBox cmbStockID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpDateOfEntry;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnAddStockTrade;
    }
}