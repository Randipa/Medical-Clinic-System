namespace Pharmacy
{
    partial class Medicine_Details
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
            this.txtPrice = new MetroFramework.Controls.MetroTextBox();
            this.txtMID = new MetroFramework.Controls.MetroTextBox();
            this.lblPrice = new MetroFramework.Controls.MetroLabel();
            this.lblMID = new MetroFramework.Controls.MetroLabel();
            this.lblMName = new MetroFramework.Controls.MetroLabel();
            this.txtMName = new MetroFramework.Controls.MetroTextBox();
            this.btnDelete = new MetroFramework.Controls.MetroButton();
            this.btnUpdate = new MetroFramework.Controls.MetroButton();
            this.btnClear = new MetroFramework.Controls.MetroButton();
            this.btnView = new MetroFramework.Controls.MetroButton();
            this.btnSave = new MetroFramework.Controls.MetroButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnTotal = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPrice
            // 
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
            this.txtPrice.Lines = new string[0];
            this.txtPrice.Location = new System.Drawing.Point(175, 129);
            this.txtPrice.MaxLength = 32767;
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.PasswordChar = '\0';
            this.txtPrice.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPrice.SelectedText = "";
            this.txtPrice.SelectionLength = 0;
            this.txtPrice.SelectionStart = 0;
            this.txtPrice.ShortcutsEnabled = true;
            this.txtPrice.Size = new System.Drawing.Size(153, 23);
            this.txtPrice.TabIndex = 44;
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
            this.txtMID.Lines = new string[0];
            this.txtMID.Location = new System.Drawing.Point(175, 85);
            this.txtMID.MaxLength = 32767;
            this.txtMID.Name = "txtMID";
            this.txtMID.PasswordChar = '\0';
            this.txtMID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtMID.SelectedText = "";
            this.txtMID.SelectionLength = 0;
            this.txtMID.SelectionStart = 0;
            this.txtMID.ShortcutsEnabled = true;
            this.txtMID.Size = new System.Drawing.Size(153, 23);
            this.txtMID.TabIndex = 43;
            this.txtMID.UseSelectable = true;
            this.txtMID.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtMID.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtMID.Click += new System.EventHandler(this.txtMID_Click);
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblPrice.Location = new System.Drawing.Point(67, 129);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(43, 19);
            this.lblPrice.TabIndex = 42;
            this.lblPrice.Text = "Price";
            // 
            // lblMID
            // 
            this.lblMID.AutoSize = true;
            this.lblMID.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblMID.Location = new System.Drawing.Point(22, 85);
            this.lblMID.Name = "lblMID";
            this.lblMID.Size = new System.Drawing.Size(88, 19);
            this.lblMID.TabIndex = 41;
            this.lblMID.Text = "Medicine ID";
            this.lblMID.Click += new System.EventHandler(this.lblPatientID_Click);
            // 
            // lblMName
            // 
            this.lblMName.AutoSize = true;
            this.lblMName.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblMName.Location = new System.Drawing.Point(408, 89);
            this.lblMName.Name = "lblMName";
            this.lblMName.Size = new System.Drawing.Size(114, 19);
            this.lblMName.TabIndex = 40;
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
            this.txtMName.Lines = new string[0];
            this.txtMName.Location = new System.Drawing.Point(587, 85);
            this.txtMName.MaxLength = 32767;
            this.txtMName.Name = "txtMName";
            this.txtMName.PasswordChar = '\0';
            this.txtMName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtMName.SelectedText = "";
            this.txtMName.SelectionLength = 0;
            this.txtMName.SelectionStart = 0;
            this.txtMName.ShortcutsEnabled = true;
            this.txtMName.Size = new System.Drawing.Size(153, 23);
            this.txtMName.TabIndex = 39;
            this.txtMName.UseSelectable = true;
            this.txtMName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtMName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnDelete
            // 
            this.btnDelete.BackgroundImage = global::Pharmacy.Properties.Resources.buttons_PNG49;
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDelete.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnDelete.Location = new System.Drawing.Point(658, 436);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(70, 40);
            this.btnDelete.TabIndex = 51;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseSelectable = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackgroundImage = global::Pharmacy.Properties.Resources.eTMy5LzAc;
            this.btnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUpdate.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnUpdate.Location = new System.Drawing.Point(360, 436);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(70, 40);
            this.btnUpdate.TabIndex = 49;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseSelectable = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackgroundImage = global::Pharmacy.Properties.Resources.images;
            this.btnClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClear.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnClear.Location = new System.Drawing.Point(512, 436);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(70, 40);
            this.btnClear.TabIndex = 48;
            this.btnClear.Text = "Clear";
            this.btnClear.UseSelectable = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnView
            // 
            this.btnView.BackgroundImage = global::Pharmacy.Properties.Resources.eTMy5LzAc;
            this.btnView.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnView.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnView.Location = new System.Drawing.Point(220, 436);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(70, 40);
            this.btnView.TabIndex = 47;
            this.btnView.Text = "View";
            this.btnView.UseSelectable = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackgroundImage = global::Pharmacy.Properties.Resources.eTMy5LzAc;
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSave.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnSave.Location = new System.Drawing.Point(67, 436);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(70, 40);
            this.btnSave.TabIndex = 46;
            this.btnSave.Text = "Save";
            this.btnSave.UseSelectable = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(220, 172);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(373, 240);
            this.dataGridView1.TabIndex = 52;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Modern No. 20", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(270, 23);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(270, 42);
            this.textBox1.TabIndex = 84;
            this.textBox1.Text = "Medicine Details";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnTotal
            // 
            this.btnTotal.BackgroundImage = global::Pharmacy.Properties.Resources.eTMy5LzAc;
            this.btnTotal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTotal.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnTotal.Location = new System.Drawing.Point(612, 172);
            this.btnTotal.Name = "btnTotal";
            this.btnTotal.Size = new System.Drawing.Size(83, 34);
            this.btnTotal.TabIndex = 86;
            this.btnTotal.Text = "Total";
            this.btnTotal.UseSelectable = true;
            this.btnTotal.Click += new System.EventHandler(this.btnTotal_Click);
            // 
            // Medicine_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Pharmacy.Properties.Resources.desktop_wallpaper_medical_doctor_clinic_doctor;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(809, 496);
            this.Controls.Add(this.btnTotal);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtMID);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblMID);
            this.Controls.Add(this.lblMName);
            this.Controls.Add(this.txtMName);
            this.Name = "Medicine_Details";
            this.Text = "Medicine_Details";
            this.Load += new System.EventHandler(this.Medicine_Details_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox txtPrice;
        private MetroFramework.Controls.MetroTextBox txtMID;
        private MetroFramework.Controls.MetroLabel lblPrice;
        private MetroFramework.Controls.MetroLabel lblMID;
        private MetroFramework.Controls.MetroLabel lblMName;
        private MetroFramework.Controls.MetroTextBox txtMName;
        private MetroFramework.Controls.MetroButton btnDelete;
        private MetroFramework.Controls.MetroButton btnUpdate;
        private MetroFramework.Controls.MetroButton btnClear;
        private MetroFramework.Controls.MetroButton btnView;
        private MetroFramework.Controls.MetroButton btnSave;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
        private MetroFramework.Controls.MetroButton btnTotal;
    }
}