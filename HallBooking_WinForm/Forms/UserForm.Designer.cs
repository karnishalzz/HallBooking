namespace HallBooking_WinForm.Forms
{
    partial class UserForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel3 = new System.Windows.Forms.Panel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.userTabControl = new MetroFramework.Controls.MetroTabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.cancelPassChangeButton = new System.Windows.Forms.Button();
            this.savePassChhangebutton = new System.Windows.Forms.Button();
            this.retypetextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.newtextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.oldtextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.usertextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.userTabControl.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.metroLabel1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(874, 32);
            this.panel3.TabIndex = 7;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(3, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(148, 25);
            this.metroLabel1.TabIndex = 7;
            this.metroLabel1.Text = "User Managment";
            this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // userTabControl
            // 
            this.userTabControl.Controls.Add(this.tabPage2);
            this.userTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userTabControl.Location = new System.Drawing.Point(0, 32);
            this.userTabControl.Name = "userTabControl";
            this.userTabControl.SelectedIndex = 0;
            this.userTabControl.Size = new System.Drawing.Size(874, 555);
            this.userTabControl.TabIndex = 8;
            this.userTabControl.UseSelectable = true;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.Controls.Add(this.cancelPassChangeButton);
            this.tabPage2.Controls.Add(this.savePassChhangebutton);
            this.tabPage2.Controls.Add(this.retypetextBox);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.newtextBox);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.oldtextBox);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.usertextBox);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 38);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(866, 513);
            this.tabPage2.TabIndex = 4;
            this.tabPage2.Text = "Change Password";
            // 
            // cancelPassChangeButton
            // 
            this.cancelPassChangeButton.BackColor = System.Drawing.Color.DimGray;
            this.cancelPassChangeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cancelPassChangeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelPassChangeButton.FlatAppearance.BorderSize = 0;
            this.cancelPassChangeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelPassChangeButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelPassChangeButton.ForeColor = System.Drawing.Color.White;
            this.cancelPassChangeButton.Location = new System.Drawing.Point(533, 247);
            this.cancelPassChangeButton.Name = "cancelPassChangeButton";
            this.cancelPassChangeButton.Size = new System.Drawing.Size(115, 33);
            this.cancelPassChangeButton.TabIndex = 31;
            this.cancelPassChangeButton.Text = "Cancel";
            this.cancelPassChangeButton.UseVisualStyleBackColor = false;
            this.cancelPassChangeButton.Click += new System.EventHandler(this.cancelPassChangeButton_Click);
            // 
            // savePassChhangebutton
            // 
            this.savePassChhangebutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.savePassChhangebutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.savePassChhangebutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.savePassChhangebutton.FlatAppearance.BorderSize = 0;
            this.savePassChhangebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.savePassChhangebutton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.savePassChhangebutton.ForeColor = System.Drawing.Color.White;
            this.savePassChhangebutton.Location = new System.Drawing.Point(407, 247);
            this.savePassChhangebutton.Name = "savePassChhangebutton";
            this.savePassChhangebutton.Size = new System.Drawing.Size(120, 33);
            this.savePassChhangebutton.TabIndex = 30;
            this.savePassChhangebutton.Text = "Save";
            this.savePassChhangebutton.UseVisualStyleBackColor = false;
            this.savePassChhangebutton.Click += new System.EventHandler(this.savePassChhangebutton_Click);
            // 
            // retypetextBox
            // 
            this.retypetextBox.Location = new System.Drawing.Point(184, 199);
            this.retypetextBox.Name = "retypetextBox";
            this.retypetextBox.PasswordChar = '*';
            this.retypetextBox.Size = new System.Drawing.Size(463, 25);
            this.retypetextBox.TabIndex = 29;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(63, 202);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(115, 17);
            this.label9.TabIndex = 28;
            this.label9.Text = "Re-Type Password";
            // 
            // newtextBox
            // 
            this.newtextBox.Location = new System.Drawing.Point(184, 158);
            this.newtextBox.Name = "newtextBox";
            this.newtextBox.PasswordChar = '*';
            this.newtextBox.Size = new System.Drawing.Size(463, 25);
            this.newtextBox.TabIndex = 27;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(63, 161);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 17);
            this.label6.TabIndex = 26;
            this.label6.Text = "New Password";
            // 
            // oldtextBox
            // 
            this.oldtextBox.Location = new System.Drawing.Point(184, 117);
            this.oldtextBox.Name = "oldtextBox";
            this.oldtextBox.PasswordChar = '*';
            this.oldtextBox.Size = new System.Drawing.Size(463, 25);
            this.oldtextBox.TabIndex = 25;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(63, 115);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 17);
            this.label7.TabIndex = 24;
            this.label7.Text = "Old Password";
            // 
            // usertextBox
            // 
            this.usertextBox.Location = new System.Drawing.Point(184, 73);
            this.usertextBox.Name = "usertextBox";
            this.usertextBox.ReadOnly = true;
            this.usertextBox.Size = new System.Drawing.Size(463, 25);
            this.usertextBox.TabIndex = 23;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(63, 76);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 17);
            this.label8.TabIndex = 22;
            this.label8.Text = "Username";
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(874, 587);
            this.ControlBox = false;
            this.Controls.Add(this.userTabControl);
            this.Controls.Add(this.panel3);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "UserForm";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.userTabControl.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTabControl userTabControl;
        private System.Windows.Forms.TabPage tabPage2;
        public System.Windows.Forms.Button cancelPassChangeButton;
        public System.Windows.Forms.Button savePassChhangebutton;
        private System.Windows.Forms.TextBox retypetextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox newtextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox oldtextBox;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox usertextBox;
        private System.Windows.Forms.Label label8;
    }
}