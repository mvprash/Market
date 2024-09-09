namespace MarketFormsApplication
{
    partial class mainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.summaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addStockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addOptionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tradesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addOptionToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.addStockToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.updateOptionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateStockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateStockToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.actionsToolStripMenuItem,
            this.tradesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(355, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.summaryToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // summaryToolStripMenuItem
            // 
            this.summaryToolStripMenuItem.Name = "summaryToolStripMenuItem";
            this.summaryToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.summaryToolStripMenuItem.Text = "Summary";
            this.summaryToolStripMenuItem.Click += new System.EventHandler(this.summaryToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // actionsToolStripMenuItem
            // 
            this.actionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addStockToolStripMenuItem,
            this.addOptionToolStripMenuItem,
            this.updateStockToolStripMenuItem1});
            this.actionsToolStripMenuItem.Name = "actionsToolStripMenuItem";
            this.actionsToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.actionsToolStripMenuItem.Text = "Actions";
            // 
            // addStockToolStripMenuItem
            // 
            this.addStockToolStripMenuItem.Name = "addStockToolStripMenuItem";
            this.addStockToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.addStockToolStripMenuItem.Text = "Add Stock";
            this.addStockToolStripMenuItem.Click += new System.EventHandler(this.addStockToolStripMenuItem_Click);
            // 
            // addOptionToolStripMenuItem
            // 
            this.addOptionToolStripMenuItem.Name = "addOptionToolStripMenuItem";
            this.addOptionToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.addOptionToolStripMenuItem.Text = "Add Option Type";
            this.addOptionToolStripMenuItem.Click += new System.EventHandler(this.addOptionToolStripMenuItem_Click);
            // 
            // tradesToolStripMenuItem
            // 
            this.tradesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addOptionToolStripMenuItem1,
            this.addStockToolStripMenuItem1,
            this.updateOptionToolStripMenuItem,
            this.updateStockToolStripMenuItem});
            this.tradesToolStripMenuItem.Name = "tradesToolStripMenuItem";
            this.tradesToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.tradesToolStripMenuItem.Text = "Trades";
            // 
            // addOptionToolStripMenuItem1
            // 
            this.addOptionToolStripMenuItem1.Name = "addOptionToolStripMenuItem1";
            this.addOptionToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.addOptionToolStripMenuItem1.Text = "Add Option";
            this.addOptionToolStripMenuItem1.Click += new System.EventHandler(this.addOptionToolStripMenuItem1_Click);
            // 
            // addStockToolStripMenuItem1
            // 
            this.addStockToolStripMenuItem1.Name = "addStockToolStripMenuItem1";
            this.addStockToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.addStockToolStripMenuItem1.Text = "Add Stock";
            this.addStockToolStripMenuItem1.Click += new System.EventHandler(this.addStockToolStripMenuItem1_Click);
            // 
            // updateOptionToolStripMenuItem
            // 
            this.updateOptionToolStripMenuItem.Name = "updateOptionToolStripMenuItem";
            this.updateOptionToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.updateOptionToolStripMenuItem.Text = "Update Option";
            this.updateOptionToolStripMenuItem.Click += new System.EventHandler(this.updateOptionToolStripMenuItem_Click);
            // 
            // updateStockToolStripMenuItem
            // 
            this.updateStockToolStripMenuItem.Name = "updateStockToolStripMenuItem";
            this.updateStockToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.updateStockToolStripMenuItem.Text = "Update Stock";
            this.updateStockToolStripMenuItem.Click += new System.EventHandler(this.updateStockToolStripMenuItem_Click);
            // 
            // updateStockToolStripMenuItem1
            // 
            this.updateStockToolStripMenuItem1.Name = "updateStockToolStripMenuItem1";
            this.updateStockToolStripMenuItem1.Size = new System.Drawing.Size(163, 22);
            this.updateStockToolStripMenuItem1.Text = "Update Stock";
            this.updateStockToolStripMenuItem1.Click += new System.EventHandler(this.updateStockToolStripMenuItem1_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 261);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "mainForm";
            this.Text = "Market";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addStockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addOptionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tradesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addOptionToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem addStockToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem updateOptionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateStockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem summaryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateStockToolStripMenuItem1;
    }
}

