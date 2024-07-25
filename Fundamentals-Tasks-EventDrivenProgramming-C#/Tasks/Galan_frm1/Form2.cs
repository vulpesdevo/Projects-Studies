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
    public partial class Form2 : Form
    {
        string stringfromfrm1;
        public Form2()
        {
            InitializeComponent();
            
        }
        Form1 frm = new Form1();
        
        private void toFrm1_Click(object sender, EventArgs e)
        {
                   
            frm.Show();
            this.Hide();
        }

        private void lblFrm2_Click(object sender, EventArgs e)
        {
            stringfromfrm1 = frm.mystring;
            lblFrm2.Text = stringfromfrm1;
        }
    }
}
