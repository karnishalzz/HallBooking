using BusinessLayer_HallBooking.Services;
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
    public partial class ManagerForm : Form
    {
        private readonly ManagerService managerService = new ManagerService();
        public ManagerForm()
        {
            InitializeComponent();
        }
        public void LoadRecords()
        {
            managerDataGridView.Rows.Clear();
            int i = 0;
            List<m.Manager> items = managerService.GetAll();
            foreach (var item in items)
            {
                i += 1;
                managerDataGridView.Rows.Add(i, item.Id, item.Name, item.Phone, item.JoiningDate, item.Email, item.Username, item.Role,item.IsActive);
            }

        }
        private void addButton_Click(object sender, EventArgs e)
        {
            CreateManager createProductForm = new CreateManager(this);
            createProductForm.updateButton.Enabled = false;
            createProductForm.ShowDialog();
        }

        private void ManagerForm_Load(object sender, EventArgs e)
        {
            LoadRecords();


        }

        private void managerDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int indexRow = e.RowIndex;
            if (indexRow < 0)
            {
                return;
            }
            int id = Convert.ToInt32(managerDataGridView.Rows[e.RowIndex].Cells[1].Value);
            string colName = managerDataGridView.Columns[e.ColumnIndex].Name;
            var manager = managerService.GetById(id);
            if (colName == "Edit")
            {
                CreateManager createManager = new CreateManager(this);
                createManager.idLabel.Text = managerDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();//id
                createManager.nameTextBox.Text = managerDataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();//name
                createManager.phoneTextBox.Text = managerDataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();//phone
                createManager.emailtextBox.Text = managerDataGridView.Rows[e.RowIndex].Cells[5].Value.ToString();//email
                createManager.usernameTextBox.Text = managerDataGridView.Rows[e.RowIndex].Cells[6].Value.ToString();//username
                createManager.roleComboBox.Text = managerDataGridView.Rows[e.RowIndex].Cells[7].Value.ToString();//role
                createManager.activeCheckBox.Checked =(bool)(managerDataGridView.Rows[e.RowIndex].Cells[7].Value);//role
                createManager.passwordtextBox.ReadOnly = true;
            
                createManager.saveButton.Enabled = false;
                createManager.cancelButton.Enabled = false;
                createManager.ShowDialog();
            }
            if (colName == "Delete")
            {
                try
                {
                    var response = MessageBox.Show("Are You Sure?", "Confirm", MessageBoxButtons.YesNo);
                    if (response == DialogResult.Yes)
                    {

                        managerService.Delete(manager);
                        MessageBox.Show("Successfully Done!");
                        LoadRecords();
                    }
                }

                catch
                {
                    MessageBox.Show("Something Went Wrong!Please Contact the Administration");
                }
            }
        }

        private void printLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PrintPreview form = new PrintPreview();
            form.LoadManager(); 
            form.ShowDialog();
        }

        private void loadButton_Click(object sender, EventArgs e)
        {

        }

        private void TodateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void fromTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        //private void searchTextBox_TextChanged(object sender, EventArgs e)
        //{
        //    managerDataGridView.Rows.Clear();
        //    int i = 0;
        //    List<m.Manager> products = managerService.GetProductBySearch(searchTextBox.Text);
        //    foreach (var product in products)
        //    {
        //        i += 1;
        //        productListDataGridView.Rows.Add(i, product.Id.ToString(), product.Code, product.Name, product.Barcode, product.Description, product.Price, product.Quantity, product.category.Name, product.brand.Name);
        //    }
        //}
    }
}
