
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
			DataTypeLink.DataType = reference.DataType;
			RangeStartLink.Reference = reference.IsRange ? reference.RangeStart : null;
			RangeEndLink.Reference = reference.IsRange ? reference.RangeEnd : null;
			RenderShortTextBox.Text = reference.Render("short");
			RenderMediumTextBox.Text = reference.Render("medium");
			RenderLongTextBox.Text = reference.Render("long");
			RenderDisplayTextBox.Text = reference.Render("display");

			ThePanel.Controls.Clear();
			object details = reference.Details;
			if (details is ILogosBibleReferenceDetails)
				ThePanel.Controls.Add(new BibleReferencePane(reference));
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
