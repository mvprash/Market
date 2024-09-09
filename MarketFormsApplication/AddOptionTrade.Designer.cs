namespace MarketFormsApplication
{
    partial class AddOptionTrade
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
            this.dtpMonth = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPremiumEntryPrice = new System.Windows.Forms.TextBox();
            this.txtPremiumExitPrice = new System.Windows.Forms.TextBox();
            this.cmbStockID = new System.Windows.Forms.ComboBox();
            this.cmbOptionTradeTypeID = new System.Windows.Forms.ComboBox();
            this.labelStock = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLotSize = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAddOptionTrade = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dtpMonth
            // 
            this.dtpMonth.Location = new System.Drawing.Point(210, 75);
            this.dtpMonth.Name = "dtpMonth";
            this.dtpMonth.Size = new System.Drawing.Size(159, 20);
            this.dtpMonth.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(71, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Date Of Trade";
            // 
            // txtPremiumEntryPrice
            // 
            this.txtPremiumEntryPrice.Location = new System.Drawing.Point(210, 101);
            this.txtPremiumEntryPrice.Name = "txtPremiumEntryPrice";
            this.txtPremiumEntryPrice.Size = new System.Drawing.Size(159, 20);
            this.txtPremiumEntryPrice.TabIndex = 3;
            // 
            // txtPremiumExitPrice
            // 
            this.txtPremiumExitPrice.Location = new System.Drawing.Point(210, 127);
            this.txtPremiumExitPrice.Name = "txtPremiumExitPrice";
            this.txtPremiumExitPrice.Size = new System.Drawing.Size(159, 20);
            this.txtPremiumExitPrice.TabIndex = 4;
            // 
            // cmbStockID
            // 
            this.cmbStockID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStockID.FormattingEnabled = true;
            this.cmbStockID.Location = new System.Drawing.Point(210, 43);
            this.cmbStockID.Name = "cmbStockID";
            this.cmbStockID.Size = new System.Drawing.Size(159, 21);
            this.cmbStockID.TabIndex = 5;
            // 
            // cmbOptionTradeTypeID
            // 
            this.cmbOptionTradeTypeID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOptionTradeTypeID.FormattingEnabled = true;
            this.cmbOptionTradeTypeID.Location = new System.Drawing.Point(472, 43);
            this.cmbOptionTradeTypeID.Name = "cmbOptionTradeTypeID";
            this.cmbOptionTradeTypeID.Size = new System.Drawing.Size(121, 21);
            this.cmbOptionTradeTypeID.TabIndex = 6;
            // 
            // labelStock
            // 
            this.labelStock.AutoSize = true;
            this.labelStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStock.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelStock.Location = new System.Drawing.Point(71, 40);
            this.labelStock.Name = "labelStock";
            this.labelStock.Size = new System.Drawing.Size(50, 20);
            this.labelStock.TabIndex = 7;
            this.labelStock.Text = "Stock";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(392, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label3.Location = new System.Drawing.Point(71, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Entry Price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label4.Location = new System.Drawing.Point(71, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Exit Price";
            // 
            // txtLotSize
            // 
            this.txtLotSize.Location = new System.Drawing.Point(471, 78);
            this.txtLotSize.Name = "txtLotSize";
            this.txtLotSize.Size = new System.Drawing.Size(159, 20);
            this.txtLotSize.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label5.Location = new System.Drawing.Point(392, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Lot Size";
            // 
            // btnAddOptionTrade
            // 
            this.btnAddOptionTrade.Location = new System.Drawing.Point(210, 190);
            this.btnAddOptionTrade.Name = "btnAddOptionTrade";
            this.btnAddOptionTrade.Size = new System.Drawing.Size(75, 23);
            this.btnAddOptionTrade.TabIndex = 13;
            this.btnAddOptionTrade.Text = "Add";
            this.btnAddOptionTrade.UseVisualStyleBackColor = true;
            this.btnAddOptionTrade.Click += new System.EventHandler(this.btnAddOptionTrade_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.Maroon;
            this.lblStatus.Location = new System.Drawing.Point(206, 150);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 24);
            this.lblStatus.TabIndex = 14;
            // 
            // AddOptionTrade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 261);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnAddOptionTrade);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtLotSize);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelStock);
            this.Controls.Add(this.cmbOptionTradeTypeID);
            this.Controls.Add(this.cmbStockID);
            this.Controls.Add(this.txtPremiumExitPrice);
            this.Controls.Add(this.txtPremiumEntryPrice);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpMonth);
            this.Name = "AddOptionTrade";
            this.Text = "AddOptionTrade";
            this.Load += new System.EventHandler(this.AddOptionTrade_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpMonth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPremiumEntryPrice;
        private System.Windows.Forms.TextBox txtPremiumExitPrice;
        private System.Windows.Forms.ComboBox cmbStockID;
        private System.Windows.Forms.ComboBox cmbOptionTradeTypeID;
        private System.Windows.Forms.Label labelStock;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtLotSize;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAddOptionTrade;
        private System.Windows.Forms.Label lblStatus;
    }
}