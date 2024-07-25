namespace Galan_frm1
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
            this.process_btn = new System.Windows.Forms.Button();
            this.thelabel = new System.Windows.Forms.Label();
            this.toFrm2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // process_btn
            // 
            this.process_btn.Location = new System.Drawing.Point(727, 403);
            this.process_btn.Name = "process_btn";
            this.process_btn.Size = new System.Drawing.Size(151, 56);
            this.process_btn.TabIndex = 0;
            this.process_btn.Text = "PROCESS";
            this.process_btn.UseVisualStyleBackColor = true;
            this.process_btn.Click += new System.EventHandler(this.process_btn_Click);
            // 
            // thelabel
            // 
            this.thelabel.AutoSize = true;
            this.thelabel.Location = new System.Drawing.Point(110, 74);
            this.thelabel.Name = "thelabel";
            this.thelabel.Size = new System.Drawing.Size(0, 16);
            this.thelabel.TabIndex = 1;
            // 
            // toFrm2
            // 
            this.toFrm2.Location = new System.Drawing.Point(564, 403);
            this.toFrm2.Name = "toFrm2";
            this.toFrm2.Size = new System.Drawing.Size(141, 56);
            this.toFrm2.TabIndex = 2;
            this.toFrm2.Text = "Got to Form 2";
            this.toFrm2.UseVisualStyleBackColor = true;
            this.toFrm2.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 506);
            this.Controls.Add(this.toFrm2);
            this.Controls.Add(this.thelabel);
            this.Controls.Add(this.process_btn);
            this.Name = "Form1";
            this.Text = "Window1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button process_btn;
        private System.Windows.Forms.Label thelabel;
        private System.Windows.Forms.Button toFrm2;
    }
}

