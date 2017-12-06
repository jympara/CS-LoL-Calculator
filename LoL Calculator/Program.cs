using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoL_Calculator
{
    static class Program
    {
		public static MainForm MainMenu;
		public static CompareForm CompareWindow;
		public static ChampOverviewForm OverviewWindow;
		public static BestVsForm VersusCalcWindow;
		public static BestVsTeamForm VsTeamCalcWindow;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(MainMenu = new MainForm());
        }

		public static void HideMaimMenu()
		{
			if (MainMenu.Visible)
				MainMenu.Visible = false;
		}

		public static void MinimizeMainMenu()
		{
			if (MainMenu.Visible)
				MainMenu.WindowState = FormWindowState.Minimized;
		}

		public static void UnMinimizeMainMenu()
		{
			if(MainMenu.WindowState == FormWindowState.Minimized)
				MainMenu.WindowState = FormWindowState.Normal;
		}

		public static void ShowMainMenu()
		{
			if (!MainMenu.Visible)
				MainMenu.Visible = true;
		}

		public static void OpenCompareWindow()
		{

			if (Application.OpenForms.OfType<CompareForm>().FirstOrDefault() != null)
			{
				CompareWindow.Show();
				CompareWindow.Activate();
			}

			else
			{
				CompareWindow = new CompareForm();
				CompareWindow.Show();
			}

		}

		public static void OpenOverviewWindow()
		{

			if (Application.OpenForms.OfType<ChampOverviewForm>().FirstOrDefault() != null)
			{
				OverviewWindow.Show();
				OverviewWindow.Activate();
			}

			else
			{
				OverviewWindow = new ChampOverviewForm();
				OverviewWindow.Show();
			}

		}

		public static void OpenVersusCalcWindow()
		{

			if (Application.OpenForms.OfType<BestVsForm>().FirstOrDefault() != null)
			{
				VersusCalcWindow.Show();
				VersusCalcWindow.Activate();
			}

			else
			{
				VersusCalcWindow = new BestVsForm();
				VersusCalcWindow.Show();
			}

		}


		public static void OpenVsTeamCalcWindow()
		{

			if (Application.OpenForms.OfType<BestVsTeamForm>().FirstOrDefault() != null)
			{
				VsTeamCalcWindow.Show();
				VsTeamCalcWindow.Activate();
			}

			else
			{
				VsTeamCalcWindow = new BestVsTeamForm();
				VsTeamCalcWindow.Show();
			}

		}




	}
}
