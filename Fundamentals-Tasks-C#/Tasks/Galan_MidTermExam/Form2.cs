using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Galan_MidTermExam
{
    public partial class Form2 : Form
    {
        string name;
        int age;
        public Form2(string name , int age)
        {
            InitializeComponent();
            this.name = name;
            this.age = age;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            labelname.Text = name;
            labelage.Text = age.ToString();
        }
    }
}
