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
    public partial class FrmMesa : Form
    {
        public FrmMesa()
        {
            InitializeComponent();
        }

        private void dgvMesa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FrmMesa_Load(object sender, EventArgs e)
        {
            PedidoMesa pedido = new PedidoMesa();
            try
            {

               dgvMesa.DataSource = pedido.listarPedidos();
                dgvMesa.Columns[2].Visible = false;
                dgvMesa.Columns[3].Visible = false;
                dgvMesa.Columns[4].Visible = false;
                dgvMesa.Columns[5].Visible = false;
                dgvMesa.Columns[6].Visible = false;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
