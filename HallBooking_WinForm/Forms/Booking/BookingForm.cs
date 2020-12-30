using BusinessLayer_HallBooking.Services;
using HallBooking_WinForm.Forms.Booking;
using HallBooking_WinForm.Forms.Manager;
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
    public partial class BookingForm : Form
    {
        private readonly BookingService bookingService = new BookingService();
       
        public BookingForm()
        {
            InitializeComponent();
        }
        public void LoadRecords()
        {
            bookingDataGridView.Rows.Clear();
            int i = 0;
            List<m.Booking> items = bookingService.GetAll();
           
            foreach (var item in items)
            {
                i += 1;
                bookingDataGridView.Rows.Add(i, item.Id, item.BookingDate.ToShortDateString(), item.Time, item.Purpose, item.Status, item.CustomerName, item.CustomerPhone, item.CustomerEmail,item.TotalAmount,item.PaidAmount,item.DueAmount);
            }

        }

        private void BookingForm_Load(object sender, EventArgs e)
        {
            LoadRecords();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            CreateBooking createProductForm = new CreateBooking();
            createProductForm.ShowDialog();
        }

        private void bookingDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int indexRow = e.RowIndex;
            if (indexRow < 0)
            {
                return;
            }
          
            int id = Convert.ToInt32(bookingDataGridView.Rows[e.RowIndex].Cells[1].Value);
            string colName = bookingDataGridView.Columns[e.ColumnIndex].Name;
            var item = bookingService.GetById(id);
            if (colName == "Edit")
            {
                CreateBooking createexpense = new CreateBooking(this);
                createexpense.bookingId= int.Parse(bookingDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString());//id
                createexpense.dateTimePicker1.Value =DateTime.Parse(bookingDataGridView.Rows[e.RowIndex].Cells[2].Value.ToString());//title
                var time=bookingDataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();//description
                if (time == "Day") createexpense.dayRadioButton.Checked = true;
                else if(time=="Night") createexpense.nightRadioButton.Checked = true;
                createexpense.purposeComboBox.Text = bookingDataGridView.Rows[e.RowIndex].Cells[4].Value.ToString();//amount
                createexpense.nametextBox.Text = bookingDataGridView.Rows[e.RowIndex].Cells[6].Value.ToString();//date
                createexpense.phonetextBox.Text = bookingDataGridView.Rows[e.RowIndex].Cells[7].Value.ToString();//date
                createexpense.emailtextBox.Text = bookingDataGridView.Rows[e.RowIndex].Cells[8].Value.ToString();//date
                createexpense.totalTextBox.Text = bookingDataGridView.Rows[e.RowIndex].Cells[9].Value.ToString();//date
                createexpense.paidTextBox.Text = bookingDataGridView.Rows[e.RowIndex].Cells[10].Value.ToString();//date
                createexpense.dueTextBox.Text = bookingDataGridView.Rows[e.RowIndex].Cells[11].Value.ToString();//date

                createexpense.saveButton.Enabled = false;
                createexpense.ShowDialog();
            }
            if (colName == "Delete")
            {
                try
                {
                    var response = MessageBox.Show("Are You Sure?", "Confirm", MessageBoxButtons.YesNo);
                    if (response == DialogResult.Yes)
                    {

                        item.Status = "Canceled";
                        bookingService.Update(item);
                        MessageBox.Show("Successfully Done!");
                        LoadRecords();
                    }
                }

                catch
                {
                    MessageBox.Show("Something Went Wrong!Please Contact the Administration");
                }
            }
            if (colName == "Print")
            {
                try
                {
                    var _id=int.Parse(bookingDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString());
                    PrintPreview receiptForm = new PrintPreview();
                    receiptForm.LoadInvoice(_id);
                    receiptForm.ShowDialog();
                 
                }

                catch
                {
                    MessageBox.Show("Something Went Wrong!Please Contact the Administration");
                }
            }
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            bookingDataGridView.Rows.Clear();
            int i = 0;
            List<m.Booking> items = bookingService.GetAll().Where(x => x.BookingDate > fromTimePicker.Value.AddDays(-1) && x.BookingDate < TodateTimePicker.Value.AddDays(1)).ToList();

            foreach (var item in items)
            {
                i += 1;
                bookingDataGridView.Rows.Add(i, item.Id, item.BookingDate.ToShortDateString(), item.Time, item.Purpose, item.Status, item.CustomerName, item.CustomerPhone, item.CustomerEmail, item.TotalAmount, item.PaidAmount, item.DueAmount);
            }

        }

     

        private void printLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PrintPreview form = new PrintPreview();
            form.LoadBookings(fromTimePicker.Value.AddDays(-1), TodateTimePicker.Value.AddDays(1)); ;
            form.ShowDialog();
        }

        private void TodateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void fromTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadRecords();
        }
    }
}
