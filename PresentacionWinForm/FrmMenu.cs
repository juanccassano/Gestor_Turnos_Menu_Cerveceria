using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentacionWinForm
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void btnEnvios_MouseClick(object sender, MouseEventArgs e)
        {
            FrmEnvio ventanaE = new FrmEnvio();
            ventanaE.ShowDialog();
        }

        private void btnSalon_MouseClick(object sender, MouseEventArgs e)
        {
            FrmMesa ventanaM = new FrmMesa();
            ventanaM.ShowDialog();
        }
    }
}
