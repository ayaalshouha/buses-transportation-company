using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using transportation_system.Daily_Exchange;
using transportation_system.Monthly_Exchange;
using transportation_system.Total;

namespace transportation_system
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            FrmAddEditDailyExchange frm = new FrmAddEditDailyExchange();
            frm.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            FrmAddEditMonthlyExchange frm = new FrmAddEditMonthlyExchange();
            frm.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            FrmTotalDailyExchanges frm = new FrmTotalDailyExchanges();
            frm.ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            FrmTotalMonthlyExchanges frm = new FrmTotalMonthlyExchanges();
            frm.ShowDialog();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            frmBackupAmount frm = new frmBackupAmount();
            frm.ShowDialog();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            frmExchangesInfo frm = new frmExchangesInfo();
            frm.ShowDialog();
        }
    }
}
