namespace transportation_system
{
    partial class frmBackupAmount
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblMoney = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Display", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(131, 27);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(467, 58);
            this.label1.TabIndex = 0;
            this.label1.Text = "مجموع الرصيد الاحتياطي : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(380, 193);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(72, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "التاريخ : ";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(274, 196);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(100, 22);
            this.lblDate.TabIndex = 3;
            this.lblDate.Text = "30/11/1997";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.BurlyWood;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 297);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(728, 39);
            this.panel1.TabIndex = 4;
            // 
            // lblMoney
            // 
            this.lblMoney.AutoSize = true;
            this.lblMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMoney.ForeColor = System.Drawing.Color.Maroon;
            this.lblMoney.Location = new System.Drawing.Point(266, 125);
            this.lblMoney.Name = "lblMoney";
            this.lblMoney.Size = new System.Drawing.Size(197, 37);
            this.lblMoney.TabIndex = 5;
            this.lblMoney.Text = "10.000 JOD";
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.BurlyWood;
            this.btnOK.Location = new System.Drawing.Point(308, 237);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(113, 44);
            this.btnOK.TabIndex = 6;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // frmBackupAmount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(728, 336);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.lblMoney);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmBackupAmount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Backup amount";
            this.Load += new System.EventHandler(this.frmBackupAmount_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblMoney;
        private System.Windows.Forms.Button btnOK;
    }
}