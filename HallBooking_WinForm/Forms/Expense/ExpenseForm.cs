using BusinessLayer_HallBooking.Services;
using HallBooking_WinForm.Forms.Expense;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using m=HallBooking_Model;

namespace HallBooking_WinForm.Forms
{
    public partial class ExpenseForm : Form
    {
        private readonly ExpenseService expenseService = new ExpenseService();
        public ExpenseForm()
        {
            InitializeComponent();
            LoadRecords();
        }
        public void LoadRecords()
        {
            expenseDataGridView.Rows.Clear();
            int i = 0;
            List<m.Expense> items = expenseService.GetAll();
            foreach (var item in items)
            {
                i += 1;
                expenseDataGridView.Rows.Add(i, item.Id, item.Title, item.Description,item.Amount,item.Date);
            }

        }
        private void addButton_Click(object sender, EventArgs e)
        {
            Createexpense form = new Createexpense(this);
            form.updateButton.Enabled = false;
            form.ShowDialog();
        }

        private void ExpenseForm_Load(object sender, EventArgs e)
        {
            LoadRecords();


        }

        private void expenseDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int indexRow = e.RowIndex;
            if (indexRow < 0)
            {
                return;
            }
            int id = Convert.ToInt32(expenseDataGridView.Rows[e.RowIndex].Cells[1].Value);
            string colName = expenseDataGridView.Columns[e.ColumnIndex].Name;
            var item = expenseService.GetById(id);
            if (colName == "Edit")
            {
                Createexpense createexpense = new Createexpense(this);
                createexpense.idLabel.Text = expenseDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();//id
                createexpense.titleTextBox.Text = expenseDataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();//title
                createexpense.descriptionTextBox.Text = expenseDataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();//description
                createexpense.amountTextBox.Text = expenseDataGridView.Rows[e.RowIndex].Cells[4].Value.ToString();//amount
                createexpense.expenseDateTimePicker.Value=DateTime.Parse(expenseDataGridView.Rows[e.RowIndex].Cells[5].Value.ToString());//date

                createexpense.saveButton.Enabled = false;
                createexpense.cancelButton.Enabled = false;
                createexpense.ShowDialog();
            }
            if (colName == "Delete")
            {
                try
                {
                    var response = MessageBox.Show("Are You Sure?", "Confirm", MessageBoxButtons.YesNo);
                    if (response == DialogResult.Yes)
                    {

                        expenseService.Delete(item);
                        MessageBox.Show("Successfully Done!");
                        LoadRecords();
                    }
                }

                catch
                {
                    MessageBox.Show("Something Went Wrong!Please Contact the Administration");
                }
            }
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            expenseDataGridView.Rows.Clear();
            int i = 0;
            List<m.Expense> items = expenseService.GetAll().Where(x=>x.Date>fromTimePicker.Value.AddDays(-1)&& x.Date<TodateTimePicker.Value.AddDays(1)).ToList();
            foreach (var item in items)
            {
                i += 1;
                expenseDataGridView.Rows.Add(i, item.Id, item.Title, item.Description, item.Amount, item.Date);
            }

        }

        private void printLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PrintPreview form = new PrintPreview();
            form.LoadExpense(fromTimePicker.Value.AddDays(-1), TodateTimePicker.Value.AddDays(1)); ;
            form.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadRecords();
        }
    }
}
