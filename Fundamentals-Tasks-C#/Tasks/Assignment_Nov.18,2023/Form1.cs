using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
namespace Assignment_Nov._18_2023
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            DataTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            setColumnsHeader();
        }
        public void setColumnsHeader()
        {
            DataTable.ColumnCount = 4;
            DataTable.Columns[0].Name = "Name";
            DataTable.Columns[1].Name = "Course";
            DataTable.Columns[2].Name = "Subject";
            DataTable.Columns[3].Name = "Grade";
        }
        //to add listed item in checkboxlist
        public void addtocheckListBox()
        {
            List<string> checkboxlist = new List<string> { "Banana", "Orange", "Grapes" };

            foreach (var items in checkboxlist)
            {
                _CheckBoxList.Items.Add(items);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            addtocheckListBox();

            //Pre-set data
            List<string> list = new List<string> { "Mark", "BSIT", "Event Driven", "70" };
            DataTable.Rows.Add(list.ToArray());
        }
        private void DataTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {  
            // getting the selected index of row
            DataGridViewRow selectedRow = DataTable.Rows[e.RowIndex];
            nametf.Text = selectedRow.Cells[0].Value.ToString();
            coursetf.Text = selectedRow.Cells[1].Value.ToString();
            subjecttf.Text = selectedRow.Cells[2].Value.ToString();
            gradetf.Text = selectedRow.Cells[3].Value.ToString();
        }

        //ADD Button
        private void addbtn_Click(object sender, EventArgs e)
        {
            string name, course, subject, grade;
            name = nametf.Text.ToString();
            course = coursetf.Text.ToString();
            subject = subjecttf.Text.ToString();
            grade = gradetf.Text.ToString();

            // string[] data = { name, course, subject, grade };
            List<string> list = new List<string>{ name, course, subject, grade };
            
            DataTable.Rows.Add(list.ToArray()); // ArrayList
        }
        private void delbtn_Click(object sender, EventArgs e)
        {

            foreach (DataGridViewRow item in this.DataTable.SelectedRows.Cast<DataGridViewRow>().ToArray())
            {
                if (item.Index >= 0 && item.Index < DataTable.Rows.Count)
                {
                    DataTable.Rows.RemoveAt(item.Index);
                }
            }
            nametf.Text = "";
            coursetf.Text = "";
            subjecttf.Text = "";
            gradetf.Text = "";

        }
        private void updbtn_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = DataTable.SelectedRows[0];   
            selectedRow.Cells[0].Value = nametf.Text;
            selectedRow.Cells[1].Value = coursetf.Text;
            selectedRow.Cells[2].Value = subjecttf.Text;
            selectedRow.Cells[3].Value = gradetf.Text;

            nametf.Text = "";
            coursetf.Text = "";
            subjecttf.Text = "";
            gradetf.Text = "";
         
        }
        private void addItembtn_Click(object sender, EventArgs e)
        {
            string newtoList = toAddItem.Text.ToString();
            _CheckBoxList.Items.Add(newtoList);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            string checkedItems = ""; 
            int count = _CheckBoxList.CheckedItems.Count;
            for (int i = 0; i < count; i++)
            {
                checkedItems += "" + _CheckBoxList.CheckedItems[i].ToString() + "\n";
            }
            _Output.Text = checkedItems;
        }
    }
}
