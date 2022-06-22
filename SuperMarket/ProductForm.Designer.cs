namespace SuperMarket
{
    partial class ProductForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.SearchCb = new System.Windows.Forms.ComboBox();
            this.ProdDGV = new Guna.UI.WinForms.GunaDataGridView();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.ProdPriceTbl = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.ProdQtyTbl = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.ProdNameTbl = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.CatCbTbl = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ProdIDTbl = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProdDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SaddleBrown;
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.SearchCb);
            this.panel1.Controls.Add(this.ProdDGV);
            this.panel1.Controls.Add(this.button9);
            this.panel1.Controls.Add(this.button8);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.ProdPriceTbl);
            this.panel1.Controls.Add(this.ProdQtyTbl);
            this.panel1.Controls.Add(this.ProdNameTbl);
            this.panel1.Controls.Add(this.CatCbTbl);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.ProdIDTbl);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(163, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(815, 511);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.White;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.button6.ForeColor = System.Drawing.Color.SaddleBrown;
            this.button6.Location = new System.Drawing.Point(635, 52);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(90, 28);
            this.button6.TabIndex = 22;
            this.button6.Text = "Refresh";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // SearchCb
            // 
            this.SearchCb.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.SearchCb.ForeColor = System.Drawing.Color.SaddleBrown;
            this.SearchCb.FormattingEnabled = true;
            this.SearchCb.Items.AddRange(new object[] {
            "Admin",
            "Seller"});
            this.SearchCb.Location = new System.Drawing.Point(466, 52);
            this.SearchCb.Name = "SearchCb";
            this.SearchCb.Size = new System.Drawing.Size(163, 28);
            this.SearchCb.TabIndex = 21;
            this.SearchCb.Text = "Select Category";
            this.SearchCb.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // ProdDGV
            // 
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            this.ProdDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.ProdDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ProdDGV.BackgroundColor = System.Drawing.Color.White;
            this.ProdDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ProdDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.ProdDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ProdDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.ProdDGV.ColumnHeadersHeight = 30;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ProdDGV.DefaultCellStyle = dataGridViewCellStyle12;
            this.ProdDGV.EnableHeadersVisualStyles = false;
            this.ProdDGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ProdDGV.Location = new System.Drawing.Point(319, 88);
            this.ProdDGV.Name = "ProdDGV";
            this.ProdDGV.RowHeadersVisible = false;
            this.ProdDGV.RowHeadersWidth = 51;
            this.ProdDGV.RowTemplate.Height = 24;
            this.ProdDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ProdDGV.Size = new System.Drawing.Size(478, 401);
            this.ProdDGV.TabIndex = 20;
            this.ProdDGV.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.ProdDGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.ProdDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.ProdDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.ProdDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.ProdDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.ProdDGV.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.ProdDGV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ProdDGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.Black;
            this.ProdDGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.ProdDGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.ProdDGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.ProdDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.ProdDGV.ThemeStyle.HeaderStyle.Height = 30;
            this.ProdDGV.ThemeStyle.ReadOnly = false;
            this.ProdDGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.ProdDGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.ProdDGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.ProdDGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ProdDGV.ThemeStyle.RowsStyle.Height = 24;
            this.ProdDGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ProdDGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.ProdDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gunaDataGridView1_CellContentClick);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.White;
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold);
            this.button9.ForeColor = System.Drawing.Color.SaddleBrown;
            this.button9.Location = new System.Drawing.Point(198, 274);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(80, 31);
            this.button9.TabIndex = 19;
            this.button9.Text = "DELETE";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.White;
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold);
            this.button8.ForeColor = System.Drawing.Color.SaddleBrown;
            this.button8.Location = new System.Drawing.Point(108, 274);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(80, 31);
            this.button8.TabIndex = 18;
            this.button8.Text = "EDIT";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.White;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold);
            this.button4.ForeColor = System.Drawing.Color.SaddleBrown;
            this.button4.Location = new System.Drawing.Point(20, 274);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(80, 31);
            this.button4.TabIndex = 15;
            this.button4.Text = "ADD";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // ProdPriceTbl
            // 
            this.ProdPriceTbl.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ProdPriceTbl.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.ProdPriceTbl.ForeColor = System.Drawing.Color.Black;
            this.ProdPriceTbl.HintForeColor = System.Drawing.Color.White;
            this.ProdPriceTbl.HintText = "";
            this.ProdPriceTbl.isPassword = false;
            this.ProdPriceTbl.LineFocusedColor = System.Drawing.Color.WhiteSmoke;
            this.ProdPriceTbl.LineIdleColor = System.Drawing.Color.White;
            this.ProdPriceTbl.LineMouseHoverColor = System.Drawing.Color.WhiteSmoke;
            this.ProdPriceTbl.LineThickness = 2;
            this.ProdPriceTbl.Location = new System.Drawing.Point(112, 161);
            this.ProdPriceTbl.Margin = new System.Windows.Forms.Padding(4);
            this.ProdPriceTbl.Name = "ProdPriceTbl";
            this.ProdPriceTbl.Size = new System.Drawing.Size(163, 31);
            this.ProdPriceTbl.TabIndex = 14;
            this.ProdPriceTbl.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // ProdQtyTbl
            // 
            this.ProdQtyTbl.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ProdQtyTbl.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.ProdQtyTbl.ForeColor = System.Drawing.Color.Black;
            this.ProdQtyTbl.HintForeColor = System.Drawing.Color.White;
            this.ProdQtyTbl.HintText = "";
            this.ProdQtyTbl.isPassword = false;
            this.ProdQtyTbl.LineFocusedColor = System.Drawing.Color.WhiteSmoke;
            this.ProdQtyTbl.LineIdleColor = System.Drawing.Color.White;
            this.ProdQtyTbl.LineMouseHoverColor = System.Drawing.Color.WhiteSmoke;
            this.ProdQtyTbl.LineThickness = 2;
            this.ProdQtyTbl.Location = new System.Drawing.Point(112, 125);
            this.ProdQtyTbl.Margin = new System.Windows.Forms.Padding(4);
            this.ProdQtyTbl.Name = "ProdQtyTbl";
            this.ProdQtyTbl.Size = new System.Drawing.Size(163, 31);
            this.ProdQtyTbl.TabIndex = 13;
            this.ProdQtyTbl.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // ProdNameTbl
            // 
            this.ProdNameTbl.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ProdNameTbl.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.ProdNameTbl.ForeColor = System.Drawing.Color.Black;
            this.ProdNameTbl.HintForeColor = System.Drawing.Color.White;
            this.ProdNameTbl.HintText = "";
            this.ProdNameTbl.isPassword = false;
            this.ProdNameTbl.LineFocusedColor = System.Drawing.Color.WhiteSmoke;
            this.ProdNameTbl.LineIdleColor = System.Drawing.Color.White;
            this.ProdNameTbl.LineMouseHoverColor = System.Drawing.Color.WhiteSmoke;
            this.ProdNameTbl.LineThickness = 2;
            this.ProdNameTbl.Location = new System.Drawing.Point(112, 88);
            this.ProdNameTbl.Margin = new System.Windows.Forms.Padding(4);
            this.ProdNameTbl.Name = "ProdNameTbl";
            this.ProdNameTbl.Size = new System.Drawing.Size(163, 31);
            this.ProdNameTbl.TabIndex = 12;
            this.ProdNameTbl.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // CatCbTbl
            // 
            this.CatCbTbl.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.CatCbTbl.ForeColor = System.Drawing.Color.SaddleBrown;
            this.CatCbTbl.FormattingEnabled = true;
            this.CatCbTbl.Items.AddRange(new object[] {
            "Admin",
            "Seller"});
            this.CatCbTbl.Location = new System.Drawing.Point(112, 210);
            this.CatCbTbl.Name = "CatCbTbl";
            this.CatCbTbl.Size = new System.Drawing.Size(163, 28);
            this.CatCbTbl.TabIndex = 11;
            this.CatCbTbl.Text = "Select Category";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(5, 208);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 19);
            this.label6.TabIndex = 10;
            this.label6.Text = "Category";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(5, 173);
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
            this.label4.Location = new System.Drawing.Point(5, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "Quantity";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(5, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Name";
            // 
            // ProdIDTbl
            // 
            this.ProdIDTbl.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ProdIDTbl.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.ProdIDTbl.ForeColor = System.Drawing.Color.Black;
            this.ProdIDTbl.HintForeColor = System.Drawing.Color.White;
            this.ProdIDTbl.HintText = "";
            this.ProdIDTbl.isPassword = false;
            this.ProdIDTbl.LineFocusedColor = System.Drawing.Color.WhiteSmoke;
            this.ProdIDTbl.LineIdleColor = System.Drawing.Color.White;
            this.ProdIDTbl.LineMouseHoverColor = System.Drawing.Color.WhiteSmoke;
            this.ProdIDTbl.LineThickness = 2;
            this.ProdIDTbl.Location = new System.Drawing.Point(112, 52);
            this.ProdIDTbl.Margin = new System.Windows.Forms.Padding(4);
            this.ProdIDTbl.Name = "ProdIDTbl";
            this.ProdIDTbl.Size = new System.Drawing.Size(163, 31);
            this.ProdIDTbl.TabIndex = 3;
            this.ProdIDTbl.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(5, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12.5F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(314, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "MANAGE PRODUCTS";
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.button1.Location = new System.Drawing.Point(-41, 102);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(203, 31);
            this.button1.TabIndex = 0;
            this.button1.Text = "Sellers";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.Color.SaddleBrown;
            this.button2.Location = new System.Drawing.Point(1, 139);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(161, 43);
            this.button2.TabIndex = 1;
            this.button2.Text = "Categories";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold);
            this.button3.ForeColor = System.Drawing.Color.SaddleBrown;
            this.button3.Location = new System.Drawing.Point(-4, 532);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(166, 43);
            this.button3.TabIndex = 2;
            this.button3.Text = "Logout";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button5
            // 
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold);
            this.button5.ForeColor = System.Drawing.Color.SaddleBrown;
            this.button5.Location = new System.Drawing.Point(955, 12);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(34, 34);
            this.button5.TabIndex = 3;
            this.button5.Text = "x";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 12;
            this.bunifuElipse1.TargetControl = this;
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 604);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProductForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProductForm";
            this.Load += new System.EventHandler(this.ProductForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProdDGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox ProdIDTbl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CatCbTbl;
        private Bunifu.Framework.UI.BunifuMaterialTextbox ProdPriceTbl;
        private Bunifu.Framework.UI.BunifuMaterialTextbox ProdQtyTbl;
        private Bunifu.Framework.UI.BunifuMaterialTextbox ProdNameTbl;
        private System.Windows.Forms.Button button4;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private Guna.UI.WinForms.GunaDataGridView ProdDGV;
        private System.Windows.Forms.ComboBox SearchCb;
        private System.Windows.Forms.Button button6;
    }
}