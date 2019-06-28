using System;
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
	public partial class FrmAltaProveedor : Form
	{
		private Proveedor proveedorLocal = null;



		public FrmAltaProveedor()
		{
			InitializeComponent();
		}

		public FrmAltaProveedor(Proveedor proveedor)
		{
			InitializeComponent();
			proveedorLocal = proveedor;

		}


		private void FrmAltaProveedor_Load(object sender, EventArgs e)
		{
			try
			{


				if (proveedorLocal != null)
				{
					txtDNI.Text = proveedorLocal.Documento.ToString();
					txtApellido.Text = proveedorLocal.Apellido;
					txtNombre.Text = proveedorLocal.Nombre;
					txtTelefono.Text = proveedorLocal.Telefono.Numero.ToString();
					txtCalle.Text = proveedorLocal.Direccion.Calle;
					txtNumeracion.Text = proveedorLocal.Direccion.Numeracion.ToString();
					txtLocalidad.Text = proveedorLocal.Direccion.Localidad;
					dtpFechaNac.Value = proveedorLocal.FechaNac.FechaNac;
					txtRubro.Text = proveedorLocal.Rubro;
					foreach (RadioButton rbo in gbxTipo.Controls)
					{
						if (proveedorLocal.Monotributista)
						{
							rdbMonotributista.Checked = true;
						}
						else
						{
							rdbResponsableInsc.Checked = true;
						}
					}
					txtCUIT.Text = proveedorLocal.CUIT;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}

		private void btnAceptar_Click(object sender, EventArgs e)
		{
			ProveedorNegocio negocio = new ProveedorNegocio();

			try
			{

				if (proveedorLocal == null)
					proveedorLocal = new Proveedor();
					proveedorLocal.Telefono = new Telefono();
					proveedorLocal.Direccion = new Direccion();
					proveedorLocal.FechaNac = new Fecha();



				proveedorLocal.Documento = Convert.ToInt32(txtDNI.Text);
				proveedorLocal.Apellido = txtApellido.Text;
				proveedorLocal.Nombre = txtNombre.Text;
				proveedorLocal.Telefono.Numero = Convert.ToInt32(txtTelefono.Text);
				proveedorLocal.Direccion.Calle = txtCalle.Text;
				proveedorLocal.Direccion.Numeracion = Convert.ToInt32(txtNumeracion.Text);
				proveedorLocal.Direccion.Localidad = txtLocalidad.Text;
				proveedorLocal.FechaNac.FechaNac = dtpFechaNac.Value;
				proveedorLocal.Rubro = txtRubro.Text;
				foreach (RadioButton rbo in gbxTipo.Controls)
				{
					if (rbo.Checked)
					{
						if (rbo.Text == "Monotributista")
						{
							proveedorLocal.Monotributista = true;
							proveedorLocal.ResponsableInscripto = false;
						}
						else
						{
							proveedorLocal.Monotributista = false;
							proveedorLocal.ResponsableInscripto = true;
						}
					}

				}
				proveedorLocal.CUIT = txtCUIT.Text;





				if (proveedorLocal.ID != 0)
				{
					negocio.modificarProveedor(proveedorLocal);
				}
				else
				{
					negocio.agregarProveedor(proveedorLocal);
				}

				Close();

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
