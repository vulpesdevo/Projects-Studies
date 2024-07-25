using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Galan_frm_p2
{
    public partial class Form1 : Form
    {
        
        int counter = 0;
        List<List<string>> orderedfood = new List<List<string>>();
        List<List<string>> ordereddrink = new List<List<string>>();
        List<List<string>> orders = new List<List<string>>();
        
        public Form1()
        {
            InitializeComponent();
        }

        private void ADD_Click(object sender, EventArgs e)
        {
            string name = customer_name.Text;
            string add = cust_address.Text;
            string DorT="";
          
            string yourfood="", yourdrink = "";
            List<string> orderDetails = new List<string>();
            List<string> foodlist = new List<string>();
            List<string> drinklist = new List<string>();
            foreach (string s in food_list.CheckedItems)
            {
                yourfood += s +"\n";
            }
            foreach (string s in drink_list.CheckedItems)
            {
                yourdrink += s + "\n";
            }

            if (yourfood != "" && yourdrink != "")
            {
                TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;
                counter++;
                num_order.Items.Add("Order # " + counter);
                foodlist.Add(yourfood);
                drinklist.Add(yourdrink);
                orderDetails.Add(textInfo.ToTitleCase(name));
                orderDetails.Add(add);
                orders.Add(orderDetails);
                orderedfood.Add(foodlist);
                ordereddrink.Add(drinklist);

                if (dine_in.Checked)
                {
                    DorT += "Dine-In";
                }
                else
                {
                    DorT += "Take-Out";
                }
                orderDetails.Add(DorT);
                customer_name.Text = "";
                cust_address.Text = "";
                food_list.SetItemChecked(0, false);
                food_list.SetItemChecked(1, false);
                food_list.SetItemChecked(2, false);
                drink_list.SetItemChecked(0, false);
                drink_list.SetItemChecked(1, false);
                food_list.SelectedIndex = -1;
                drink_list.SelectedIndex = -1;
            }
            
        }
        int orderind ;
        private void num_order_SelectedIndexChanged(object sender, EventArgs e)
        {
            orderind = num_order.SelectedIndex;
        }

        private void next_Click(object sender, EventArgs e)
        {
            if (num_order.SelectedIndex >= 0)
            {
                List<string> selectedOrder = orders[orderind];
                List<string> selectedOrder2 = orderedfood[orderind];
                List<string> selectedOrder3 = ordereddrink[orderind];
                Form2 form2 = new Form2(num_order.SelectedItem.ToString(), selectedOrder[0], selectedOrder[1], selectedOrder[2], selectedOrder2, selectedOrder3);

                form2.Show();
            }
        }

        private void view_Click(object sender, EventArgs e)
        {
            if (num_order.SelectedIndex >= 0)
            {
                food_list.SetItemChecked(0, false);
                food_list.SetItemChecked(1, false);
                food_list.SetItemChecked(2, false);
                drink_list.SetItemChecked(0, false);
                drink_list.SetItemChecked(1, false);
                

                List<string> selectedOrder = orders[orderind];
                List<string> selectedOrder2 = orderedfood[orderind];
                List<string> selectedOrder3 = ordereddrink[orderind];

                customer_name.Text = selectedOrder[0];
                cust_address.Text = selectedOrder[1];  
                string _mode = selectedOrder[2];
                string _foods = string.Join(", ", selectedOrder2);
                string _drinks = string.Join(", ", selectedOrder3);

                
                if (_foods.Contains("Pizza"))
                {
                    food_list.SetItemChecked(0, true);
                }
                if (_foods.Contains("Burger"))
                {
                    food_list.SetItemChecked(1, true);
                }
                if (_foods.Contains("Pasta"))
                {
                    food_list.SetItemChecked(2, true);
                }
                
                
                if (_drinks.Contains("Softdrinks"))
                {
                    drink_list.SetItemChecked(0, true);
                }
                if (_drinks.Contains("Juice"))
                {
                    drink_list.SetItemChecked(1, true);
                }
                   
           
                if (_mode == "Dine-In")
                {
                    dine_in.Select();
                }
                if (_mode == "Take-Out")
                {
                    take_out.Select();
                }


            }
        }

        private void CLEAR_Click(object sender, EventArgs e)
        {
            customer_name.Clear();
            cust_address.Clear();
            food_list.SetItemChecked(0, false);
            food_list.SetItemChecked(1, false);
            food_list.SetItemChecked(2, false);
            drink_list.SetItemChecked(0, false);
            drink_list.SetItemChecked(1, false);
            food_list.SelectedIndex = -1;
            drink_list.SelectedIndex = -1;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}