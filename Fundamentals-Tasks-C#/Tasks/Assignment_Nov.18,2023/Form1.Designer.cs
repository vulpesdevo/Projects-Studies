namespace Assignment_Nov._18_2023
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
            this._CheckBoxList = new System.Windows.Forms.CheckedListBox();
            this.addItembtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.toAddItem = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.addbtn = new System.Windows.Forms.Button();
            this.delbtn = new System.Windows.Forms.Button();
            this.updbtn = new System.Windows.Forms.Button();
            this.nametf = new System.Windows.Forms.TextBox();
            this.coursetf = new System.Windows.Forms.TextBox();
            this.subjecttf = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.gradetf = new System.Windows.Forms.TextBox();
            this.DataTable = new System.Windows.Forms.DataGridView();
            this._Output = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable)).BeginInit();
            this.SuspendLayout();
            // 
            // _CheckBoxList
            // 
            this._CheckBoxList.FormattingEnabled = true;
            this._CheckBoxList.Location = new System.Drawing.Point(29, 117);
            this._CheckBoxList.Name = "_CheckBoxList";
            this._CheckBoxList.Size = new System.Drawing.Size(268, 225);
            this._CheckBoxList.TabIndex = 0;
            // 
            // addItembtn
            // 
            this.addItembtn.Location = new System.Drawing.Point(242, 80);
            this.addItembtn.Name = "addItembtn";
            this.addItembtn.Size = new System.Drawing.Size(64, 28);
            this.addItembtn.TabIndex = 1;
            this.addItembtn.Text = "ADD";
            this.addItembtn.UseVisualStyleBackColor = true;
            this.addItembtn.Click += new System.EventHandler(this.addItembtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Day :";
            // 
            // toAddItem
            // 
            this.toAddItem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.toAddItem.Location = new System.Drawing.Point(69, 81);
            this.toAddItem.Name = "toAddItem";
            this.toAddItem.Size = new System.Drawing.Size(131, 22);
            this.toAddItem.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(29, 357);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(82, 28);
            this.button2.TabIndex = 4;
            this.button2.Text = "List Item";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // addbtn
            // 
            this.addbtn.BackColor = System.Drawing.Color.Lime;
            this.addbtn.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addbtn.Location = new System.Drawing.Point(650, 81);
            this.addbtn.Name = "addbtn";
            this.addbtn.Size = new System.Drawing.Size(119, 43);
            this.addbtn.TabIndex = 6;
            this.addbtn.Text = "ADD";
            this.addbtn.UseVisualStyleBackColor = false;
            this.addbtn.Click += new System.EventHandler(this.addbtn_Click);
            // 
            // delbtn
            // 
            this.delbtn.BackColor = System.Drawing.Color.Red;
            this.delbtn.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delbtn.Location = new System.Drawing.Point(650, 130);
            this.delbtn.Name = "delbtn";
            this.delbtn.Size = new System.Drawing.Size(119, 43);
            this.delbtn.TabIndex = 7;
            this.delbtn.Text = "DELETE";
            this.delbtn.UseVisualStyleBackColor = false;
            this.delbtn.Click += new System.EventHandler(this.delbtn_Click);
            // 
            // updbtn
            // 
            this.updbtn.BackColor = System.Drawing.Color.Yellow;
            this.updbtn.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updbtn.Location = new System.Drawing.Point(650, 179);
            this.updbtn.Name = "updbtn";
            this.updbtn.Size = new System.Drawing.Size(119, 40);
            this.updbtn.TabIndex = 8;
            this.updbtn.Text = "UPDATE";
            this.updbtn.UseVisualStyleBackColor = false;
            this.updbtn.Click += new System.EventHandler(this.updbtn_Click);
            // 
            // nametf
            // 
            this.nametf.Location = new System.Drawing.Point(498, 85);
            this.nametf.Name = "nametf";
            this.nametf.Size = new System.Drawing.Size(131, 22);
            this.nametf.TabIndex = 9;
            // 
            // coursetf
            // 
            this.coursetf.Location = new System.Drawing.Point(498, 119);
            this.coursetf.Name = "coursetf";
            this.coursetf.Size = new System.Drawing.Size(131, 22);
            this.coursetf.TabIndex = 10;
            // 
            // subjecttf
            // 
            this.subjecttf.Location = new System.Drawing.Point(498, 153);
            this.subjecttf.Name = "subjecttf";
            this.subjecttf.Size = new System.Drawing.Size(131, 22);
            this.subjecttf.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(429, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(429, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Course";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(429, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "Subject";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(430, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 20);
            this.label5.TabIndex = 16;
            this.label5.Text = "Grade";
            // 
            // gradetf
            // 
            this.gradetf.Location = new System.Drawing.Point(499, 190);
            this.gradetf.Name = "gradetf";
            this.gradetf.Size = new System.Drawing.Size(131, 22);
            this.gradetf.TabIndex = 15;
            // 
            // DataTable
            // 
            this.DataTable.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.DataTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataTable.Location = new System.Drawing.Point(378, 239);
            this.DataTable.Name = "DataTable";
            this.DataTable.RowHeadersWidth = 51;
            this.DataTable.RowTemplate.Height = 24;
            this.DataTable.Size = new System.Drawing.Size(556, 227);
            this.DataTable.TabIndex = 17;
            this.DataTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataTable_CellClick);
            // 
            // _Output
            // 
            this._Output.AutoSize = true;
            this._Output.Location = new System.Drawing.Point(133, 421);
            this._Output.Name = "_Output";
            this._Output.Size = new System.Drawing.Size(0, 16);
            this._Output.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(1026, 544);
            this.Controls.Add(this._Output);
            this.Controls.Add(this.DataTable);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.gradetf);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.subjecttf);
            this.Controls.Add(this.coursetf);
            this.Controls.Add(this.nametf);
            this.Controls.Add(this.updbtn);
            this.Controls.Add(this.delbtn);
            this.Controls.Add(this.addbtn);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.toAddItem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addItembtn);
            this.Controls.Add(this._CheckBoxList);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox _CheckBoxList;
        private System.Windows.Forms.Button addItembtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox toAddItem;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button addbtn;
        private System.Windows.Forms.Button delbtn;
        private System.Windows.Forms.Button updbtn;
        private System.Windows.Forms.TextBox nametf;
        private System.Windows.Forms.TextBox coursetf;
        private System.Windows.Forms.TextBox subjecttf;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox gradetf;
        private System.Windows.Forms.DataGridView DataTable;
        private System.Windows.Forms.Label _Output;
    }
}

