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

    }
}
