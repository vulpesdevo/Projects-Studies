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
    public partial class Form1 : Form
    {
        string notification ="", gender = "";
        public Form1()
        {
            InitializeComponent();
        }    

        private void submitbtn_Click(object sender, EventArgs e)
        {
            string cname, cadd, cemail;
            int C_contact;
            cname = name.Text;
            cadd = address.Text;
            C_contact = Convert.ToInt32(contact.Text);
            cemail = email.Text;

            string allinfo = "Name: "+ cname + "\n" + "Address: " + cadd + "\n" + "Contact: " + C_contact + "\n" + "Email Address: " + cemail + "\n";

            if (sms.Checked)
            {
                notification += "SMS\n";
            }
            if (nemail.Checked)
            {
                notification += "Email\n";
            }
            if (nmail.Checked)
            {
                notification += "Mail\n";
            }

            if (male.Checked)
            {
                gender += "Male";
            }
            if (female.Checked)
            {
                gender += "Female";
            }

            
            Form2 f2 = new Form2(subscription.Text,notification, allinfo,gender );
            f2.Show();
            this.Hide();
            


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void clearbtn_Click(object sender, EventArgs e)
        {
            RadioButton radioButton = new RadioButton();

            radioButton.Checked = false;
            name.Clear();
            address.Clear();
            contact.Clear();
            email.Clear();
        }
    }
}
