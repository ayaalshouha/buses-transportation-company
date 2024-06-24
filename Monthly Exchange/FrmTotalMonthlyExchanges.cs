using buisness_layer;
using System;
using System.Data;
using System.Windows.Forms;
using transportation_system.Daily_Exchange;

namespace transportation_system.Monthly_Exchange
{
    public partial class FrmTotalMonthlyExchanges : Form
    {
        private DataTable exchange = null; 
        public FrmTotalMonthlyExchanges()
        {
            InitializeComponent();
        }
        private void _renameHeaders()
        {
            if(dataGridView1.ColumnCount > 0)
            {
                dataGridView1.Columns[0].Width = 40;
                dataGridView1.Columns[1].HeaderText = "المبلغ كامل";
                dataGridView1.Columns[2].HeaderText = "مبلغ الاحتياط";
                dataGridView1.Columns[3].HeaderText = "راتب الموظف";
                dataGridView1.Columns[4].HeaderText = "صافي المبلغ";
                dataGridView1.Columns[5].HeaderText = "نسبة عاكف الشوحة";
                dataGridView1.Columns[6].HeaderText = "نسبة خلدون الشوحة";
                dataGridView1.Columns[7].HeaderText = "نسبة وليد الشوحة";
                dataGridView1.Columns[8].HeaderText = "التاريخ";
            }
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
        private void FrmTotalMonthlyExchanges_Load(object sender, EventArgs e)
        {
            exchange = monthlyExchange.MonthlyExchangeData();
            dataGridView1.DataSource = exchange;
            lblRecords.Text = dataGridView1.RowCount.ToString();
            _renameHeaders();
            _AddEditDeleteButtons();
        }
        private void _RefreshData()
        {
            exchange = monthlyExchange.MonthlyExchangeData();
            dataGridView1.DataSource = exchange;
            lblRecords.Text = dataGridView1.RowCount.ToString();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string ColumnName = dataGridView1.Columns[e.ColumnIndex].Name;
                int ExchangeID = (int)dataGridView1["ID", e.RowIndex].Value;

                if (ColumnName == "Edit")
                {
                    //edit coode
                    FrmAddEditMonthlyExchange frm = new FrmAddEditMonthlyExchange(ExchangeID);
                    frm.ShowDialog();
                    _RefreshData();
                }
                else if (ColumnName == "Delete")
                {
                    //delete code
                    if (MessageBox.Show("هل انت متأكد انك تريد اتمام عملية الحذف؟ ملاحظة: المعلومات غير قابلة للاسترداد لاحقاَ !", "Message Box", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading) == DialogResult.Yes)
                    {
                        monthlyExchange exch = monthlyExchange.Find(ExchangeID);
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
                    return;
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
