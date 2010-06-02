
using System.Collections.Generic;
using System.Windows.Forms;
using Logos4Lib;

namespace Logos4ComApiDemo
{
	public partial class ReferenceForm : Form
	{
		public ReferenceForm()
		{
			m_history = new Stack<LogosDataTypeReference>();

			InitializeComponent();
		}

		public LogosDataTypeReference Reference
		{
			get { return m_reference; }
			set { SetReference(value, false); }
		}

		private void SetReference(LogosDataTypeReference reference, bool bInHistory)
		{
			if (!bInHistory && m_reference != null)
				m_history.Push(m_reference);

			m_reference = reference;
			UpdateControls();

			ReferenceTextBox.Text = reference.Save();
			DataTypeLink.Text = reference.DataType.Alias;
			RangeStartLink.Text = reference.IsRange ? reference.RangeStart.Save() : string.Empty;
			RangeEndLink.Text = reference.IsRange ? reference.RangeEnd.Save() : string.Empty;
			RenderShortTextBox.Text = reference.Render("short");
			RenderMediumTextBox.Text = reference.Render("medium");
			RenderLongTextBox.Text = reference.Render("long");
			RenderDisplayTextBox.Text = reference.Render("display");
		}

		private void DataTypeLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			MainForm.Instance.DataTypeForm.DataType = m_reference.DataType;
		}

		private void RangeStartLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Reference = m_reference.RangeStart;
		}

		private void RangeEndLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Reference = m_reference.RangeEnd;
		}

		private void BackLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			if (m_history.Count != 0)
			{
				SetReference(m_history.Pop(), true);
				UpdateControls();
			}
		}

		private void UpdateControls()
		{
			BackLink.Visible = m_history.Count != 0;
		}

		LogosDataTypeReference m_reference;
		readonly Stack<LogosDataTypeReference> m_history;
	}
}
