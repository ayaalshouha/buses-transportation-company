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

namespace transportation_system.Monthly_Exchange
{
    public partial class FrmAddEditMonthlyExchange : Form
    {
        private enum enMode { add , update}; 
        private enMode _Mode = enMode.add;
        private int exchange_id = -1;
        public FrmAddEditMonthlyExchange(int exchangeID = -1)
        {
            InitializeComponent();
            exchange_id = exchangeID;
            _Mode = exchange_id == -1 ? enMode.add : enMode.update;
        }

        private void _DefaultValues()
        {
            dateTimePicker1.Value = DateTime.MinValue; 
            backupValue.ReadOnly = true;
            salaryValue.ReadOnly = true;
        }
        private void _ResetValues()
        {
            backupValue.ReadOnly = false;
            salaryValue.ReadOnly = false;
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren())
                return;

            if (MessageBox.Show("هل انت متأكد انك تريد الحفظ؟", "Message Box", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                monthlyExchange exchange = new monthlyExchange();
                //exchange.TotalAmountPerMonth = 
                /* exchange.TotalAmountPerMonth = total.Value;
                exchange.DailyFuel = FuelValue.Value;
                exchange.DailyRepair = repairValue.Value;
                exchange.WorkerPay = workerPayValue.Value;
                exchange.CompanyPay = companyPayValue.Value;
                exchange.BusNumber = rdBusOne.Checked ? 1 : 2;
                exchange.Date = dateTimePicker1.Value;
                exchange.MiscCost = miscValue.Value;*/
                
                if (exchange.Save())
                {
                    MessageBox.Show("تم حفظ البيانات بنجاح.", "Message Box", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtNetAmount.Visible = true;
                    lblNetAmount.Visible = true;
                    txtNetAmount.Text = exchange.NetAmount.ToString();
                    btnSave.Enabled = false;
                }
                else
                {
                    MessageBox.Show("حدث خطأ ما، يرجى المحاولة مرة أخرى لاحقاً.", "Message Box", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("تم الغاء العملية", "Message Box", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
         private void salaryValue_Validating(object sender, CancelEventArgs e)
        {
            if(salaryValue.Value == 0)
            {
                errorProvider1.SetError(salaryValue, "الرجاء ادخال راتب الموظف!");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(salaryValue, ""); 
            }
         }

        private void FrmAddEditMonthlyExchange_Load(object sender, EventArgs e)
        {
            if (_Mode == enMode.add)
            {
                _DefaultValues();
            }

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            // check if already exist by month 
            int month = dateTimePicker1.Value.Month;
            if (monthlyExchange.isExist(month))
            {
                MessageBox.Show("الشهر المحدد موجود مسبقاً !! ", "Message Box", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                _ResetValues();
            }
        }
    }
}
