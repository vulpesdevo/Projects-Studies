using System;
using System.Data.SqlClient;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection.Emit;
using System.Xml.Linq;

namespace SDCA_BUSINESS_CENTER
{
    public partial class editproducts : Form
    {
        SqlConnection conn;
        public editproducts()
        {
            InitializeComponent();
            conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\Mark Francis\\Desktop\\2023-2024\\Event Driven Programming\\Tasks\\SDCA BUSINESS CENTER\\SDCA BUSINESS CENTER\\Database.mdf\";Integrated Security=True");

        }



        private void editproducts_Load(object sender, EventArgs e)
        {

            
           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }
        string stk,updStock;
        private void StockNum_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(StockNum.Text, out var numstock))
            {
                if (numstock <= 20)
                {
                    edit_btn.Enabled = false;
                    StockNum.BackColor = Color.Red;
                }
                else
                {
                    
                    
                    edit_btn.Enabled = true;
                    StockNum.BackColor = Color.Green;

                }
            }
        }

        private void StockNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }
        string pdPrice;
        private void productCombo_SelectedValueChanged(object sender, EventArgs e)
        {
            conn.Open();
            string the_item_name = productCombo.Text;
            SqlCommand cmd = new SqlCommand("SELECT * FROM Product_Information_tbl WHERE Product_Code=@the_item_name", conn);
            cmd.Parameters.AddWithValue("@the_item_name", the_item_name);
            SqlDataReader dr = cmd.ExecuteReader();
            int the_stock = Convert.ToInt32(StockNum.Text);
            while (dr.Read())
            {
                Console.WriteLine(dr[0].ToString());
                //StockNum.Text = dr[0].ToString();
                prodCode.Text = dr.GetValue(1).ToString();
                prodName.Text = dr.GetValue(3).ToString();
                StockNum.Text = dr.GetValue(5).ToString();
                gender.Text = dr.GetValue(6).ToString();
                price.Text = dr.GetValue(7).ToString();
                pdPrice = dr.GetValue(7).ToString();
                stk = dr.GetValue(5).ToString();
                if (Convert.ToInt32(stk) <= 20)
                {
                    edit_btn.Enabled = false;
                    StockNum.BackColor = Color.Red;
                }
                else
                {
                    edit_btn.Enabled = true;
                    StockNum.BackColor = Color.Green;
                }

            }
            switch (the_item_name)
            {
                case "22-GE-FE-BELT":
                    // Handle the case for product code 22-GE-FE-BELT
                    pictureBox1.Image = Properties.Resources.Belt_NBG;
                    Console.WriteLine("Handling product code 22-GE-FE-BELT");
                    break;

                case "21-GE-MA-TIE":
                    // Handle the case for product code 21-GE-MA-TIE
                    pictureBox1.Image = Properties.Resources.Tie_NBG;
                    Console.WriteLine("Handling product code 21-GE-MA-TIE");
                    break;

                case "23-GE-FE-SCA":
                    // Handle the case for product code 23-GE-FE-SCA
                    pictureBox1.Image = Properties.Resources.Scarf_NBG;
                    Console.WriteLine("Handling product code 23-GE-FE-SCA");
                    break;

                case "1-GE-MA-POLO":
                    // Handle the case for product code 1-GE-MA-POLO
                    pictureBox1.Image = Properties.Resources.poloMale;
                    Console.WriteLine("Handling product code 1-GE-MA-POLO");
                    break;

                case "11-GE-MA-PANTS":
                    // Handle the case for product code 11-GE-MA-PANTS
                    pictureBox1.Image = Properties.Resources.Male_Pants_NBG;
                    Console.WriteLine("Handling product code 11-GE-MA-PANTS");
                    break;

                case "25-GE-FE-BL":
                    // Handle the case for product code 25-GE-FE-BL
                    pictureBox1.Image = Properties.Resources.Blouse_NBG;
                    Console.WriteLine("Handling product code 25-GE-FE-BL");
                    break;

                case "36-GE-FE-PANTS":
                    // Handle the case for product code 36-GE-FE-PANTS
                    pictureBox1.Image = Properties.Resources.Female_Pants_NBG;
                    Console.WriteLine("Handling product code 36-GE-FE-PANTS");
                    break;

                case "47-GE-IJNI-RS":
                    // Handle the case for product code 47-GE-IJNI-RS
                    pictureBox1.Image = Properties.Resources.Redshirt_NBG;
                    Console.WriteLine("Handling product code 47-GE-IJNI-RS");
                    break;

                default:
                    // Handle the default case (if none of the specified codes match)

                    Console.WriteLine("Unhandled product code");
                    break;
            }
            conn.Close();
        }

        private void edit_btn_Click(object sender, EventArgs e)
        {


            
            if (MessageBox.Show("Are you sure you want to update?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //get the item  details..............pdCode, pdName, qty,pdSize, ttlPrice
                /* SqlCommand updateCmd = new SqlCommand("UPDATE Product_Information_tbl SET Stocks=@newStockValue, Price=@newPriceValue WHERE Product_Code=@the_item_name", conn);
                 updateCmd.Parameters.AddWithValue("@newStockValue", newStockValue);
                 updateCmd.Parameters.AddWithValue("@newPriceValue", newPriceValue);
                 updateCmd.Parameters.AddWithValue("@the_item_name", the_item_name);
                 MessageBox.Show($"Edit Successfully {the_item_name}");
                 updateCmd.ExecuteNonQuery();*/
                try
                {
                    conn.Open();
                    string the_item_name = prodCode.Text.ToString();
                    int newStockValue = Convert.ToInt32(StockNum.Text);
                    int newPriceValue = Convert.ToInt32(pdPrice);

                    SqlCommand updateCmd = new SqlCommand("UPDATE dbo.Product_Information_tbl SET Stocks=@newStockValue WHERE Product_Code=@the_item_name", conn);
                    updateCmd.Parameters.AddWithValue("@newStockValue", newStockValue);
                    updateCmd.Parameters.AddWithValue("@newPriceValue", newPriceValue);
                    updateCmd.Parameters.AddWithValue("@the_item_name", the_item_name);

                    int rowsAffected = updateCmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No rows were updated.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
                catch (Exception ex)
                {
                    // Handle exceptions (e.g., print or log the error message)
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    // Ensure to close the connection, whether the update was successful or not
                    conn.Close();
                }
                conn.Close();

            }
           
        }
    }
}
