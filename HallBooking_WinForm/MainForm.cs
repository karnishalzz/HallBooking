using HallBooking_WinForm.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HallBooking_WinForm
{
    public partial class MainForm : Form
    {
        LoginForm LoginForm;
        public MainForm(LoginForm loginForm)
        {
            InitializeComponent();
            this.LoginForm = loginForm;
        }

       
        private void calanderButton_Click(object sender, EventArgs e)
        {
            containerPanel.Controls.Clear();
            CalanderForm form = new CalanderForm();
            form.TopLevel = false;
            containerPanel.Controls.Add(form);
            form.BringToFront();
            form.Show();
        }

        private void bookingsButton_Click(object sender, EventArgs e)
        {
            containerPanel.Controls.Clear();
            BookingForm form = new BookingForm();
            form.TopLevel = false;
            containerPanel.Controls.Add(form);
            form.BringToFront();
            form.Show();
        }

        private void expenseButton_Click(object sender, EventArgs e)
        {
            containerPanel.Controls.Clear();
            ExpenseForm form = new ExpenseForm();
            form.TopLevel = false;
            containerPanel.Controls.Add(form);
            form.BringToFront();
            form.Show();

        }

        private void incomeButton_Click(object sender, EventArgs e)
        {
            containerPanel.Controls.Clear();
            IncomeForm form = new IncomeForm();
            form.TopLevel = false;
            containerPanel.Controls.Add(form);
            form.BringToFront();
            form.Show();
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {

            StoreForm form = new StoreForm();
            form.BringToFront();
            form.Show();
        }

        private void userButton_Click(object sender, EventArgs e)
        {

            containerPanel.Controls.Clear();
            UserForm form = new UserForm(this);
            form.TopLevel = false;
            containerPanel.Controls.Add(form);
            form.usertextBox.Text = userlabel.Text;
            form.BringToFront();
            form.Show();
        }

        private void managerButton_Click(object sender, EventArgs e)
        {
            containerPanel.Controls.Clear();
            ManagerForm form = new ManagerForm();
            form.TopLevel = false;
            containerPanel.Controls.Add(form);
            form.BringToFront();
            form.Show();
        }

        private void reportsButton_Click(object sender, EventArgs e)
        {

        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            var response = MessageBox.Show("Are You Sure?", "Confirm", MessageBoxButtons.YesNo);
            if (response == DialogResult.Yes)
            {

                
                this.Close();
              
                LoginForm.Show();
            }
        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            containerPanel.Controls.Clear();
            CalanderForm form = new CalanderForm();
            form.TopLevel = false;
            containerPanel.Controls.Add(form);
            form.BringToFront();
            form.Show();
        }

        private void backupbutton_Click(object sender, EventArgs e)
        {
            BackupForm backupForm = new BackupForm();
            backupForm.BringToFront();
            backupForm.ShowDialog();
        }

        private void iconPictureBox4_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;

                this.MinimumSize = new Size(1140, 650);
                this.MaximumSize = new Size(1140, 650);

                this.StartPosition = FormStartPosition.CenterScreen;

            }
            else
            {
                this.MaximumSize = new Size(0, 0);
                this.MinimumSize = new Size(0, 0);
                this.WindowState = FormWindowState.Maximized;
                this.MinimumSize = this.Size;
                this.MaximumSize = this.Size;
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("LOGOUT From Application?", "LOGOUT", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
                this.LoginForm.Show();
            }
        }

        private void restorebutton_Click(object sender, EventArgs e)
        {
            RestoreForm backupForm = new RestoreForm();
            backupForm.BringToFront();
            backupForm.ShowDialog();

        }
        int mouseX, mouseY;
        bool mouseM;
      

        private void MainForm_MouseMove(object sender, MouseEventArgs e)
        {
            mouseM = false;
        }

        private void panel3_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseM)
            {
                SetDesktopLocation(MousePosition.X - mouseX, MousePosition.Y - mouseY);
            }
        }

        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            mouseX = e.X;
            mouseY = e.Y;
            mouseM = true;

        }

    }
}