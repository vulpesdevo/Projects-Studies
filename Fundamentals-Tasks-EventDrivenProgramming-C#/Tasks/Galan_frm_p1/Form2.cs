using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Galan_frm_p1
{
    public partial class Form2 : Form
    {
        string subscription, notify, info, gender;

       
        private void button1_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            this.Hide();
        }

        public Form2(string subscription, string notify,string info, string gender)
        {
            InitializeComponent();
            this.subscription = subscription;
            this.notify = notify;
            this.info = info;
            this.gender = gender;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            subs.Text = subscription;
            notif.Text = notify;
            cost_info.Text = info;
            cos_gender.Text = gender;
        }
    }
}
