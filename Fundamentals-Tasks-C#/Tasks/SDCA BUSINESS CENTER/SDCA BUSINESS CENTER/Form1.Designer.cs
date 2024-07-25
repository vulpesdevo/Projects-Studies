namespace SDCA_BUSINESS_CENTER
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.StockNum = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.productCombo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.addItem = new System.Windows.Forms.Button();
            this.sizeCombo = new System.Windows.Forms.ComboBox();
            this.qtyInp = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SNum = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.editProd = new System.Windows.Forms.Button();
            this.deleteItem = new System.Windows.Forms.Button();
            this.confirmOrder = new System.Windows.Forms.Button();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.catalog_btn = new System.Windows.Forms.Button();
            this.prodCode = new System.Windows.Forms.Label();
            this.prodName = new System.Windows.Forms.Label();
            this.price = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.TotalPrice = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.OrderListTbl = new System.Windows.Forms.DataGridView();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cashBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.errormessage = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.OrderListTbl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // StockNum
            // 
            this.StockNum.AutoSize = true;
            this.StockNum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(119)))), ((int)(((byte)(149)))));
            this.StockNum.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold);
            this.StockNum.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.StockNum.Location = new System.Drawing.Point(189, 206);
            this.StockNum.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.StockNum.Name = "StockNum";
            this.StockNum.Size = new System.Drawing.Size(41, 29);
            this.StockNum.TabIndex = 13;
            this.StockNum.Text = "19";
            this.StockNum.TextChanged += new System.EventHandler(this.StockNum_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(14, 206);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 23);
            this.label2.TabIndex = 12;
            this.label2.Text = "AVAILABLE STOCKS:";
            // 
            // productCombo
            // 
            this.productCombo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(119)))), ((int)(((byte)(149)))));
            this.productCombo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productCombo.ForeColor = System.Drawing.Color.White;
            this.productCombo.FormattingEnabled = true;
            this.productCombo.Items.AddRange(new object[] {
            "21-GE-MA-TIE",
            "22-GE-FE-BELT",
            "23-GE-FE-SCA",
            "1-GE-MA-POLO",
            "11-GE-MA-PANTS",
            "25-GE-FE-BL",
            "36-GE-FE-PANTS",
            "47-GE-IJNI-RS"});
            this.productCombo.Location = new System.Drawing.Point(188, 163);
            this.productCombo.Margin = new System.Windows.Forms.Padding(5);
            this.productCombo.Name = "productCombo";
            this.productCombo.Size = new System.Drawing.Size(271, 31);
            this.productCombo.TabIndex = 11;
            this.productCombo.SelectedValueChanged += new System.EventHandler(this.productCombo_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(14, 163);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 23);
            this.label1.TabIndex = 10;
            this.label1.Text = "Product Name: ";
            // 
            // addItem
            // 
            this.addItem.BackColor = System.Drawing.Color.Black;
            this.addItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addItem.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addItem.ForeColor = System.Drawing.Color.Transparent;
            this.addItem.Location = new System.Drawing.Point(189, 682);
            this.addItem.Name = "addItem";
            this.addItem.Size = new System.Drawing.Size(105, 44);
            this.addItem.TabIndex = 33;
            this.addItem.Text = "ADD";
            this.addItem.UseVisualStyleBackColor = false;
            this.addItem.Click += new System.EventHandler(this.addItem_Click);
            // 
            // sizeCombo
            // 
            this.sizeCombo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(119)))), ((int)(((byte)(149)))));
            this.sizeCombo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sizeCombo.ForeColor = System.Drawing.Color.White;
            this.sizeCombo.FormattingEnabled = true;
            this.sizeCombo.Items.AddRange(new object[] {
            "S",
            "M",
            "L",
            "XL",
            "2XL",
            "3XL"});
            this.sizeCombo.Location = new System.Drawing.Point(337, 563);
            this.sizeCombo.Margin = new System.Windows.Forms.Padding(5);
            this.sizeCombo.Name = "sizeCombo";
            this.sizeCombo.Size = new System.Drawing.Size(130, 31);
            this.sizeCombo.TabIndex = 32;
            this.sizeCombo.Text = "S";
            // 
            // qtyInp
            // 
            this.qtyInp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(119)))), ((int)(((byte)(149)))));
            this.qtyInp.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qtyInp.ForeColor = System.Drawing.Color.White;
            this.qtyInp.Location = new System.Drawing.Point(337, 602);
            this.qtyInp.Margin = new System.Windows.Forms.Padding(5);
            this.qtyInp.Name = "qtyInp";
            this.qtyInp.Size = new System.Drawing.Size(130, 32);
            this.qtyInp.TabIndex = 30;
            this.qtyInp.Text = "1";
            this.qtyInp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.qtyInp_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label8.Location = new System.Drawing.Point(281, 605);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 23);
            this.label8.TabIndex = 27;
            this.label8.Text = "QTY:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(76, 637);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 23);
            this.label7.TabIndex = 28;
            this.label7.Text = "Price: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(281, 566);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 23);
            this.label6.TabIndex = 29;
            this.label6.Text = "Size: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(9, 600);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 23);
            this.label3.TabIndex = 24;
            this.label3.Text = "Product Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(9, 563);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 23);
            this.label4.TabIndex = 21;
            this.label4.Text = "Product Code: ";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(228)))), ((int)(((byte)(232)))));
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(-5, 136);
            this.textBox1.Margin = new System.Windows.Forms.Padding(5);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(1367, 11);
            this.textBox1.TabIndex = 34;
            // 
            // SNum
            // 
            this.SNum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(119)))), ((int)(((byte)(149)))));
            this.SNum.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SNum.ForeColor = System.Drawing.Color.White;
            this.SNum.Location = new System.Drawing.Point(736, 165);
            this.SNum.Margin = new System.Windows.Forms.Padding(5);
            this.SNum.Name = "SNum";
            this.SNum.Size = new System.Drawing.Size(209, 32);
            this.SNum.TabIndex = 39;
            this.SNum.TextChanged += new System.EventHandler(this.SNum_TextChanged);
            this.SNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SNum_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label9.Location = new System.Drawing.Point(501, 168);
            this.label9.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(236, 23);
            this.label9.TabIndex = 38;
            this.label9.Text = "Enter Student Number: ";
            // 
            // editProd
            // 
            this.editProd.BackColor = System.Drawing.Color.Black;
            this.editProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editProd.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editProd.ForeColor = System.Drawing.Color.Transparent;
            this.editProd.Location = new System.Drawing.Point(1178, 409);
            this.editProd.Name = "editProd";
            this.editProd.Size = new System.Drawing.Size(157, 40);
            this.editProd.TabIndex = 41;
            this.editProd.Text = "EDIT PRODUCTS";
            this.editProd.UseVisualStyleBackColor = false;
            this.editProd.Click += new System.EventHandler(this.button3_Click);
            // 
            // deleteItem
            // 
            this.deleteItem.BackColor = System.Drawing.Color.Black;
            this.deleteItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteItem.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteItem.ForeColor = System.Drawing.Color.Transparent;
            this.deleteItem.Location = new System.Drawing.Point(541, 597);
            this.deleteItem.Name = "deleteItem";
            this.deleteItem.Size = new System.Drawing.Size(105, 44);
            this.deleteItem.TabIndex = 42;
            this.deleteItem.Text = "Delete";
            this.deleteItem.UseVisualStyleBackColor = false;
            this.deleteItem.Click += new System.EventHandler(this.deleteItem_Click);
            // 
            // confirmOrder
            // 
            this.confirmOrder.BackColor = System.Drawing.Color.Black;
            this.confirmOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.confirmOrder.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmOrder.ForeColor = System.Drawing.Color.Transparent;
            this.confirmOrder.Location = new System.Drawing.Point(976, 669);
            this.confirmOrder.Name = "confirmOrder";
            this.confirmOrder.Size = new System.Drawing.Size(146, 44);
            this.confirmOrder.TabIndex = 43;
            this.confirmOrder.Text = "Confirm";
            this.confirmOrder.UseVisualStyleBackColor = false;
            this.confirmOrder.Click += new System.EventHandler(this.confirmOrder_Click);
            // 
            // textBox9
            // 
            this.textBox9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(228)))), ((int)(((byte)(232)))));
            this.textBox9.Enabled = false;
            this.textBox9.Location = new System.Drawing.Point(1159, 157);
            this.textBox9.Margin = new System.Windows.Forms.Padding(5);
            this.textBox9.Multiline = true;
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(10, 567);
            this.textBox9.TabIndex = 44;
            // 
            // catalog_btn
            // 
            this.catalog_btn.BackColor = System.Drawing.Color.Black;
            this.catalog_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.catalog_btn.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.catalog_btn.ForeColor = System.Drawing.Color.Transparent;
            this.catalog_btn.Location = new System.Drawing.Point(1178, 359);
            this.catalog_btn.Name = "catalog_btn";
            this.catalog_btn.Size = new System.Drawing.Size(157, 44);
            this.catalog_btn.TabIndex = 45;
            this.catalog_btn.Text = "CATALOG";
            this.catalog_btn.UseVisualStyleBackColor = false;
            this.catalog_btn.Click += new System.EventHandler(this.catalog_btn_Click);
            // 
            // prodCode
            // 
            this.prodCode.AutoSize = true;
            this.prodCode.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.prodCode.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.prodCode.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.prodCode.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.prodCode.Location = new System.Drawing.Point(142, 563);
            this.prodCode.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.prodCode.Name = "prodCode";
            this.prodCode.Size = new System.Drawing.Size(159, 25);
            this.prodCode.TabIndex = 46;
            this.prodCode.Text = "1-GE-MA-POLO";
            // 
            // prodName
            // 
            this.prodName.AutoSize = true;
            this.prodName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.prodName.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.prodName.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.prodName.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.prodName.Location = new System.Drawing.Point(141, 600);
            this.prodName.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.prodName.Name = "prodName";
            this.prodName.Size = new System.Drawing.Size(123, 25);
            this.prodName.TabIndex = 47;
            this.prodName.Text = " POLO-GEN";
            // 
            // price
            // 
            this.price.AutoSize = true;
            this.price.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.price.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.price.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.price.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.price.Location = new System.Drawing.Point(141, 637);
            this.price.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(45, 25);
            this.price.TabIndex = 49;
            this.price.Text = "690";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(119)))), ((int)(((byte)(149)))));
            this.label17.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label17.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label17.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label17.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label17.Location = new System.Drawing.Point(830, 545);
            this.label17.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(123, 25);
            this.label17.TabIndex = 61;
            this.label17.Text = "Total Price: ";
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(119)))), ((int)(((byte)(149)))));
            this.textBox4.Enabled = false;
            this.textBox4.Location = new System.Drawing.Point(540, 536);
            this.textBox4.Margin = new System.Windows.Forms.Padding(5);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(555, 44);
            this.textBox4.TabIndex = 62;
            // 
            // TotalPrice
            // 
            this.TotalPrice.AutoSize = true;
            this.TotalPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(119)))), ((int)(((byte)(149)))));
            this.TotalPrice.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TotalPrice.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.TotalPrice.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.TotalPrice.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.TotalPrice.Location = new System.Drawing.Point(963, 545);
            this.TotalPrice.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.TotalPrice.Name = "TotalPrice";
            this.TotalPrice.Size = new System.Drawing.Size(123, 25);
            this.TotalPrice.TabIndex = 63;
            this.TotalPrice.Text = "totaloutput";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(228)))), ((int)(((byte)(232)))));
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(477, 157);
            this.textBox2.Margin = new System.Windows.Forms.Padding(5);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(10, 571);
            this.textBox2.TabIndex = 65;
            // 
            // OrderListTbl
            // 
            this.OrderListTbl.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(53)))), ((int)(((byte)(87)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(119)))), ((int)(((byte)(149)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.OrderListTbl.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.OrderListTbl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(53)))), ((int)(((byte)(87)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.OrderListTbl.DefaultCellStyle = dataGridViewCellStyle2;
            this.OrderListTbl.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(228)))), ((int)(((byte)(232)))));
            this.OrderListTbl.Location = new System.Drawing.Point(540, 239);
            this.OrderListTbl.Name = "OrderListTbl";
            this.OrderListTbl.RowHeadersWidth = 51;
            this.OrderListTbl.RowTemplate.Height = 24;
            this.OrderListTbl.Size = new System.Drawing.Size(555, 289);
            this.OrderListTbl.TabIndex = 66;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::SDCA_BUSINESS_CENTER.Properties.Resources.poloMale;
            this.pictureBox2.Location = new System.Drawing.Point(107, 239);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(239, 304);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 37;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SDCA_BUSINESS_CENTER.Properties.Resources.IDRIS_HEADER1;
            this.pictureBox1.Location = new System.Drawing.Point(285, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(714, 119);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 36;
            this.pictureBox1.TabStop = false;
            // 
            // cashBox
            // 
            this.cashBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(119)))), ((int)(((byte)(149)))));
            this.cashBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashBox.Location = new System.Drawing.Point(808, 606);
            this.cashBox.Multiline = true;
            this.cashBox.Name = "cashBox";
            this.cashBox.Size = new System.Drawing.Size(203, 29);
            this.cashBox.TabIndex = 67;
            this.cashBox.TextChanged += new System.EventHandler(this.cashBox_TextChanged);
            this.cashBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cashBox_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Location = new System.Drawing.Point(658, 609);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(143, 23);
            this.label10.TabIndex = 68;
            this.label10.Text = "Enter Amount";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(1484, 234);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 17);
            this.label11.TabIndex = 69;
            this.label11.Text = "label11";
            // 
            // errormessage
            // 
            this.errormessage.AutoSize = true;
            this.errormessage.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errormessage.Location = new System.Drawing.Point(811, 638);
            this.errormessage.Name = "errormessage";
            this.errormessage.Size = new System.Drawing.Size(18, 27);
            this.errormessage.TabIndex = 70;
            this.errormessage.Text = ".";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(1177, 455);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(158, 54);
            this.button1.TabIndex = 71;
            this.button1.Text = "LOGOUT";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(53)))), ((int)(((byte)(87)))));
            this.ClientSize = new System.Drawing.Size(1341, 742);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.errormessage);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cashBox);
            this.Controls.Add(this.OrderListTbl);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.TotalPrice);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.price);
            this.Controls.Add(this.prodName);
            this.Controls.Add(this.prodCode);
            this.Controls.Add(this.catalog_btn);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.confirmOrder);
            this.Controls.Add(this.deleteItem);
            this.Controls.Add(this.editProd);
            this.Controls.Add(this.SNum);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.addItem);
            this.Controls.Add(this.sizeCombo);
            this.Controls.Add(this.qtyInp);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.StockNum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.productCombo);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.OrderListTbl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label StockNum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox productCombo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addItem;
        private System.Windows.Forms.ComboBox sizeCombo;
        private System.Windows.Forms.TextBox qtyInp;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox SNum;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button editProd;
        private System.Windows.Forms.Button deleteItem;
        private System.Windows.Forms.Button confirmOrder;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Button catalog_btn;
        private System.Windows.Forms.Label prodCode;
        private System.Windows.Forms.Label prodName;
        private System.Windows.Forms.Label price;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label TotalPrice;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.DataGridView OrderListTbl;
        private System.Windows.Forms.TextBox cashBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label errormessage;
        private System.Windows.Forms.Button button1;
    }
}

