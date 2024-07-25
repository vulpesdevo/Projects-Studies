using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SDCA_BUSINESS_CENTER
{
    public partial class Form1 : Form
    {

        SqlConnection conn;


        //the orderlist
        string pdCode, pdName, pdSize;
        int qty, pdPrice,ttlPrice;


        public Form1()
        {
            InitializeComponent();
            conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\Mark Francis\\Desktop\\2023-2024\\Event Driven Programming\\Tasks\\SDCA BUSINESS CENTER\\SDCA BUSINESS CENTER\\Database.mdf\";Integrated Security=True");

            setColumnsHeader();
        }
        public void setColumnsHeader()
        {
            OrderListTbl.ColumnCount = 5;
            OrderListTbl.Columns[0].Name = "Product Code";
            OrderListTbl.Columns[1].Name = "Product Name";
            OrderListTbl.Columns[2].Name = "QTY";
            OrderListTbl.Columns[3].Name = "Size";
            OrderListTbl.Columns[4].Name = "Price";
            OrderListTbl.BackColor = Color.Red;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            confirmOrder.Enabled = false;
        }

        private void sizeCombo_SelectedValueChanged(object sender, EventArgs e)
        {
           
        }

        public int CalculateTotalPrice()
        {
            int totalPrice = 0;
            // Assuming your DataGridView is named OrderListTbl
            foreach (DataGridViewRow row in OrderListTbl.Rows)
            {
                // Check if the row is not empty and the "Price" column is not null
                if (!row.IsNewRow && row.Cells["Price"].Value != null)
                {
                    // Parse the "Price" value to decimal and add it to the total
                    int priceValue;
                    if (int.TryParse(row.Cells["Price"].Value.ToString(), out priceValue))
                    {
                        totalPrice += priceValue;
                    }
                }
            }

            return totalPrice;
        }

        private void deleteItem_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in this.OrderListTbl.SelectedRows.Cast<DataGridViewRow>().ToArray())
            {
                if (item.Index >= 0 && item.Index < OrderListTbl.Rows.Count)
                {
                    OrderListTbl.Rows.RemoveAt(item.Index);
                }
            }
            TotalPrice.Text = $"P {CalculateTotalPrice()}";
        }

        private void confirmOrder_Click(object sender, EventArgs e)
        {
            conn.Open();
            TotalPrice.Text = $"P {CalculateTotalPrice()}";
            string wholename="";
            string studName = SNum.Text;
            
            SqlCommand getstudent = new SqlCommand("SELECT * FROM Student_Informmation_tbl WHERE Student_No=@studName", conn);
            getstudent.Parameters.AddWithValue("@studName", studName);
            SqlDataReader dr = getstudent.ExecuteReader();
           
            // Student number exists in the table
            while (dr.Read())
            {
                /*Console.WriteLine(dr[0].ToString());
                StockNum.Text = dr[0].ToString();*/
                wholename =""+dr.GetValue(2).ToString();
            }

            conn.Close();
            conn.Open();
            SqlCommand getLatestTransactionID = new SqlCommand("SELECT MAX(Transaction_ID) AS LatestTransactionID FROM Transaction_tbl", conn);

            // ExecuteScalar is used to retrieve a single value (the latest Transaction_ID)
            int latestTransactionID = Convert.ToInt32(getLatestTransactionID.ExecuteScalar());
            latestTransactionID += 1;
            conn.Close();
            string transactionDate = DateTime.Now.ToString("yyyy-MM-dd");

            if (int.TryParse(cashBox.Text, out int enteredAmount) && SNum.Text != null && cashBox.Text != null)
            {
                if (enteredAmount >= ttlPrice)
                {
                    int cashchange = Convert.ToInt32(cashBox.Text) - Convert.ToInt32(CalculateTotalPrice());
                    if (MessageBox.Show("Are you sure you want to proceed?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {


                        for (int i = 0; i < OrderListTbl.Rows.Count - 1; i++)
                        {

                            SqlCommand getCMD = new SqlCommand("INSERT INTO Transaction_tbl(Transaction_No,Student_No, Product_Code, ProductName, Size, Quantity, TransactionDate, Amount, Cash) VALUES('" + latestTransactionID + "','" + studName + "','" + OrderListTbl.Rows[i].Cells[0].Value + "','" + OrderListTbl.Rows[i].Cells[1].Value + "','" + OrderListTbl.Rows[i].Cells[3].Value + "','" + OrderListTbl.Rows[0].Cells[2].Value + "','" + transactionDate + "','" + OrderListTbl.Rows[0].Cells[4].Value + "','" + int.Parse(cashBox.Text) + "')", conn);
                            conn.Open();
                            getCMD.ExecuteNonQuery();
                            conn.Close();
                            SqlCommand updateStockCMD = new SqlCommand("UPDATE Product_Information_tbl SET Stocks = Stocks - @Quantity WHERE ProductName = @ProductName", conn);
                            // Add parameters to the updateStockCMD
                            updateStockCMD.Parameters.AddWithValue("@Quantity", OrderListTbl.Rows[i].Cells[2].Value);
                            updateStockCMD.Parameters.AddWithValue("@ProductName", OrderListTbl.Rows[i].Cells[1].Value);
                            // Open connection, execute update query, and close connection
                            conn.Open();
                            updateStockCMD.ExecuteNonQuery();
                            conn.Close();
                        }
                        conn.Open();
                        string the_item_name = productCombo.Text;
                        SqlCommand cmd = new SqlCommand("SELECT * FROM Product_Information_tbl WHERE Product_Code=@the_item_name", conn);
                        cmd.Parameters.AddWithValue("@the_item_name", the_item_name);
                        SqlDataReader dragain = cmd.ExecuteReader();
                        while (dragain.Read())
                        {
                            StockNum.Text = dragain.GetValue(5).ToString();
                        }
                        conn.Close();
                        DataGridViewRowCollection rows = OrderListTbl.Rows;
                        
                        receipt receiptfrm = new receipt(latestTransactionID.ToString(), transactionDate, studName, wholename, cashBox.Text.ToString(), cashchange, $"₱ {CalculateTotalPrice()}");
                        receiptfrm.SetData(rows);
                        receiptfrm.Show();
                        cashBox.Text = string.Empty;
                        TotalPrice.Text = string.Empty;
                        SNum.Text = string.Empty;
                        OrderListTbl.Rows.Clear();

                    }
                }
            }
            /*if (SNum.Text != null && cashBox.Text != null || Convert.ToInt32(cashBox.Text) > Convert.ToInt32(CalculateTotalPrice()))
            {
                
            }*/
            else
            {
                MessageBox.Show("Invalid Amount");
            }
            
        }

        private void SNum_TextChanged(object sender, EventArgs e)
        {
            conn.Open();
            string studName = SNum.Text;
            SqlCommand getstudent = new SqlCommand("SELECT Student_No FROM Student_Informmation_tbl WHERE Student_No = @studName", conn);
            getstudent.Parameters.AddWithValue("@studName", studName);

            
            SqlDataReader dr = getstudent.ExecuteReader();
            
                
            if (dr.Read())
            {
                SNum.BackColor = Color.Green;
                confirmOrder.Enabled = true;
                // Student number exists in the table
            }
            else
            {
                // Student number does not exist in the table
                confirmOrder.Enabled = false;
                SNum.BackColor = Color.Red;
            }

                
            
            dr.Close(); // Close the SqlDataReader to prevent resource leaks
            conn.Close();

        }

        private void SNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void qtyInp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void cashBox_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(cashBox.Text, out int enteredAmount))
            {
                if (enteredAmount < CalculateTotalPrice())
                {
                    errormessage.Text = "Invalid Amount";
                    errormessage.ForeColor = Color.Red;
                }
                else
                {
                    errormessage.Text = "Valid";
                    errormessage.ForeColor = Color.Green;
                }
            }
            else
            {
                // Handle the case where the input is not a valid integer
                errormessage.Text = "Please enter a valid number.";
            }
        }

        private void cashBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void productCombo_TextChanged(object sender, EventArgs e)
        {
            if (productCombo.Text.ToString() == "")
            {
                addItem.Enabled = false;
            }
            else
            {
                addItem.Enabled = true;
            }
        }

        private void StockNum_TextChanged(object sender, EventArgs e)
        {

            if (Convert.ToInt32(StockNum.Text)<=20)
            {
                addItem.Enabled = false;
                StockNum.BackColor = Color.Red;
            }
            else
            {
                addItem.Enabled = true;
                StockNum.BackColor = Color.Green;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            login logout = new login();
            logout.Show();
            this.Hide();
        }

        private void addItem_Click(object sender, EventArgs e)
        {
            pdCode = prodCode.Text;
            pdName = prodName.Text;
            string commbopdname = productCombo.Text.ToString();
            pdSize = sizeCombo.Text.ToString();


            if (commbopdname != "")
            {
                if (int.TryParse(price.Text, out pdPrice) && int.TryParse(qtyInp.Text, out qty) && Convert.ToInt32(qtyInp.Text) < Convert.ToInt32(StockNum.Text))
                {
                    if (MessageBox.Show("Do you want to add this item to your orderlist?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        if (qty >= 0 && pdSize != "" && commbopdname != "")
                        {
                            ttlPrice = pdPrice * qty;
                            List<object> list = new List<object> { pdCode, pdName, qty, pdSize, ttlPrice };
                            OrderListTbl.Rows.Add(list.ToArray());
                            TotalPrice.Text = $"P {CalculateTotalPrice()}";
                        }
                        
                    }
                }

                else
                {
                    MessageBox.Show("Error: Invalid input size or quantity. Please check your entries and ensure that the quantity does not exceed the available stock.");
                }
            }
            else
            {
                MessageBox.Show("Select Product");
            }  
        }

        private void catalog_btn_Click(object sender, EventArgs e)
        {
            catalog f2 = new catalog();
            f2.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //edit products button
            editproducts f3 = new editproducts();
            f3.Show();
            this.Hide();
        }
        /*22-GE-FE-BELT
                    21-GE-MA-TIE
                    23-GE-FE-SCA
                    1-GE-MA-POLO
                    11-GE-MA-PANTS
                    25-GE-FE-BL
                    36-GE-FE-PANTS
                    47-GE-IJNI-RS*/
        private void productCombo_SelectedValueChanged(object sender, EventArgs e)
        {
            conn.Open();
            string the_item_name = productCombo.Text;
            SqlCommand cmd = new SqlCommand("SELECT * FROM Product_Information_tbl WHERE Product_Code=@the_item_name",conn);
            cmd.Parameters.AddWithValue("@the_item_name", the_item_name);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                /*Console.WriteLine(dr[0].ToString());
                StockNum.Text = dr[0].ToString();*/
                StockNum.Text = dr.GetValue(5).ToString();
                prodCode.Text = dr.GetValue(1).ToString();
                prodName.Text = dr.GetValue(3).ToString();
                price.Text = dr.GetValue(7).ToString();

            }
            Dictionary<string, System.Drawing.Image> productImages = new Dictionary<string, System.Drawing.Image>
            {
                { "22-GE-FE-BELT", Properties.Resources.Belt_NBG },
                { "21-GE-MA-TIE", Properties.Resources.Tie_NBG },
                { "23-GE-FE-SCA", Properties.Resources.Scarf_NBG },
                { "1-GE-MA-POLO", Properties.Resources.poloMale },
                { "11-GE-MA-PANTS", Properties.Resources.Male_Pants_NBG },
                { "25-GE-FE-BL", Properties.Resources.Blouse_NBG },
                { "36-GE-FE-PANTS", Properties.Resources.Female_Pants_NBG },
                { "47-GE-IJNI-RS", Properties.Resources.Redshirt_NBG },
            };

            if (productImages.TryGetValue(the_item_name, out var image))
            {
                pictureBox2.Image = image;
            }
            else
            {
                Console.WriteLine("Unhandled product code");
            }
            conn.Close();

        }
    }
}
