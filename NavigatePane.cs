
using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Logos4ComApiDemo
{
	public partial class NavigatePane : UserControl
	{
		public NavigatePane()
		{
			InitializeComponent();
		}

		private void NavigateButton_Click(object sender, EventArgs e)
		{
			Navigate();
		}

		private void NavigateTextBox_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
				Navigate();
		}

		private void Navigate()
		{
			try
			{
				var request = MainForm.Instance.LogosApplication.CreateNavigationRequest();
				request.ResourceId = ResourceIdTextBox.Text;
				request.Article = ArticleTextBox.Text;
				request.Reference = MainForm.Instance.LogosApplication.DataTypes.LoadReference(ReferenceTextBox.Text);
				request.Headword = HeadwordTextBox.Text;
				request.HeadwordLanguage = HeadwordLanguageTextBox.Text;
				MainForm.Instance.LogosApplication.Navigate(request);
			}
			catch (COMException)
			{
				MainForm.Instance.RefreshApplication();
			}
		}
	}
}
