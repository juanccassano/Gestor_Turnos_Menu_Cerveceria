﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Negocio;

namespace PresentacionWinForm
{
	public partial class FrmAltaBebida : Form
	{
		private Bebida bebidaLocal = null;
		public FrmAltaBebida()
		{
			InitializeComponent();
		}

		public FrmAltaBebida(Bebida bebida)
		{
			InitializeComponent();
			bebidaLocal = bebida;
		}

		private void btnAceptar_Click(object sender, EventArgs e)
		{
			BebidaNegocio negocio = new BebidaNegocio();
			try
			{

				if (bebidaLocal == null)
					bebidaLocal = new Bebida();

				bebidaLocal.Nombre = txtNombre.Text;
				bebidaLocal.Marca = txtMarca.Text;
				bebidaLocal.ContieneAlcohol = ckbAlcoholica.Checked;
				bebidaLocal.PrecioUnitario = Convert.ToDecimal(txtPrecioUnitario.Text);


				if (bebidaLocal.ID != 0)
				{
					negocio.modificarBebida(bebidaLocal);
				}
				else
				{
					negocio.agregarBebida(bebidaLocal);
				}

				Close();

			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}

		private void FrmAltaBebida_Load(object sender, EventArgs e)
		{

			try
			{


				if (bebidaLocal != null)
				{
					txtNombre.Text = bebidaLocal.Nombre;
					txtMarca.Text = bebidaLocal.Marca;
					ckbAlcoholica.Checked = bebidaLocal.ContieneAlcohol;
					txtPrecioUnitario.Text = bebidaLocal.PrecioUnitario.ToString();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}

		}

		private void btnCancelar_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}