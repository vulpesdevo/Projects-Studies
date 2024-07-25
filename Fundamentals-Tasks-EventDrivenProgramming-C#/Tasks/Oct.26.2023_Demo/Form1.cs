using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oct._26._2023_Demo
{
    public partial class Form1 : Form
    {

        List<string> fruits = new List<string>
        {
            "Apple",
            "Banana",
            "Mango"
        };

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            fruits.Add("Grapes");
            foreach (string fruit in fruits)
            {
                listBox1.Items.Add(fruit);
            }
            
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                listBox1.Items.Add(textBox1.Text);
                textBox1.Text = "";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string addfruit = textBox1.Text;
            listBox1.Items.Add(addfruit);
            
            textBox1.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var count = listBox1.Items.Count;
            if (count > 0)
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
            }
        }


        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
          
            label1.Text = listBox1.SelectedItem.ToString();
            
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.redshirt;
        }


        private void button7_Click(object sender, EventArgs e)
        {
            //string mydate = dateTimePicker1.Value.ToString("MMM dd, yyyy");
            string mytime = dateTimePicker1.Value.ToString("hh:mm:ss tt");
            label2.Text = mytime;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.Tie_Male;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.Blouse_Female;
        }
    }
}
