using BusinessLayer_HallBooking.Services;
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

namespace HallBooking_WinForm.Forms.Expense
{
    public partial class Createexpense : Form
    {
        private readonly ExpenseService expenseService = new ExpenseService();
        ExpenseForm expenseForm;
        public Createexpense(ExpenseForm expenseForm)
        {
            InitializeComponent();
            this.expenseForm = expenseForm;
        }
        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
               
                if (String.IsNullOrEmpty(titleTextBox.Text) || string.IsNullOrEmpty(descriptionTextBox.Text))
                {
                    MessageBox.Show("Please Fill Up All the Information");
                    return ;
                }
                if (!decimal.TryParse(amountTextBox.Text, out var z))
                {
                    MessageBox.Show("Not a valid number in amount field");
                    return ;
                }
                var expense = new m.Expense
                {
                   Title=titleTextBox.Text,
                   Amount=decimal.Parse(amountTextBox.Text),
                   Date=expenseDateTimePicker.Value,
                   Description=descriptionTextBox.Text,
               
                };
                expenseService.Insert(expense);
                MessageBox.Show("Successfully Done!");
                expenseForm.LoadRecords();
                clear();
            }
            catch
            {
                MessageBox.Show("Something Went Wrong!Please Contact the Administration");
            }
        }
        private void cancelButton_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(titleTextBox.Text) || string.IsNullOrEmpty(descriptionTextBox.Text))
                {
                    MessageBox.Show("Please Fill Up All the Information");
                    return;
                }
                if (!decimal.TryParse(amountTextBox.Text, out var z))
                {
                    MessageBox.Show("Not a valid number in amount field");
                    return;
                }
                var expense = expenseService.GetById(int.Parse(idLabel.Text));
                expense.Title = titleTextBox.Text;
                expense.Description = descriptionTextBox.Text;
                expense.Amount =decimal.Parse(amountTextBox.Text);
       
                expenseService.Update(expense);
                MessageBox.Show("Successfully Done!");
                expenseForm.LoadRecords();
                this.Close();
            }
            catch
            {
                MessageBox.Show("Something Went Wrong!Please Contact the Administration");
            }
        }

        private void clear()
        {
            titleTextBox.Clear();
            descriptionTextBox.Clear();
            expenseDateTimePicker.Value = DateTime.Now;
            amountTextBox.Clear();
        }
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
