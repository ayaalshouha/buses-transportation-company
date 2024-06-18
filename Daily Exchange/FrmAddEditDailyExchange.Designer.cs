namespace transportation_system.Daily_Exchange
{
    partial class FrmAddEditDailyExchange
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
            this.mainlbl = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.rdBusOne = new System.Windows.Forms.RadioButton();
            this.rdBusTwo = new System.Windows.Forms.RadioButton();
            this.lblNetAmount = new System.Windows.Forms.Label();
            this.txtNetAmount = new System.Windows.Forms.MaskedTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.totalValue = new System.Windows.Forms.NumericUpDown();
            this.FuelValue = new System.Windows.Forms.NumericUpDown();
            this.repairValue = new System.Windows.Forms.NumericUpDown();
            this.workerPayValue = new System.Windows.Forms.NumericUpDown();
            this.companyPayValue = new System.Windows.Forms.NumericUpDown();
            this.miscValue = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.totalValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FuelValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repairValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workerPayValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyPayValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.miscValue)).BeginInit();
            this.SuspendLayout();
            // 
            // mainlbl
            // 
            this.mainlbl.AutoSize = true;
            this.mainlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainlbl.Location = new System.Drawing.Point(423, 8);
            this.mainlbl.Name = "mainlbl";
            this.mainlbl.Size = new System.Drawing.Size(273, 46);
            this.mainlbl.TabIndex = 0;
            this.mainlbl.Text = "اضافة صرف يومي";
            this.mainlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(909, 515);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(164, 65);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "حفظ";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 126);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(214, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "ادخل المبلغ كاملاَ: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(47, 189);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(187, 37);
            this.label2.TabIndex = 3;
            this.label2.Text = "صرف الديزل : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(47, 252);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(221, 37);
            this.label3.TabIndex = 4;
            this.label3.Text = "صرف الاصلاحات:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(47, 315);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(158, 37);
            this.label4.TabIndex = 5;
            this.label4.Text = "اجرة العامل: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(47, 378);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(167, 37);
            this.label5.TabIndex = 6;
            this.label5.Text = "اجرة الشركة: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(47, 486);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label6.Size = new System.Drawing.Size(145, 37);
            this.label6.TabIndex = 7;
            this.label6.Text = "رقم الباص: ";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(263, 545);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(180, 30);
            this.dateTimePicker1.TabIndex = 8;
            this.dateTimePicker1.Value = new System.DateTime(2024, 6, 4, 22, 28, 54, 0);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(47, 545);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label7.Size = new System.Drawing.Size(106, 37);
            this.label7.TabIndex = 9;
            this.label7.Text = "التاريخ: ";
            // 
            // rdBusOne
            // 
            this.rdBusOne.AutoSize = true;
            this.rdBusOne.Checked = true;
            this.rdBusOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdBusOne.Location = new System.Drawing.Point(365, 483);
            this.rdBusOne.Name = "rdBusOne";
            this.rdBusOne.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rdBusOne.Size = new System.Drawing.Size(78, 33);
            this.rdBusOne.TabIndex = 10;
            this.rdBusOne.TabStop = true;
            this.rdBusOne.Text = "الاول";
            this.rdBusOne.UseVisualStyleBackColor = true;
            // 
            // rdBusTwo
            // 
            this.rdBusTwo.AutoSize = true;
            this.rdBusTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdBusTwo.Location = new System.Drawing.Point(274, 483);
            this.rdBusTwo.Name = "rdBusTwo";
            this.rdBusTwo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rdBusTwo.Size = new System.Drawing.Size(80, 33);
            this.rdBusTwo.TabIndex = 11;
            this.rdBusTwo.Text = "الثاني";
            this.rdBusTwo.UseVisualStyleBackColor = true;
            // 
            // lblNetAmount
            // 
            this.lblNetAmount.AutoSize = true;
            this.lblNetAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNetAmount.ForeColor = System.Drawing.Color.Maroon;
            this.lblNetAmount.Location = new System.Drawing.Point(723, 114);
            this.lblNetAmount.Name = "lblNetAmount";
            this.lblNetAmount.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblNetAmount.Size = new System.Drawing.Size(154, 37);
            this.lblNetAmount.TabIndex = 17;
            this.lblNetAmount.Text = "صافي المبلغ:";
            // 
            // txtNetAmount
            // 
            this.txtNetAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNetAmount.ForeColor = System.Drawing.Color.Maroon;
            this.txtNetAmount.Location = new System.Drawing.Point(945, 120);
            this.txtNetAmount.Mask = "00000";
            this.txtNetAmount.Name = "txtNetAmount";
            this.txtNetAmount.ReadOnly = true;
            this.txtNetAmount.Size = new System.Drawing.Size(137, 30);
            this.txtNetAmount.TabIndex = 18;
            this.txtNetAmount.ValidatingType = typeof(int);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::transportation_system.Properties.Resources._1;
            this.pictureBox1.Location = new System.Drawing.Point(730, 215);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(343, 239);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // totalValue
            // 
            this.totalValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalValue.Location = new System.Drawing.Point(323, 126);
            this.totalValue.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.totalValue.Name = "totalValue";
            this.totalValue.Size = new System.Drawing.Size(120, 30);
            this.totalValue.TabIndex = 20;
            // 
            // FuelValue
            // 
            this.FuelValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FuelValue.Location = new System.Drawing.Point(323, 189);
            this.FuelValue.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.FuelValue.Name = "FuelValue";
            this.FuelValue.Size = new System.Drawing.Size(120, 30);
            this.FuelValue.TabIndex = 21;
            // 
            // repairValue
            // 
            this.repairValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.repairValue.Location = new System.Drawing.Point(323, 252);
            this.repairValue.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.repairValue.Name = "repairValue";
            this.repairValue.Size = new System.Drawing.Size(120, 30);
            this.repairValue.TabIndex = 22;
            // 
            // workerPayValue
            // 
            this.workerPayValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.workerPayValue.Location = new System.Drawing.Point(323, 315);
            this.workerPayValue.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.workerPayValue.Name = "workerPayValue";
            this.workerPayValue.Size = new System.Drawing.Size(120, 30);
            this.workerPayValue.TabIndex = 23;
            // 
            // companyPayValue
            // 
            this.companyPayValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.companyPayValue.Location = new System.Drawing.Point(323, 378);
            this.companyPayValue.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.companyPayValue.Name = "companyPayValue";
            this.companyPayValue.Size = new System.Drawing.Size(120, 30);
            this.companyPayValue.TabIndex = 24;
            // 
            // miscValue
            // 
            this.miscValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.miscValue.Location = new System.Drawing.Point(323, 436);
            this.miscValue.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.miscValue.Name = "miscValue";
            this.miscValue.Size = new System.Drawing.Size(120, 30);
            this.miscValue.TabIndex = 26;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(47, 436);
            this.label8.Name = "label8";
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label8.Size = new System.Drawing.Size(164, 37);
            this.label8.TabIndex = 25;
            this.label8.Text = " نفقات متفرقة:";
            // 
            // FrmAddEditDailyExchange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1119, 648);
            this.Controls.Add(this.miscValue);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.companyPayValue);
            this.Controls.Add(this.workerPayValue);
            this.Controls.Add(this.repairValue);
            this.Controls.Add(this.FuelValue);
            this.Controls.Add(this.totalValue);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtNetAmount);
            this.Controls.Add(this.lblNetAmount);
            this.Controls.Add(this.rdBusTwo);
            this.Controls.Add(this.rdBusOne);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.mainlbl);
            this.Name = "FrmAddEditDailyExchange";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "اضافة صرف يومي";
            this.Load += new System.EventHandler(this.FrmAddEditDailyExchange_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.totalValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FuelValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repairValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workerPayValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyPayValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.miscValue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label mainlbl;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton rdBusOne;
        private System.Windows.Forms.RadioButton rdBusTwo;
        private System.Windows.Forms.Label lblNetAmount;
        private System.Windows.Forms.MaskedTextBox txtNetAmount;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.NumericUpDown totalValue;
        private System.Windows.Forms.NumericUpDown FuelValue;
        private System.Windows.Forms.NumericUpDown repairValue;
        private System.Windows.Forms.NumericUpDown workerPayValue;
        private System.Windows.Forms.NumericUpDown companyPayValue;
        private System.Windows.Forms.NumericUpDown miscValue;
        private System.Windows.Forms.Label label8;
    }
}