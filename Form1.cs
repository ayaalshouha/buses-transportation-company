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

namespace transportation_system
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAddDailyExchange_Click(object sender, EventArgs e)
        {
            FrmAddEditDailyExchange frm = new FrmAddEditDailyExchange();
            frm.ShowDialog();
        }

        private void btnAddMonthlyExchange_Click(object sender, EventArgs e)
        {
            FrmAddEditMonthlyExchange frm = new FrmAddEditMonthlyExchange();
            frm.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            frmBackupAmount frm = new frmBackupAmount();
            frm.ShowDialog();
        }

        private void DailyExchangeData_Click(object sender, EventArgs e)
        {
            FrmTotalDailyExchanges frm = new FrmTotalDailyExchanges();
            frm.ShowDialog();
        }

        private void btnMonthlyExchangeData_Click(object sender, EventArgs e)
        {
            FrmTotalMonthlyExchanges frm = new FrmTotalMonthlyExchanges();
            frm.ShowDialog();
        }
    }
}
