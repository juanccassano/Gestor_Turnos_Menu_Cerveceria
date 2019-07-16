using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentacionWinForm
{
	static class Program
	{
		[STAThread]
		static void Main()
		{
			//Application.EnableVisualStyles();
			//Application.SetCompatibleTextRenderingDefault(false);
			//Application.Run(new FrmMenu());
			frmLogin login = new frmLogin();
			Application.Run(login);
			if (login.DialogResult == DialogResult.OK)
			{
				Application.Run(new FrmMenu(login.local));
			}
		}
	}
}

