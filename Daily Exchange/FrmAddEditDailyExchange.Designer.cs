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
            this.lblHeader = new System.Windows.Forms.Label();
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.totalAmount = new System.Windows.Forms.MaskedTextBox();
            this.fuelValue = new System.Windows.Forms.MaskedTextBox();
            this.repairValue = new System.Windows.Forms.MaskedTextBox();
            this.workerPayValue = new System.Windows.Forms.MaskedTextBox();
            this.companyValue = new System.Windows.Forms.MaskedTextBox();
            this.miscCostValue = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdBusThree = new System.Windows.Forms.RadioButton();
            this.txtNetAmount = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtRepairNotes = new System.Windows.Forms.RichTextBox();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(423, 19);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(273, 46);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "اضافة صرف يومي";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSave
            // 
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(818, 604);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(119, 65);
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
            this.label2.Location = new System.Drawing.Point(47, 185);
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
            this.label3.Location = new System.Drawing.Point(47, 244);
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
            this.label4.Location = new System.Drawing.Point(47, 303);
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
            this.label5.Location = new System.Drawing.Point(47, 362);
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
            this.label6.Location = new System.Drawing.Point(47, 480);
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
            this.dateTimePicker1.Location = new System.Drawing.Point(95, 540);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(163, 30);
            this.dateTimePicker1.TabIndex = 8;
            this.dateTimePicker1.Value = new System.DateTime(2024, 6, 4, 22, 28, 54, 0);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(428, 533);
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
            this.rdBusOne.Location = new System.Drawing.Point(188, 395);
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
            this.rdBusTwo.Location = new System.Drawing.Point(102, 395);
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
            this.lblNetAmount.Location = new System.Drawing.Point(761, 164);
            this.lblNetAmount.Name = "lblNetAmount";
            this.lblNetAmount.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblNetAmount.Size = new System.Drawing.Size(154, 37);
            this.lblNetAmount.TabIndex = 17;
            this.lblNetAmount.Text = "صافي المبلغ:";
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
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(47, 421);
            this.label8.Name = "label8";
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label8.Size = new System.Drawing.Size(164, 37);
            this.label8.TabIndex = 25;
            this.label8.Text = " نفقات متفرقة:";
            // 
            // totalAmount
            // 
            this.totalAmount.Location = new System.Drawing.Point(323, 131);
            this.totalAmount.Mask = "00000";
            this.totalAmount.Name = "totalAmount";
            this.totalAmount.Size = new System.Drawing.Size(163, 26);
            this.totalAmount.TabIndex = 27;
            this.totalAmount.ValidatingType = typeof(int);
            // 
            // fuelValue
            // 
            this.fuelValue.Location = new System.Drawing.Point(323, 190);
            this.fuelValue.Mask = "00000";
            this.fuelValue.Name = "fuelValue";
            this.fuelValue.Size = new System.Drawing.Size(163, 26);
            this.fuelValue.TabIndex = 28;
            this.fuelValue.ValidatingType = typeof(int);
            // 
            // repairValue
            // 
            this.repairValue.Location = new System.Drawing.Point(323, 249);
            this.repairValue.Mask = "00000";
            this.repairValue.Name = "repairValue";
            this.repairValue.Size = new System.Drawing.Size(163, 26);
            this.repairValue.TabIndex = 29;
            this.repairValue.ValidatingType = typeof(int);
            // 
            // workerPayValue
            // 
            this.workerPayValue.Location = new System.Drawing.Point(323, 308);
            this.workerPayValue.Mask = "00000";
            this.workerPayValue.Name = "workerPayValue";
            this.workerPayValue.Size = new System.Drawing.Size(163, 26);
            this.workerPayValue.TabIndex = 30;
            this.workerPayValue.ValidatingType = typeof(int);
            // 
            // companyValue
            // 
            this.companyValue.Location = new System.Drawing.Point(323, 367);
            this.companyValue.Mask = "00000";
            this.companyValue.Name = "companyValue";
            this.companyValue.Size = new System.Drawing.Size(163, 26);
            this.companyValue.TabIndex = 31;
            this.companyValue.ValidatingType = typeof(int);
            // 
            // miscCostValue
            // 
            this.miscCostValue.Location = new System.Drawing.Point(323, 426);
            this.miscCostValue.Mask = "00000";
            this.miscCostValue.Name = "miscCostValue";
            this.miscCostValue.Size = new System.Drawing.Size(163, 26);
            this.miscCostValue.TabIndex = 32;
            this.miscCostValue.ValidatingType = typeof(int);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtRepairNotes);
            this.groupBox1.Controls.Add(this.rdBusThree);
            this.groupBox1.Controls.Add(this.rdBusOne);
            this.groupBox1.Controls.Add(this.rdBusTwo);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(37, 85);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(544, 598);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "المعلومات";
            // 
            // rdBusThree
            // 
            this.rdBusThree.AutoSize = true;
            this.rdBusThree.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdBusThree.Location = new System.Drawing.Point(16, 395);
            this.rdBusThree.Name = "rdBusThree";
            this.rdBusThree.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rdBusThree.Size = new System.Drawing.Size(82, 33);
            this.rdBusThree.TabIndex = 37;
            this.rdBusThree.Text = "الثالث";
            this.rdBusThree.UseVisualStyleBackColor = true;
            // 
            // txtNetAmount
            // 
            this.txtNetAmount.AutoSize = true;
            this.txtNetAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNetAmount.ForeColor = System.Drawing.Color.Maroon;
            this.txtNetAmount.Location = new System.Drawing.Point(919, 164);
            this.txtNetAmount.Name = "txtNetAmount";
            this.txtNetAmount.Size = new System.Drawing.Size(103, 37);
            this.txtNetAmount.TabIndex = 34;
            this.txtNetAmount.Text = "[????]";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Maroon;
            this.label9.Location = new System.Drawing.Point(1028, 164);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 37);
            this.label9.TabIndex = 35;
            this.label9.Text = "د.أ";
            // 
            // btnClear
            // 
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(943, 604);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(159, 65);
            this.btnClear.TabIndex = 36;
            this.btnClear.Text = "مسح الكل";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtRepairNotes
            // 
            this.txtRepairNotes.Location = new System.Drawing.Point(24, 440);
            this.txtRepairNotes.Name = "txtRepairNotes";
            this.txtRepairNotes.Size = new System.Drawing.Size(242, 75);
            this.txtRepairNotes.TabIndex = 38;
            this.txtRepairNotes.Text = "";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(274, 463);
            this.label10.Name = "label10";
            this.label10.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label10.Size = new System.Drawing.Size(260, 37);
            this.label10.TabIndex = 37;
            this.label10.Text = "ملاحظات الاصلاحات: ";
            // 
            // FrmAddEditDailyExchange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1119, 695);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtNetAmount);
            this.Controls.Add(this.miscCostValue);
            this.Controls.Add(this.companyValue);
            this.Controls.Add(this.workerPayValue);
            this.Controls.Add(this.repairValue);
            this.Controls.Add(this.fuelValue);
            this.Controls.Add(this.totalAmount);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblNetAmount);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmAddEditDailyExchange";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "اضافة/تعديل صرف يومي";
            this.Load += new System.EventHandler(this.FrmAddEditDailyExchange_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeader;
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
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox totalAmount;
        private System.Windows.Forms.MaskedTextBox fuelValue;
        private System.Windows.Forms.MaskedTextBox repairValue;
        private System.Windows.Forms.MaskedTextBox workerPayValue;
        private System.Windows.Forms.MaskedTextBox companyValue;
        private System.Windows.Forms.MaskedTextBox miscCostValue;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label txtNetAmount;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.RadioButton rdBusThree;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RichTextBox txtRepairNotes;
    }
}