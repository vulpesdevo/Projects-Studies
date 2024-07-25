using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Galan_frm_p2
{
    public partial class Form2 : Form
    {
        string orderNumber;
        string customerName;
        string mode;
        string address;
        string foodItems;
        string drinkItems;
        public Form2(string orderNumber, string customerName, string address, string mode, List<string> foodItems, List<string> drinkItems)
        {
            InitializeComponent();

            this.orderNumber = orderNumber;
            this.customerName = customerName;
            this.mode = mode;
            this.address = address;
            this.foodItems = string.Join(", ", foodItems);
            this.drinkItems = string.Join(", ", drinkItems);
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            label1.Text = orderNumber.ToUpper();
            label2.Text = customerName;
            label9.Text = mode;
            label3.Text = address;
            label4.Text = foodItems+"\n"+drinkItems;

        }

        
    }
}
