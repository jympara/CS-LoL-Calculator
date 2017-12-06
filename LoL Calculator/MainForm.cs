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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
			//CalculatorMain.CheckTemplateFile();
			Data.LoadItems();
			Data.LoadChampions();
		}

		private void button3_Click(object sender, EventArgs e)
		{

		}

		private void button8_Click(object sender, EventArgs e)
		{

		}

		private void button6_Click(object sender, EventArgs e)
		{

		}

		private void ChampOverviewButton_Click(object sender, EventArgs e)
		{
			Program.OpenOverviewWindow();
			Program.MinimizeMainMenu();
		}

		private void exitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Application.ExitThread();
		}

		private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			Program.MainMenu.Visible = false;
			e.Cancel = true;
		}

		

		private void notifyIcon1_DoubleClick(object sender, EventArgs e)
		{
			Program.ShowMainMenu();
			Program.UnMinimizeMainMenu();
		}
		

		private void openMenuToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Program.ShowMainMenu();
			Program.UnMinimizeMainMenu();
		}

		private void compareToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Program.OpenCompareWindow();
			Program.MinimizeMainMenu();
		}

		private void versusToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Program.OpenVersusCalcWindow();
			Program.MinimizeMainMenu();
		}

		private void overviewToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Program.OpenOverviewWindow();
			Program.MinimizeMainMenu();
		}

		private void ChampCompareButton_Click(object sender, EventArgs e)
		{
			Program.OpenCompareWindow();
			Program.MinimizeMainMenu();
		}

		private void VersusCalcButton_Click(object sender, EventArgs e)
		{
			Program.OpenVersusCalcWindow();
			Program.MinimizeMainMenu();
		}

		private void VsTeamCalcButton_Click(object sender, EventArgs e)
		{
			Program.OpenVsTeamCalcWindow();
			Program.MinimizeMainMenu();
		}

		private void teamVersusToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Program.OpenVsTeamCalcWindow();
			Program.MinimizeMainMenu();
		}

		private void ExitButton_Click(object sender, EventArgs e)
		{
			Application.ExitThread();
		}
	}
}
