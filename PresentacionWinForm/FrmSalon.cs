﻿using System;
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
	public partial class FrmSalon : Form
	{
		public FrmSalon()
		{
			InitializeComponent();
		}

		private void btnCaja_Click(object sender, EventArgs e)
		{
			FrmAltaPedido ventanaAP = new FrmAltaPedido();
			ventanaAP.ShowDialog();
		}
	}
}
