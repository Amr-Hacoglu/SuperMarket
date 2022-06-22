namespace SuperMarket
{
    partial class SellingForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle43 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle44 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle45 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle37 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle38 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle39 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle40 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle41 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle42 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SellingForm));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.button6 = new System.Windows.Forms.Button();
            this.BillsDGV = new Guna.UI.WinForms.GunaDataGridView();
            this.button8 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SellProdPriceTbl = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.SellProdQtyTbl = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.SellProdNameTbl = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.SellCatCbTbl = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BillIdTbl = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.OrderDGV = new Guna.UI.WinForms.GunaDataGridView();
            this.PId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AmtPriceTbl = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SellerNameTbl = new System.Windows.Forms.Label();
            this.button11 = new System.Windows.Forms.Button();
            this.SellProdDGV = new Guna.UI.WinForms.GunaDataGridView();
            this.SellDateTbl = new System.Windows.Forms.Label();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.BillsDGV)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrderDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SellProdDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 12;
            this.bunifuElipse1.TargetControl = this;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.White;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.button6.ForeColor = System.Drawing.Color.Brown;
            this.button6.Location = new System.Drawing.Point(185, 233);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(90, 28);
            this.button6.TabIndex = 22;
            this.button6.Text = "Refresh";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // BillsDGV
            // 
            dataGridViewCellStyle43.BackColor = System.Drawing.Color.White;
            this.BillsDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle43;
            this.BillsDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.BillsDGV.BackgroundColor = System.Drawing.Color.White;
            this.BillsDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BillsDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.BillsDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle44.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle44.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle44.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle44.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle44.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle44.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle44.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.BillsDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle44;
            this.BillsDGV.ColumnHeadersHeight = 4;
            dataGridViewCellStyle45.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle45.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle45.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle45.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle45.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle45.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle45.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.BillsDGV.DefaultCellStyle = dataGridViewCellStyle45;
            this.BillsDGV.EnableHeadersVisualStyles = false;
            this.BillsDGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.BillsDGV.Location = new System.Drawing.Point(317, 284);
            this.BillsDGV.Name = "BillsDGV";
            this.BillsDGV.RowHeadersVisible = false;
            this.BillsDGV.RowHeadersWidth = 51;
            this.BillsDGV.RowTemplate.Height = 24;
            this.BillsDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.BillsDGV.Size = new System.Drawing.Size(478, 177);
            this.BillsDGV.TabIndex = 20;
            this.BillsDGV.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.BillsDGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.BillsDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.BillsDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.BillsDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.BillsDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.BillsDGV.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.BillsDGV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.BillsDGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.BillsDGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.BillsDGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.BillsDGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.BillsDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.BillsDGV.ThemeStyle.HeaderStyle.Height = 4;
            this.BillsDGV.ThemeStyle.ReadOnly = false;
            this.BillsDGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.BillsDGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.BillsDGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.BillsDGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BillsDGV.ThemeStyle.RowsStyle.Height = 24;
            this.BillsDGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.BillsDGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.BillsDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.BillsDGV_CellContentClick);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.White;
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold);
            this.button8.ForeColor = System.Drawing.Color.Brown;
            this.button8.Location = new System.Drawing.Point(715, 471);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(80, 31);
            this.button8.TabIndex = 18;
            this.button8.Text = "PRINT";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.White;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold);
            this.button4.ForeColor = System.Drawing.Color.Brown;
            this.button4.Location = new System.Drawing.Point(317, 471);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(80, 31);
            this.button4.TabIndex = 15;
            this.button4.Text = "ADD";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // SellProdPriceTbl
            // 
            this.SellProdPriceTbl.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SellProdPriceTbl.Enabled = false;
            this.SellProdPriceTbl.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.SellProdPriceTbl.ForeColor = System.Drawing.Color.Black;
            this.SellProdPriceTbl.HintForeColor = System.Drawing.Color.White;
            this.SellProdPriceTbl.HintText = "";
            this.SellProdPriceTbl.isPassword = false;
            this.SellProdPriceTbl.LineFocusedColor = System.Drawing.Color.WhiteSmoke;
            this.SellProdPriceTbl.LineIdleColor = System.Drawing.Color.White;
            this.SellProdPriceTbl.LineMouseHoverColor = System.Drawing.Color.WhiteSmoke;
            this.SellProdPriceTbl.LineThickness = 2;
            this.SellProdPriceTbl.Location = new System.Drawing.Point(112, 109);
            this.SellProdPriceTbl.Margin = new System.Windows.Forms.Padding(4);
            this.SellProdPriceTbl.Name = "SellProdPriceTbl";
            this.SellProdPriceTbl.Size = new System.Drawing.Size(163, 31);
            this.SellProdPriceTbl.TabIndex = 14;
            this.SellProdPriceTbl.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // SellProdQtyTbl
            // 
            this.SellProdQtyTbl.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SellProdQtyTbl.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.SellProdQtyTbl.ForeColor = System.Drawing.Color.Black;
            this.SellProdQtyTbl.HintForeColor = System.Drawing.Color.White;
            this.SellProdQtyTbl.HintText = "";
            this.SellProdQtyTbl.isPassword = false;
            this.SellProdQtyTbl.LineFocusedColor = System.Drawing.Color.WhiteSmoke;
            this.SellProdQtyTbl.LineIdleColor = System.Drawing.Color.White;
            this.SellProdQtyTbl.LineMouseHoverColor = System.Drawing.Color.WhiteSmoke;
            this.SellProdQtyTbl.LineThickness = 2;
            this.SellProdQtyTbl.Location = new System.Drawing.Point(112, 144);
            this.SellProdQtyTbl.Margin = new System.Windows.Forms.Padding(4);
            this.SellProdQtyTbl.Name = "SellProdQtyTbl";
            this.SellProdQtyTbl.Size = new System.Drawing.Size(163, 31);
            this.SellProdQtyTbl.TabIndex = 13;
            this.SellProdQtyTbl.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // SellProdNameTbl
            // 
            this.SellProdNameTbl.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SellProdNameTbl.Enabled = false;
            this.SellProdNameTbl.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.SellProdNameTbl.ForeColor = System.Drawing.Color.Black;
            this.SellProdNameTbl.HintForeColor = System.Drawing.Color.White;
            this.SellProdNameTbl.HintText = "";
            this.SellProdNameTbl.isPassword = false;
            this.SellProdNameTbl.LineFocusedColor = System.Drawing.Color.WhiteSmoke;
            this.SellProdNameTbl.LineIdleColor = System.Drawing.Color.White;
            this.SellProdNameTbl.LineMouseHoverColor = System.Drawing.Color.WhiteSmoke;
            this.SellProdNameTbl.LineThickness = 2;
            this.SellProdNameTbl.Location = new System.Drawing.Point(112, 70);
            this.SellProdNameTbl.Margin = new System.Windows.Forms.Padding(4);
            this.SellProdNameTbl.Name = "SellProdNameTbl";
            this.SellProdNameTbl.Size = new System.Drawing.Size(163, 31);
            this.SellProdNameTbl.TabIndex = 12;
            this.SellProdNameTbl.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // SellCatCbTbl
            // 
            this.SellCatCbTbl.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.SellCatCbTbl.ForeColor = System.Drawing.Color.Brown;
            this.SellCatCbTbl.FormattingEnabled = true;
            this.SellCatCbTbl.Items.AddRange(new object[] {
            "Admin",
            "Seller"});
            this.SellCatCbTbl.Location = new System.Drawing.Point(9, 233);
            this.SellCatCbTbl.Name = "SellCatCbTbl";
            this.SellCatCbTbl.Size = new System.Drawing.Size(163, 28);
            this.SellCatCbTbl.TabIndex = 11;
            this.SellCatCbTbl.Text = "Select Category";
            this.SellCatCbTbl.SelectedIndexChanged += new System.EventHandler(this.SellCatCbTbl_SelectedIndexChanged);
            this.SellCatCbTbl.SelectionChangeCommitted += new System.EventHandler(this.SellCatCbTbl_SelectionChangeCommitted);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(5, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 19);
            this.label5.TabIndex = 8;
            this.label5.Text = "Price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(5, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "Quantity";
            // 
            // BillIdTbl
            // 
            this.BillIdTbl.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.BillIdTbl.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.BillIdTbl.ForeColor = System.Drawing.Color.Black;
            this.BillIdTbl.HintForeColor = System.Drawing.Color.White;
            this.BillIdTbl.HintText = "";
            this.BillIdTbl.isPassword = false;
            this.BillIdTbl.LineFocusedColor = System.Drawing.Color.WhiteSmoke;
            this.BillIdTbl.LineIdleColor = System.Drawing.Color.White;
            this.BillIdTbl.LineMouseHoverColor = System.Drawing.Color.WhiteSmoke;
            this.BillIdTbl.LineThickness = 2;
            this.BillIdTbl.Location = new System.Drawing.Point(112, 31);
            this.BillIdTbl.Margin = new System.Windows.Forms.Padding(4);
            this.BillIdTbl.Name = "BillIdTbl";
            this.BillIdTbl.Size = new System.Drawing.Size(163, 31);
            this.BillIdTbl.TabIndex = 3;
            this.BillIdTbl.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(5, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "BILLID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12.5F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(368, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "SELLING";
            // 
            // button5
            // 
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold);
            this.button5.ForeColor = System.Drawing.Color.Brown;
            this.button5.Location = new System.Drawing.Point(962, 2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(34, 34);
            this.button5.TabIndex = 8;
            this.button5.Text = "x";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(5, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "ProdName";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Brown;
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.OrderDGV);
            this.panel1.Controls.Add(this.AmtPriceTbl);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.SellerNameTbl);
            this.panel1.Controls.Add(this.button11);
            this.panel1.Controls.Add(this.SellProdDGV);
            this.panel1.Controls.Add(this.SellDateTbl);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.BillsDGV);
            this.panel1.Controls.Add(this.button8);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.SellProdPriceTbl);
            this.panel1.Controls.Add(this.SellProdQtyTbl);
            this.panel1.Controls.Add(this.SellProdNameTbl);
            this.panel1.Controls.Add(this.SellCatCbTbl);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.BillIdTbl);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(170, 54);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(815, 511);
            this.panel1.TabIndex = 5;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12.5F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(511, 256);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 25);
            this.label8.TabIndex = 32;
            this.label8.Text = "Sells List";
            // 
            // OrderDGV
            // 
            dataGridViewCellStyle37.BackColor = System.Drawing.Color.White;
            this.OrderDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle37;
            this.OrderDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.OrderDGV.BackgroundColor = System.Drawing.Color.White;
            this.OrderDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.OrderDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.OrderDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle38.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle38.BackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle38.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle38.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle38.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle38.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle38.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.OrderDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle38;
            this.OrderDGV.ColumnHeadersHeight = 30;
            this.OrderDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PId,
            this.PName,
            this.PPrice,
            this.PQuantity,
            this.Total});
            dataGridViewCellStyle39.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle39.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle39.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle39.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle39.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle39.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle39.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.OrderDGV.DefaultCellStyle = dataGridViewCellStyle39;
            this.OrderDGV.EnableHeadersVisualStyles = false;
            this.OrderDGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.OrderDGV.Location = new System.Drawing.Point(317, 55);
            this.OrderDGV.Name = "OrderDGV";
            this.OrderDGV.RowHeadersVisible = false;
            this.OrderDGV.RowHeadersWidth = 51;
            this.OrderDGV.RowTemplate.Height = 24;
            this.OrderDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.OrderDGV.Size = new System.Drawing.Size(478, 151);
            this.OrderDGV.TabIndex = 31;
            this.OrderDGV.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.OrderDGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.OrderDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.OrderDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.OrderDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.OrderDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.OrderDGV.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.OrderDGV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.OrderDGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.IndianRed;
            this.OrderDGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.OrderDGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.OrderDGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.OrderDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.OrderDGV.ThemeStyle.HeaderStyle.Height = 30;
            this.OrderDGV.ThemeStyle.ReadOnly = false;
            this.OrderDGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.OrderDGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.OrderDGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.OrderDGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.OrderDGV.ThemeStyle.RowsStyle.Height = 24;
            this.OrderDGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.OrderDGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // PId
            // 
            this.PId.HeaderText = "ProdID";
            this.PId.MinimumWidth = 6;
            this.PId.Name = "PId";
            // 
            // PName
            // 
            this.PName.HeaderText = "ProdName";
            this.PName.MinimumWidth = 6;
            this.PName.Name = "PName";
            // 
            // PPrice
            // 
            this.PPrice.HeaderText = "ProdPrice";
            this.PPrice.MinimumWidth = 6;
            this.PPrice.Name = "PPrice";
            // 
            // PQuantity
            // 
            this.PQuantity.HeaderText = "ProdQty";
            this.PQuantity.MinimumWidth = 6;
            this.PQuantity.Name = "PQuantity";
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.MinimumWidth = 6;
            this.Total.Name = "Total";
            // 
            // AmtPriceTbl
            // 
            this.AmtPriceTbl.AutoSize = true;
            this.AmtPriceTbl.Font = new System.Drawing.Font("Century Gothic", 12.5F, System.Drawing.FontStyle.Bold);
            this.AmtPriceTbl.ForeColor = System.Drawing.Color.White;
            this.AmtPriceTbl.Location = new System.Drawing.Point(604, 209);
            this.AmtPriceTbl.Name = "AmtPriceTbl";
            this.AmtPriceTbl.Size = new System.Drawing.Size(33, 25);
            this.AmtPriceTbl.TabIndex = 30;
            this.AmtPriceTbl.Text = "Rs";
            this.AmtPriceTbl.Click += new System.EventHandler(this.label7_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12.5F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(472, 209);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 25);
            this.label6.TabIndex = 29;
            this.label6.Text = "Amount Rs : ";
            // 
            // SellerNameTbl
            // 
            this.SellerNameTbl.AutoSize = true;
            this.SellerNameTbl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.SellerNameTbl.ForeColor = System.Drawing.Color.Gold;
            this.SellerNameTbl.Location = new System.Drawing.Point(110, 4);
            this.SellerNameTbl.Name = "SellerNameTbl";
            this.SellerNameTbl.Size = new System.Drawing.Size(62, 23);
            this.SellerNameTbl.TabIndex = 28;
            this.SellerNameTbl.Text = "Seller";
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.White;
            this.button11.FlatAppearance.BorderSize = 0;
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.button11.ForeColor = System.Drawing.Color.Brown;
            this.button11.Location = new System.Drawing.Point(9, 196);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(265, 31);
            this.button11.TabIndex = 25;
            this.button11.Text = "Add Product";
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // SellProdDGV
            // 
            dataGridViewCellStyle40.BackColor = System.Drawing.Color.White;
            this.SellProdDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle40;
            this.SellProdDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.SellProdDGV.BackgroundColor = System.Drawing.Color.White;
            this.SellProdDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SellProdDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.SellProdDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle41.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle41.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle41.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle41.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle41.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle41.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle41.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.SellProdDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle41;
            this.SellProdDGV.ColumnHeadersHeight = 4;
            dataGridViewCellStyle42.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle42.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle42.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle42.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle42.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle42.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle42.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.SellProdDGV.DefaultCellStyle = dataGridViewCellStyle42;
            this.SellProdDGV.EnableHeadersVisualStyles = false;
            this.SellProdDGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.SellProdDGV.Location = new System.Drawing.Point(9, 267);
            this.SellProdDGV.Name = "SellProdDGV";
            this.SellProdDGV.RowHeadersVisible = false;
            this.SellProdDGV.RowHeadersWidth = 51;
            this.SellProdDGV.RowTemplate.Height = 24;
            this.SellProdDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.SellProdDGV.Size = new System.Drawing.Size(269, 231);
            this.SellProdDGV.TabIndex = 24;
            this.SellProdDGV.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.SellProdDGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.SellProdDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.SellProdDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.SellProdDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.SellProdDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.SellProdDGV.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.SellProdDGV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.SellProdDGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.SellProdDGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.SellProdDGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.SellProdDGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.SellProdDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.SellProdDGV.ThemeStyle.HeaderStyle.Height = 4;
            this.SellProdDGV.ThemeStyle.ReadOnly = false;
            this.SellProdDGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.SellProdDGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.SellProdDGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.SellProdDGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.SellProdDGV.ThemeStyle.RowsStyle.Height = 24;
            this.SellProdDGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.SellProdDGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.SellProdDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SellProdDGV_CellContentClick);
            // 
            // SellDateTbl
            // 
            this.SellDateTbl.AutoSize = true;
            this.SellDateTbl.Font = new System.Drawing.Font("Century Gothic", 12.5F, System.Drawing.FontStyle.Bold);
            this.SellDateTbl.ForeColor = System.Drawing.Color.White;
            this.SellDateTbl.Location = new System.Drawing.Point(672, 17);
            this.SellDateTbl.Name = "SellDateTbl";
            this.SellDateTbl.Size = new System.Drawing.Size(60, 25);
            this.SellDateTbl.TabIndex = 23;
            this.SellDateTbl.Text = "Date";
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.Brown;
            this.label7.Location = new System.Drawing.Point(88, 542);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 23);
            this.label7.TabIndex = 33;
            this.label7.Text = "Logout";
            this.label7.Click += new System.EventHandler(this.label7_Click_1);
            // 
            // SellingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 604);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SellingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SellingForm";
            this.Load += new System.EventHandler(this.SellingForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BillsDGV)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrderDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SellProdDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button6;
        private Guna.UI.WinForms.GunaDataGridView BillsDGV;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button4;
        private Bunifu.Framework.UI.BunifuMaterialTextbox SellProdPriceTbl;
        private Bunifu.Framework.UI.BunifuMaterialTextbox SellProdQtyTbl;
        private Bunifu.Framework.UI.BunifuMaterialTextbox SellProdNameTbl;
        private System.Windows.Forms.ComboBox SellCatCbTbl;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuMaterialTextbox BillIdTbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label SellDateTbl;
        private Guna.UI.WinForms.GunaDataGridView SellProdDGV;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Label SellerNameTbl;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label AmtPriceTbl;
        private Guna.UI.WinForms.GunaDataGridView OrderDGV;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn PId;
        private System.Windows.Forms.DataGridViewTextBoxColumn PName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn PQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Label label7;
    }
}