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

namespace HallBooking_WinForm.Forms.Booking
{
    public partial class CreateBooking : Form
    {
        string time = "";
        public int bookingId;
        bool isExist;
        private readonly BookingService bookingService = new BookingService();
        m.Booking _booking = new m.Booking();
        BookingForm bookingForm;
        public CreateBooking()
        {
            InitializeComponent();
            bookingId = 0;
            dateTimePicker1.Value = DateTime.Today;
            updateButton.Enabled = false;
        }
        public CreateBooking(DateTime date)
        {
            InitializeComponent();
            bookingId = 0;
            dateTimePicker1.Value = date;
            updateButton.Enabled = false;
            clear();
        }

        public CreateBooking(m.Booking booking)
        {

            InitializeComponent();
            bookingId = booking.Id;
            ShowBookingDetails(booking);
            

        }
        public CreateBooking(BookingForm bookingForm)
        {

            InitializeComponent();
            this.bookingForm = bookingForm;
        }
        private void ShowBookingDetails(m.Booking _booking)
        {
            bookingId = _booking.Id;
            var item = bookingService.GetById(bookingId);
            purposeComboBox.Text = item.Purpose;
            saveButton.Enabled = false;
            if (item.Time == "Day")
            {
                dayRadioButton.Checked = true;
                nightRadioButton.Enabled = false;
               
                
            }
            else
            {
                nightRadioButton.Checked = true;
                dayRadioButton.Enabled = false;
               
            }
            dateTimePicker1.Value = item.BookingDate;
            dateTimePicker1.Enabled = false;
            totalTextBox.Text = item.TotalAmount.ToString();
            paidTextBox.Text = item.PaidAmount.ToString();
            dueTextBox.Text = item.DueAmount.ToString();
            nametextBox.Text = item.CustomerName.ToString();
            phonetextBox.Text = item.CustomerPhone.ToString();
            emailtextBox.Text = item.CustomerEmail;

        }
        private void Booking_Load(object sender, EventArgs e)
        {
            
            if (bookingId == 0)
            {
                deleteButton.Visible = false;

            }

        }
        public void clear()
        {
            purposeComboBox.Text = "--select Purpose--";
            purposeComboBox.SelectedItem = null;
            totalTextBox.Clear();
            paidTextBox.Clear();
            dueTextBox.Clear();
            emailtextBox.Clear();
            nametextBox.Clear();
            phonetextBox.Clear();
            nightRadioButton.Checked = false;
            dayRadioButton.Checked = false;

        }



        private void saveButton_Click(object sender, EventArgs e)
        {
          
                if (bookingId == 0)
                {
                if (!GetValuesFromForm()) return;
                        isExist = BookingExit(_booking.BookingDate, _booking.Time);
                }
               
                if (isExist != true)
                {
                bookingService.Insert(_booking);
                MessageBox.Show("Success!");
                this.Close();

                }
                else
                {
                MessageBox.Show("This Date & Time is Already Booked");

                }




            }
        
        private bool GetValuesFromForm()
        {

            if (dayRadioButton.Checked)
            {
                time = dayRadioButton.Text;
            }

             else if (nightRadioButton.Checked)
            {
                time = nightRadioButton.Text;
            }
            else
            {
                MessageBox.Show("Please Select A Time For Booking");
                return false;
            }
            if(purposeComboBox.SelectedItem== null)
            {
                MessageBox.Show("Please Select A Purpose For Booking");
                return false;
            }
            
            if (!decimal.TryParse(totalTextBox.Text, out var x))
            {
                MessageBox.Show("Please Give A valid Number Value in Totalamount Field");
                return false;
            }
            if (!decimal.TryParse(paidTextBox.Text, out var y))
            {
                MessageBox.Show("Please Give A valid Number Value in Paidamount Field");
                return false;
            }
            if (!decimal.TryParse(dueTextBox.Text, out var z))
            {
                MessageBox.Show("Fields are not in correct format");
                return false;
            }
            if (String.IsNullOrEmpty(nametextBox.Text) || string.IsNullOrEmpty(phonetextBox.Text))
            {
                MessageBox.Show("Please Fill Up the customer Information");
                return false;
            }
            _booking.CustomerEmail = emailtextBox.Text.Trim();
            _booking.CustomerName = nametextBox.Text.Trim();
            _booking.CustomerPhone = phonetextBox.Text.Trim();
            _booking.BookingDate = dateTimePicker1.Value;
            _booking.Time = time;
            _booking.Purpose = purposeComboBox.SelectedItem.ToString();
            _booking.TotalAmount = decimal.Parse(totalTextBox.Text.Trim());
            _booking.PaidAmount = decimal.Parse(paidTextBox.Text.Trim());
            _booking.DueAmount =decimal.Parse(dueTextBox.Text.Trim());
            _booking.Status = "Pending";
            _booking.Id = bookingId;

            return true;
        }
        private void paidTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!decimal.TryParse(totalTextBox.Text, out var x))
            {
                MessageBox.Show("Please Give A valid Number Value in Totalamount Field");
                return;
            }
            if (!decimal.TryParse(paidTextBox.Text, out var y))
            {
                MessageBox.Show("Please Give A valid Number Value in Paidamount Field");
                return ;
            }
            decimal total = decimal.Parse(totalTextBox.Text);
            decimal paid = decimal.Parse(paidTextBox.Text);
            decimal due = total - paid;
            if (due < 0)
            {
                dueTextBox.Text = "0";

            }
            else
            {
                dueTextBox.Text = due.ToString();

            }


        }


        private void totalTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!decimal.TryParse(totalTextBox.Text, out var x))
            {
                MessageBox.Show("Please Give A valid Number Value in Totalamount Field");
                return;
            }
            if (paidTextBox.Text != "")
            {
                if (!decimal.TryParse(paidTextBox.Text, out var y))
                {
                    MessageBox.Show("Please Give A valid Number Value in Paidamount Field");
                    return;
                }
                decimal total = decimal.Parse(totalTextBox.Text);
                decimal paid = decimal.Parse(paidTextBox.Text);
                decimal due = total - paid;
                dueTextBox.Text = due.ToString();

            }


        }


        private void deleteButton_Click(object sender, EventArgs e)
        {


            var _booking = bookingService.GetById(bookingId);
            if (_booking != null)
            {
                _booking.Status = "Canceled";
                bookingService.Update(_booking);
            }

            MessageBox.Show("Successfully Deleted");
            this.Close();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        public bool BookingExit(DateTime dateTime, string time)
        {
            var result = bookingService.GetAll().Where(f => f.BookingDate == dateTime && f.Time == time).FirstOrDefault();

            if (result != null)
            {
                return true;
            }
            else
                return false;
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            try
            {
                if(!GetValuesFromForm()) return;
                var item = bookingService.GetById(_booking.Id);
                item.Purpose = _booking.Purpose;
                item.TotalAmount = _booking.TotalAmount;
                item.PaidAmount = _booking.PaidAmount;
                item.DueAmount = _booking.DueAmount;
                item.CustomerName = _booking.CustomerName;
                item.CustomerPhone = _booking.CustomerPhone;
                item.CustomerEmail = _booking.CustomerEmail;
                if (item.PaidAmount >= item.TotalAmount)
                {
                    item.Status = "Completed";
                }
                bookingService.Update(item);
                MessageBox.Show("Successfully Done!");
                if (bookingForm != null) { bookingForm.LoadRecords(); }
                
                this.Close();
            }
            catch
            {
                MessageBox.Show("Something Went Wrong!Please Contact the Administration");
            }
        }

        private void purposeComboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
    }

