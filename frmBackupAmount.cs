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

namespace transportation_system
{
    public partial class frmBackupAmount : Form
    {
        public frmBackupAmount()
        {
            InitializeComponent();
        }

        private void frmBackupAmount_Load(object sender, EventArgs e)
        {
           lblDate.Text = DateTime.Now.ToShortDateString();
           lblMoney.Text = total.TotalBackupAccount().ToString() + " JOD";
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
