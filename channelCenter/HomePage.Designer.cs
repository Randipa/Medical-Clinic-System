namespace channelCenter
{
    partial class HomePage
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
            this.btnPharmacist = new MetroFramework.Controls.MetroButton();
            this.btnDoctor = new MetroFramework.Controls.MetroButton();
            this.btnReceptionist = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // btnPharmacist
            // 
            this.btnPharmacist.BackgroundImage = global::channelCenter.Properties.Resources.images;
            this.btnPharmacist.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPharmacist.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnPharmacist.Location = new System.Drawing.Point(341, 267);
            this.btnPharmacist.Name = "btnPharmacist";
            this.btnPharmacist.Size = new System.Drawing.Size(118, 38);
            this.btnPharmacist.TabIndex = 5;
            this.btnPharmacist.Text = "Pharmacist";
            this.btnPharmacist.UseSelectable = true;
            this.btnPharmacist.Click += new System.EventHandler(this.btnPharmacist_Click);
            // 
            // btnDoctor
            // 
            this.btnDoctor.BackgroundImage = global::channelCenter.Properties.Resources.images;
            this.btnDoctor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDoctor.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnDoctor.Location = new System.Drawing.Point(341, 207);
            this.btnDoctor.Name = "btnDoctor";
            this.btnDoctor.Size = new System.Drawing.Size(118, 38);
            this.btnDoctor.TabIndex = 4;
            this.btnDoctor.Text = "Doctor";
            this.btnDoctor.UseSelectable = true;
            this.btnDoctor.Click += new System.EventHandler(this.btnDoctor_Click);
            // 
            // btnReceptionist
            // 
            this.btnReceptionist.BackgroundImage = global::channelCenter.Properties.Resources.images;
            this.btnReceptionist.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnReceptionist.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnReceptionist.Location = new System.Drawing.Point(341, 145);
            this.btnReceptionist.Name = "btnReceptionist";
            this.btnReceptionist.Size = new System.Drawing.Size(118, 38);
            this.btnReceptionist.TabIndex = 3;
            this.btnReceptionist.Text = "Receptionist";
            this.btnReceptionist.UseSelectable = true;
            this.btnReceptionist.Click += new System.EventHandler(this.btnReceptionist_Click);
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::channelCenter.Properties.Resources.medical_clinic_instagram_posts___Made_with_PosterMyWall;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPharmacist);
            this.Controls.Add(this.btnDoctor);
            this.Controls.Add(this.btnReceptionist);
            this.Name = "HomePage";
            this.Text = "HomePage";
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnPharmacist;
        private MetroFramework.Controls.MetroButton btnDoctor;
        private MetroFramework.Controls.MetroButton btnReceptionist;
    }
}