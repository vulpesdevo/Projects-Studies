namespace Galan_frm_p2
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
            this.customer_name = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cust_address = new System.Windows.Forms.TextBox();
            this.address = new System.Windows.Forms.Label();
            this.dine_in = new System.Windows.Forms.RadioButton();
            this.take_out = new System.Windows.Forms.RadioButton();
            this.num_order = new System.Windows.Forms.ListBox();
            this.food_list = new System.Windows.Forms.CheckedListBox();
            this.drink_list = new System.Windows.Forms.CheckedListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.ADD = new System.Windows.Forms.Button();
            this.CLEAR = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.next = new System.Windows.Forms.Button();
            this.view = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // customer_name
            // 
            this.customer_name.BackColor = System.Drawing.Color.PeachPuff;
            this.customer_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customer_name.Location = new System.Drawing.Point(59, 85);
            this.customer_name.Multiline = true;
            this.customer_name.Name = "customer_name";
            this.customer_name.Size = new System.Drawing.Size(283, 37);
            this.customer_name.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // cust_address
            // 
            this.cust_address.BackColor = System.Drawing.Color.PeachPuff;
            this.cust_address.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cust_address.Location = new System.Drawing.Point(59, 189);
            this.cust_address.Multiline = true;
            this.cust_address.Name = "cust_address";
            this.cust_address.Size = new System.Drawing.Size(283, 115);
            this.cust_address.TabIndex = 2;
            // 
            // address
            // 
            this.address.AutoSize = true;
            this.address.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.address.Location = new System.Drawing.Point(54, 161);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(105, 25);
            this.address.TabIndex = 4;
            this.address.Text = "Address: ";
            // 
            // dine_in
            // 
            this.dine_in.AutoSize = true;
            this.dine_in.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dine_in.Location = new System.Drawing.Point(59, 351);
            this.dine_in.Name = "dine_in";
            this.dine_in.Size = new System.Drawing.Size(103, 29);
            this.dine_in.TabIndex = 5;
            this.dine_in.TabStop = true;
            this.dine_in.Text = "Dine-In";
            this.dine_in.UseVisualStyleBackColor = true;
            // 
            // take_out
            // 
            this.take_out.AutoSize = true;
            this.take_out.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.take_out.Location = new System.Drawing.Point(59, 386);
            this.take_out.Name = "take_out";
            this.take_out.Size = new System.Drawing.Size(125, 29);
            this.take_out.TabIndex = 6;
            this.take_out.TabStop = true;
            this.take_out.Text = "Take-Out";
            this.take_out.UseVisualStyleBackColor = true;
            // 
            // num_order
            // 
            this.num_order.BackColor = System.Drawing.Color.SaddleBrown;
            this.num_order.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num_order.FormattingEnabled = true;
            this.num_order.ItemHeight = 31;
            this.num_order.Location = new System.Drawing.Point(741, 76);
            this.num_order.Name = "num_order";
            this.num_order.Size = new System.Drawing.Size(268, 407);
            this.num_order.TabIndex = 12;
            this.num_order.SelectedIndexChanged += new System.EventHandler(this.num_order_SelectedIndexChanged);
            // 
            // food_list
            // 
            this.food_list.BackColor = System.Drawing.Color.DarkKhaki;
            this.food_list.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.food_list.FormattingEnabled = true;
            this.food_list.Items.AddRange(new object[] {
            "Pizza",
            "Burger",
            "Pasta"});
            this.food_list.Location = new System.Drawing.Point(408, 82);
            this.food_list.Name = "food_list";
            this.food_list.Size = new System.Drawing.Size(266, 104);
            this.food_list.TabIndex = 13;
            // 
            // drink_list
            // 
            this.drink_list.BackColor = System.Drawing.Color.DarkKhaki;
            this.drink_list.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drink_list.FormattingEnabled = true;
            this.drink_list.Items.AddRange(new object[] {
            "Softdrinks",
            "Juice"});
            this.drink_list.Location = new System.Drawing.Point(408, 222);
            this.drink_list.Name = "drink_list";
            this.drink_list.Size = new System.Drawing.Size(266, 79);
            this.drink_list.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(364, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 25);
            this.label3.TabIndex = 16;
            this.label3.Text = "Products: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(700, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 25);
            this.label2.TabIndex = 17;
            this.label2.Text = "List of All Orders: ";
            // 
            // ADD
            // 
            this.ADD.BackColor = System.Drawing.Color.LimeGreen;
            this.ADD.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ADD.Location = new System.Drawing.Point(539, 383);
            this.ADD.Name = "ADD";
            this.ADD.Size = new System.Drawing.Size(135, 61);
            this.ADD.TabIndex = 18;
            this.ADD.Text = "ADD";
            this.ADD.UseVisualStyleBackColor = false;
            this.ADD.Click += new System.EventHandler(this.ADD_Click);
            // 
            // CLEAR
            // 
            this.CLEAR.BackColor = System.Drawing.Color.Red;
            this.CLEAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CLEAR.Location = new System.Drawing.Point(408, 383);
            this.CLEAR.Name = "CLEAR";
            this.CLEAR.Size = new System.Drawing.Size(125, 61);
            this.CLEAR.TabIndex = 19;
            this.CLEAR.Text = "CLEAR";
            this.CLEAR.UseVisualStyleBackColor = false;
            this.CLEAR.Click += new System.EventHandler(this.CLEAR_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(54, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Customer Name: ";
            // 
            // next
            // 
            this.next.Location = new System.Drawing.Point(1030, 82);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(118, 39);
            this.next.TabIndex = 20;
            this.next.Text = "NEXT";
            this.next.UseVisualStyleBackColor = true;
            this.next.Click += new System.EventHandler(this.next_Click);
            // 
            // view
            // 
            this.view.Location = new System.Drawing.Point(1030, 147);
            this.view.Name = "view";
            this.view.Size = new System.Drawing.Size(118, 39);
            this.view.TabIndex = 21;
            this.view.Text = "VIEW";
            this.view.UseVisualStyleBackColor = true;
            this.view.Click += new System.EventHandler(this.view_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Sienna;
            this.ClientSize = new System.Drawing.Size(1181, 528);
            this.Controls.Add(this.view);
            this.Controls.Add(this.next);
            this.Controls.Add(this.CLEAR);
            this.Controls.Add(this.ADD);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.drink_list);
            this.Controls.Add(this.food_list);
            this.Controls.Add(this.num_order);
            this.Controls.Add(this.take_out);
            this.Controls.Add(this.dine_in);
            this.Controls.Add(this.address);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cust_address);
            this.Controls.Add(this.customer_name);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox customer_name;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox cust_address;
        private System.Windows.Forms.Label address;
        private System.Windows.Forms.RadioButton dine_in;
        private System.Windows.Forms.RadioButton take_out;
        private System.Windows.Forms.ListBox num_order;
        private System.Windows.Forms.CheckedListBox food_list;
        private System.Windows.Forms.CheckedListBox drink_list;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button ADD;
        private System.Windows.Forms.Button CLEAR;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button next;
        private System.Windows.Forms.Button view;
    }
}

