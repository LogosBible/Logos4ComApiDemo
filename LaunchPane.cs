
using System;
using System.Windows.Forms;
using Logos4ComApiDemo.Properties;

namespace Logos4ComApiDemo
{
	public partial class LaunchPane : UserControl
	{
		public LaunchPane()
		{
			InitializeComponent();
		}

		protected override void OnLoad(EventArgs e)
		{
			// show whether the application is ready or not
			ApplicationReadyLabel.Text = MainForm.Instance.LogosApplication == null ?
				Resources.LaunchPaneNotReady : Resources.LaunchPaneReady;

			base.OnLoad(e);
		}

		private void LaunchButton_Click(object sender, EventArgs e)
		{
			// launch Logos 4
			MainForm.Instance.AllowSetForegroundWindow();
			MainForm.Instance.LogosLauncher.LaunchApplication(CommandLineComboBox.Text);
		}

		private void RefreshLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			// check to see if Logos 4 is running
			MainForm.Instance.RefreshApplication();
		}
	}
}
