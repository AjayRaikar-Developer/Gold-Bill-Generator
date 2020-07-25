namespace BillGenerator
{
    partial class GoldPurchase
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.Name = new System.Windows.Forms.TextBox();
            this.CusMobile = new System.Windows.Forms.TextBox();
            this.CusName = new System.Windows.Forms.Label();
            this.MobileNumber = new System.Windows.Forms.Label();
            this.Save = new System.Windows.Forms.Button();
            this.CusAddress = new System.Windows.Forms.TextBox();
            this.Address = new System.Windows.Forms.Label();
            this.VoucherNo = new System.Windows.Forms.Label();
            this.BillNumber = new System.Windows.Forms.TextBox();
            this.Date = new System.Windows.Forms.Label();
            this.BillDate = new System.Windows.Forms.DateTimePicker();
            this.IdProofMenu = new System.Windows.Forms.ComboBox();
            this.IDProof = new System.Windows.Forms.Label();
            this.IDProofDetails = new System.Windows.Forms.Label();
            this.CusIdDetails = new System.Windows.Forms.TextBox();
            this.GoldRate = new System.Windows.Forms.Label();
            this.GldPerGm = new System.Windows.Forms.TextBox();
            this.ItemDescription = new System.Windows.Forms.Label();
            this.GrossWeight = new System.Windows.Forms.Label();
            this.LessWeight = new System.Windows.Forms.Label();
            this.ItemDesc = new System.Windows.Forms.TextBox();
            this.GWt = new System.Windows.Forms.TextBox();
            this.LWt = new System.Windows.Forms.TextBox();
            this.PurityPercent = new System.Windows.Forms.Label();
            this.GPur = new System.Windows.Forms.TextBox();
            this.AddItem = new System.Windows.Forms.Button();
            this.ItemDetails = new System.Windows.Forms.DataGridView();
            this.SlNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HSN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GrossWt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LessWt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Purity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PureWeight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StoneValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TxnValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChargeableAmt = new System.Windows.Forms.RichTextBox();
            this.TotalChargable = new System.Windows.Forms.Label();
            this.StoneAmount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.Roundoff = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.FinalAmount = new System.Windows.Forms.RichTextBox();
            this.RoundOffAmt = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ItemDetails)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.richTextBox1.BackColor = System.Drawing.SystemColors.Info;
            this.richTextBox1.Font = new System.Drawing.Font("Calibri", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(569, -2);
            this.richTextBox1.Multiline = false;
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.richTextBox1.Size = new System.Drawing.Size(414, 62);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "Gold Purchase Bill";
            // 
            // Name
            // 
            this.Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name.Location = new System.Drawing.Point(356, 3);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(347, 30);
            this.Name.TabIndex = 2;
            // 
            // CusMobile
            // 
            this.CusMobile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CusMobile.Location = new System.Drawing.Point(356, 45);
            this.CusMobile.Name = "CusMobile";
            this.CusMobile.Size = new System.Drawing.Size(347, 30);
            this.CusMobile.TabIndex = 3;
            // 
            // CusName
            // 
            this.CusName.AutoSize = true;
            this.CusName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CusName.Location = new System.Drawing.Point(3, 0);
            this.CusName.Name = "CusName";
            this.CusName.Size = new System.Drawing.Size(68, 25);
            this.CusName.TabIndex = 4;
            this.CusName.Text = "Name";
            // 
            // MobileNumber
            // 
            this.MobileNumber.AutoSize = true;
            this.MobileNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MobileNumber.Location = new System.Drawing.Point(3, 42);
            this.MobileNumber.Name = "MobileNumber";
            this.MobileNumber.Size = new System.Drawing.Size(157, 25);
            this.MobileNumber.TabIndex = 5;
            this.MobileNumber.Text = "Mobile Number";
            // 
            // Save
            // 
            this.Save.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Save.Location = new System.Drawing.Point(978, 674);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(566, 93);
            this.Save.TabIndex = 6;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // CusAddress
            // 
            this.CusAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CusAddress.Location = new System.Drawing.Point(356, 171);
            this.CusAddress.Name = "CusAddress";
            this.CusAddress.Size = new System.Drawing.Size(347, 30);
            this.CusAddress.TabIndex = 7;
            // 
            // Address
            // 
            this.Address.AutoSize = true;
            this.Address.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Address.Location = new System.Drawing.Point(3, 168);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(92, 25);
            this.Address.TabIndex = 8;
            this.Address.Text = "Address";
            // 
            // VoucherNo
            // 
            this.VoucherNo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.VoucherNo.AutoSize = true;
            this.VoucherNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VoucherNo.Location = new System.Drawing.Point(1241, 14);
            this.VoucherNo.Name = "VoucherNo";
            this.VoucherNo.Size = new System.Drawing.Size(126, 25);
            this.VoucherNo.TabIndex = 9;
            this.VoucherNo.Text = "Voucher No";
            // 
            // BillNumber
            // 
            this.BillNumber.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BillNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BillNumber.Location = new System.Drawing.Point(1380, 14);
            this.BillNumber.Name = "BillNumber";
            this.BillNumber.Size = new System.Drawing.Size(167, 30);
            this.BillNumber.TabIndex = 10;
            // 
            // Date
            // 
            this.Date.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Date.AutoSize = true;
            this.Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Date.Location = new System.Drawing.Point(1241, 53);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(57, 25);
            this.Date.TabIndex = 11;
            this.Date.Text = "Date";
            // 
            // BillDate
            // 
            this.BillDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BillDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BillDate.Location = new System.Drawing.Point(1304, 50);
            this.BillDate.Name = "BillDate";
            this.BillDate.Size = new System.Drawing.Size(243, 30);
            this.BillDate.TabIndex = 10;
            // 
            // IdProofMenu
            // 
            this.IdProofMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdProofMenu.FormattingEnabled = true;
            this.IdProofMenu.Location = new System.Drawing.Point(356, 87);
            this.IdProofMenu.Name = "IdProofMenu";
            this.IdProofMenu.Size = new System.Drawing.Size(347, 33);
            this.IdProofMenu.TabIndex = 13;
            // 
            // IDProof
            // 
            this.IDProof.AutoSize = true;
            this.IDProof.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDProof.Location = new System.Drawing.Point(3, 84);
            this.IDProof.Name = "IDProof";
            this.IDProof.Size = new System.Drawing.Size(90, 25);
            this.IDProof.TabIndex = 14;
            this.IDProof.Text = "ID Proof";
            // 
            // IDProofDetails
            // 
            this.IDProofDetails.AutoSize = true;
            this.IDProofDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDProofDetails.Location = new System.Drawing.Point(3, 126);
            this.IDProofDetails.Name = "IDProofDetails";
            this.IDProofDetails.Size = new System.Drawing.Size(162, 25);
            this.IDProofDetails.TabIndex = 15;
            this.IDProofDetails.Text = "ID Proof Details";
            // 
            // CusIdDetails
            // 
            this.CusIdDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CusIdDetails.Location = new System.Drawing.Point(356, 129);
            this.CusIdDetails.Name = "CusIdDetails";
            this.CusIdDetails.Size = new System.Drawing.Size(347, 30);
            this.CusIdDetails.TabIndex = 16;
            // 
            // GoldRate
            // 
            this.GoldRate.AutoSize = true;
            this.GoldRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GoldRate.Location = new System.Drawing.Point(3, 132);
            this.GoldRate.Name = "GoldRate";
            this.GoldRate.Size = new System.Drawing.Size(185, 25);
            this.GoldRate.TabIndex = 17;
            this.GoldRate.Text = "Gold Rate Per Gm";
            // 
            // GldPerGm
            // 
            this.GldPerGm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GldPerGm.Location = new System.Drawing.Point(397, 135);
            this.GldPerGm.Name = "GldPerGm";
            this.GldPerGm.Size = new System.Drawing.Size(389, 30);
            this.GldPerGm.TabIndex = 18;
            // 
            // ItemDescription
            // 
            this.ItemDescription.AutoSize = true;
            this.ItemDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemDescription.Location = new System.Drawing.Point(3, 0);
            this.ItemDescription.Name = "ItemDescription";
            this.ItemDescription.Size = new System.Drawing.Size(167, 25);
            this.ItemDescription.TabIndex = 19;
            this.ItemDescription.Text = "Item Description";
            // 
            // GrossWeight
            // 
            this.GrossWeight.AutoSize = true;
            this.GrossWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrossWeight.Location = new System.Drawing.Point(3, 33);
            this.GrossWeight.Name = "GrossWeight";
            this.GrossWeight.Size = new System.Drawing.Size(143, 25);
            this.GrossWeight.TabIndex = 20;
            this.GrossWeight.Text = "Gross Weight";
            // 
            // LessWeight
            // 
            this.LessWeight.AutoSize = true;
            this.LessWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LessWeight.Location = new System.Drawing.Point(3, 66);
            this.LessWeight.Name = "LessWeight";
            this.LessWeight.Size = new System.Drawing.Size(132, 25);
            this.LessWeight.TabIndex = 21;
            this.LessWeight.Text = "Less Weight";
            // 
            // ItemDesc
            // 
            this.ItemDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemDesc.Location = new System.Drawing.Point(397, 3);
            this.ItemDesc.Name = "ItemDesc";
            this.ItemDesc.Size = new System.Drawing.Size(389, 30);
            this.ItemDesc.TabIndex = 22;
            // 
            // GWt
            // 
            this.GWt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GWt.Location = new System.Drawing.Point(397, 36);
            this.GWt.Name = "GWt";
            this.GWt.Size = new System.Drawing.Size(389, 30);
            this.GWt.TabIndex = 23;
            // 
            // LWt
            // 
            this.LWt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LWt.Location = new System.Drawing.Point(397, 69);
            this.LWt.Name = "LWt";
            this.LWt.Size = new System.Drawing.Size(389, 30);
            this.LWt.TabIndex = 24;
            // 
            // PurityPercent
            // 
            this.PurityPercent.AutoSize = true;
            this.PurityPercent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PurityPercent.Location = new System.Drawing.Point(3, 99);
            this.PurityPercent.Name = "PurityPercent";
            this.PurityPercent.Size = new System.Drawing.Size(86, 25);
            this.PurityPercent.TabIndex = 25;
            this.PurityPercent.Text = "Purity%";
            // 
            // GPur
            // 
            this.GPur.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GPur.Location = new System.Drawing.Point(397, 102);
            this.GPur.Name = "GPur";
            this.GPur.Size = new System.Drawing.Size(389, 30);
            this.GPur.TabIndex = 26;
            // 
            // AddItem
            // 
            this.AddItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddItem.Location = new System.Drawing.Point(758, 327);
            this.AddItem.Name = "AddItem";
            this.AddItem.Size = new System.Drawing.Size(789, 52);
            this.AddItem.TabIndex = 27;
            this.AddItem.Text = "Add Item";
            this.AddItem.UseVisualStyleBackColor = true;
            this.AddItem.Click += new System.EventHandler(this.AddItem_Click);
            // 
            // ItemDetails
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            this.ItemDetails.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.ItemDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ItemDetails.BackgroundColor = System.Drawing.Color.LightSalmon;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ItemDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.ItemDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ItemDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SlNo,
            this.Description,
            this.HSN,
            this.GrossWt,
            this.LessWt,
            this.Purity,
            this.PureWeight,
            this.Rate,
            this.StoneValue,
            this.TxnValue,
            this.Total});
            this.ItemDetails.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.ItemDetails.Location = new System.Drawing.Point(12, 423);
            this.ItemDetails.Name = "ItemDetails";
            this.ItemDetails.RowHeadersWidth = 51;
            this.ItemDetails.RowTemplate.Height = 24;
            this.ItemDetails.Size = new System.Drawing.Size(1532, 210);
            this.ItemDetails.TabIndex = 28;
            // 
            // SlNo
            // 
            this.SlNo.HeaderText = "SL No";
            this.SlNo.MinimumWidth = 6;
            this.SlNo.Name = "SlNo";
            this.SlNo.Width = 125;
            // 
            // Description
            // 
            this.Description.HeaderText = "Description";
            this.Description.MinimumWidth = 6;
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            this.Description.Width = 125;
            // 
            // HSN
            // 
            this.HSN.HeaderText = "HSN";
            this.HSN.MinimumWidth = 6;
            this.HSN.Name = "HSN";
            this.HSN.Width = 125;
            // 
            // GrossWt
            // 
            this.GrossWt.HeaderText = "Gross Weight";
            this.GrossWt.MinimumWidth = 6;
            this.GrossWt.Name = "GrossWt";
            this.GrossWt.ReadOnly = true;
            this.GrossWt.Width = 125;
            // 
            // LessWt
            // 
            this.LessWt.HeaderText = "Less Weight";
            this.LessWt.MinimumWidth = 6;
            this.LessWt.Name = "LessWt";
            this.LessWt.ReadOnly = true;
            this.LessWt.Width = 125;
            // 
            // Purity
            // 
            this.Purity.HeaderText = "Purity";
            this.Purity.MinimumWidth = 6;
            this.Purity.Name = "Purity";
            this.Purity.ReadOnly = true;
            this.Purity.Width = 125;
            // 
            // PureWeight
            // 
            this.PureWeight.HeaderText = "PureWeight";
            this.PureWeight.MinimumWidth = 6;
            this.PureWeight.Name = "PureWeight";
            this.PureWeight.ReadOnly = true;
            this.PureWeight.Width = 125;
            // 
            // Rate
            // 
            this.Rate.HeaderText = "Rate";
            this.Rate.MinimumWidth = 6;
            this.Rate.Name = "Rate";
            this.Rate.ReadOnly = true;
            this.Rate.Width = 125;
            // 
            // StoneValue
            // 
            this.StoneValue.HeaderText = "Stone Amount";
            this.StoneValue.MinimumWidth = 6;
            this.StoneValue.Name = "StoneValue";
            this.StoneValue.Width = 125;
            // 
            // TxnValue
            // 
            this.TxnValue.HeaderText = "TxnAmount";
            this.TxnValue.MinimumWidth = 6;
            this.TxnValue.Name = "TxnValue";
            this.TxnValue.ReadOnly = true;
            this.TxnValue.Width = 125;
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.MinimumWidth = 6;
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            this.Total.Width = 125;
            // 
            // ChargeableAmt
            // 
            this.ChargeableAmt.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ChargeableAmt.BackColor = System.Drawing.SystemColors.Info;
            this.ChargeableAmt.Font = new System.Drawing.Font("Calibri", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChargeableAmt.Location = new System.Drawing.Point(206, 674);
            this.ChargeableAmt.Name = "ChargeableAmt";
            this.ChargeableAmt.ReadOnly = true;
            this.ChargeableAmt.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ChargeableAmt.Size = new System.Drawing.Size(322, 39);
            this.ChargeableAmt.TabIndex = 29;
            this.ChargeableAmt.Text = "";
            // 
            // TotalChargable
            // 
            this.TotalChargable.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.TotalChargable.AutoSize = true;
            this.TotalChargable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalChargable.Location = new System.Drawing.Point(15, 674);
            this.TotalChargable.Name = "TotalChargable";
            this.TotalChargable.Size = new System.Drawing.Size(167, 25);
            this.TotalChargable.TabIndex = 30;
            this.TotalChargable.Text = "Total Chargable";
            // 
            // StoneAmount
            // 
            this.StoneAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StoneAmount.Location = new System.Drawing.Point(397, 168);
            this.StoneAmount.Name = "StoneAmount";
            this.StoneAmount.Size = new System.Drawing.Size(389, 30);
            this.StoneAmount.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 25);
            this.label1.TabIndex = 31;
            this.label1.Text = "Stone Amount";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.CusName, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.MobileNumber, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.IDProof, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.IDProofDetails, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.Address, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.Name, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.CusMobile, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.IdProofMenu, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.CusIdDetails, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.CusAddress, 1, 4);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 87);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(706, 211);
            this.tableLayoutPanel1.TabIndex = 33;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.ItemDescription, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.ItemDesc, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.GrossWeight, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.GPur, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.GldPerGm, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.GWt, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.GoldRate, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.LessWeight, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.PurityPercent, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.LWt, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.StoneAmount, 1, 5);
            this.tableLayoutPanel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel2.Location = new System.Drawing.Point(758, 90);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 6;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(789, 204);
            this.tableLayoutPanel2.TabIndex = 34;
            // 
            // Roundoff
            // 
            this.Roundoff.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Roundoff.AutoSize = true;
            this.Roundoff.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Roundoff.Location = new System.Drawing.Point(15, 728);
            this.Roundoff.Name = "Roundoff";
            this.Roundoff.Size = new System.Drawing.Size(109, 25);
            this.Roundoff.TabIndex = 35;
            this.Roundoff.Text = "Round Off";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(674, 674);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 29);
            this.label2.TabIndex = 37;
            this.label2.Text = "Total Amount";
            // 
            // FinalAmount
            // 
            this.FinalAmount.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.FinalAmount.BackColor = System.Drawing.SystemColors.Info;
            this.FinalAmount.Font = new System.Drawing.Font("Calibri", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FinalAmount.Location = new System.Drawing.Point(601, 728);
            this.FinalAmount.Name = "FinalAmount";
            this.FinalAmount.ReadOnly = true;
            this.FinalAmount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.FinalAmount.Size = new System.Drawing.Size(322, 39);
            this.FinalAmount.TabIndex = 38;
            this.FinalAmount.Text = "";
            // 
            // RoundOffAmt
            // 
            this.RoundOffAmt.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.RoundOffAmt.BackColor = System.Drawing.SystemColors.Info;
            this.RoundOffAmt.Font = new System.Drawing.Font("Calibri", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoundOffAmt.Location = new System.Drawing.Point(206, 728);
            this.RoundOffAmt.Name = "RoundOffAmt";
            this.RoundOffAmt.ReadOnly = true;
            this.RoundOffAmt.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RoundOffAmt.Size = new System.Drawing.Size(322, 39);
            this.RoundOffAmt.TabIndex = 39;
            this.RoundOffAmt.Text = "";
            // 
            // GoldPurchase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1736, 812);
            this.Controls.Add(this.RoundOffAmt);
            this.Controls.Add(this.FinalAmount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Roundoff);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.TotalChargable);
            this.Controls.Add(this.ChargeableAmt);
            this.Controls.Add(this.ItemDetails);
            this.Controls.Add(this.AddItem);
            this.Controls.Add(this.BillDate);
            this.Controls.Add(this.Date);
            this.Controls.Add(this.VoucherNo);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.BillNumber);
            this.Text = "GoldPurchase";
            ((System.ComponentModel.ISupportInitialize)(this.ItemDetails)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox Name;
        private System.Windows.Forms.TextBox CusMobile;
        private new System.Windows.Forms.Label CusName;
        private System.Windows.Forms.Label MobileNumber;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.TextBox CusAddress;
        private System.Windows.Forms.Label Address;
        private System.Windows.Forms.Label VoucherNo;
        private System.Windows.Forms.Label Date;
        private System.Windows.Forms.DateTimePicker BillDate;
        private System.Windows.Forms.ComboBox IdProofMenu;
        private System.Windows.Forms.Label IDProof;
        private System.Windows.Forms.Label IDProofDetails;
        private System.Windows.Forms.TextBox CusIdDetails;
        private System.Windows.Forms.Label GoldRate;
        private System.Windows.Forms.TextBox GldPerGm;
        private System.Windows.Forms.Label ItemDescription;
        private System.Windows.Forms.Label GrossWeight;
        private System.Windows.Forms.Label LessWeight;
        private System.Windows.Forms.TextBox ItemDesc;
        private System.Windows.Forms.TextBox GWt;
        private System.Windows.Forms.TextBox LWt;
        private System.Windows.Forms.Label PurityPercent;
        private System.Windows.Forms.TextBox GPur;
        private System.Windows.Forms.Button AddItem;
        private System.Windows.Forms.DataGridView ItemDetails;
        private System.Windows.Forms.RichTextBox ChargeableAmt;
        private System.Windows.Forms.Label TotalChargable;
        private System.Windows.Forms.TextBox StoneAmount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox BillNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn SlNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn HSN;
        private System.Windows.Forms.DataGridViewTextBoxColumn GrossWt;
        private System.Windows.Forms.DataGridViewTextBoxColumn LessWt;
        private System.Windows.Forms.DataGridViewTextBoxColumn Purity;
        private System.Windows.Forms.DataGridViewTextBoxColumn PureWeight;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rate;
        private System.Windows.Forms.DataGridViewTextBoxColumn StoneValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn TxnValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label Roundoff;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox FinalAmount;
        private System.Windows.Forms.RichTextBox RoundOffAmt;
    }
}