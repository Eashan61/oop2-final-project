namespace Safe_Plus_Dental_Care
{
    partial class DaashBoard
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
            this.lb1chair = new System.Windows.Forms.Label();
            this.lb2chair = new System.Windows.Forms.Label();
            this.btn1back = new System.Windows.Forms.Button();
            this.btn2next = new System.Windows.Forms.Button();
            this.dgvUpNext = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUpNext)).BeginInit();
            this.SuspendLayout();
            // 
            // lb1chair
            // 
            this.lb1chair.AutoSize = true;
            this.lb1chair.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb1chair.Location = new System.Drawing.Point(94, 58);
            this.lb1chair.Name = "lb1chair";
            this.lb1chair.Size = new System.Drawing.Size(53, 20);
            this.lb1chair.TabIndex = 0;
            this.lb1chair.Text = "label1";
            // 
            // lb2chair
            // 
            this.lb2chair.AutoSize = true;
            this.lb2chair.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb2chair.Location = new System.Drawing.Point(97, 116);
            this.lb2chair.Name = "lb2chair";
            this.lb2chair.Size = new System.Drawing.Size(53, 20);
            this.lb2chair.TabIndex = 1;
            this.lb2chair.Text = "label2";
            // 
            // btn1back
            // 
            this.btn1back.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1back.Location = new System.Drawing.Point(101, 369);
            this.btn1back.Name = "btn1back";
            this.btn1back.Size = new System.Drawing.Size(99, 45);
            this.btn1back.TabIndex = 2;
            this.btn1back.Text = "> Back";
            this.btn1back.UseVisualStyleBackColor = true;
            // 
            // btn2next
            // 
            this.btn2next.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2next.Location = new System.Drawing.Point(256, 369);
            this.btn2next.Name = "btn2next";
            this.btn2next.Size = new System.Drawing.Size(94, 43);
            this.btn2next.TabIndex = 3;
            this.btn2next.Text = "Next";
            this.btn2next.UseVisualStyleBackColor = true;
            this.btn2next.Click += new System.EventHandler(this.btn2next_Click);
            // 
            // dgvUpNext
            // 
            this.dgvUpNext.AllowUserToAddRows = false;
            this.dgvUpNext.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUpNext.Location = new System.Drawing.Point(98, 179);
            this.dgvUpNext.Name = "dgvUpNext";
            this.dgvUpNext.ReadOnly = true;
            this.dgvUpNext.RowHeadersWidth = 51;
            this.dgvUpNext.RowTemplate.Height = 24;
            this.dgvUpNext.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUpNext.Size = new System.Drawing.Size(240, 150);
            this.dgvUpNext.TabIndex = 4;
            // 
            // DaashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvUpNext);
            this.Controls.Add(this.btn2next);
            this.Controls.Add(this.btn1back);
            this.Controls.Add(this.lb2chair);
            this.Controls.Add(this.lb1chair);
            this.Name = "DaashBoard";
            this.Text = "DaashBoard";
            ((System.ComponentModel.ISupportInitialize)(this.dgvUpNext)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb1chair;
        private System.Windows.Forms.Label lb2chair;
        private System.Windows.Forms.Button btn1back;
        private System.Windows.Forms.Button btn2next;
        private System.Windows.Forms.DataGridView dgvUpNext;
    }
}