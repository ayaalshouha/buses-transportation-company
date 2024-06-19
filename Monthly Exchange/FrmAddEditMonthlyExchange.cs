using buisness_layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using transportation_system.Global;

namespace transportation_system.Monthly_Exchange
{
    public partial class FrmAddEditMonthlyExchange : Form
    {
        private enum enMode { add , update}; 
        private enMode _Mode = enMode.add;
        private monthlyExchange exchange = null; 
        private int exchange_id = -1;
        public FrmAddEditMonthlyExchange(int exchangeID = -1)
        {
            InitializeComponent();
            exchange_id = exchangeID;
            _Mode = exchange_id == -1 ? enMode.add : enMode.update;
        }

        private void _DisableElements()
        {
            if(_Mode == enMode.add)
            {
                txtBackup.Enabled = false;
                txtSalary.Enabled = false;
                lbltotal.Visible = false;
                totalAmountPerMonth.Visible = false;
            }
            else
            {
                txtBackup.Enabled = true;
                txtSalary.Enabled = true;
                lbltotal.Visible = true;
                totalAmountPerMonth.Visible = true;
            }
        }

        private void _EnableElements()
        {
            txtBackup.Enabled = true;
            txtSalary.Enabled = true;
            lbltotal.Visible = true;
            totalAmountPerMonth.Visible = true;
        }

        private void _AssignInsertedDataToExchange()
        {
            exchange.BackupAmount = Convert.ToDouble(txtBackup.Text); 
            exchange.WorkerSalary = Convert.ToDouble(txtSalary.Text);
           // string totalAmount = totalAmountPerMonth.Text.Trim('J' , 'P' ,'D');
            //exchange.TotalAmount = Convert.ToDouble(totalAmount);
            exchange.Date = dateTimePicker1.Value; 
        }
        private void _RetrieveData()
        {
            //صافي المبلغ لتوزيع النسب مع النسب
            txtNetAmount.Text = exchange.NetAmount.ToString();
            akefPercent.Text = exchange.AkefPercent.ToString();
            waleedPercent.Text = exchange.WaleedPercent.ToString();
            khaldounPercent.Text = exchange.khaldounPercent.ToString();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren())
                return;

            /* if (txtBackup.Enabled == false || txtSalary.Enabled == false)
                return;*/

            if (MessageBox.Show("هل انت متأكد انك تريد الحفظ؟", "Message Box", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading) == DialogResult.Yes)
            {
                if(_Mode == enMode.add)
                    exchange = new monthlyExchange();


                _AssignInsertedDataToExchange();
              
                if (exchange.Save())
                {
                    MessageBox.Show("تم حفظ البيانات بنجاح.", "Message Box", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading);

                    //retrieve data and update 
                    _RetrieveData();
                    btnSave.Enabled = false;
                }
                else
                    MessageBox.Show("حدث خطأ ما، يرجى المحاولة مرة أخرى لاحقاً.", "Message Box", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading);
            }
            else
                MessageBox.Show("تم الغاء العملية", "Message Box", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading);
        }
        private void salaryValue_Validating(object sender, CancelEventArgs e)
        {
            if (Convert.ToInt32(txtSalary.Text) == 0)
            {
                errorProvider1.SetError(txtSalary, "الرجاء ادخال راتب الموظف!");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txtSalary, "");
            }
        }
        private void _FillExchangeDataIntoForm()
        {
            if (exchange != null && _Mode == enMode.update)
            {
                totalAmountPerMonth.Text = exchange.TotalAmount.ToString();
                dateTimePicker1.Value = exchange.Date;
                txtBackup.Text = exchange.BackupAmount.ToString();
                txtSalary.Text = exchange.WorkerSalary.ToString();
                txtNetAmount.Text = exchange.NetAmount.ToString();
                akefPercent.Text = exchange.AkefPercent.ToString();
                waleedPercent.Text = exchange.WaleedPercent.ToString();
                khaldounPercent.Text = exchange.khaldounPercent.ToString();
            }
        }

        private void FrmAddEditMonthlyExchange_Load(object sender, EventArgs e)
        {
            _DisableElements();

            if (_Mode == enMode.update)
            {
                lblHeader.Text = "تعديل صرف شهري";
                exchange = monthlyExchange.Find(exchange_id); 
                if(exchange!= null)
                    _FillExchangeDataIntoForm();
                else
                    MessageBox.Show("حدث خطأ أثناء تحميل معلومات الصرف يرجى المحاولة لاحقاَ", "Message Box",
                        MessageBoxButtons.OK, MessageBoxIcon.Error,
                        MessageBoxDefaultButton.Button1,
                        MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading);
            }
            else 
               
                lblHeader.Text = "اضافة صرف شهري";
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            // check if already exist by month 
            int month = dateTimePicker1.Value.Month;
            if (_Mode == enMode.add && monthlyExchange.isExist(month))
            {
                MessageBox.Show("الشهر المحدد موجود مسبقاً !! ", "Message Box", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading);
                return;
            }
            else
            {
                totalAmountPerMonth.Text = monthlyExchange.TotalAmountPerMonth(dateTimePicker1.Value).ToString() + "JOD";
                
                if (Convert.ToDouble(totalAmountPerMonth.Text) > 0)
                    _EnableElements();
                else
                    return; 
            }
        }
    }
}
