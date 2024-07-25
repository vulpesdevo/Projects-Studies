namespace SDCA_BUSINESS_CENTER
{
    partial class editproducts
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.productCombo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.prodName = new System.Windows.Forms.Label();
            this.prodCode = new System.Windows.Forms.Label();
            this.gender = new System.Windows.Forms.Label();
            this.edit_btn = new System.Windows.Forms.Button();
            this.gobck_btn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.StockNum = new System.Windows.Forms.TextBox();
            this.price = new System.Windows.Forms.TextBox();
            this.size = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dataSet = new SDCA_BUSINESS_CENTER.DataSet();
            this.dataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(228)))), ((int)(((byte)(232)))));
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(-9, 140);
            this.textBox1.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(1068, 11);
            this.textBox1.TabIndex = 55;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(205, 188);
            this.label1.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 23);
            this.label1.TabIndex = 50;
            this.label1.Text = "Product Name: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 30F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(308, 44);
            this.label2.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(387, 59);
            this.label2.TabIndex = 59;
            this.label2.Text = "EDIT PRODUCTS";
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
            this.productCombo.Location = new System.Drawing.Point(395, 185);
            this.productCombo.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.productCombo.Name = "productCombo";
            this.productCombo.Size = new System.Drawing.Size(391, 31);
            this.productCombo.TabIndex = 51;
            this.productCombo.SelectedValueChanged += new System.EventHandler(this.productCombo_SelectedValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(505, 297);
            this.label3.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 23);
            this.label3.TabIndex = 60;
            this.label3.Text = "Product Code:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(505, 345);
            this.label4.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(165, 23);
            this.label4.TabIndex = 60;
            this.label4.Text = "Product Name: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(505, 389);
            this.label5.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 23);
            this.label5.TabIndex = 60;
            this.label5.Text = "Gender: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(505, 486);
            this.label6.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(153, 23);
            this.label6.TabIndex = 60;
            this.label6.Text = "Stock Number:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(505, 533);
            this.label7.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 23);
            this.label7.TabIndex = 61;
            this.label7.Text = "Price:";
            // 
            // prodName
            // 
            this.prodName.AutoSize = true;
            this.prodName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.prodName.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.prodName.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.prodName.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.prodName.Location = new System.Drawing.Point(683, 342);
            this.prodName.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.prodName.Name = "prodName";
            this.prodName.Size = new System.Drawing.Size(123, 25);
            this.prodName.TabIndex = 63;
            this.prodName.Text = " POLO-GEN";
            // 
            // prodCode
            // 
            this.prodCode.AutoSize = true;
            this.prodCode.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.prodCode.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.prodCode.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.prodCode.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.prodCode.Location = new System.Drawing.Point(683, 297);
            this.prodCode.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.prodCode.Name = "prodCode";
            this.prodCode.Size = new System.Drawing.Size(159, 25);
            this.prodCode.TabIndex = 62;
            this.prodCode.Text = "1-GE-MA-POLO";
            // 
            // gender
            // 
            this.gender.AutoSize = true;
            this.gender.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gender.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.gender.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.gender.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.gender.Location = new System.Drawing.Point(683, 389);
            this.gender.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.gender.Name = "gender";
            this.gender.Size = new System.Drawing.Size(64, 25);
            this.gender.TabIndex = 64;
            this.gender.Text = "MALE";
            // 
            // edit_btn
            // 
            this.edit_btn.BackColor = System.Drawing.Color.Black;
            this.edit_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.edit_btn.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edit_btn.ForeColor = System.Drawing.Color.Transparent;
            this.edit_btn.Location = new System.Drawing.Point(511, 593);
            this.edit_btn.Margin = new System.Windows.Forms.Padding(4);
            this.edit_btn.Name = "edit_btn";
            this.edit_btn.Size = new System.Drawing.Size(140, 54);
            this.edit_btn.TabIndex = 68;
            this.edit_btn.Text = "Edit";
            this.edit_btn.UseVisualStyleBackColor = false;
            this.edit_btn.Click += new System.EventHandler(this.edit_btn_Click);
            // 
            // gobck_btn
            // 
            this.gobck_btn.BackColor = System.Drawing.Color.Black;
            this.gobck_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gobck_btn.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gobck_btn.ForeColor = System.Drawing.Color.Transparent;
            this.gobck_btn.Location = new System.Drawing.Point(659, 593);
            this.gobck_btn.Margin = new System.Windows.Forms.Padding(4);
            this.gobck_btn.Name = "gobck_btn";
            this.gobck_btn.Size = new System.Drawing.Size(140, 54);
            this.gobck_btn.TabIndex = 69;
            this.gobck_btn.Text = "Go back";
            this.gobck_btn.UseVisualStyleBackColor = false;
            this.gobck_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SDCA_BUSINESS_CENTER.Properties.Resources.poloMale;
            this.pictureBox1.Location = new System.Drawing.Point(148, 262);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(321, 385);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 67;
            this.pictureBox1.TabStop = false;
            // 
            // StockNum
            // 
            this.StockNum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(119)))), ((int)(((byte)(149)))));
            this.StockNum.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StockNum.ForeColor = System.Drawing.Color.White;
            this.StockNum.Location = new System.Drawing.Point(683, 482);
            this.StockNum.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.StockNum.Name = "StockNum";
            this.StockNum.Size = new System.Drawing.Size(132, 32);
            this.StockNum.TabIndex = 70;
            this.StockNum.Text = "500";
            this.StockNum.TextChanged += new System.EventHandler(this.StockNum_TextChanged);
            this.StockNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.StockNum_KeyPress);
            // 
            // price
            // 
            this.price.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(119)))), ((int)(((byte)(149)))));
            this.price.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.price.ForeColor = System.Drawing.Color.White;
            this.price.Location = new System.Drawing.Point(683, 526);
            this.price.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(132, 32);
            this.price.TabIndex = 71;
            this.price.Text = "₱690";
            // 
            // size
            // 
            this.size.AutoSize = true;
            this.size.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.size.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.size.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.size.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.size.Location = new System.Drawing.Point(683, 437);
            this.size.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.size.Name = "size";
            this.size.Size = new System.Drawing.Size(61, 25);
            this.size.TabIndex = 73;
            this.size.Text = "S-3XL";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label9.Location = new System.Drawing.Point(505, 437);
            this.label9.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 23);
            this.label9.TabIndex = 72;
            this.label9.Text = "Size:";
            // 
            // dataSet
            // 
            this.dataSet.DataSetName = "DataSet";
            this.dataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataSetBindingSource
            // 
            this.dataSetBindingSource.DataSource = this.dataSet;
            this.dataSetBindingSource.Position = 0;
            // 
            // editproducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(53)))), ((int)(((byte)(87)))));
            this.ClientSize = new System.Drawing.Size(1057, 726);
            this.Controls.Add(this.size);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.price);
            this.Controls.Add(this.StockNum);
            this.Controls.Add(this.gobck_btn);
            this.Controls.Add(this.edit_btn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.gender);
            this.Controls.Add(this.prodName);
            this.Controls.Add(this.prodCode);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.productCombo);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "editproducts";
            this.Text = "editproducts";
            this.Load += new System.EventHandler(this.editproducts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox productCombo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label prodName;
        private System.Windows.Forms.Label prodCode;
        private System.Windows.Forms.Label gender;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button edit_btn;
        private System.Windows.Forms.Button gobck_btn;
        private System.Windows.Forms.TextBox StockNum;
        private System.Windows.Forms.TextBox price;
        private System.Windows.Forms.Label size;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.BindingSource dataSetBindingSource;
        private DataSet dataSet;
        
        
    }
}