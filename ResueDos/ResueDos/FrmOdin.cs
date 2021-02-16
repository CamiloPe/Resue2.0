using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ResueDos
{
    public partial class FrmOdin : Form
    {
        public FrmOdin()
        {
            InitializeComponent();
        }

        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            FrmRegistrarse frmRegistrarse = new FrmRegistrarse();
            frmRegistrarse.Show();
        }

        private void btnConfig_Click(object sender, EventArgs e)
        {
            FrmConfig frmconfig = new FrmConfig();
            frmconfig.Show();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTips_Click(object sender, EventArgs e)
        {
            FrmTips frmtips = new FrmTips();
            frmtips.Show();
        }
    }
}
