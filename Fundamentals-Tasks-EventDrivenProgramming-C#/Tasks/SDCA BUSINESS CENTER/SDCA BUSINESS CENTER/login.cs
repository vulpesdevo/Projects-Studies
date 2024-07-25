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

namespace SDCA_BUSINESS_CENTER
{
    public partial class login : Form
    {
        SqlConnection conn;
        public login()
        {
            conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\Mark Francis\\Desktop\\2023-2024\\Event Driven Programming\\Tasks\\SDCA BUSINESS CENTER\\SDCA BUSINESS CENTER\\Database.mdf\";Integrated Security=True");
            InitializeComponent();
        }

        private void login_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet.Prices_tbl' table. You can move, or remove it, as needed.
            

        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            
            conn.Open();
            
                // Check the username and password in the Security_tbl
            SqlCommand checkLogin = new SqlCommand("SELECT COUNT(*) FROM Security_tbl WHERE Username=@Username AND Password=@Password", conn);
            checkLogin.Parameters.AddWithValue("@Username", username.Text.ToString());
            checkLogin.Parameters.AddWithValue("@Password", password.Text.ToString());

            int count = Convert.ToInt32(checkLogin.ExecuteScalar());

            if (count > 0)
            {
                Form1 form = new Form1();
                form.Show();
                this.Hide();
                // Perform actions for successful login
            }
            else
            {
                MessageBox.Show("Enter a valid account");
                // Handle invalid login attempt
            }
            conn.Close();
            
        }
    }
}
