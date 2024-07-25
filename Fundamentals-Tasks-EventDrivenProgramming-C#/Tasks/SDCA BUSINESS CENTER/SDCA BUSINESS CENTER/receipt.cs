using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SDCA_BUSINESS_CENTER
{
    public partial class receipt : Form
    {
        string orNum, orDate, stNum, stName, cPaid, total;

        int cChange;
        private void receipt_Load(object sender, EventArgs e)
        {
            orderNo.Text = orNum;
            orderDate.Text = orDate;
            sName.Text = stName;
            sNum.Text = stNum;
            cashPaid.Text = $"₱{cPaid}";
            change.Text = $"₱ {cChange}";
            totalOut.Text = total;
        }
        //private DataTable dataForForm2;
        

        public receipt(string orNum,string orDate,string stNum,string stName,string cPaid,int cChange,string total)
        {
            InitializeComponent();
            ordershow.ColumnCount = 5;
            ordershow.Columns[0].Name = "Product Code";
            ordershow.Columns[1].Name = "Product Name";
            ordershow.Columns[2].Name = "QTY";
            ordershow.Columns[3].Name = "Size";
            ordershow.Columns[4].Name = "Price";

            this.orNum = orNum;
            this.orDate = orDate;
            this.stNum = stNum;
            this.stName = stName;
            this.cPaid = cPaid;
            this.cChange += cChange;
            this.total = total;
            /*dataForForm2 = data.Copy(); // Copy the DataTable to avoid modifying the original data
            ordershow.DataSource = dataForForm2;*/
        }
        public void SetData(DataGridViewRowCollection rows)
        {
            // Clear existing rows in dataGridView2
            ordershow.Rows.Clear();

            // Add rows from Form1 to dataGridView2
            foreach (DataGridViewRow row in rows)
            {
                // Clone the row to avoid sharing the same reference
                DataGridViewRow clonedRow = (DataGridViewRow)row.Clone();

                // Copy cell values to the new row
                for (int i = 0; i < row.Cells.Count; i++)
                {
                    clonedRow.Cells[i].Value = row.Cells[i].Value;
                }

                // Add the cloned row to dataGridView2
                ordershow.Rows.Add(clonedRow);
            }
        }


        private void printbtn_Click(object sender, EventArgs e)
        {

            PrintDocument printDoc = new PrintDocument();
            printDoc.PrintPage += PrintPageHandler;

            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = printDoc;

            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                printDoc.Print();
            }
        }

        private void PrintPageHandler(object sender, PrintPageEventArgs e)
        {
            // Capture the contentPanel as an image and print it
            Bitmap bmp = new Bitmap(panel1.Width, panel1.Height);
            panel1.DrawToBitmap(bmp, new Rectangle(0, 0, panel1.Width, panel1.Height));
            e.Graphics.DrawImage(bmp, 0, 0);
        }
    }
}
