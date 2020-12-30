using BusinessLayer_HallBooking.Services;
using System;
using System.Windows.Forms;
using m = HallBooking_Model;

namespace HallBooking_WinForm.Forms.Manager
{
    public partial class CreateManager : Form
    {
        private readonly ManagerService managerService = new ManagerService();
        ManagerForm managerForm;
        public CreateManager(ManagerForm managerForm)
        {
            InitializeComponent();
            this.managerForm = managerForm;
        }
        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(usernameTextBox.Text) || string.IsNullOrEmpty(passwordtextBox.Text) || string.IsNullOrEmpty(nameTextBox.Text)|| string.IsNullOrEmpty(phoneTextBox.Text))
                {
                    MessageBox.Show("Please Fill Up All the Information");
                    return;
                }
                if (roleComboBox.SelectedItem==null)
                {
                    MessageBox.Show("Please select a role");
                    return;
                }


                var manager = new m.Manager
                {
                    Name = nameTextBox.Text,
                    Username = usernameTextBox.Text,
                    JoiningDate = DateTime.Now.ToShortDateString(),
                    Email = emailtextBox.Text,
                    Password = passwordtextBox.Text,
                    Phone = phoneTextBox.Text,
                    Role = roleComboBox.Text,
                    IsActive = activeCheckBox.Checked,

                };
                managerService.Insert(manager);
                MessageBox.Show("Successfully Done!");
                managerForm.LoadRecords();
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
            if (String.IsNullOrEmpty(usernameTextBox.Text) || string.IsNullOrEmpty(passwordtextBox.Text) || string.IsNullOrEmpty(nameTextBox.Text) || string.IsNullOrEmpty(phoneTextBox.Text))
            {
                MessageBox.Show("Please Fill Up All the Information");
                return;
            }
            if (roleComboBox.SelectedItem == null)
            {
                MessageBox.Show("Please select a role");
                return;
            }
            try
            {
                var manager = managerService.GetById(int.Parse(idLabel.Text));
                manager.Name = nameTextBox.Text;
                manager.Phone = phoneTextBox.Text;
                manager.Role = roleComboBox.Text;
                manager.Username = usernameTextBox.Text;
                manager.Email = emailtextBox.Text;
                manager.IsActive = activeCheckBox.Checked;
                managerService.Update(manager);
                MessageBox.Show("Successfully Done!");
                managerForm.LoadRecords();
                this.Close();
            }
            catch
            {
                MessageBox.Show("Something Went Wrong!Please Contact the Administration");
            }
        }

        private void clear()
        {
           
            nameTextBox.Clear();
            phoneTextBox.Clear();
            emailtextBox.Clear();
            usernameTextBox.Clear();
            passwordtextBox.Clear();
            idLabel.Text = null;
            roleComboBox.SelectedIndex = -1;
            roleComboBox.Text = "--Select Role--";
            roleComboBox.SelectedIndex = -1;
            
        }
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CreateManager_Load(object sender, EventArgs e)
        {

        }

        private void emailtextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void roleComboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
