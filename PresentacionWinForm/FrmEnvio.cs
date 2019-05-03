using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;

namespace PresentacionWinForm
{
    public partial class FrmEnvio : Form
    {
        public FrmEnvio()
        {
            InitializeComponent();
        }

        private void dgvEnviosPendientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FrmEnvio_Load(object sender, EventArgs e)
        {
            EnviosPendientes envio = new EnviosPendientes();
            try
            {
                
                dgvEnviosPendientes.DataSource = envio.listarEnviosPendientes();
                dgvEnviosPendientes.Columns[5].Visible = false;
                dgvEnviosPendientes.Columns[6].Visible = false;
                dgvEnviosPendientes.Columns[7].Visible = false;
                dgvEnviosPendientes.Columns[8].Visible = false;
                dgvEnviosPendientes.Columns[9].Visible = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
