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

namespace transportation_system.Daily_Exchange
{
    public partial class FrmAddEditDailyExchange : Form
    {
        private enum enMode { add, update}
        private enMode mode = enMode.add;
        private int ExchangeID = -1;

        public FrmAddEditDailyExchange(int Exchange_ID =-1)
        {
            InitializeComponent();
            ExchangeID = Exchange_ID; 
            mode = ExchangeID == -1 ? enMode.add : enMode.update;
        }

        private void _ResetVisibleElements()
        {
            lblNetAmount.Visible = false;
            txtNetAmount.Visible = false;
            //btnSave.Visible = false;
        }

        private void FrmAddEditDailyExchange_Load(object sender, EventArgs e)
        {
            _ResetVisibleElements();


        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DateTime date = dateTimePicker1.Value;
            int busnumber = rdBusOne.Checked ? 1 : 2; 

            if (mode == enMode.add)
            {
                if(dailyExchange.isExist(date, busnumber))
                {
                    MessageBox.Show($"الصرف اليومي للباص {busnumber} موجود مسبقا ", "message box", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; 
                }
            }

            if(MessageBox.Show("هل انت متأكد انك تريد الحفظ؟", "Message Box", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                dailyExchange exchange = new dailyExchange();
                exchange.TotalAmount = totalValue.Value;
                exchange.DailyFuel = FuelValue.Value;
                exchange.DailyRepair = repairValue.Value;
                exchange.WorkerPay = workerPayValue.Value;
                exchange.CompanyPay = companyPayValue.Value;
                exchange.BusNumber = rdBusOne.Checked ? 1 : 2;
                exchange.Date = dateTimePicker1.Value;
                exchange.MiscCost = miscValue.Value; 

                if (exchange.Save())
                {
                    MessageBox.Show("تم حفظ البيانات بنجاح.", "Message Box", MessageBoxButtons.OK,MessageBoxIcon.Information );
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
    }
}
