
using System.Globalization;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Logos4ComApiDemo.Properties;

namespace Logos4ComApiDemo
{
	public partial class ApplicationPane : UserControl
	{
		public ApplicationPane()
		{
			InitializeComponent();

			// show the API version
			ApiVersionLabel.Text = string.Format(CultureInfo.CurrentCulture, Resources.ApplicationPaneApiVersion, MainForm.Instance.LogosApplication.ApiVersion);
		}

		private void ActivateLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			try
			{
				// activate Logos 4
				MainForm.Instance.AllowSetForegroundWindow();
				MainForm.Instance.LogosApplication.Activate();
			}
			catch (COMException)
			{
				MainForm.Instance.RefreshApplication();
			}
		}

		private void ExitLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			try
			{
				// exit Logos 4
				MainForm.Instance.LogosApplication.Exit();
			}
			catch (COMException)
			{
				MainForm.Instance.RefreshApplication();
			}
		}

		private void UriGoButton_Click(object sender, System.EventArgs e)
		{
			try
			{
				// execute the URI
				MainForm.Instance.AllowSetForegroundWindow();
				MainForm.Instance.LogosApplication.ExecuteUri(UriComboBox.Text);
			}
			catch (COMException)
			{
				MainForm.Instance.RefreshApplication();
			}
		}
	}
}
