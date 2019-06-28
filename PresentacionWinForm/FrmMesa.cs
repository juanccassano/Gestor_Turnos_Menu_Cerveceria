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
using Dominio;

namespace PresentacionWinForm
{
	//private List<Mesa> listaMesasLocal;
	public partial class FrmMesa : Form
    {
        public FrmMesa()
        {
            InitializeComponent();
        }

		private void cargarGrilla()
		{
			MesaNegocio negocio = new MesaNegocio();
			try
			{
				//listaMesasLocal = negocio.listarMesas();
				//dgvMesa.DataSource = listaMesasLocal;

			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}

		private void FrmMesa_Load(object sender, EventArgs e)
        {
			cargarGrilla();
		}
    }
}
