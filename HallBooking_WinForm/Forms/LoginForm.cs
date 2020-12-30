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

namespace HallBooking_WinForm.Forms
{
    public partial class LoginForm : Form
    {
        private readonly ManagerService userService = new ManagerService();
        public bool _isActive = false;
        LicenseForm licenseForm;
        public LoginForm(LicenseForm license)
        {
            InitializeComponent();
            this.licenseForm = license;
        }
        private void loginButton_Click(object sender, EventArgs e)
        {
            string _username = "", _role = "", _name = "";
            try
            {
                bool found = false;
                var user = userService.GetByUsername(usernameTextBox.Text, passTextBox.Text);
                if (user != null)
                {
                    found = true;
                    _username = user.Username.ToString();
                    _role = user.Role.ToString();
                    _name = user.Name.ToString();
                    _isActive = user.IsActive;
                }
                if (_isActive == false)
                {
                    MessageBox.Show("Account Is Inactive.Unable To Login.", "Access Denied.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (found != false)
                {
                    if (_role == "Manager")
                    {
                        MessageBox.Show("Welcome " + _name + "!", "ACCESS GRANTED", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        passTextBox.Clear();
                        usernameTextBox.Clear();
                        this.Hide();
                        MainForm mainForm = new MainForm(this);
                        mainForm.userlabel.Text = _username;
                        mainForm.rolelabel.Text = _role;
                        mainForm.managerButton.Visible = false;
                     
                        mainForm.settingsButton.Visible = false;
                        mainForm.incomeButton.Visible = false;
                        mainForm.expenseButton.Visible = false;
                        mainForm.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Welcome " + _name + "!", "ACCESS GRANTED", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        passTextBox.Clear();
                        usernameTextBox.Clear();
                        this.Hide();
                        MainForm mainForm = new MainForm(this);
                        
                        mainForm.userlabel.Text = _username;
                        mainForm.rolelabel.Text = _role;
                        mainForm.ShowDialog();
                    }
                }
                else
                {
                    found = false;
                    MessageBox.Show("Wrong Information", "ACCESS DENIED", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit?", "EXIT", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
