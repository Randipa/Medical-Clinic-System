namespace channelCenter
{
    partial class ReceptionNew
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReceptionNew));
            this.btnDelete = new MetroFramework.Controls.MetroButton();
            this.btnCal = new MetroFramework.Controls.MetroButton();
            this.txtDoctorCharge = new MetroFramework.Controls.MetroTextBox();
            this.lblDoctorCharge = new MetroFramework.Controls.MetroLabel();
            this.cmbDoctors = new MetroFramework.Controls.MetroComboBox();
            this.lblDoctors = new MetroFramework.Controls.MetroLabel();
            this.btnUpdate = new MetroFramework.Controls.MetroButton();
            this.btnClear = new MetroFramework.Controls.MetroButton();
            this.btnView = new MetroFramework.Controls.MetroButton();
            this.btnSave = new MetroFramework.Controls.MetroButton();
            this.txtEmail = new MetroFramework.Controls.MetroTextBox();
            this.txtPhoneNO = new MetroFramework.Controls.MetroTextBox();
            this.txtAddress = new MetroFramework.Controls.MetroTextBox();
            this.txtAge = new MetroFramework.Controls.MetroTextBox();
            this.txtPatientID = new MetroFramework.Controls.MetroTextBox();
            this.lblEmail = new MetroFramework.Controls.MetroLabel();
            this.lblPhoneNo = new MetroFramework.Controls.MetroLabel();
            this.lblAddress = new MetroFramework.Controls.MetroLabel();
            this.lblAge = new MetroFramework.Controls.MetroLabel();
            this.lblPatientID = new MetroFramework.Controls.MetroLabel();
            this.lblPatientName = new MetroFramework.Controls.MetroLabel();
            this.txtPatientName = new MetroFramework.Controls.MetroTextBox();
            this.metroDateTime1 = new MetroFramework.Controls.MetroDateTime();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.BackgroundImage = global::channelCenter.Properties.Resources.buttons_PNG49;
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDelete.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnDelete.Highlight = true;
            this.btnDelete.Location = new System.Drawing.Point(613, 407);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 30);
            this.btnDelete.TabIndex = 45;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseSelectable = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnCal
            // 
            this.btnCal.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCal.BackgroundImage")));
            this.btnCal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCal.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnCal.Highlight = true;
            this.btnCal.Location = new System.Drawing.Point(515, 407);
            this.btnCal.Name = "btnCal";
            this.btnCal.Size = new System.Drawing.Size(75, 30);
            this.btnCal.TabIndex = 44;
            this.btnCal.Text = "Cal";
            this.btnCal.UseSelectable = true;
            this.btnCal.Click += new System.EventHandler(this.btnCal_Click);
            // 
            // txtDoctorCharge
            // 
            // 
            // 
            // 
            this.txtDoctorCharge.CustomButton.Image = null;
            this.txtDoctorCharge.CustomButton.Location = new System.Drawing.Point(131, 1);
            this.txtDoctorCharge.CustomButton.Name = "";
            this.txtDoctorCharge.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtDoctorCharge.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDoctorCharge.CustomButton.TabIndex = 1;
            this.txtDoctorCharge.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDoctorCharge.CustomButton.UseSelectable = true;
            this.txtDoctorCharge.CustomButton.Visible = false;
            this.txtDoctorCharge.Enabled = false;
            this.txtDoctorCharge.Lines = new string[0];
            this.txtDoctorCharge.Location = new System.Drawing.Point(262, 342);
            this.txtDoctorCharge.MaxLength = 32767;
            this.txtDoctorCharge.Name = "txtDoctorCharge";
            this.txtDoctorCharge.PasswordChar = '\0';
            this.txtDoctorCharge.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDoctorCharge.SelectedText = "";
            this.txtDoctorCharge.SelectionLength = 0;
            this.txtDoctorCharge.SelectionStart = 0;
            this.txtDoctorCharge.ShortcutsEnabled = true;
            this.txtDoctorCharge.Size = new System.Drawing.Size(153, 23);
            this.txtDoctorCharge.TabIndex = 43;
            this.txtDoctorCharge.UseSelectable = true;
            this.txtDoctorCharge.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDoctorCharge.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblDoctorCharge
            // 
            this.lblDoctorCharge.AutoSize = true;
            this.lblDoctorCharge.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblDoctorCharge.Location = new System.Drawing.Point(109, 342);
            this.lblDoctorCharge.Name = "lblDoctorCharge";
            this.lblDoctorCharge.Size = new System.Drawing.Size(105, 19);
            this.lblDoctorCharge.TabIndex = 42;
            this.lblDoctorCharge.Text = "Doctor charge";
            // 
            // cmbDoctors
            // 
            this.cmbDoctors.FormattingEnabled = true;
            this.cmbDoctors.ItemHeight = 23;
            this.cmbDoctors.Items.AddRange(new object[] {
            "VP - Mr.Manjula",
            "VOG - Mrs.Kumari",
            "Cardiologist - Mr.Janaka",
            "Surgeon - Mr.Thennakoon",
            "Neurologist - Mrs.Kanthi",
            "Dermatologist -Mr.Mahendra",
            "ENT - Mrs. Damayanthi"});
            this.cmbDoctors.Location = new System.Drawing.Point(262, 299);
            this.cmbDoctors.Name = "cmbDoctors";
            this.cmbDoctors.Size = new System.Drawing.Size(153, 29);
            this.cmbDoctors.TabIndex = 41;
            this.cmbDoctors.UseSelectable = true;
            // 
            // lblDoctors
            // 
            this.lblDoctors.AutoSize = true;
            this.lblDoctors.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblDoctors.Location = new System.Drawing.Point(109, 299);
            this.lblDoctors.Name = "lblDoctors";
            this.lblDoctors.Size = new System.Drawing.Size(61, 19);
            this.lblDoctors.TabIndex = 40;
            this.lblDoctors.Text = "Doctors";
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackgroundImage = global::channelCenter.Properties.Resources.eTMy5LzAc;
            this.btnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUpdate.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnUpdate.Highlight = true;
            this.btnUpdate.Location = new System.Drawing.Point(313, 407);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 30);
            this.btnUpdate.TabIndex = 39;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseSelectable = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnClear.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClear.BackgroundImage")));
            this.btnClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClear.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnClear.Highlight = true;
            this.btnClear.Location = new System.Drawing.Point(411, 407);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 30);
            this.btnClear.TabIndex = 38;
            this.btnClear.Text = "Clear";
            this.btnClear.UseSelectable = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnView
            // 
            this.btnView.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnView.BackgroundImage")));
            this.btnView.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnView.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnView.Highlight = true;
            this.btnView.Location = new System.Drawing.Point(212, 407);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(75, 30);
            this.btnView.TabIndex = 37;
            this.btnView.Text = "View";
            this.btnView.UseSelectable = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSave.BackgroundImage")));
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSave.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnSave.Highlight = true;
            this.btnSave.Location = new System.Drawing.Point(109, 407);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 30);
            this.btnSave.TabIndex = 36;
            this.btnSave.Text = "Save";
            this.btnSave.UseSelectable = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtEmail
            // 
            // 
            // 
            // 
            this.txtEmail.CustomButton.Image = null;
            this.txtEmail.CustomButton.Location = new System.Drawing.Point(131, 1);
            this.txtEmail.CustomButton.Name = "";
            this.txtEmail.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtEmail.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtEmail.CustomButton.TabIndex = 1;
            this.txtEmail.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtEmail.CustomButton.UseSelectable = true;
            this.txtEmail.CustomButton.Visible = false;
            this.txtEmail.Lines = new string[0];
            this.txtEmail.Location = new System.Drawing.Point(262, 256);
            this.txtEmail.MaxLength = 32767;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtEmail.SelectedText = "";
            this.txtEmail.SelectionLength = 0;
            this.txtEmail.SelectionStart = 0;
            this.txtEmail.ShortcutsEnabled = true;
            this.txtEmail.Size = new System.Drawing.Size(153, 23);
            this.txtEmail.TabIndex = 35;
            this.txtEmail.UseSelectable = true;
            this.txtEmail.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtEmail.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtPhoneNO
            // 
            // 
            // 
            // 
            this.txtPhoneNO.CustomButton.Image = null;
            this.txtPhoneNO.CustomButton.Location = new System.Drawing.Point(131, 1);
            this.txtPhoneNO.CustomButton.Name = "";
            this.txtPhoneNO.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPhoneNO.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPhoneNO.CustomButton.TabIndex = 1;
            this.txtPhoneNO.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPhoneNO.CustomButton.UseSelectable = true;
            this.txtPhoneNO.CustomButton.Visible = false;
            this.txtPhoneNO.Lines = new string[0];
            this.txtPhoneNO.Location = new System.Drawing.Point(262, 218);
            this.txtPhoneNO.MaxLength = 32767;
            this.txtPhoneNO.Name = "txtPhoneNO";
            this.txtPhoneNO.PasswordChar = '\0';
            this.txtPhoneNO.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPhoneNO.SelectedText = "";
            this.txtPhoneNO.SelectionLength = 0;
            this.txtPhoneNO.SelectionStart = 0;
            this.txtPhoneNO.ShortcutsEnabled = true;
            this.txtPhoneNO.Size = new System.Drawing.Size(153, 23);
            this.txtPhoneNO.TabIndex = 34;
            this.txtPhoneNO.UseSelectable = true;
            this.txtPhoneNO.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPhoneNO.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtPhoneNO.Click += new System.EventHandler(this.txtPhoneNO_Click);
            // 
            // txtAddress
            // 
            // 
            // 
            // 
            this.txtAddress.CustomButton.Image = null;
            this.txtAddress.CustomButton.Location = new System.Drawing.Point(131, 1);
            this.txtAddress.CustomButton.Name = "";
            this.txtAddress.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtAddress.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAddress.CustomButton.TabIndex = 1;
            this.txtAddress.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAddress.CustomButton.UseSelectable = true;
            this.txtAddress.CustomButton.Visible = false;
            this.txtAddress.Lines = new string[0];
            this.txtAddress.Location = new System.Drawing.Point(262, 180);
            this.txtAddress.MaxLength = 32767;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.PasswordChar = '\0';
            this.txtAddress.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAddress.SelectedText = "";
            this.txtAddress.SelectionLength = 0;
            this.txtAddress.SelectionStart = 0;
            this.txtAddress.ShortcutsEnabled = true;
            this.txtAddress.Size = new System.Drawing.Size(153, 23);
            this.txtAddress.TabIndex = 33;
            this.txtAddress.UseSelectable = true;
            this.txtAddress.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAddress.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtAge
            // 
            // 
            // 
            // 
            this.txtAge.CustomButton.Image = null;
            this.txtAge.CustomButton.Location = new System.Drawing.Point(131, 1);
            this.txtAge.CustomButton.Name = "";
            this.txtAge.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtAge.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAge.CustomButton.TabIndex = 1;
            this.txtAge.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAge.CustomButton.UseSelectable = true;
            this.txtAge.CustomButton.Visible = false;
            this.txtAge.Lines = new string[0];
            this.txtAge.Location = new System.Drawing.Point(262, 146);
            this.txtAge.MaxLength = 32767;
            this.txtAge.Name = "txtAge";
            this.txtAge.PasswordChar = '\0';
            this.txtAge.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAge.SelectedText = "";
            this.txtAge.SelectionLength = 0;
            this.txtAge.SelectionStart = 0;
            this.txtAge.ShortcutsEnabled = true;
            this.txtAge.Size = new System.Drawing.Size(153, 23);
            this.txtAge.TabIndex = 32;
            this.txtAge.UseSelectable = true;
            this.txtAge.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAge.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtPatientID
            // 
            // 
            // 
            // 
            this.txtPatientID.CustomButton.Image = null;
            this.txtPatientID.CustomButton.Location = new System.Drawing.Point(131, 1);
            this.txtPatientID.CustomButton.Name = "";
            this.txtPatientID.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPatientID.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPatientID.CustomButton.TabIndex = 1;
            this.txtPatientID.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPatientID.CustomButton.UseSelectable = true;
            this.txtPatientID.CustomButton.Visible = false;
            this.txtPatientID.Lines = new string[0];
            this.txtPatientID.Location = new System.Drawing.Point(262, 109);
            this.txtPatientID.MaxLength = 32767;
            this.txtPatientID.Name = "txtPatientID";
            this.txtPatientID.PasswordChar = '\0';
            this.txtPatientID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPatientID.SelectedText = "";
            this.txtPatientID.SelectionLength = 0;
            this.txtPatientID.SelectionStart = 0;
            this.txtPatientID.ShortcutsEnabled = true;
            this.txtPatientID.Size = new System.Drawing.Size(153, 23);
            this.txtPatientID.TabIndex = 31;
            this.txtPatientID.UseSelectable = true;
            this.txtPatientID.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPatientID.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblEmail.Location = new System.Drawing.Point(109, 256);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(45, 19);
            this.lblEmail.TabIndex = 30;
            this.lblEmail.Text = "Email";
            // 
            // lblPhoneNo
            // 
            this.lblPhoneNo.AutoSize = true;
            this.lblPhoneNo.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblPhoneNo.Location = new System.Drawing.Point(109, 218);
            this.lblPhoneNo.Name = "lblPhoneNo";
            this.lblPhoneNo.Size = new System.Drawing.Size(75, 19);
            this.lblPhoneNo.TabIndex = 29;
            this.lblPhoneNo.Text = "Phone No";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblAddress.Location = new System.Drawing.Point(109, 180);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(63, 19);
            this.lblAddress.TabIndex = 28;
            this.lblAddress.Text = "Address";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblAge.Location = new System.Drawing.Point(109, 146);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(36, 19);
            this.lblAge.TabIndex = 27;
            this.lblAge.Text = "Age";
            // 
            // lblPatientID
            // 
            this.lblPatientID.AutoSize = true;
            this.lblPatientID.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblPatientID.Location = new System.Drawing.Point(109, 109);
            this.lblPatientID.Name = "lblPatientID";
            this.lblPatientID.Size = new System.Drawing.Size(74, 19);
            this.lblPatientID.TabIndex = 26;
            this.lblPatientID.Text = "Patient ID";
            // 
            // lblPatientName
            // 
            this.lblPatientName.AutoSize = true;
            this.lblPatientName.BackColor = System.Drawing.Color.LightGray;
            this.lblPatientName.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblPatientName.Location = new System.Drawing.Point(109, 73);
            this.lblPatientName.Name = "lblPatientName";
            this.lblPatientName.Size = new System.Drawing.Size(100, 19);
            this.lblPatientName.TabIndex = 25;
            this.lblPatientName.Text = "Patient Name";
            // 
            // txtPatientName
            // 
            // 
            // 
            // 
            this.txtPatientName.CustomButton.Image = null;
            this.txtPatientName.CustomButton.Location = new System.Drawing.Point(131, 1);
            this.txtPatientName.CustomButton.Name = "";
            this.txtPatientName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPatientName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPatientName.CustomButton.TabIndex = 1;
            this.txtPatientName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPatientName.CustomButton.UseSelectable = true;
            this.txtPatientName.CustomButton.Visible = false;
            this.txtPatientName.Lines = new string[0];
            this.txtPatientName.Location = new System.Drawing.Point(262, 73);
            this.txtPatientName.MaxLength = 32767;
            this.txtPatientName.Name = "txtPatientName";
            this.txtPatientName.PasswordChar = '\0';
            this.txtPatientName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPatientName.SelectedText = "";
            this.txtPatientName.SelectionLength = 0;
            this.txtPatientName.SelectionStart = 0;
            this.txtPatientName.ShortcutsEnabled = true;
            this.txtPatientName.Size = new System.Drawing.Size(153, 23);
            this.txtPatientName.TabIndex = 24;
            this.txtPatientName.UseSelectable = true;
            this.txtPatientName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPatientName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtPatientName.Click += new System.EventHandler(this.txtPatientName_Click);
            // 
            // metroDateTime1
            // 
            this.metroDateTime1.CalendarMonthBackground = System.Drawing.SystemColors.HotTrack;
            this.metroDateTime1.Location = new System.Drawing.Point(532, 3);
            this.metroDateTime1.MinimumSize = new System.Drawing.Size(0, 29);
            this.metroDateTime1.Name = "metroDateTime1";
            this.metroDateTime1.Size = new System.Drawing.Size(224, 29);
            this.metroDateTime1.TabIndex = 46;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Modern No. 20", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(92, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(349, 42);
            this.textBox1.TabIndex = 80;
            this.textBox1.Text = "Patient Details";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ReceptionNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::channelCenter.Properties.Resources.คลินิกอายุรกรรมทั่วไป;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.metroDateTime1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnCal);
            this.Controls.Add(this.txtDoctorCharge);
            this.Controls.Add(this.lblDoctorCharge);
            this.Controls.Add(this.cmbDoctors);
            this.Controls.Add(this.lblDoctors);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtPhoneNO);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.txtPatientID);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblPhoneNo);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.lblPatientID);
            this.Controls.Add(this.lblPatientName);
            this.Controls.Add(this.txtPatientName);
            this.Name = "ReceptionNew";
            this.Text = "ReceptionNew";
            this.Load += new System.EventHandler(this.ReceptionNew_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnDelete;
        private MetroFramework.Controls.MetroButton btnCal;
        private MetroFramework.Controls.MetroTextBox txtDoctorCharge;
        private MetroFramework.Controls.MetroLabel lblDoctorCharge;
        private MetroFramework.Controls.MetroComboBox cmbDoctors;
        private MetroFramework.Controls.MetroLabel lblDoctors;
        private MetroFramework.Controls.MetroButton btnUpdate;
        private MetroFramework.Controls.MetroButton btnClear;
        private MetroFramework.Controls.MetroButton btnView;
        private MetroFramework.Controls.MetroButton btnSave;
        private MetroFramework.Controls.MetroTextBox txtEmail;
        private MetroFramework.Controls.MetroTextBox txtPhoneNO;
        private MetroFramework.Controls.MetroTextBox txtAddress;
        private MetroFramework.Controls.MetroTextBox txtAge;
        private MetroFramework.Controls.MetroTextBox txtPatientID;
        private MetroFramework.Controls.MetroLabel lblEmail;
        private MetroFramework.Controls.MetroLabel lblPhoneNo;
        private MetroFramework.Controls.MetroLabel lblAddress;
        private MetroFramework.Controls.MetroLabel lblAge;
        private MetroFramework.Controls.MetroLabel lblPatientID;
        private MetroFramework.Controls.MetroLabel lblPatientName;
        private MetroFramework.Controls.MetroTextBox txtPatientName;
        private MetroFramework.Controls.MetroDateTime metroDateTime1;
        private System.Windows.Forms.TextBox textBox1;
    }
}