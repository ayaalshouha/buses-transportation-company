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

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void frmExchangesInfo_Load(object sender, EventArgs e)
        {
            // upload options from daily exchange data and monthly exchange data
            
           // comboBox1.Items.Add(""); 
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            int busNumebr = rdBusOne.Checked ? 1 : rdBusTwo.Checked ? 2 : 0;
            DateTime from = dateFrom.Value.Date; 
            DateTime to = dateTo.Value.Date;    
            
        }
    }
}
