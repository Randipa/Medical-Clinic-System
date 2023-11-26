namespace Pharmacy
{
    partial class Login
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
            this.btnMedecineLogin = new MetroFramework.Controls.MetroButton();
            this.btnPharmacyLogin = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // btnMedecineLogin
            // 
            this.btnMedecineLogin.BackgroundImage = global::Pharmacy.Properties.Resources.eTMy5LzAc;
            this.btnMedecineLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMedecineLogin.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnMedecineLogin.Location = new System.Drawing.Point(469, 160);
            this.btnMedecineLogin.Name = "btnMedecineLogin";
            this.btnMedecineLogin.Size = new System.Drawing.Size(189, 61);
            this.btnMedecineLogin.TabIndex = 6;
            this.btnMedecineLogin.Text = "Medecine Login";
            this.btnMedecineLogin.UseSelectable = true;
            this.btnMedecineLogin.Click += new System.EventHandler(this.btnMedecineLogin_Click);
            // 
            // btnPharmacyLogin
            // 
            this.btnPharmacyLogin.BackgroundImage = global::Pharmacy.Properties.Resources.eTMy5LzAc;
            this.btnPharmacyLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPharmacyLogin.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnPharmacyLogin.Location = new System.Drawing.Point(138, 160);
            this.btnPharmacyLogin.Name = "btnPharmacyLogin";
            this.btnPharmacyLogin.Size = new System.Drawing.Size(189, 61);
            this.btnPharmacyLogin.TabIndex = 5;
            this.btnPharmacyLogin.Text = "Pharmacy Login";
            this.btnPharmacyLogin.UseSelectable = true;
            this.btnPharmacyLogin.Click += new System.EventHandler(this.btnPharmacyLogin_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Pharmacy.Properties.Resources.istockphoto_1447388979_612x612;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMedecineLogin);
            this.Controls.Add(this.btnPharmacyLogin);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnMedecineLogin;
        private MetroFramework.Controls.MetroButton btnPharmacyLogin;
    }
}