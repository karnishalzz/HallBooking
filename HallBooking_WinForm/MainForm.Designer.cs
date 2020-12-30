namespace HallBooking_WinForm
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel3 = new System.Windows.Forms.Panel();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.iconPictureBox4 = new FontAwesome.Sharp.IconPictureBox();
            this.exitButton = new FontAwesome.Sharp.IconPictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.restorebutton = new System.Windows.Forms.Button();
            this.backupbutton = new System.Windows.Forms.Button();
            this.managerButton = new System.Windows.Forms.Button();
            this.userButton = new System.Windows.Forms.Button();
            this.settingsButton = new System.Windows.Forms.Button();
            this.logoutButton = new System.Windows.Forms.Button();
            this.incomeButton = new System.Windows.Forms.Button();
            this.expenseButton = new System.Windows.Forms.Button();
            this.bookingsButton = new System.Windows.Forms.Button();
            this.calanderButton = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.namelabel = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.rolelabel = new System.Windows.Forms.Label();
            this.userlabel = new System.Windows.Forms.Label();
            this.containerPanel = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.iconPictureBox3 = new FontAwesome.Sharp.IconPictureBox();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitButton)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(195)))), ((int)(((byte)(239)))));
            this.panel3.Controls.Add(this.iconPictureBox1);
            this.panel3.Controls.Add(this.iconPictureBox4);
            this.panel3.Controls.Add(this.exitButton);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1140, 22);
            this.panel3.TabIndex = 25;
            this.panel3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseDown);
            this.panel3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseMove);
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.iconPictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.iconPictureBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.iconPictureBox1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 22;
            this.iconPictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.iconPictureBox1.Location = new System.Drawing.Point(1034, 0);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(36, 22);
            this.iconPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconPictureBox1.TabIndex = 27;
            this.iconPictureBox1.TabStop = false;
            // 
            // iconPictureBox4
            // 
            this.iconPictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.iconPictureBox4.Dock = System.Windows.Forms.DockStyle.Right;
            this.iconPictureBox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.iconPictureBox4.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            this.iconPictureBox4.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.iconPictureBox4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox4.IconSize = 22;
            this.iconPictureBox4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.iconPictureBox4.Location = new System.Drawing.Point(1070, 0);
            this.iconPictureBox4.Name = "iconPictureBox4";
            this.iconPictureBox4.Size = new System.Drawing.Size(36, 22);
            this.iconPictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconPictureBox4.TabIndex = 26;
            this.iconPictureBox4.TabStop = false;
            this.iconPictureBox4.Click += new System.EventHandler(this.iconPictureBox4_Click);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.Transparent;
            this.exitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.exitButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.exitButton.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.exitButton.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.exitButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.exitButton.IconSize = 22;
            this.exitButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.exitButton.Location = new System.Drawing.Point(1106, 0);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(34, 22);
            this.exitButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.exitButton.TabIndex = 23;
            this.exitButton.TabStop = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.panel1.Controls.Add(this.restorebutton);
            this.panel1.Controls.Add(this.backupbutton);
            this.panel1.Controls.Add(this.managerButton);
            this.panel1.Controls.Add(this.userButton);
            this.panel1.Controls.Add(this.settingsButton);
            this.panel1.Controls.Add(this.logoutButton);
            this.panel1.Controls.Add(this.incomeButton);
            this.panel1.Controls.Add(this.expenseButton);
            this.panel1.Controls.Add(this.bookingsButton);
            this.panel1.Controls.Add(this.calanderButton);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(247, 628);
            this.panel1.TabIndex = 26;
            // 
            // restorebutton
            // 
            this.restorebutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.restorebutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.restorebutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.restorebutton.Dock = System.Windows.Forms.DockStyle.Top;
            this.restorebutton.FlatAppearance.BorderSize = 0;
            this.restorebutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.restorebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.restorebutton.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.restorebutton.ForeColor = System.Drawing.Color.White;
            this.restorebutton.Image = ((System.Drawing.Image)(resources.GetObject("restorebutton.Image")));
            this.restorebutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.restorebutton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.restorebutton.Location = new System.Drawing.Point(0, 506);
            this.restorebutton.Name = "restorebutton";
            this.restorebutton.Size = new System.Drawing.Size(247, 42);
            this.restorebutton.TabIndex = 40;
            this.restorebutton.Text = "   Restore Db";
            this.restorebutton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.restorebutton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.restorebutton.UseVisualStyleBackColor = false;
            this.restorebutton.Click += new System.EventHandler(this.restorebutton_Click);
            // 
            // backupbutton
            // 
            this.backupbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.backupbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.backupbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backupbutton.Dock = System.Windows.Forms.DockStyle.Top;
            this.backupbutton.FlatAppearance.BorderSize = 0;
            this.backupbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.backupbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backupbutton.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.backupbutton.ForeColor = System.Drawing.Color.White;
            this.backupbutton.Image = ((System.Drawing.Image)(resources.GetObject("backupbutton.Image")));
            this.backupbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.backupbutton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.backupbutton.Location = new System.Drawing.Point(0, 464);
            this.backupbutton.Name = "backupbutton";
            this.backupbutton.Size = new System.Drawing.Size(247, 42);
            this.backupbutton.TabIndex = 39;
            this.backupbutton.Text = "   Backup Db";
            this.backupbutton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.backupbutton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.backupbutton.UseVisualStyleBackColor = false;
            this.backupbutton.Click += new System.EventHandler(this.backupbutton_Click);
            // 
            // managerButton
            // 
            this.managerButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.managerButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.managerButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.managerButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.managerButton.FlatAppearance.BorderSize = 0;
            this.managerButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.managerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.managerButton.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.managerButton.ForeColor = System.Drawing.Color.White;
            this.managerButton.Image = ((System.Drawing.Image)(resources.GetObject("managerButton.Image")));
            this.managerButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.managerButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.managerButton.Location = new System.Drawing.Point(0, 422);
            this.managerButton.Name = "managerButton";
            this.managerButton.Size = new System.Drawing.Size(247, 42);
            this.managerButton.TabIndex = 34;
            this.managerButton.Text = "   Managers";
            this.managerButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.managerButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.managerButton.UseVisualStyleBackColor = false;
            this.managerButton.Click += new System.EventHandler(this.managerButton_Click);
            // 
            // userButton
            // 
            this.userButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.userButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.userButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.userButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.userButton.FlatAppearance.BorderSize = 0;
            this.userButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.userButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.userButton.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.userButton.ForeColor = System.Drawing.Color.White;
            this.userButton.Image = ((System.Drawing.Image)(resources.GetObject("userButton.Image")));
            this.userButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.userButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.userButton.Location = new System.Drawing.Point(0, 380);
            this.userButton.Name = "userButton";
            this.userButton.Size = new System.Drawing.Size(247, 42);
            this.userButton.TabIndex = 33;
            this.userButton.Text = "   User Settings";
            this.userButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.userButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.userButton.UseVisualStyleBackColor = false;
            this.userButton.Click += new System.EventHandler(this.userButton_Click);
            // 
            // settingsButton
            // 
            this.settingsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.settingsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.settingsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.settingsButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.settingsButton.FlatAppearance.BorderSize = 0;
            this.settingsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.settingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settingsButton.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.settingsButton.ForeColor = System.Drawing.Color.White;
            this.settingsButton.Image = ((System.Drawing.Image)(resources.GetObject("settingsButton.Image")));
            this.settingsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.settingsButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.settingsButton.Location = new System.Drawing.Point(0, 338);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(247, 42);
            this.settingsButton.TabIndex = 32;
            this.settingsButton.Text = "   System Settings";
            this.settingsButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.settingsButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.settingsButton.UseVisualStyleBackColor = false;
            this.settingsButton.Click += new System.EventHandler(this.settingsButton_Click);
            // 
            // logoutButton
            // 
            this.logoutButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.logoutButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.logoutButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logoutButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.logoutButton.FlatAppearance.BorderSize = 0;
            this.logoutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutButton.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.logoutButton.ForeColor = System.Drawing.Color.White;
            this.logoutButton.Image = ((System.Drawing.Image)(resources.GetObject("logoutButton.Image")));
            this.logoutButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logoutButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.logoutButton.Location = new System.Drawing.Point(0, 597);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(247, 31);
            this.logoutButton.TabIndex = 30;
            this.logoutButton.Text = "   Logout";
            this.logoutButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logoutButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.logoutButton.UseVisualStyleBackColor = false;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // incomeButton
            // 
            this.incomeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.incomeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.incomeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.incomeButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.incomeButton.FlatAppearance.BorderSize = 0;
            this.incomeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.incomeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.incomeButton.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.incomeButton.ForeColor = System.Drawing.Color.White;
            this.incomeButton.Image = ((System.Drawing.Image)(resources.GetObject("incomeButton.Image")));
            this.incomeButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.incomeButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.incomeButton.Location = new System.Drawing.Point(0, 296);
            this.incomeButton.Name = "incomeButton";
            this.incomeButton.Size = new System.Drawing.Size(247, 42);
            this.incomeButton.TabIndex = 26;
            this.incomeButton.Text = "   Income";
            this.incomeButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.incomeButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.incomeButton.UseVisualStyleBackColor = false;
            this.incomeButton.Click += new System.EventHandler(this.incomeButton_Click);
            // 
            // expenseButton
            // 
            this.expenseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.expenseButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.expenseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.expenseButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.expenseButton.FlatAppearance.BorderSize = 0;
            this.expenseButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.expenseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.expenseButton.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.expenseButton.ForeColor = System.Drawing.Color.White;
            this.expenseButton.Image = ((System.Drawing.Image)(resources.GetObject("expenseButton.Image")));
            this.expenseButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.expenseButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.expenseButton.Location = new System.Drawing.Point(0, 254);
            this.expenseButton.Name = "expenseButton";
            this.expenseButton.Size = new System.Drawing.Size(247, 42);
            this.expenseButton.TabIndex = 25;
            this.expenseButton.Text = "   Expense";
            this.expenseButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.expenseButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.expenseButton.UseVisualStyleBackColor = false;
            this.expenseButton.Click += new System.EventHandler(this.expenseButton_Click);
            // 
            // bookingsButton
            // 
            this.bookingsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.bookingsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bookingsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bookingsButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.bookingsButton.FlatAppearance.BorderSize = 0;
            this.bookingsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.bookingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bookingsButton.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.bookingsButton.ForeColor = System.Drawing.Color.White;
            this.bookingsButton.Image = ((System.Drawing.Image)(resources.GetObject("bookingsButton.Image")));
            this.bookingsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bookingsButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.bookingsButton.Location = new System.Drawing.Point(0, 212);
            this.bookingsButton.Name = "bookingsButton";
            this.bookingsButton.Size = new System.Drawing.Size(247, 42);
            this.bookingsButton.TabIndex = 24;
            this.bookingsButton.Text = "   Bookings";
            this.bookingsButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bookingsButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bookingsButton.UseVisualStyleBackColor = false;
            this.bookingsButton.Click += new System.EventHandler(this.bookingsButton_Click);
            // 
            // calanderButton
            // 
            this.calanderButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.calanderButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.calanderButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.calanderButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.calanderButton.FlatAppearance.BorderSize = 0;
            this.calanderButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.calanderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.calanderButton.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.calanderButton.ForeColor = System.Drawing.Color.White;
            this.calanderButton.Image = ((System.Drawing.Image)(resources.GetObject("calanderButton.Image")));
            this.calanderButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.calanderButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.calanderButton.Location = new System.Drawing.Point(0, 170);
            this.calanderButton.Name = "calanderButton";
            this.calanderButton.Size = new System.Drawing.Size(247, 42);
            this.calanderButton.TabIndex = 23;
            this.calanderButton.Text = "   Calander";
            this.calanderButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.calanderButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.calanderButton.UseVisualStyleBackColor = false;
            this.calanderButton.Click += new System.EventHandler(this.calanderButton_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.namelabel);
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Controls.Add(this.rolelabel);
            this.panel4.Controls.Add(this.userlabel);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(247, 170);
            this.panel4.TabIndex = 22;
            // 
            // namelabel
            // 
            this.namelabel.AutoSize = true;
            this.namelabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.namelabel.Location = new System.Drawing.Point(208, 27);
            this.namelabel.Name = "namelabel";
            this.namelabel.Size = new System.Drawing.Size(0, 17);
            this.namelabel.TabIndex = 9;
            this.namelabel.Visible = false;
            // 
            // panel6
            // 
            this.panel6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel6.BackgroundImage")));
            this.panel6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel6.Location = new System.Drawing.Point(0, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(244, 102);
            this.panel6.TabIndex = 8;
            // 
            // rolelabel
            // 
            this.rolelabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.rolelabel.ForeColor = System.Drawing.Color.White;
            this.rolelabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rolelabel.Location = new System.Drawing.Point(-4, 132);
            this.rolelabel.Name = "rolelabel";
            this.rolelabel.Size = new System.Drawing.Size(247, 31);
            this.rolelabel.TabIndex = 7;
            this.rolelabel.Text = "Administrator";
            this.rolelabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // userlabel
            // 
            this.userlabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.userlabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(195)))), ((int)(((byte)(239)))));
            this.userlabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.userlabel.Location = new System.Drawing.Point(0, 108);
            this.userlabel.Name = "userlabel";
            this.userlabel.Size = new System.Drawing.Size(244, 24);
            this.userlabel.TabIndex = 6;
            this.userlabel.Text = "User Name";
            this.userlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // containerPanel
            // 
            this.containerPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.containerPanel.Location = new System.Drawing.Point(258, 29);
            this.containerPanel.Name = "containerPanel";
            this.containerPanel.Size = new System.Drawing.Size(874, 587);
            this.containerPanel.TabIndex = 29;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.panel5.Controls.Add(this.iconButton2);
            this.panel5.Controls.Add(this.iconPictureBox3);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(247, 623);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(893, 27);
            this.panel5.TabIndex = 30;
            // 
            // iconButton2
            // 
            this.iconButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.iconButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.iconButton2.FlatAppearance.BorderSize = 0;
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.iconButton2.ForeColor = System.Drawing.Color.White;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.Copyright;
            this.iconButton2.IconColor = System.Drawing.Color.White;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.IconSize = 15;
            this.iconButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.iconButton2.Location = new System.Drawing.Point(719, 1);
            this.iconButton2.Margin = new System.Windows.Forms.Padding(0);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconButton2.Size = new System.Drawing.Size(174, 22);
            this.iconButton2.TabIndex = 33;
            this.iconButton2.Text = "Developed By Marinoft";
            this.iconButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton2.UseVisualStyleBackColor = false;
            // 
            // iconPictureBox3
            // 
            this.iconPictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.iconPictureBox3.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.iconPictureBox3.IconColor = System.Drawing.Color.White;
            this.iconPictureBox3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox3.IconSize = 26;
            this.iconPictureBox3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.iconPictureBox3.Location = new System.Drawing.Point(1323, 0);
            this.iconPictureBox3.Name = "iconPictureBox3";
            this.iconPictureBox3.Size = new System.Drawing.Size(26, 34);
            this.iconPictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconPictureBox3.TabIndex = 15;
            this.iconPictureBox3.TabStop = false;
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(1140, 650);
            this.ControlBox = false;
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.containerPanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseMove);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitButton)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox3)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Button managerButton;
        public System.Windows.Forms.Button userButton;
        public System.Windows.Forms.Button settingsButton;
        public System.Windows.Forms.Button logoutButton;
        public System.Windows.Forms.Button incomeButton;
        public System.Windows.Forms.Button expenseButton;
        public System.Windows.Forms.Button bookingsButton;
        public System.Windows.Forms.Button calanderButton;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label namelabel;
        private System.Windows.Forms.Panel panel6;
        public System.Windows.Forms.Label rolelabel;
        public System.Windows.Forms.Label userlabel;
        private System.Windows.Forms.Panel containerPanel;
        private System.Windows.Forms.Panel panel5;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox3;
        public System.Windows.Forms.Button restorebutton;
        public System.Windows.Forms.Button backupbutton;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox4;
        private FontAwesome.Sharp.IconPictureBox exitButton;
    }

}