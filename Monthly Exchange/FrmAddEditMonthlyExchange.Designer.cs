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
            this.salaryValue = new System.Windows.Forms.NumericUpDown();
            this.backupValue = new System.Windows.Forms.NumericUpDown();
            this.txtNetAmount = new System.Windows.Forms.MaskedTextBox();
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
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.akefPercent = new System.Windows.Forms.MaskedTextBox();
            this.waleedPercent = new System.Windows.Forms.MaskedTextBox();
            this.khaldounPercent = new System.Windows.Forms.MaskedTextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.totalAmount = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.salaryValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.backupValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // salaryValue
            // 
            this.salaryValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salaryValue.Location = new System.Drawing.Point(401, 274);
            this.salaryValue.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.salaryValue.Name = "salaryValue";
            this.salaryValue.Size = new System.Drawing.Size(180, 30);
            this.salaryValue.TabIndex = 43;
            this.salaryValue.Validating += new System.ComponentModel.CancelEventHandler(this.salaryValue_Validating);
            // 
            // backupValue
            // 
            this.backupValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backupValue.Location = new System.Drawing.Point(401, 211);
            this.backupValue.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.backupValue.Name = "backupValue";
            this.backupValue.Size = new System.Drawing.Size(180, 30);
            this.backupValue.TabIndex = 42;
            // 
            // txtNetAmount
            // 
            this.txtNetAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNetAmount.ForeColor = System.Drawing.Color.Maroon;
            this.txtNetAmount.Location = new System.Drawing.Point(401, 342);
            this.txtNetAmount.Mask = "00000";
            this.txtNetAmount.Name = "txtNetAmount";
            this.txtNetAmount.ReadOnly = true;
            this.txtNetAmount.Size = new System.Drawing.Size(180, 30);
            this.txtNetAmount.TabIndex = 40;
            this.txtNetAmount.ValidatingType = typeof(int);
            // 
            // lblNetAmount
            // 
            this.lblNetAmount.AutoSize = true;
            this.lblNetAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNetAmount.ForeColor = System.Drawing.Color.Maroon;
            this.lblNetAmount.Location = new System.Drawing.Point(42, 335);
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
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(913, 509);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(164, 65);
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
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(414, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(291, 46);
            this.label9.TabIndex = 49;
            this.label9.Text = "اضافة صرف شهري";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // akefPercent
            // 
            this.akefPercent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.akefPercent.ForeColor = System.Drawing.Color.Maroon;
            this.akefPercent.Location = new System.Drawing.Point(401, 406);
            this.akefPercent.Mask = "00000";
            this.akefPercent.Name = "akefPercent";
            this.akefPercent.ReadOnly = true;
            this.akefPercent.Size = new System.Drawing.Size(180, 30);
            this.akefPercent.TabIndex = 50;
            this.akefPercent.ValidatingType = typeof(int);
            // 
            // waleedPercent
            // 
            this.waleedPercent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.waleedPercent.ForeColor = System.Drawing.Color.Maroon;
            this.waleedPercent.Location = new System.Drawing.Point(401, 470);
            this.waleedPercent.Mask = "00000";
            this.waleedPercent.Name = "waleedPercent";
            this.waleedPercent.ReadOnly = true;
            this.waleedPercent.Size = new System.Drawing.Size(180, 30);
            this.waleedPercent.TabIndex = 51;
            this.waleedPercent.ValidatingType = typeof(int);
            // 
            // khaldounPercent
            // 
            this.khaldounPercent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.khaldounPercent.ForeColor = System.Drawing.Color.Maroon;
            this.khaldounPercent.Location = new System.Drawing.Point(401, 532);
            this.khaldounPercent.Mask = "00000";
            this.khaldounPercent.Name = "khaldounPercent";
            this.khaldounPercent.ReadOnly = true;
            this.khaldounPercent.Size = new System.Drawing.Size(180, 30);
            this.khaldounPercent.TabIndex = 52;
            this.khaldounPercent.ValidatingType = typeof(int);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // totalAmount
            // 
            this.totalAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalAmount.ForeColor = System.Drawing.Color.Maroon;
            this.totalAmount.Location = new System.Drawing.Point(940, 158);
            this.totalAmount.Mask = "00000";
            this.totalAmount.Name = "totalAmount";
            this.totalAmount.ReadOnly = true;
            this.totalAmount.Size = new System.Drawing.Size(137, 30);
            this.totalAmount.TabIndex = 54;
            this.totalAmount.ValidatingType = typeof(int);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(727, 151);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(209, 37);
            this.label1.TabIndex = 53;
            this.label1.Text = "صافي مبلغ الشهر:";
            // 
            // FrmAddEditMonthlyExchange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1119, 648);
            this.Controls.Add(this.totalAmount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.khaldounPercent);
            this.Controls.Add(this.waleedPercent);
            this.Controls.Add(this.akefPercent);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.salaryValue);
            this.Controls.Add(this.backupValue);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtNetAmount);
            this.Controls.Add(this.lblNetAmount);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.mainlbl);
            this.Name = "FrmAddEditMonthlyExchange";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAddEditMonthlyExchange";
            this.Load += new System.EventHandler(this.FrmAddEditMonthlyExchange_Load);
            ((System.ComponentModel.ISupportInitialize)(this.salaryValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.backupValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.NumericUpDown salaryValue;
        private System.Windows.Forms.NumericUpDown backupValue;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MaskedTextBox txtNetAmount;
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
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MaskedTextBox akefPercent;
        private System.Windows.Forms.MaskedTextBox waleedPercent;
        private System.Windows.Forms.MaskedTextBox khaldounPercent;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.MaskedTextBox totalAmount;
        private System.Windows.Forms.Label label1;
    }
}