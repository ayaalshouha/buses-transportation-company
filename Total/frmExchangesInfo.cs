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

namespace transportation_system.Total
{
    public partial class frmExchangesInfo : Form
    {
        public frmExchangesInfo()
        {
            InitializeComponent();
        }
        private void frmExchangesInfo_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("مبلغ الشغل كامل");
            comboBox1.Items.Add("صافي المبلغ كامل");
            comboBox1.Items.Add("مبلغ الديزل");
            comboBox1.Items.Add("مبلغ الاصلاحات");
            comboBox1.Items.Add("اجرة العامل");
            comboBox1.Items.Add("اجرة الشركة");
            comboBox1.Items.Add("النفقات اضافية");
            comboBox1.SelectedIndex = 0; 
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            int busNumebr = rdBusOne.Checked ? 1 : rdBusTwo.Checked ? 2 : 0;
            DateTime from = dateFrom.Value; 
            DateTime to = dateTo.Value;
            double value = 0; 

            switch (comboBox1.SelectedItem.ToString())
            {
                case "مبلغ الشغل كامل":
                    if (busNumebr == 0)
                        value = total.getSumTotalAmount(from, to, 1) + total.getSumTotalAmount(from, to, 2);
                    else
                        value = total.getSumTotalAmount(from, to, busNumebr); 
                    break;

                case "صافي المبلغ كامل":
                    if (busNumebr == 0)
                        value = total.getSumNetAmount(from, to, 1) + total.getSumNetAmount(from, to, 2);
                    else
                        value = total.getSumNetAmount(from, to, busNumebr);
                    break;

                case "مبلغ الديزل":
                    if (busNumebr == 0)
                        value = total.getSumFuelAmount(from, to, 1) + total.getSumFuelAmount(from, to, 2);
                    else
                        value = total.getSumFuelAmount(from, to, busNumebr);
                    break;

                case "مبلغ الاصلاحات":
                    if (busNumebr == 0)
                        value = total.getSumRepairAmount(from, to, 1) + total.getSumRepairAmount(from, to, 2);
                    else
                        value = total.getSumRepairAmount(from, to, busNumebr);
                    break;

                case "اجرة الشركة":
                    if (busNumebr == 0)
                        value = total.getSumCompanyPayAmount(from, to, 1) + total.getSumCompanyPayAmount(from, to, 2);
                    else
                        value = total.getSumCompanyPayAmount(from, to, busNumebr);
                    break;

                case "اجرة العامل":
                    if (busNumebr == 0)
                        value = total.getSumWorkerPayAmount(from, to, 1) + total.getSumWorkerPayAmount(from, to, 2);
                    else
                        value = total.getSumWorkerPayAmount(from, to, busNumebr);
                    break;

                case "النفقات اضافية":
                    if (busNumebr == 0)
                        value = total.getSumMiscCost(from, to, 1) + total.getSumMiscCost(from, to, 2);
                    else
                        value = total.getSumMiscCost(from, to, busNumebr);
                    break;

                default:
                    value = 0000; break;
            }

            lblResult.Text = value.ToString();
        }
    }
}
