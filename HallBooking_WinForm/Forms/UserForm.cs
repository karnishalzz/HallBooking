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
using u=HallBooking_Model;

namespace HallBooking_WinForm.Forms
{
    public partial class UserForm : Form
    {
        private readonly ManagerService managerService = new ManagerService();
        MainForm form;
        public UserForm(MainForm mainForm)
        {
            InitializeComponent();
            form = mainForm;
        }

        private void savePassChhangebutton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(oldtextBox.Text) || string.IsNullOrEmpty(newtextBox.Text) || string.IsNullOrEmpty(retypetextBox.Text))
            {
                MessageBox.Show("Please Fill Up All the Information");
                return;
            }
            try
            {
                var user = managerService.GetUser(usertextBox.Text);
                if (user.Password != oldtextBox.Text)
                {
                    MessageBox.Show("Old Password Is Incorrect.Please Try Again.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                if (newtextBox.Text != retypetextBox.Text)
                {
                    MessageBox.Show("The new password didnot match the retyped password", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                user.Password = newtextBox.Text.ToString();
                managerService.Update(user);
                MessageBox.Show("Password Successfully Updated", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                oldtextBox.Clear();
                newtextBox.Clear();
                retypetextBox.Clear();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void cancelPassChangeButton_Click(object sender, EventArgs e)
        {
            oldtextBox.Clear();
            newtextBox.Clear();
            retypetextBox.Clear();
        }


        private void UserForm_Resize(object sender, EventArgs e)
        {

        }
    }
}
