using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Galan_frm1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        
        public string mystring;
        private void process_btn_Click(object sender, EventArgs e)
        {
            
            thelabel.Text = "Hello World";
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 myForm2 = new Form2();
            mystring = thelabel.Text;
            myForm2.Show();
            this.Hide();
        }

        
    }
}
