namespace Safe_Plus_Dental_Care
{
    partial class PrescriptionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrescriptionForm));
            this.dgvTodayAppointments = new System.Windows.Forms.DataGridView();
            this.tbName = new System.Windows.Forms.Label();
            this.tbPhone = new System.Windows.Forms.Label();
            this.tbGender = new System.Windows.Forms.Label();
            this.tbBlood = new System.Windows.Forms.Label();
            this.tbDiagnosis = new System.Windows.Forms.TextBox();
            this.tbMedicines = new System.Windows.Forms.TextBox();
            this.tbAdvice = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTodayAppointments)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTodayAppointments
            // 
            this.dgvTodayAppointments.AllowUserToAddRows = false;
            this.dgvTodayAppointments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTodayAppointments.Location = new System.Drawing.Point(75, 75);
            this.dgvTodayAppointments.MultiSelect = false;
            this.dgvTodayAppointments.Name = "dgvTodayAppointments";
            this.dgvTodayAppointments.ReadOnly = true;
            this.dgvTodayAppointments.RowHeadersWidth = 51;
            this.dgvTodayAppointments.RowTemplate.Height = 24;
            this.dgvTodayAppointments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTodayAppointments.Size = new System.Drawing.Size(240, 150);
            this.dgvTodayAppointments.TabIndex = 0;
            this.dgvTodayAppointments.SelectionChanged += new System.EventHandler(this.dgvTodayAppointments_SelectionChanged);
            // 
            // tbName
            // 
            this.tbName.AutoSize = true;
            this.tbName.Location = new System.Drawing.Point(396, 75);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(44, 16);
            this.tbName.TabIndex = 1;
            this.tbName.Text = "label1";
            // 
            // tbPhone
            // 
            this.tbPhone.AutoSize = true;
            this.tbPhone.Location = new System.Drawing.Point(399, 116);
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Size = new System.Drawing.Size(44, 16);
            this.tbPhone.TabIndex = 2;
            this.tbPhone.Text = "label1";
            // 
            // tbGender
            // 
            this.tbGender.AutoSize = true;
            this.tbGender.Location = new System.Drawing.Point(402, 164);
            this.tbGender.Name = "tbGender";
            this.tbGender.Size = new System.Drawing.Size(44, 16);
            this.tbGender.TabIndex = 3;
            this.tbGender.Text = "label1";
            // 
            // tbBlood
            // 
            this.tbBlood.AutoSize = true;
            this.tbBlood.Location = new System.Drawing.Point(405, 208);
            this.tbBlood.Name = "tbBlood";
            this.tbBlood.Size = new System.Drawing.Size(44, 16);
            this.tbBlood.TabIndex = 4;
            this.tbBlood.Text = "label1";
            // 
            // tbDiagnosis
            // 
            this.tbDiagnosis.Location = new System.Drawing.Point(547, 68);
            this.tbDiagnosis.Name = "tbDiagnosis";
            this.tbDiagnosis.Size = new System.Drawing.Size(100, 22);
            this.tbDiagnosis.TabIndex = 5;
            // 
            // tbMedicines
            // 
            this.tbMedicines.Location = new System.Drawing.Point(547, 128);
            this.tbMedicines.Name = "tbMedicines";
            this.tbMedicines.Size = new System.Drawing.Size(100, 22);
            this.tbMedicines.TabIndex = 6;
            // 
            // tbAdvice
            // 
            this.tbAdvice.Location = new System.Drawing.Point(547, 185);
            this.tbAdvice.Name = "tbAdvice";
            this.tbAdvice.Size = new System.Drawing.Size(100, 22);
            this.tbAdvice.TabIndex = 7;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(58, 324);
            this.btnBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(189, 46);
            this.btnBack.TabIndex = 36;
            this.btnBack.Text = "< Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Location = new System.Drawing.Point(270, 324);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(189, 46);
            this.btnPrint.TabIndex = 35;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // PrescriptionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.tbAdvice);
            this.Controls.Add(this.tbMedicines);
            this.Controls.Add(this.tbDiagnosis);
            this.Controls.Add(this.tbBlood);
            this.Controls.Add(this.tbGender);
            this.Controls.Add(this.tbPhone);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.dgvTodayAppointments);
            this.Name = "PrescriptionForm";
            this.Text = "PrescriptionForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTodayAppointments)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTodayAppointments;
        private System.Windows.Forms.Label tbName;
        private System.Windows.Forms.Label tbPhone;
        private System.Windows.Forms.Label tbGender;
        private System.Windows.Forms.Label tbBlood;
        private System.Windows.Forms.TextBox tbDiagnosis;
        private System.Windows.Forms.TextBox tbMedicines;
        private System.Windows.Forms.TextBox tbAdvice;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnPrint;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}