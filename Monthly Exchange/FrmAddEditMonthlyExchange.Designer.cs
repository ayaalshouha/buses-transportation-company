namespace transportation_system.Monthly_Exchange
{
    partial class FrmAddEditMonthlyExchange
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
            this.components = new System.ComponentModel.Container();
            this.lblNetAmount = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.mainlbl = new System.Windows.Forms.Label();
            this.lblHeader = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.lbltotal = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.khaldounPercent = new System.Windows.Forms.Label();
            this.waleedPercent = new System.Windows.Forms.Label();
            this.akefPercent = new System.Windows.Forms.Label();
            this.txtNetAmount = new System.Windows.Forms.Label();
            this.txtSalary = new System.Windows.Forms.MaskedTextBox();
            this.txtBackup = new System.Windows.Forms.MaskedTextBox();
            this.totalAmountPerMonth = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblNote = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNetAmount
            // 
            this.lblNetAmount.AutoSize = true;
            this.lblNetAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNetAmount.ForeColor = System.Drawing.Color.Maroon;
            this.lblNetAmount.Location = new System.Drawing.Point(415, 247);
            this.lblNetAmount.Name = "lblNetAmount";
            this.lblNetAmount.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblNetAmount.Size = new System.Drawing.Size(154, 37);
            this.lblNetAmount.TabIndex = 39;
            this.lblNetAmount.Text = "صافي المبلغ:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(42, 144);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label7.Size = new System.Drawing.Size(106, 37);
            this.label7.TabIndex = 36;
            this.label7.Text = "التاريخ: ";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(401, 151);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(180, 30);
            this.dateTimePicker1.TabIndex = 35;
            this.dateTimePicker1.Value = new System.DateTime(2024, 6, 4, 22, 28, 54, 0);
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Maroon;
            this.label5.Location = new System.Drawing.Point(42, 526);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(137, 37);
            this.label5.TabIndex = 33;
            this.label5.Text = "نسبة خلدون";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Maroon;
            this.label4.Location = new System.Drawing.Point(42, 463);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(129, 37);
            this.label4.TabIndex = 32;
            this.label4.Text = "نسبة وليد: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(42, 400);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(151, 37);
            this.label3.TabIndex = 31;
            this.label3.Text = "نسبة عاكف: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(42, 267);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(257, 37);
            this.label2.TabIndex = 30;
            this.label2.Text = "راتب الموظف الشهري";
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.Location = new System.Drawing.Point(42, 204);
            this.lbl.Name = "lbl";
            this.lbl.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl.Size = new System.Drawing.Size(321, 37);
            this.lbl.TabIndex = 29;
            this.lbl.Text = "ادخل مبلغ الاحتياط الشهري: ";
            // 
            // btnSave
            // 
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(937, 493);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(140, 65);
            this.btnSave.TabIndex = 28;
            this.btnSave.Text = "حفظ";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // mainlbl
            // 
            this.mainlbl.AutoSize = true;
            this.mainlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainlbl.Location = new System.Drawing.Point(249, -53);
            this.mainlbl.Name = "mainlbl";
            this.mainlbl.Size = new System.Drawing.Size(273, 46);
            this.mainlbl.TabIndex = 27;
            this.mainlbl.Text = "اضافة صرف يومي";
            this.mainlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(414, 18);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(291, 46);
            this.lblHeader.TabIndex = 49;
            this.lblHeader.Text = "اضافة صرف شهري";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::transportation_system.Properties.Resources._1;
            this.pictureBox1.Location = new System.Drawing.Point(734, 233);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(343, 239);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 41;
            this.pictureBox1.TabStop = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // lbltotal
            // 
            this.lbltotal.AutoSize = true;
            this.lbltotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotal.ForeColor = System.Drawing.Color.Maroon;
            this.lbltotal.Location = new System.Drawing.Point(685, 185);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbltotal.Size = new System.Drawing.Size(270, 32);
            this.lbltotal.TabIndex = 53;
            this.lbltotal.Text = "صافي مبلغ الشهر للباصين :";
            this.lbltotal.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.khaldounPercent);
            this.groupBox1.Controls.Add(this.waleedPercent);
            this.groupBox1.Controls.Add(this.akefPercent);
            this.groupBox1.Controls.Add(this.txtNetAmount);
            this.groupBox1.Controls.Add(this.lblNetAmount);
            this.groupBox1.Controls.Add(this.txtSalary);
            this.groupBox1.Controls.Add(this.txtBackup);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(22, 88);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(589, 535);
            this.groupBox1.TabIndex = 55;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "المعلومات";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Maroon;
            this.label10.Location = new System.Drawing.Point(55, 438);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 37);
            this.label10.TabIndex = 64;
            this.label10.Text = "د.أ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Maroon;
            this.label8.Location = new System.Drawing.Point(55, 375);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 37);
            this.label8.TabIndex = 63;
            this.label8.Text = "د.أ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Maroon;
            this.label6.Location = new System.Drawing.Point(55, 312);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 37);
            this.label6.TabIndex = 62;
            this.label6.Text = "د.أ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(55, 247);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 37);
            this.label1.TabIndex = 61;
            this.label1.Text = "د.أ";
            // 
            // khaldounPercent
            // 
            this.khaldounPercent.AutoSize = true;
            this.khaldounPercent.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.khaldounPercent.ForeColor = System.Drawing.Color.Maroon;
            this.khaldounPercent.Location = new System.Drawing.Point(117, 438);
            this.khaldounPercent.Name = "khaldounPercent";
            this.khaldounPercent.Size = new System.Drawing.Size(78, 32);
            this.khaldounPercent.TabIndex = 60;
            this.khaldounPercent.Text = "[???]";
            // 
            // waleedPercent
            // 
            this.waleedPercent.AutoSize = true;
            this.waleedPercent.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.waleedPercent.ForeColor = System.Drawing.Color.Maroon;
            this.waleedPercent.Location = new System.Drawing.Point(117, 375);
            this.waleedPercent.Name = "waleedPercent";
            this.waleedPercent.Size = new System.Drawing.Size(78, 32);
            this.waleedPercent.TabIndex = 59;
            this.waleedPercent.Text = "[???]";
            // 
            // akefPercent
            // 
            this.akefPercent.AutoSize = true;
            this.akefPercent.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.akefPercent.ForeColor = System.Drawing.Color.Maroon;
            this.akefPercent.Location = new System.Drawing.Point(117, 312);
            this.akefPercent.Name = "akefPercent";
            this.akefPercent.Size = new System.Drawing.Size(78, 32);
            this.akefPercent.TabIndex = 58;
            this.akefPercent.Text = "[???]";
            // 
            // txtNetAmount
            // 
            this.txtNetAmount.AutoSize = true;
            this.txtNetAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNetAmount.ForeColor = System.Drawing.Color.Maroon;
            this.txtNetAmount.Location = new System.Drawing.Point(117, 247);
            this.txtNetAmount.Name = "txtNetAmount";
            this.txtNetAmount.Size = new System.Drawing.Size(78, 32);
            this.txtNetAmount.TabIndex = 57;
            this.txtNetAmount.Text = "[???]";
            // 
            // txtSalary
            // 
            this.txtSalary.Location = new System.Drawing.Point(30, 184);
            this.txtSalary.Mask = "00000";
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(180, 32);
            this.txtSalary.TabIndex = 57;
            this.txtSalary.ValidatingType = typeof(int);
            // 
            // txtBackup
            // 
            this.txtBackup.Location = new System.Drawing.Point(30, 126);
            this.txtBackup.Mask = "00000";
            this.txtBackup.Name = "txtBackup";
            this.txtBackup.Size = new System.Drawing.Size(180, 32);
            this.txtBackup.TabIndex = 56;
            this.txtBackup.ValidatingType = typeof(int);
            // 
            // totalAmountPerMonth
            // 
            this.totalAmountPerMonth.AutoSize = true;
            this.totalAmountPerMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalAmountPerMonth.ForeColor = System.Drawing.Color.Maroon;
            this.totalAmountPerMonth.Location = new System.Drawing.Point(961, 185);
            this.totalAmountPerMonth.Name = "totalAmountPerMonth";
            this.totalAmountPerMonth.Size = new System.Drawing.Size(78, 32);
            this.totalAmountPerMonth.TabIndex = 56;
            this.totalAmountPerMonth.Text = "[???]";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Maroon;
            this.label9.Location = new System.Drawing.Point(1045, 185);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 37);
            this.label9.TabIndex = 57;
            this.label9.Text = "د.أ";
            // 
            // lblNote
            // 
            this.lblNote.AutoSize = true;
            this.lblNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNote.ForeColor = System.Drawing.Color.Maroon;
            this.lblNote.Location = new System.Drawing.Point(617, 153);
            this.lblNote.Name = "lblNote";
            this.lblNote.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblNote.Size = new System.Drawing.Size(194, 25);
            this.lblNote.TabIndex = 58;
            this.lblNote.Text = "** لا يوجد رصيد لهذا الشهر";
            this.lblNote.Visible = false;
            // 
            // FrmAddEditMonthlyExchange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1119, 648);
            this.Controls.Add(this.lblNote);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.totalAmountPerMonth);
            this.Controls.Add(this.lbltotal);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.mainlbl);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmAddEditMonthlyExchange";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "اضافة/تعديل صرف شهري";
            this.Load += new System.EventHandler(this.FrmAddEditMonthlyExchange_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblNetAmount;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label mainlbl;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label lbltotal;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox txtSalary;
        private System.Windows.Forms.MaskedTextBox txtBackup;
        private System.Windows.Forms.Label totalAmountPerMonth;
        private System.Windows.Forms.Label khaldounPercent;
        private System.Windows.Forms.Label waleedPercent;
        private System.Windows.Forms.Label akefPercent;
        private System.Windows.Forms.Label txtNetAmount;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblNote;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
    }
}