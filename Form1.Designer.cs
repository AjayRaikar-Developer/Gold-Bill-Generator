namespace BillGenerator
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SALES = new System.Windows.Forms.Button();
            this.PURCHASE = new System.Windows.Forms.Button();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.purchaseMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.goldToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.silverToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.goldToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.silverToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salesMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.purchaseMenu.SuspendLayout();
            this.salesMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.richTextBox1.BackColor = System.Drawing.SystemColors.Info;
            this.richTextBox1.Font = new System.Drawing.Font("Calibri", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(396, 26);
            this.richTextBox1.Multiline = false;
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.richTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBox1.Size = new System.Drawing.Size(622, 87);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "Welcome To Bill Generator";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // SALES
            // 
            this.SALES.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.SALES.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SALES.Font = new System.Drawing.Font("Calibri", 25.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SALES.Location = new System.Drawing.Point(237, 370);
            this.SALES.Name = "SALES";
            this.SALES.Size = new System.Drawing.Size(1151, 90);
            this.SALES.TabIndex = 2;
            this.SALES.Text = "SALES BILL";
            this.SALES.UseVisualStyleBackColor = false;
            this.SALES.Click += new System.EventHandler(this.button2_Click);
            // 
            // PURCHASE
            // 
            this.PURCHASE.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.PURCHASE.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PURCHASE.Font = new System.Drawing.Font("Calibri", 25.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PURCHASE.Location = new System.Drawing.Point(237, 241);
            this.PURCHASE.Name = "PURCHASE";
            this.PURCHASE.Size = new System.Drawing.Size(1151, 90);
            this.PURCHASE.TabIndex = 3;
            this.PURCHASE.Text = "PURCHASE BILL";
            this.PURCHASE.UseVisualStyleBackColor = false;
            this.PURCHASE.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // richTextBox2
            // 
            this.richTextBox2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.richTextBox2.BackColor = System.Drawing.SystemColors.Info;
            this.richTextBox2.Font = new System.Drawing.Font("Brush Script Std", 25F, System.Drawing.FontStyle.Bold);
            this.richTextBox2.Location = new System.Drawing.Point(532, 575);
            this.richTextBox2.Multiline = false;
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.ReadOnly = true;
            this.richTextBox2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.richTextBox2.Size = new System.Drawing.Size(522, 56);
            this.richTextBox2.TabIndex = 4;
            this.richTextBox2.Text = "Created By - Ajay Raikar";
            this.richTextBox2.TextChanged += new System.EventHandler(this.richTextBox2_TextChanged);
            // 
            // purchaseMenu
            // 
            this.purchaseMenu.Font = new System.Drawing.Font("Segoe UI", 25F);
            this.purchaseMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.purchaseMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.goldToolStripMenuItem1,
            this.silverToolStripMenuItem1});
            this.purchaseMenu.Name = "contextMenuStrip1";
            this.purchaseMenu.Size = new System.Drawing.Size(210, 128);
            this.purchaseMenu.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // goldToolStripMenuItem1
            // 
            this.goldToolStripMenuItem1.Name = "goldToolStripMenuItem1";
            this.goldToolStripMenuItem1.Size = new System.Drawing.Size(209, 62);
            this.goldToolStripMenuItem1.Text = "Gold";
            this.goldToolStripMenuItem1.Click += new System.EventHandler(this.GoldPurchaseItemClick);
            // 
            // silverToolStripMenuItem1
            // 
            this.silverToolStripMenuItem1.Name = "silverToolStripMenuItem1";
            this.silverToolStripMenuItem1.Size = new System.Drawing.Size(209, 62);
            this.silverToolStripMenuItem1.Text = "Silver";
            this.silverToolStripMenuItem1.Click += new System.EventHandler(this.SilverPurchaseItemClick);
            // 
            // goldToolStripMenuItem
            // 
            this.goldToolStripMenuItem.Name = "goldToolStripMenuItem";
            this.goldToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // silverToolStripMenuItem
            // 
            this.silverToolStripMenuItem.Name = "silverToolStripMenuItem";
            this.silverToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // salesMenu
            // 
            this.salesMenu.Font = new System.Drawing.Font("Segoe UI", 25F);
            this.salesMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.salesMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2});
            this.salesMenu.Name = "contextMenuStrip1";
            this.salesMenu.Size = new System.Drawing.Size(211, 156);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(210, 62);
            this.toolStripMenuItem1.Text = "Gold";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.GoldSaleItemClick);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(210, 62);
            this.toolStripMenuItem2.Text = "Silver";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.SilverSaleItemClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1676, 665);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.PURCHASE);
            this.Controls.Add(this.SALES);
            this.Controls.Add(this.richTextBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.purchaseMenu.ResumeLayout(false);
            this.salesMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button SALES;
        private System.Windows.Forms.Button PURCHASE;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.ContextMenuStrip purchaseMenu;
        private System.Windows.Forms.ToolStripMenuItem goldToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem silverToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem goldToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem silverToolStripMenuItem1;
        private System.Windows.Forms.ContextMenuStrip salesMenu;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
    }
}

