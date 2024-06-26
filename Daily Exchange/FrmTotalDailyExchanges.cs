﻿using buisness_layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace transportation_system.Daily_Exchange
{
    public partial class FrmTotalDailyExchanges : Form
    {
        DataTable exch = null; 
        public FrmTotalDailyExchanges()
        {
            InitializeComponent();
        }

        private void _renameHeaders()
        {
            dataGridView1.Columns[0].Width = 40;
            dataGridView1.Columns[1].HeaderText = "المبلغ كامل";
            dataGridView1.Columns[2].HeaderText = "الاصلاحات";
            dataGridView1.Columns[3].HeaderText = "اجرة العامل";
            dataGridView1.Columns[4].HeaderText = "اجرة الشركة";
            dataGridView1.Columns[5].HeaderText = "ديزل ";
            dataGridView1.Columns[6].HeaderText = "صافي المبلغ";
            dataGridView1.Columns[7].HeaderText = "رقم الباص";
            dataGridView1.Columns[8].HeaderText = "التاريخ";
            dataGridView1.Columns[9].HeaderText = "نفقات اضافية";
        }
        private void _AddEditDeleteButtons()
        {
            DataGridViewButtonColumn editButton = new DataGridViewButtonColumn()
            {
                HeaderText = "تعديل",
                Text = "تعديل",
                UseColumnTextForButtonValue = true,
                Name = "Edit"
            };
            DataGridViewButtonColumn deleteButton = new DataGridViewButtonColumn()
            {
                HeaderText = "حذف",
                Text = "حذف",
                UseColumnTextForButtonValue = true,
                Name = "Delete",
            };
            dataGridView1.Columns.Add(editButton);
            dataGridView1.Columns.Add(deleteButton);
        }
        private void FrmTotalDailyExchanges_Load(object sender, EventArgs e)
        {
            exch = dailyExchange.DailyExchangeData();
            dataGridView1.DataSource = exch;
            lblRecords.Text = dataGridView1.RowCount.ToString();
            _renameHeaders();
            _AddEditDeleteButtons();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void _RefreshData()
        {
            exch = dailyExchange.DailyExchangeData();
            dataGridView1.DataSource = exch;
            lblRecords.Text = dataGridView1.RowCount.ToString();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                string ColumnName = dataGridView1.Columns[e.ColumnIndex].Name;
                int ExchangeID = (int)dataGridView1["ID", e.RowIndex].Value;

                if (ColumnName == "Edit")
                {
                    //edit coode
                    FrmAddEditDailyExchange frm = new FrmAddEditDailyExchange(ExchangeID);
                    frm.ShowDialog();
                    //refresh dataSource
                    _RefreshData();

                }
                else if (ColumnName == "Delete")
                {
                    //delete code
                    if (MessageBox.Show("هل انت متأكد انك تريد اتمام عملية الحذف؟  ملاحظة: المعلومات غير قابلة للاسترداد لاحقاَ !", "Message Box", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading) == DialogResult.Yes)
                    {
                        dailyExchange exch = dailyExchange.Find(ExchangeID);
                        if (exch != null)
                        {
                            if (exch.Delete())
                                MessageBox.Show("تمت عملية الحذف بنجاح.", "Message Box", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading);
                            else
                                MessageBox.Show("حدث خطأ ما اثناء الحذف، يرجى المحاولة مرة أخرى لاحقاً.", "Message Box", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading);
                           
                            _RefreshData();
                        }
                        else
                            MessageBox.Show("البيانات المراد حذفها غير متوفرة يرجى المحاولة لاحقاَ", "Message Box", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading);
                    }
                    else
                        MessageBox.Show("تم الغاء عملية الحذف بنجاح", "Message Box", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading);
                }
               
            }
        }



    }
}
