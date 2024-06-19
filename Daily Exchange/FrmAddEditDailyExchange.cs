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
        private dailyExchange exchange = null; 
        private int exchangeID = -1;

        public FrmAddEditDailyExchange(int Exchange_ID =-1)
        {
            InitializeComponent();
            exchangeID = Exchange_ID; 
            mode = exchangeID == -1 ? enMode.add : enMode.update;
        }
        private void SetVisibleElements()
        {
            lblNetAmount.Visible = false;
            txtNetAmount.Visible = false;
            label9.Visible= false;
        }
        private void ResetVisibleElement()
        {
            lblNetAmount.Visible = true;
            txtNetAmount.Visible = true;
            label9.Visible = true;
        }
        private void _FillExchangeDataIntoForm()
        {
            if(exchange != null && mode == enMode.update)
            {
                totalAmount.Text = exchange.TotalAmount.ToString(); 
                fuelValue.Text  = exchange.DailyFuel.ToString();
                repairValue.Text = exchange.DailyRepair.ToString();
                workerPayValue.Text = exchange.WorkerPay.ToString();
                companyValue.Text = exchange.CompanyPay.ToString();
                miscCostValue.Text = exchange.MiscCost.ToString();

                if (exchange.BusNumber == 1)
                    rdBusOne.Checked = true; 
                else
                    rdBusTwo.Checked = true;

                dateTimePicker1.Value = exchange.Date;
                txtNetAmount.Text = exchange.NetAmount.ToString(); 
            }
        }

        private void FrmAddEditDailyExchange_Load(object sender, EventArgs e)
        {
            if(mode == enMode.update)
            {
                lblHeader.Text = "تعديل صرف يومي";
                ResetVisibleElement();
                exchange = dailyExchange.Find(exchangeID); 
                if(exchange != null)
                    _FillExchangeDataIntoForm();
                else
                    MessageBox.Show("حدث خطأ أثناء تحميل معلومات الصرف يرجى المحاولة لاحقاَ", "Message Box",
                        MessageBoxButtons.OK, MessageBoxIcon.Error,
                        MessageBoxDefaultButton.Button1,
                        MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading);
            }
            else
            {
                lblHeader.Text = "اضافة صرف يومي";
                dateTimePicker1.Value = DateTime.Now;
                SetVisibleElements();
            }
        }

        private void _AssignInsertedDataToExchange()
        {
            exchange.TotalAmount = Convert.ToDouble(totalAmount.Text);
            exchange.DailyFuel = Convert.ToDouble(fuelValue.Text);
            exchange.DailyRepair = Convert.ToDouble(repairValue.Text);
            exchange.WorkerPay = Convert.ToDouble(workerPayValue.Text);
            exchange.CompanyPay = Convert.ToDouble(companyValue.Text);
            exchange.BusNumber = rdBusOne.Checked ? 1 : 2;
            exchange.Date = dateTimePicker1.Value;
            exchange.MiscCost = Convert.ToDouble(miscCostValue.Text);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DateTime date = dateTimePicker1.Value.Date;
            int busnumber = rdBusOne.Checked ? 1 : 2; 

            if (mode == enMode.add)
            {
                if(dailyExchange.isExist(date, busnumber))
                {
                    MessageBox.Show($"الصرف اليومي للباص {busnumber} موجود مسبقا ", "message box", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading);
                    return; 
                }
            }
            if(MessageBox.Show("هل أنت متأكد أنك تريد الحفظ؟", "Message Box", MessageBoxButtons.YesNo, MessageBoxIcon.Question,MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading) == DialogResult.Yes)
            {
                int busNumber = rdBusOne.Checked? 1 : 2;

                

                if(mode == enMode.add)
                    exchange = new dailyExchange();


                _AssignInsertedDataToExchange();
                if (exchange.Save())
                {
                    MessageBox.Show("تم حفظ البيانات بنجاح.", "Message Box", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading);
                    ResetVisibleElement();
                    txtNetAmount.Text = exchange.NetAmount.ToString();
                    btnSave.Enabled = false;
                    exchangeID = exchange.ID; 
                }
                else
                    MessageBox.Show("حدث خطأ ما، يرجى المحاولة مرة أخرى لاحقاً.", "Message Box", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading);
            }
            else
                MessageBox.Show("تم إلغاء العملية بنجاح", "Message Box", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading);
        }
    }
}
