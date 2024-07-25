using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace SDCA_BUSINESS_CENTER
{
    public partial class catalog : Form
    {
        SqlConnection conn;
        public catalog()
        {
            InitializeComponent();
            conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\Mark Francis\\Desktop\\2023-2024\\Event Driven Programming\\Tasks\\SDCA BUSINESS CENTER\\SDCA BUSINESS CENTER\\Database.mdf\";Integrated Security=True");
        }

        private void catalog_Load(object sender, EventArgs e)
        {
            /*
            22-GE-FE-BELT
            21-GE-MA-TIE
            23-GE-FE-SCA
            1-GE-MA-POLO
            11-GE-MA-PANTS
            25-GE-FE-BL
            36-GE-FE-PANTS
            47-GE-IJNI-RS
            */

            // Call the method for each product
            FetchAndUpdateProductInfo("1-GE-MA-POLO", poloPrice, poloStock);
            FetchAndUpdateProductInfo("22-GE-FE-BELT", beltPrice, beltStock);
            FetchAndUpdateProductInfo("21-GE-MA-TIE", tiePrice, tieStock);
            FetchAndUpdateProductInfo("23-GE-FE-SCA", scaPrice, scaStock);
            FetchAndUpdateProductInfo("11-GE-MA-PANTS", MPantPrice, MPantStock);
            FetchAndUpdateProductInfo("25-GE-FE-BL", bloPrice, bloStock);
            FetchAndUpdateProductInfo("36-GE-FE-PANTS", FPantPrice, FPantStock);
            FetchAndUpdateProductInfo("47-GE-IJNI-RS", shirtPrice, shirtStock);

            SetStockBackgroundColor(poloStock);
            SetStockBackgroundColor(MPantStock);
            SetStockBackgroundColor(bloStock);
            SetStockBackgroundColor(FPantStock);
            SetStockBackgroundColor(shirtStock);
            SetStockBackgroundColor(beltStock);
            SetStockBackgroundColor(tieStock);
            SetStockBackgroundColor(scaStock);

        }
        private void FetchAndUpdateProductInfo(string productCode, Label priceTextBox, Label stockTextBox)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Product_Information_tbl WHERE Product_Code=@productCode", conn);
            cmd.Parameters.AddWithValue("@productCode", productCode);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                // Access the columns in the result set
                priceTextBox.Text = $"{dr.GetValue(7)}";
                stockTextBox.Text = dr.GetValue(5).ToString();
            }
            conn.Close();
        }


        private void SetStockBackgroundColor(Label stockTextBox)
        {
            if (int.TryParse(stockTextBox.Text, out var numstock))
            {
                stockTextBox.BackColor = numstock <= 20 ? Color.Red : Color.Green;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        

        

        


      

       

        
    }
}
