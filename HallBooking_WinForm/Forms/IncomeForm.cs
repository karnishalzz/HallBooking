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

namespace HallBooking_WinForm.Forms
{
    public partial class IncomeForm : Form
    {
        private readonly BookingService bookingService = new BookingService();
        public IncomeForm()
        {
            InitializeComponent();
        }

        private void IncomeForm_Load(object sender, EventArgs e)
        {
            LoadRecords();
        }
        public void LoadRecords()
        {
            incomeDataGridView.Rows.Clear();
            int i = 0;
            decimal total = 0;
            List<m.Booking> items = bookingService.GetAll().Where(x => x.Status == "Completed").ToList();
            if (items != null)
            {
                foreach (var item in items)
                {
                    i += 1;
                    total += (decimal)item.PaidAmount;
                    incomeDataGridView.Rows.Add(i, item.Id, item.BookingDate.ToShortDateString() + "," + item.Time, item.Purpose, item.TotalAmount, item.PaidAmount);
                }
            }
            totallabel.Text = total.ToString();
           

        }

        private void incomeDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int indexRow = e.RowIndex;
            if (indexRow < 0)
            {
                return;
            }
        }
    }
}
