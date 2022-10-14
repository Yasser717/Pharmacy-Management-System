namespace Pharmacy.Project
{
    partial class Medicine
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Medicine));
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxISSNMed = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBoxNameMed = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpExpDate = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpProDate = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtBoxQty = new System.Windows.Forms.TextBox();
            this.txtBoxBuyPri = new System.Windows.Forms.TextBox();
            this.dgv_Medicine = new System.Windows.Forms.DataGridView();
            this.ISSN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MedicineName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExpDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bprice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sprice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Man_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button_clear = new System.Windows.Forms.Button();
            this.button_Back = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.button_add = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtBoxSellPri = new System.Windows.Forms.TextBox();
            this.cmbBoxName_Man = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.lbl_ISSN = new System.Windows.Forms.Label();
            this.lbl_Qty = new System.Windows.Forms.Label();
            this.lbl_MedName = new System.Windows.Forms.Label();
            this.lbl_BuyPrice = new System.Windows.Forms.Label();
            this.lbl_SellPrice = new System.Windows.Forms.Label();
            this.lbl_ExpiryDate = new System.Windows.Forms.Label();
            this.lbl_ManufactruerName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Medicine)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(307, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 17);
            this.label2.TabIndex = 4;
            // 
            // txtBoxISSNMed
            // 
            this.txtBoxISSNMed.BackColor = System.Drawing.SystemColors.Control;
            this.txtBoxISSNMed.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxISSNMed.Location = new System.Drawing.Point(157, 138);
            this.txtBoxISSNMed.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBoxISSNMed.Name = "txtBoxISSNMed";
            this.txtBoxISSNMed.Size = new System.Drawing.Size(268, 32);
            this.txtBoxISSNMed.TabIndex = 5;
            this.txtBoxISSNMed.TextChanged += new System.EventHandler(this.txtBoxNameDoc_TextChanged);
            this.txtBoxISSNMed.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxISSNMed_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(175, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "ISSN:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(464, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Medicine Name:";
            // 
            // txtBoxNameMed
            // 
            this.txtBoxNameMed.BackColor = System.Drawing.SystemColors.Control;
            this.txtBoxNameMed.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxNameMed.Location = new System.Drawing.Point(455, 138);
            this.txtBoxNameMed.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBoxNameMed.Name = "txtBoxNameMed";
            this.txtBoxNameMed.Size = new System.Drawing.Size(268, 32);
            this.txtBoxNameMed.TabIndex = 8;
            this.txtBoxNameMed.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxNameMed_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1051, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "ExpiryDate:";
            // 
            // dtpExpDate
            // 
            this.dtpExpDate.CalendarMonthBackground = System.Drawing.SystemColors.Control;
            this.dtpExpDate.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpExpDate.Location = new System.Drawing.Point(1027, 140);
            this.dtpExpDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpExpDate.Name = "dtpExpDate";
            this.dtpExpDate.Size = new System.Drawing.Size(233, 32);
            this.dtpExpDate.TabIndex = 10;
            this.dtpExpDate.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(763, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(152, 25);
            this.label6.TabIndex = 11;
            this.label6.Text = "ProductionDate:";
            // 
            // dtpProDate
            // 
            this.dtpProDate.CalendarMonthBackground = System.Drawing.SystemColors.Control;
            this.dtpProDate.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpProDate.Location = new System.Drawing.Point(746, 140);
            this.dtpProDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpProDate.Name = "dtpProDate";
            this.dtpProDate.Size = new System.Drawing.Size(233, 32);
            this.dtpProDate.TabIndex = 12;
            this.dtpProDate.ValueChanged += new System.EventHandler(this.dtpProDate_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(175, 206);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 25);
            this.label7.TabIndex = 13;
            this.label7.Text = "Quantity:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(464, 206);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(127, 25);
            this.label8.TabIndex = 14;
            this.label8.Text = "Buying Price:";
            // 
            // txtBoxQty
            // 
            this.txtBoxQty.BackColor = System.Drawing.SystemColors.Control;
            this.txtBoxQty.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxQty.Location = new System.Drawing.Point(160, 233);
            this.txtBoxQty.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBoxQty.Name = "txtBoxQty";
            this.txtBoxQty.Size = new System.Drawing.Size(268, 32);
            this.txtBoxQty.TabIndex = 15;
            this.txtBoxQty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxQty_KeyPress);
            // 
            // txtBoxBuyPri
            // 
            this.txtBoxBuyPri.BackColor = System.Drawing.SystemColors.Control;
            this.txtBoxBuyPri.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxBuyPri.Location = new System.Drawing.Point(451, 233);
            this.txtBoxBuyPri.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBoxBuyPri.Name = "txtBoxBuyPri";
            this.txtBoxBuyPri.Size = new System.Drawing.Size(268, 32);
            this.txtBoxBuyPri.TabIndex = 16;
            this.txtBoxBuyPri.TextChanged += new System.EventHandler(this.txtBoxBuyPri_TextChanged);
            this.txtBoxBuyPri.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxBuyPri_KeyPress);
            // 
            // dgv_Medicine
            // 
            this.dgv_Medicine.BackgroundColor = System.Drawing.Color.White;
            this.dgv_Medicine.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Medicine.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ISSN,
            this.MedicineName,
            this.ProDate,
            this.ExpDate,
            this.Bprice,
            this.Sprice,
            this.Qty,
            this.Man_Name});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(238)))), ((int)(((byte)(218)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Medicine.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_Medicine.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgv_Medicine.Location = new System.Drawing.Point(234, 314);
            this.dgv_Medicine.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_Medicine.Name = "dgv_Medicine";
            this.dgv_Medicine.RowHeadersWidth = 51;
            this.dgv_Medicine.RowTemplate.Height = 26;
            this.dgv_Medicine.Size = new System.Drawing.Size(1063, 344);
            this.dgv_Medicine.TabIndex = 19;
            this.dgv_Medicine.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Medicine_CellContentClick);
            this.dgv_Medicine.DoubleClick += new System.EventHandler(this.dgv_Medicine_DoubleClick);
            // 
            // ISSN
            // 
            this.ISSN.DataPropertyName = "ISSN";
            this.ISSN.HeaderText = "ISSN";
            this.ISSN.MinimumWidth = 6;
            this.ISSN.Name = "ISSN";
            this.ISSN.Width = 70;
            // 
            // MedicineName
            // 
            this.MedicineName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MedicineName.DataPropertyName = "name1";
            this.MedicineName.HeaderText = "Medicine Name";
            this.MedicineName.MinimumWidth = 6;
            this.MedicineName.Name = "MedicineName";
            // 
            // ProDate
            // 
            this.ProDate.DataPropertyName = "ProductionDate";
            this.ProDate.HeaderText = "Pro Date";
            this.ProDate.MinimumWidth = 6;
            this.ProDate.Name = "ProDate";
            this.ProDate.Width = 125;
            // 
            // ExpDate
            // 
            this.ExpDate.DataPropertyName = "ExpiryDate";
            this.ExpDate.HeaderText = "Exp Date";
            this.ExpDate.MinimumWidth = 6;
            this.ExpDate.Name = "ExpDate";
            this.ExpDate.Width = 125;
            // 
            // Bprice
            // 
            this.Bprice.DataPropertyName = "BuyingPrice";
            this.Bprice.HeaderText = "Bprice";
            this.Bprice.MinimumWidth = 6;
            this.Bprice.Name = "Bprice";
            this.Bprice.Width = 80;
            // 
            // Sprice
            // 
            this.Sprice.DataPropertyName = "SellingPrice";
            this.Sprice.HeaderText = "Sprice";
            this.Sprice.MinimumWidth = 6;
            this.Sprice.Name = "Sprice";
            this.Sprice.Width = 80;
            // 
            // Qty
            // 
            this.Qty.DataPropertyName = "Quantity";
            this.Qty.HeaderText = "Qty";
            this.Qty.MinimumWidth = 6;
            this.Qty.Name = "Qty";
            this.Qty.Width = 60;
            // 
            // Man_Name
            // 
            this.Man_Name.DataPropertyName = "Name";
            this.Man_Name.HeaderText = "Man Name";
            this.Man_Name.MinimumWidth = 6;
            this.Man_Name.Name = "Man_Name";
            this.Man_Name.Width = 125;
            // 
            // button_clear
            // 
            this.button_clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.button_clear.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Italic);
            this.button_clear.ForeColor = System.Drawing.Color.White;
            this.button_clear.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_clear.Location = new System.Drawing.Point(365, 704);
            this.button_clear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(200, 53);
            this.button_clear.TabIndex = 23;
            this.button_clear.Text = "Clear";
            this.button_clear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_clear.UseVisualStyleBackColor = false;
            this.button_clear.Click += new System.EventHandler(this.button_clear_Click);
            // 
            // button_Back
            // 
            this.button_Back.BackColor = System.Drawing.Color.Red;
            this.button_Back.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Italic);
            this.button_Back.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_Back.Location = new System.Drawing.Point(1168, 704);
            this.button_Back.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_Back.Name = "button_Back";
            this.button_Back.Size = new System.Drawing.Size(200, 53);
            this.button_Back.TabIndex = 22;
            this.button_Back.Text = "Back";
            this.button_Back.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_Back.UseVisualStyleBackColor = false;
            this.button_Back.Click += new System.EventHandler(this.button_Back_Click);
            // 
            // button_delete
            // 
            this.button_delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.button_delete.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Italic);
            this.button_delete.ForeColor = System.Drawing.Color.White;
            this.button_delete.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_delete.Location = new System.Drawing.Point(602, 704);
            this.button_delete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(200, 53);
            this.button_delete.TabIndex = 21;
            this.button_delete.Text = "Delete";
            this.button_delete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_delete.UseVisualStyleBackColor = false;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // button_add
            // 
            this.button_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.button_add.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Italic);
            this.button_add.ForeColor = System.Drawing.Color.White;
            this.button_add.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_add.Location = new System.Drawing.Point(129, 704);
            this.button_add.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(200, 53);
            this.button_add.TabIndex = 20;
            this.button_add.Text = "Add";
            this.button_add.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_add.UseVisualStyleBackColor = false;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(763, 206);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(126, 25);
            this.label9.TabIndex = 25;
            this.label9.Text = "Selling Price:";
            // 
            // txtBoxSellPri
            // 
            this.txtBoxSellPri.BackColor = System.Drawing.SystemColors.Control;
            this.txtBoxSellPri.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxSellPri.Location = new System.Drawing.Point(743, 233);
            this.txtBoxSellPri.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBoxSellPri.Name = "txtBoxSellPri";
            this.txtBoxSellPri.Size = new System.Drawing.Size(268, 32);
            this.txtBoxSellPri.TabIndex = 26;
            this.txtBoxSellPri.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxSellPri_KeyPress);
            // 
            // cmbBoxName_Man
            // 
            this.cmbBoxName_Man.BackColor = System.Drawing.SystemColors.Control;
            this.cmbBoxName_Man.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBoxName_Man.FormattingEnabled = true;
            this.cmbBoxName_Man.Location = new System.Drawing.Point(1038, 233);
            this.cmbBoxName_Man.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbBoxName_Man.Name = "cmbBoxName_Man";
            this.cmbBoxName_Man.Size = new System.Drawing.Size(268, 32);
            this.cmbBoxName_Man.TabIndex = 27;
            this.cmbBoxName_Man.SelectedIndexChanged += new System.EventHandler(this.cmbBoxName_Man_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(1051, 206);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(173, 25);
            this.label10.TabIndex = 28;
            this.label10.Text = "The Manufactruer:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1382, 100);
            this.panel1.TabIndex = 65;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(121, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 73);
            this.label1.TabIndex = 61;
            this.label1.Text = "Medicine";
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(1340, 0);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(40, 42);
            this.btnClose.TabIndex = 62;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(115, 770);
            this.panel2.TabIndex = 66;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Red;
            this.label16.Location = new System.Drawing.Point(447, 112);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(22, 23);
            this.label16.TabIndex = 74;
            this.label16.Text = "*";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(447, 208);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(22, 23);
            this.label11.TabIndex = 75;
            this.label11.Text = "*";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(156, 208);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(22, 23);
            this.label12.TabIndex = 76;
            this.label12.Text = "*";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Red;
            this.label13.Location = new System.Drawing.Point(156, 114);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(22, 23);
            this.label13.TabIndex = 77;
            this.label13.Text = "*";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Red;
            this.label14.Location = new System.Drawing.Point(1034, 114);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(22, 23);
            this.label14.TabIndex = 78;
            this.label14.Text = "*";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Red;
            this.label15.Location = new System.Drawing.Point(747, 208);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(22, 23);
            this.label15.TabIndex = 79;
            this.label15.Text = "*";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Red;
            this.label17.Location = new System.Drawing.Point(747, 114);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(22, 23);
            this.label17.TabIndex = 80;
            this.label17.Text = "*";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.Red;
            this.label18.Location = new System.Drawing.Point(1034, 208);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(22, 23);
            this.label18.TabIndex = 81;
            this.label18.Text = "*";
            // 
            // lbl_ISSN
            // 
            this.lbl_ISSN.AutoSize = true;
            this.lbl_ISSN.ForeColor = System.Drawing.Color.Red;
            this.lbl_ISSN.Location = new System.Drawing.Point(297, 172);
            this.lbl_ISSN.Name = "lbl_ISSN";
            this.lbl_ISSN.Size = new System.Drawing.Size(128, 17);
            this.lbl_ISSN.TabIndex = 82;
            this.lbl_ISSN.Text = "Must be 8 number !";
            this.lbl_ISSN.Visible = false;
            // 
            // lbl_Qty
            // 
            this.lbl_Qty.AutoSize = true;
            this.lbl_Qty.ForeColor = System.Drawing.Color.Red;
            this.lbl_Qty.Location = new System.Drawing.Point(356, 267);
            this.lbl_Qty.Name = "lbl_Qty";
            this.lbl_Qty.Size = new System.Drawing.Size(69, 17);
            this.lbl_Qty.TabIndex = 83;
            this.lbl_Qty.Text = "Quantity !";
            this.lbl_Qty.Visible = false;
            // 
            // lbl_MedName
            // 
            this.lbl_MedName.AutoSize = true;
            this.lbl_MedName.ForeColor = System.Drawing.Color.Red;
            this.lbl_MedName.Location = new System.Drawing.Point(615, 172);
            this.lbl_MedName.Name = "lbl_MedName";
            this.lbl_MedName.Size = new System.Drawing.Size(104, 17);
            this.lbl_MedName.TabIndex = 84;
            this.lbl_MedName.Text = "Medcine Name !";
            this.lbl_MedName.Visible = false;
            // 
            // lbl_BuyPrice
            // 
            this.lbl_BuyPrice.AutoSize = true;
            this.lbl_BuyPrice.ForeColor = System.Drawing.Color.Red;
            this.lbl_BuyPrice.Location = new System.Drawing.Point(628, 267);
            this.lbl_BuyPrice.Name = "lbl_BuyPrice";
            this.lbl_BuyPrice.Size = new System.Drawing.Size(91, 17);
            this.lbl_BuyPrice.TabIndex = 85;
            this.lbl_BuyPrice.Text = "Buying Price !";
            this.lbl_BuyPrice.Visible = false;
            // 
            // lbl_SellPrice
            // 
            this.lbl_SellPrice.AutoSize = true;
            this.lbl_SellPrice.ForeColor = System.Drawing.Color.Red;
            this.lbl_SellPrice.Location = new System.Drawing.Point(740, 267);
            this.lbl_SellPrice.Name = "lbl_SellPrice";
            this.lbl_SellPrice.Size = new System.Drawing.Size(281, 17);
            this.lbl_SellPrice.TabIndex = 87;
            this.lbl_SellPrice.Text = "Selling Price Must be more than Buying Price!";
            this.lbl_SellPrice.Visible = false;
            // 
            // lbl_ExpiryDate
            // 
            this.lbl_ExpiryDate.AutoSize = true;
            this.lbl_ExpiryDate.ForeColor = System.Drawing.Color.Red;
            this.lbl_ExpiryDate.Location = new System.Drawing.Point(1035, 176);
            this.lbl_ExpiryDate.Name = "lbl_ExpiryDate";
            this.lbl_ExpiryDate.Size = new System.Drawing.Size(312, 17);
            this.lbl_ExpiryDate.TabIndex = 88;
            this.lbl_ExpiryDate.Text = "Expiry Date Must be more than Production Date !";
            this.lbl_ExpiryDate.Visible = false;
            // 
            // lbl_ManufactruerName
            // 
            this.lbl_ManufactruerName.AutoSize = true;
            this.lbl_ManufactruerName.ForeColor = System.Drawing.Color.Red;
            this.lbl_ManufactruerName.Location = new System.Drawing.Point(1177, 267);
            this.lbl_ManufactruerName.Name = "lbl_ManufactruerName";
            this.lbl_ManufactruerName.Size = new System.Drawing.Size(136, 17);
            this.lbl_ManufactruerName.TabIndex = 89;
            this.lbl_ManufactruerName.Text = "Manufactruer Name !";
            this.lbl_ManufactruerName.Visible = false;
            // 
            // Medicine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1380, 768);
            this.Controls.Add(this.lbl_ManufactruerName);
            this.Controls.Add(this.lbl_ExpiryDate);
            this.Controls.Add(this.lbl_SellPrice);
            this.Controls.Add(this.lbl_BuyPrice);
            this.Controls.Add(this.lbl_MedName);
            this.Controls.Add(this.lbl_Qty);
            this.Controls.Add(this.lbl_ISSN);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cmbBoxName_Man);
            this.Controls.Add(this.txtBoxSellPri);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button_clear);
            this.Controls.Add(this.button_Back);
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.dgv_Medicine);
            this.Controls.Add(this.txtBoxBuyPri);
            this.Controls.Add(this.txtBoxQty);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtpProDate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtpExpDate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtBoxNameMed);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBoxISSNMed);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Medicine";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Medicine";
            this.Load += new System.EventHandler(this.Medicine_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Medicine)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxISSNMed;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBoxNameMed;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpExpDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpProDate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtBoxQty;
        private System.Windows.Forms.TextBox txtBoxBuyPri;
        private System.Windows.Forms.DataGridView dgv_Medicine;
        private System.Windows.Forms.Button button_clear;
        private System.Windows.Forms.Button button_Back;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtBoxSellPri;
        private System.Windows.Forms.ComboBox cmbBoxName_Man;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridViewTextBoxColumn ISSN;
        private System.Windows.Forms.DataGridViewTextBoxColumn MedicineName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExpDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bprice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sprice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn Man_Name;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label lbl_ISSN;
        private System.Windows.Forms.Label lbl_Qty;
        private System.Windows.Forms.Label lbl_MedName;
        private System.Windows.Forms.Label lbl_BuyPrice;
        private System.Windows.Forms.Label lbl_SellPrice;
        private System.Windows.Forms.Label lbl_ExpiryDate;
        private System.Windows.Forms.Label lbl_ManufactruerName;
    }
}