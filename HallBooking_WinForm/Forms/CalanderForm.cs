using BusinessLayer_HallBooking.Services;
using HallBooking_Model;
using HallBooking_WinForm.Forms.Booking;
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
    public partial class CalanderForm : Form
    {
        List<TableLayoutPanel> listOfDay = new List<TableLayoutPanel>();
        DateTime currentDate = DateTime.Today;
        private readonly BookingService bookingService = new BookingService();
        public CalanderForm()
        {
            InitializeComponent();
        }
        private void CalandarView_Load(object sender, EventArgs e)
        {
            GeneratePanel(40);
            DisplayCurrentDate();
        }
        public void GeneratePanel(int total)
        {
            flowLayoutPanel3.Controls.Clear();

            listOfDay.Clear();
            for (int i = 0; i <= (total - 1); i++)
            {


                TableLayoutPanel f1 = new TableLayoutPanel();
                f1.Name = $"Day{i}";
                f1.Size = new Size(116, 60);
                f1.BackColor = Color.Transparent;
                f1.BorderStyle = BorderStyle.None;
                f1.RowCount = 3;
                f1.ColumnCount = 1;
                f1.Cursor = Cursors.Hand;
                f1.Click += new EventHandler(AddNewAppointment);
                f1.RowStyles.Add(new RowStyle(SizeType.Percent, 33));
                f1.RowStyles.Add(new RowStyle(SizeType.Percent, 33));
                f1.RowStyles.Add(new RowStyle(SizeType.Percent, 33));



                f1.CellBorderStyle = TableLayoutPanelCellBorderStyle.Outset;
                flowLayoutPanel3.Controls.Add(f1);
                listOfDay.Add(f1);
            }

        }
        public void AddLabelDay(int start, int end)
        {
            foreach (var i in listOfDay)
            {
                i.Controls.Clear();
                i.Tag = 0;
            }

            for (int i = 1; i <= end; i++)
            {
                Label l1 = new Label();
                l1.Name = $"labelDay{i}";
                l1.AutoSize = false;
                l1.TextAlign = ContentAlignment.MiddleRight;
                l1.Size = new Size(116, 60);
                l1.Font = new Font("Microsoft Sans Serif", 8.75F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
                l1.Text = i.ToString();

                int index = ((i - 1) + (start - 1) + 1);

                listOfDay[index].Tag = i;

                listOfDay[index].Controls.Add(l1);

            }




        }
        public void DisplayCurrentDate()
        {

            monthYearLabel.Text = currentDate.ToString("MMMM,yyyy");
            AddLabelDay(GetFirstDayOfWeekOfCurrentDate(), GetTotalDaysOfCurrentMonth());
            AddBookingOfDay(GetFirstDayOfWeekOfCurrentDate());
        }
        public void PrevMonth()
        {

            currentDate = currentDate.AddMonths(-1);
            DisplayCurrentDate();
        }
        public void NextMonth()
        {

            currentDate = currentDate.AddMonths(1);
            DisplayCurrentDate();
        }
        public void Today()
        {
            currentDate = DateTime.Today;
            DisplayCurrentDate();
        }
        private int GetTotalDaysOfCurrentMonth()
        {
            DateTime firstDate = new DateTime(currentDate.Year, currentDate.Month, 1);
            return firstDate.AddMonths(1).AddDays(-1).Day;
        }
        private int GetFirstDayOfWeekOfCurrentDate()
        {
            DateTime firstDayOfMonth = new DateTime(currentDate.Year, currentDate.Month, 1);
            return Convert.ToInt32(firstDayOfMonth.DayOfWeek) + 1;
        }
        private void AddBookingOfDay(int startDayOfMonth)
        {
            DateTime startDate = new DateTime(currentDate.Year, currentDate.Month, 1);
            DateTime endDate = startDate.AddMonths(1).AddDays(-1);
            var start = startDate.Date.AddDays(-1);
            var end = endDate.Date.AddDays(1);

            var query = bookingService.GetAll();
                query=query
                .Where(x => x.Status == "Pending")
                .Where(x => x.BookingDate >= start && x.BookingDate <= end)
                .ToList();
                
                foreach (var i in query)
                {
                    int x = 1;
                    DateTime appDay = i.BookingDate;
                    LinkLabel link = new LinkLabel();
                    link.Name = $"linkId{x}";
                    link.Text = i.Time;
                    link.Tag = i.Id;
                    link.LinkColor = Color.White;
                    link.LinkBehavior = LinkBehavior.NeverUnderline;
                    link.Dock = DockStyle.Fill;
                    link.TextAlign = ContentAlignment.MiddleCenter;
                    var index = ((appDay.Day) + (startDayOfMonth - 1));
                    link.Click += new EventHandler(ShowAppointmentDetail);
                    if (i.Time == "Day")
                    {
                        link.Text = "Day";
                        listOfDay[index].Controls.Add(link, 0, 1);
                        //listOfDay[index].GetControlFromPosition(0, 1).Text = "Day";
                        listOfDay[index].GetControlFromPosition(0, 1).BackColor = Color.MediumTurquoise;
                        listOfDay[index].Controls.Add(link, 0, 1);
                    }
                    else
                    {
                        link.Text = "Night";
                        listOfDay[index].Controls.Add(link, 0, 2);

                        listOfDay[index].GetControlFromPosition(0, 2).BackColor = Color.MediumTurquoise;
                        //listOfDay[index].Controls.Add(link, 0, 2);
                    }

                    // bookingList.Add(i);
                    x += 1;
                }

            }
        
        private void previousMonthButton_Click(object sender, EventArgs e)
        {
            PrevMonth();
        }

        private void nextMonthButton_Click(object sender, EventArgs e)
        {
            NextMonth();
        }

        private void TodayButton_Click(object sender, EventArgs e)
        {
            Today();
        }
        private void AddNewAppointment(object sender, EventArgs e)
        {
            int day = Convert.ToInt32(((Control)sender).Tag);


            if (day != 0)
            {

                DateTime dateTime = new DateTime(currentDate.Year, currentDate.Month, day);

                CreateBooking createBooking = new CreateBooking(dateTime);
                createBooking.ShowDialog();
                DisplayCurrentDate();

            }

        }
        private void ShowAppointmentDetail(object sender, EventArgs e)
        {
            int appId = Convert.ToInt32(((LinkLabel)sender).Tag);

            m.Booking result = bookingService.GetById(appId); 
            CreateBooking createBooking = new CreateBooking(result);
             createBooking.ShowDialog();
             DisplayCurrentDate();


            }
        }
    }

