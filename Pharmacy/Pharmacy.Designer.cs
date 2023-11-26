namespace Pharmacy
{
    partial class Pharmacy
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
            this.btnClear = new MetroFramework.Controls.MetroButton();
            this.btnView = new MetroFramework.Controls.MetroButton();
            this.txtSpecialNote = new MetroFramework.Controls.MetroTextBox();
            this.lblEmail = new MetroFramework.Controls.MetroLabel();
            this.txtMedicine = new MetroFramework.Controls.MetroTextBox();
            this.lblAddress = new MetroFramework.Controls.MetroLabel();
            this.txtAge = new MetroFramework.Controls.MetroTextBox();
            this.txtPatientID = new MetroFramework.Controls.MetroTextBox();
            this.lblAge = new MetroFramework.Controls.MetroLabel();
            this.lblPatientID = new MetroFramework.Controls.MetroLabel();
            this.lblPatientName = new MetroFramework.Controls.MetroLabel();
            this.txtPatientName = new MetroFramework.Controls.MetroTextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblSearch = new MetroFramework.Controls.MetroLabel();
            this.txtPrice = new MetroFramework.Controls.MetroTextBox();
            this.txtMID = new MetroFramework.Controls.MetroTextBox();
            this.lblPrice = new MetroFramework.Controls.MetroLabel();
            this.lblMID = new MetroFramework.Controls.MetroLabel();
            this.lblMName = new MetroFramework.Controls.MetroLabel();
            this.txtMName = new MetroFramework.Controls.MetroTextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.metroDateTime1 = new MetroFramework.Controls.MetroDateTime();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClear
            // 
            this.btnClear.BackgroundImage = global::Pharmacy.Properties.Resources.eTMy5LzAc;
            this.btnClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClear.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnClear.Location = new System.Drawing.Point(659, 447);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(88, 34);
            this.btnClear.TabIndex = 58;
            this.btnClear.Text = "Clear";
            this.btnClear.UseSelectable = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnView
            // 
            this.btnView.BackgroundImage = global::Pharmacy.Properties.Resources.eTMy5LzAc;
            this.btnView.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnView.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnView.Location = new System.Drawing.Point(397, 447);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(83, 34);
            this.btnView.TabIndex = 57;
            this.btnView.Text = "View";
            this.btnView.UseSelectable = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // txtSpecialNote
            // 
            // 
            // 
            // 
            this.txtSpecialNote.CustomButton.Image = null;
            this.txtSpecialNote.CustomButton.Location = new System.Drawing.Point(101, 1);
            this.txtSpecialNote.CustomButton.Name = "";
            this.txtSpecialNote.CustomButton.Size = new System.Drawing.Size(91, 91);
            this.txtSpecialNote.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSpecialNote.CustomButton.TabIndex = 1;
            this.txtSpecialNote.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSpecialNote.CustomButton.UseSelectable = true;
            this.txtSpecialNote.CustomButton.Visible = false;
            this.txtSpecialNote.Lines = new string[0];
            this.txtSpecialNote.Location = new System.Drawing.Point(165, 185);
            this.txtSpecialNote.MaxLength = 32767;
            this.txtSpecialNote.Name = "txtSpecialNote";
            this.txtSpecialNote.PasswordChar = '\0';
            this.txtSpecialNote.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSpecialNote.SelectedText = "";
            this.txtSpecialNote.SelectionLength = 0;
            this.txtSpecialNote.SelectionStart = 0;
            this.txtSpecialNote.ShortcutsEnabled = true;
            this.txtSpecialNote.Size = new System.Drawing.Size(193, 93);
            this.txtSpecialNote.TabIndex = 55;
            this.txtSpecialNote.UseSelectable = true;
            this.txtSpecialNote.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSpecialNote.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtSpecialNote.Click += new System.EventHandler(this.txtSpecialNote_Click);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblEmail.Location = new System.Drawing.Point(12, 218);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(90, 19);
            this.lblEmail.TabIndex = 54;
            this.lblEmail.Text = "SpecialNote";
            this.lblEmail.Click += new System.EventHandler(this.lblEmail_Click);
            // 
            // txtMedicine
            // 
            // 
            // 
            // 
            this.txtMedicine.CustomButton.Image = null;
            this.txtMedicine.CustomButton.Location = new System.Drawing.Point(125, 2);
            this.txtMedicine.CustomButton.Name = "";
            this.txtMedicine.CustomButton.Size = new System.Drawing.Size(65, 65);
            this.txtMedicine.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtMedicine.CustomButton.TabIndex = 1;
            this.txtMedicine.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtMedicine.CustomButton.UseSelectable = true;
            this.txtMedicine.CustomButton.Visible = false;
            this.txtMedicine.Lines = new string[0];
            this.txtMedicine.Location = new System.Drawing.Point(165, 306);
            this.txtMedicine.MaxLength = 32767;
            this.txtMedicine.Name = "txtMedicine";
            this.txtMedicine.PasswordChar = '\0';
            this.txtMedicine.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtMedicine.SelectedText = "";
            this.txtMedicine.SelectionLength = 0;
            this.txtMedicine.SelectionStart = 0;
            this.txtMedicine.ShortcutsEnabled = true;
            this.txtMedicine.Size = new System.Drawing.Size(193, 70);
            this.txtMedicine.TabIndex = 53;
            this.txtMedicine.UseSelectable = true;
            this.txtMedicine.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtMedicine.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtMedicine.Click += new System.EventHandler(this.txtMedicine_Click);
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblAddress.Location = new System.Drawing.Point(12, 330);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(70, 19);
            this.lblAddress.TabIndex = 52;
            this.lblAddress.Text = "Medicine";
            // 
            // txtAge
            // 
            // 
            // 
            // 
            this.txtAge.CustomButton.Image = null;
            this.txtAge.CustomButton.Location = new System.Drawing.Point(171, 1);
            this.txtAge.CustomButton.Name = "";
            this.txtAge.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtAge.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAge.CustomButton.TabIndex = 1;
            this.txtAge.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAge.CustomButton.UseSelectable = true;
            this.txtAge.CustomButton.Visible = false;
            this.txtAge.Lines = new string[0];
            this.txtAge.Location = new System.Drawing.Point(165, 140);
            this.txtAge.MaxLength = 32767;
            this.txtAge.Name = "txtAge";
            this.txtAge.PasswordChar = '\0';
            this.txtAge.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAge.SelectedText = "";
            this.txtAge.SelectionLength = 0;
            this.txtAge.SelectionStart = 0;
            this.txtAge.ShortcutsEnabled = true;
            this.txtAge.Size = new System.Drawing.Size(193, 23);
            this.txtAge.TabIndex = 51;
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
            this.txtPatientID.CustomButton.Location = new System.Drawing.Point(171, 1);
            this.txtPatientID.CustomButton.Name = "";
            this.txtPatientID.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPatientID.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPatientID.CustomButton.TabIndex = 1;
            this.txtPatientID.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPatientID.CustomButton.UseSelectable = true;
            this.txtPatientID.CustomButton.Visible = false;
            this.txtPatientID.Lines = new string[0];
            this.txtPatientID.Location = new System.Drawing.Point(165, 60);
            this.txtPatientID.MaxLength = 32767;
            this.txtPatientID.Name = "txtPatientID";
            this.txtPatientID.PasswordChar = '\0';
            this.txtPatientID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPatientID.SelectedText = "";
            this.txtPatientID.SelectionLength = 0;
            this.txtPatientID.SelectionStart = 0;
            this.txtPatientID.ShortcutsEnabled = true;
            this.txtPatientID.Size = new System.Drawing.Size(193, 23);
            this.txtPatientID.TabIndex = 50;
            this.txtPatientID.UseSelectable = true;
            this.txtPatientID.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPatientID.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblAge.Location = new System.Drawing.Point(12, 140);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(36, 19);
            this.lblAge.TabIndex = 49;
            this.lblAge.Text = "Age";
            // 
            // lblPatientID
            // 
            this.lblPatientID.AutoSize = true;
            this.lblPatientID.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblPatientID.Location = new System.Drawing.Point(12, 64);
            this.lblPatientID.Name = "lblPatientID";
            this.lblPatientID.Size = new System.Drawing.Size(74, 19);
            this.lblPatientID.TabIndex = 48;
            this.lblPatientID.Text = "Patient ID";
            // 
            // lblPatientName
            // 
            this.lblPatientName.AutoSize = true;
            this.lblPatientName.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblPatientName.Location = new System.Drawing.Point(12, 102);
            this.lblPatientName.Name = "lblPatientName";
            this.lblPatientName.Size = new System.Drawing.Size(100, 19);
            this.lblPatientName.TabIndex = 47;
            this.lblPatientName.Text = "Patient Name";
            // 
            // txtPatientName
            // 
            // 
            // 
            // 
            this.txtPatientName.CustomButton.Image = null;
            this.txtPatientName.CustomButton.Location = new System.Drawing.Point(171, 1);
            this.txtPatientName.CustomButton.Name = "";
            this.txtPatientName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPatientName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPatientName.CustomButton.TabIndex = 1;
            this.txtPatientName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPatientName.CustomButton.UseSelectable = true;
            this.txtPatientName.CustomButton.Visible = false;
            this.txtPatientName.Lines = new string[0];
            this.txtPatientName.Location = new System.Drawing.Point(165, 102);
            this.txtPatientName.MaxLength = 32767;
            this.txtPatientName.Name = "txtPatientName";
            this.txtPatientName.PasswordChar = '\0';
            this.txtPatientName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPatientName.SelectedText = "";
            this.txtPatientName.SelectionLength = 0;
            this.txtPatientName.SelectionStart = 0;
            this.txtPatientName.ShortcutsEnabled = true;
            this.txtPatientName.Size = new System.Drawing.Size(193, 23);
            this.txtPatientName.TabIndex = 46;
            this.txtPatientName.UseSelectable = true;
            this.txtPatientName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPatientName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(395, 82);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(352, 312);
            this.dataGridView1.TabIndex = 59;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblSearch.Location = new System.Drawing.Point(397, 53);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(54, 19);
            this.lblSearch.TabIndex = 62;
            this.lblSearch.Text = "Search";
            this.lblSearch.Click += new System.EventHandler(this.lblSearch_Click);
            // 
            // txtPrice
            // 
            this.txtPrice.BackColor = System.Drawing.SystemColors.Control;
            // 
            // 
            // 
            this.txtPrice.CustomButton.Image = null;
            this.txtPrice.CustomButton.Location = new System.Drawing.Point(131, 1);
            this.txtPrice.CustomButton.Name = "";
            this.txtPrice.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPrice.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPrice.CustomButton.TabIndex = 1;
            this.txtPrice.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPrice.CustomButton.UseSelectable = true;
            this.txtPrice.CustomButton.Visible = false;
            this.txtPrice.Enabled = false;
            this.txtPrice.Lines = new string[0];
            this.txtPrice.Location = new System.Drawing.Point(12, 484);
            this.txtPrice.MaxLength = 32767;
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.PasswordChar = '\0';
            this.txtPrice.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPrice.SelectedText = "";
            this.txtPrice.SelectionLength = 0;
            this.txtPrice.SelectionStart = 0;
            this.txtPrice.ShortcutsEnabled = true;
            this.txtPrice.Size = new System.Drawing.Size(153, 23);
            this.txtPrice.TabIndex = 68;
            this.txtPrice.UseSelectable = true;
            this.txtPrice.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPrice.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtPrice.Click += new System.EventHandler(this.txtPrice_Click);
            // 
            // txtMID
            // 
            // 
            // 
            // 
            this.txtMID.CustomButton.Image = null;
            this.txtMID.CustomButton.Location = new System.Drawing.Point(131, 1);
            this.txtMID.CustomButton.Name = "";
            this.txtMID.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtMID.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtMID.CustomButton.TabIndex = 1;
            this.txtMID.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtMID.CustomButton.UseSelectable = true;
            this.txtMID.CustomButton.Visible = false;
            this.txtMID.Enabled = false;
            this.txtMID.Lines = new string[0];
            this.txtMID.Location = new System.Drawing.Point(12, 432);
            this.txtMID.MaxLength = 32767;
            this.txtMID.Name = "txtMID";
            this.txtMID.PasswordChar = '\0';
            this.txtMID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtMID.SelectedText = "";
            this.txtMID.SelectionLength = 0;
            this.txtMID.SelectionStart = 0;
            this.txtMID.ShortcutsEnabled = true;
            this.txtMID.Size = new System.Drawing.Size(153, 23);
            this.txtMID.TabIndex = 67;
            this.txtMID.UseSelectable = true;
            this.txtMID.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtMID.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblPrice.Location = new System.Drawing.Point(12, 462);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(43, 19);
            this.lblPrice.TabIndex = 66;
            this.lblPrice.Text = "Price";
            // 
            // lblMID
            // 
            this.lblMID.AutoSize = true;
            this.lblMID.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblMID.Location = new System.Drawing.Point(12, 410);
            this.lblMID.Name = "lblMID";
            this.lblMID.Size = new System.Drawing.Size(88, 19);
            this.lblMID.TabIndex = 65;
            this.lblMID.Text = "Medicine ID";
            // 
            // lblMName
            // 
            this.lblMName.AutoSize = true;
            this.lblMName.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblMName.Location = new System.Drawing.Point(194, 410);
            this.lblMName.Name = "lblMName";
            this.lblMName.Size = new System.Drawing.Size(114, 19);
            this.lblMName.TabIndex = 64;
            this.lblMName.Text = "Medicine Name";
            // 
            // txtMName
            // 
            // 
            // 
            // 
            this.txtMName.CustomButton.Image = null;
            this.txtMName.CustomButton.Location = new System.Drawing.Point(131, 1);
            this.txtMName.CustomButton.Name = "";
            this.txtMName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtMName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtMName.CustomButton.TabIndex = 1;
            this.txtMName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtMName.CustomButton.UseSelectable = true;
            this.txtMName.CustomButton.Visible = false;
            this.txtMName.Enabled = false;
            this.txtMName.Lines = new string[0];
            this.txtMName.Location = new System.Drawing.Point(194, 432);
            this.txtMName.MaxLength = 32767;
            this.txtMName.Name = "txtMName";
            this.txtMName.PasswordChar = '\0';
            this.txtMName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtMName.SelectedText = "";
            this.txtMName.SelectionLength = 0;
            this.txtMName.SelectionStart = 0;
            this.txtMName.ShortcutsEnabled = true;
            this.txtMName.Size = new System.Drawing.Size(153, 23);
            this.txtMName.TabIndex = 63;
            this.txtMName.UseSelectable = true;
            this.txtMName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtMName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(477, 52);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(227, 20);
            this.textBox1.TabIndex = 70;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Enabled = false;
            this.textBox2.Font = new System.Drawing.Font("Modern No. 20", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(234, 4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(270, 42);
            this.textBox2.TabIndex = 83;
            this.textBox2.Text = "Pharmacy Form";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // metroDateTime1
            // 
            this.metroDateTime1.CalendarMonthBackground = System.Drawing.SystemColors.HotTrack;
            this.metroDateTime1.Location = new System.Drawing.Point(582, 4);
            this.metroDateTime1.MinimumSize = new System.Drawing.Size(0, 29);
            this.metroDateTime1.Name = "metroDateTime1";
            this.metroDateTime1.Size = new System.Drawing.Size(224, 29);
            this.metroDateTime1.TabIndex = 84;
            // 
            // Pharmacy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Pharmacy.Properties.Resources.stethoscope_doctor_md_medical_health_hospital;
            this.ClientSize = new System.Drawing.Size(808, 523);
            this.Controls.Add(this.metroDateTime1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtMID);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblMID);
            this.Controls.Add(this.lblMName);
            this.Controls.Add(this.txtMName);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.txtSpecialNote);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtMedicine);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.txtPatientID);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.lblPatientID);
            this.Controls.Add(this.lblPatientName);
            this.Controls.Add(this.txtPatientName);
            this.Name = "Pharmacy";
            this.Text = "Pharmacy";
            this.Load += new System.EventHandler(this.Pharmacy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnClear;
        private MetroFramework.Controls.MetroButton btnView;
        private MetroFramework.Controls.MetroTextBox txtSpecialNote;
        private MetroFramework.Controls.MetroLabel lblEmail;
        private MetroFramework.Controls.MetroTextBox txtMedicine;
        private MetroFramework.Controls.MetroLabel lblAddress;
        private MetroFramework.Controls.MetroTextBox txtAge;
        private MetroFramework.Controls.MetroTextBox txtPatientID;
        private MetroFramework.Controls.MetroLabel lblAge;
        private MetroFramework.Controls.MetroLabel lblPatientID;
        private MetroFramework.Controls.MetroLabel lblPatientName;
        private MetroFramework.Controls.MetroTextBox txtPatientName;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MetroFramework.Controls.MetroLabel lblSearch;
        private MetroFramework.Controls.MetroTextBox txtPrice;
        private MetroFramework.Controls.MetroTextBox txtMID;
        private MetroFramework.Controls.MetroLabel lblPrice;
        private MetroFramework.Controls.MetroLabel lblMID;
        private MetroFramework.Controls.MetroLabel lblMName;
        private MetroFramework.Controls.MetroTextBox txtMName;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private MetroFramework.Controls.MetroDateTime metroDateTime1;
    }
}