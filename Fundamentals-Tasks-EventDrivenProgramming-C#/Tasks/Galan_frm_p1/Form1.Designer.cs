namespace Galan_frm_p1
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
            this.name = new System.Windows.Forms.TextBox();
            this.address = new System.Windows.Forms.TextBox();
            this.contact = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.male = new System.Windows.Forms.RadioButton();
            this.female = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.sms = new System.Windows.Forms.CheckBox();
            this.nemail = new System.Windows.Forms.CheckBox();
            this.nmail = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.subscription = new System.Windows.Forms.ComboBox();
            this.submitbtn = new System.Windows.Forms.Button();
            this.clearbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(161, 103);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(233, 22);
            this.name.TabIndex = 0;
            // 
            // address
            // 
            this.address.Location = new System.Drawing.Point(161, 143);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(233, 22);
            this.address.TabIndex = 1;
            // 
            // contact
            // 
            this.contact.Location = new System.Drawing.Point(161, 187);
            this.contact.Name = "contact";
            this.contact.Size = new System.Drawing.Size(233, 22);
            this.contact.TabIndex = 3;
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(161, 231);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(233, 22);
            this.email.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Costumer Name: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Address: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Contact #: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Email Address: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(462, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Gender: ";
            // 
            // male
            // 
            this.male.AutoSize = true;
            this.male.Location = new System.Drawing.Point(500, 132);
            this.male.Name = "male";
            this.male.Size = new System.Drawing.Size(58, 20);
            this.male.TabIndex = 10;
            this.male.TabStop = true;
            this.male.Text = "Male";
            this.male.UseVisualStyleBackColor = true;
            // 
            // female
            // 
            this.female.AutoSize = true;
            this.female.Location = new System.Drawing.Point(578, 132);
            this.female.Name = "female";
            this.female.Size = new System.Drawing.Size(74, 20);
            this.female.TabIndex = 11;
            this.female.TabStop = true;
            this.female.Text = "Female";
            this.female.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(462, 175);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "Send Notification";
            // 
            // sms
            // 
            this.sms.AutoSize = true;
            this.sms.Location = new System.Drawing.Point(500, 208);
            this.sms.Name = "sms";
            this.sms.Size = new System.Drawing.Size(58, 20);
            this.sms.TabIndex = 13;
            this.sms.Text = "SMS";
            this.sms.UseVisualStyleBackColor = true;
            // 
            // nemail
            // 
            this.nemail.AutoSize = true;
            this.nemail.Location = new System.Drawing.Point(601, 208);
            this.nemail.Name = "nemail";
            this.nemail.Size = new System.Drawing.Size(63, 20);
            this.nemail.TabIndex = 14;
            this.nemail.Text = "Email";
            this.nemail.UseVisualStyleBackColor = true;
            // 
            // nmail
            // 
            this.nmail.AutoSize = true;
            this.nmail.Location = new System.Drawing.Point(702, 208);
            this.nmail.Name = "nmail";
            this.nmail.Size = new System.Drawing.Size(54, 20);
            this.nmail.TabIndex = 15;
            this.nmail.Text = "Mail";
            this.nmail.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(462, 261);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 16);
            this.label7.TabIndex = 16;
            this.label7.Text = "Subscription";
            // 
            // subscription
            // 
            this.subscription.FormattingEnabled = true;
            this.subscription.Items.AddRange(new object[] {
            "Monthly",
            "Yearly"});
            this.subscription.Location = new System.Drawing.Point(564, 289);
            this.subscription.Name = "subscription";
            this.subscription.Size = new System.Drawing.Size(156, 24);
            this.subscription.TabIndex = 17;
            this.subscription.Text = "Monthly";
            // 
            // submitbtn
            // 
            this.submitbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.submitbtn.Location = new System.Drawing.Point(402, 348);
            this.submitbtn.Name = "submitbtn";
            this.submitbtn.Size = new System.Drawing.Size(128, 62);
            this.submitbtn.TabIndex = 19;
            this.submitbtn.Text = "SUBMIT";
            this.submitbtn.UseVisualStyleBackColor = false;
            this.submitbtn.Click += new System.EventHandler(this.submitbtn_Click);
            // 
            // clearbtn
            // 
            this.clearbtn.BackColor = System.Drawing.Color.IndianRed;
            this.clearbtn.Location = new System.Drawing.Point(272, 348);
            this.clearbtn.Name = "clearbtn";
            this.clearbtn.Size = new System.Drawing.Size(124, 62);
            this.clearbtn.TabIndex = 20;
            this.clearbtn.Text = "CLEAR";
            this.clearbtn.UseVisualStyleBackColor = false;
            this.clearbtn.Click += new System.EventHandler(this.clearbtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.clearbtn);
            this.Controls.Add(this.submitbtn);
            this.Controls.Add(this.subscription);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.nmail);
            this.Controls.Add(this.nemail);
            this.Controls.Add(this.sms);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.female);
            this.Controls.Add(this.male);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.email);
            this.Controls.Add(this.contact);
            this.Controls.Add(this.address);
            this.Controls.Add(this.name);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox address;
        private System.Windows.Forms.TextBox contact;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton male;
        private System.Windows.Forms.RadioButton female;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox sms;
        private System.Windows.Forms.CheckBox nemail;
        private System.Windows.Forms.CheckBox nmail;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox subscription;
        private System.Windows.Forms.Button submitbtn;
        private System.Windows.Forms.Button clearbtn;
    }
}

