namespace Galan_frm1
{
    partial class Form2
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
            this.toFrm1 = new System.Windows.Forms.Button();
            this.lblFrm2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // toFrm1
            // 
            this.toFrm1.Location = new System.Drawing.Point(568, 338);
            this.toFrm1.Name = "toFrm1";
            this.toFrm1.Size = new System.Drawing.Size(195, 77);
            this.toFrm1.TabIndex = 0;
            this.toFrm1.Text = "Back to form 1";
            this.toFrm1.UseVisualStyleBackColor = true;
            this.toFrm1.Click += new System.EventHandler(this.toFrm1_Click);
            // 
            // lblFrm2
            // 
            this.lblFrm2.AutoSize = true;
            this.lblFrm2.Location = new System.Drawing.Point(253, 119);
            this.lblFrm2.Name = "lblFrm2";
            this.lblFrm2.Size = new System.Drawing.Size(44, 16);
            this.lblFrm2.TabIndex = 1;
            this.lblFrm2.Text = "label1";
            this.lblFrm2.Click += new System.EventHandler(this.lblFrm2_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblFrm2);
            this.Controls.Add(this.toFrm1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button toFrm1;
        private System.Windows.Forms.Label lblFrm2;
    }
}