namespace Safe_Plus_Dental_Care
{
    partial class DoctorHome
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
            this.btnGenPre = new System.Windows.Forms.Button();
            this.btnChApp = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGenPre
            // 
            this.btnGenPre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.btnGenPre.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGenPre.FlatAppearance.BorderSize = 0;
            this.btnGenPre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenPre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenPre.ForeColor = System.Drawing.Color.White;
            this.btnGenPre.Location = new System.Drawing.Point(377, 288);
            this.btnGenPre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGenPre.Name = "btnGenPre";
            this.btnGenPre.Size = new System.Drawing.Size(312, 33);
            this.btnGenPre.TabIndex = 24;
            this.btnGenPre.Text = "Generate Prescription";
            this.btnGenPre.UseVisualStyleBackColor = false;
            this.btnGenPre.Click += new System.EventHandler(this.btnGenPre_Click);
            // 
            // btnChApp
            // 
            this.btnChApp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.btnChApp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChApp.FlatAppearance.BorderSize = 0;
            this.btnChApp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChApp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChApp.ForeColor = System.Drawing.Color.White;
            this.btnChApp.Location = new System.Drawing.Point(377, 234);
            this.btnChApp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnChApp.Name = "btnChApp";
            this.btnChApp.Size = new System.Drawing.Size(312, 33);
            this.btnChApp.TabIndex = 23;
            this.btnChApp.Text = "Check Appointment";
            this.btnChApp.UseVisualStyleBackColor = false;
            this.btnChApp.Click += new System.EventHandler(this.btnChApp_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(15, 14);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(189, 46);
            this.btnLogout.TabIndex = 26;
            this.btnLogout.Text = "Log Out";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // DoctorHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnGenPre);
            this.Controls.Add(this.btnChApp);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "DoctorHome";
            this.Text = "DoctorHome";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGenPre;
        private System.Windows.Forms.Button btnChApp;
        private System.Windows.Forms.Button btnLogout;
    }
}