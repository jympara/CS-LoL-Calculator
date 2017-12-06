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
	public partial class CompareForm : Form
	{
		public CompareForm()
		{
			InitializeComponent();
		}

		private void CompareForm_FormClosed(object sender, FormClosedEventArgs e)
		{
			Program.UnMinimizeMainMenu();
		}
	}
}
