using BusinessLayer_HallBooking.Services;
using HallBooking_BusinessLayer.Services;
using Microsoft.Reporting.WinForms;
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
    public partial class PrintPreview : Form
    {
        private string _store = "";
        private string _address = "";
        private readonly StoreService storeService = new StoreService();
        private readonly BookingService bookingService = new BookingService();
        private readonly ExpenseService expenseService = new ExpenseService();
        private readonly ManagerService managerService = new ManagerService();
        public PrintPreview()
        {
            InitializeComponent();
            GetStoreInfo();
        }
        public void GetStoreInfo()
        {
            var store = storeService.GetStore();
            if (store != null)
            {
                _store = store.Name;
                _address = store.Address;
            }
            else
            {
                _store = "Marinoft";
                _address = "10th floor,Karnafuli Tower,Kazir dewri,Chattogram";
            }
        }

        public void LoadBookings(DateTime from, DateTime to)
        {
            ReportDataSource reportDataSource;
            try
            {
                this.reportViewer1.LocalReport.ReportPath = Application.StartupPath + @"\Reports\BookingReport.rdlc";
                this.reportViewer1.LocalReport.DataSources.Clear();
                DataSet dataSet = new DataSet();
                var bookings = bookingService.GetAll().Where(x => x.BookingDate > from && x.BookingDate < to).ToList();

                ReportParameter pFrom = new ReportParameter("pFrom", from.AddDays(1).ToShortDateString());
                ReportParameter pTo = new ReportParameter("pTO", to.AddDays(-1).ToShortDateString());



                reportViewer1.LocalReport.SetParameters(pFrom);
                reportViewer1.LocalReport.SetParameters(pTo);


                reportDataSource = new ReportDataSource("DataSet1", bookings);
                reportViewer1.LocalReport.DataSources.Add(reportDataSource);
                reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
                reportViewer1.ZoomMode = ZoomMode.Percent;
                reportViewer1.ZoomPercent = 100;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void LoadExpense(DateTime from, DateTime to)
        {
            ReportDataSource reportDataSource;
            try
            {
                this.reportViewer1.LocalReport.ReportPath = Application.StartupPath + @"\Reports\ExpenseReport.rdlc";
                this.reportViewer1.LocalReport.DataSources.Clear();
                DataSet dataSet = new DataSet();
                var expenses = expenseService.GetAll().Where(x => x.Date > from && x.Date < to).ToList();

                ReportParameter pFrom = new ReportParameter("pFrom", from.AddDays(1).ToShortDateString());
                ReportParameter pTo = new ReportParameter("pTo", to.AddDays(-1).ToShortDateString());



                reportViewer1.LocalReport.SetParameters(pFrom);
                reportViewer1.LocalReport.SetParameters(pTo);


                reportDataSource = new ReportDataSource("DataSet1", expenses);
                reportViewer1.LocalReport.DataSources.Add(reportDataSource);
                reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
                reportViewer1.ZoomMode = ZoomMode.Percent;
                reportViewer1.ZoomPercent = 100;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void LoadInvoice(int id)
        {
            ReportDataSource reportDataSource;
            try
            {
                this.reportViewer1.LocalReport.ReportPath = Application.StartupPath + @"\Reports\Invoice.rdlc";
                this.reportViewer1.LocalReport.DataSources.Clear();
                DataSet dataSet = new DataSet();
                m.Booking booking = bookingService.GetById(id);
                ReportParameter pStore = new ReportParameter("pStore",_store);
                ReportParameter pAddress = new ReportParameter("pAddress", _address);

                List<m.Booking> bookings = new List<m.Booking>();
                bookings.Add(booking);

                reportViewer1.LocalReport.SetParameters(pStore);
                reportViewer1.LocalReport.SetParameters(pAddress);

                reportDataSource = new ReportDataSource("DataSet1", bookings);
                reportViewer1.LocalReport.DataSources.Add(reportDataSource);
                reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
                reportViewer1.ZoomMode = ZoomMode.Percent;
                reportViewer1.ZoomPercent = 100;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void LoadManager()
        {
            ReportDataSource reportDataSource;
            try
            {
                this.reportViewer1.LocalReport.ReportPath = Application.StartupPath + @"\Reports\ManagerReport.rdlc";
                this.reportViewer1.LocalReport.DataSources.Clear();
                DataSet dataSet = new DataSet();
                var manager = managerService.GetAll();

                reportDataSource = new ReportDataSource("DataSet1", manager);
                reportViewer1.LocalReport.DataSources.Add(reportDataSource);
                reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
                reportViewer1.ZoomMode = ZoomMode.Percent;
                reportViewer1.ZoomPercent = 100;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void ReportForm_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
