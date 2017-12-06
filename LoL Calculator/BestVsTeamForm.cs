using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoL_Calculator
{
	public partial class BestVsTeamForm : Form
	{
		public BestVsTeamForm()
		{
			InitializeComponent();
		}

		private void BestVsTeamForm_FormClosed(object sender, FormClosedEventArgs e)
		{
			Program.UnMinimizeMainMenu();
		}
	}
}
