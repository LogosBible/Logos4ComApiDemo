
using System.Windows.Forms;
using Logos4Lib;

namespace Logos4ComApiDemo
{
	public class ReferenceLinkLabel : LinkLabel
	{
		public ReferenceLinkLabel()
		{
		}

		public LogosDataTypeReference Reference
		{
			get
			{
				return m_reference;
			}
			set
			{
				m_reference = value;
				Text = m_reference == null ? string.Empty : m_reference.Save();
			}
		}

		public void Execute()
		{
			if (m_reference != null)
			{
				MainForm.Instance.ReferenceForm.Reference = m_reference;
				MainForm.Instance.ReferenceForm.Activate();
			}
		}

		protected override void OnLinkClicked(LinkLabelLinkClickedEventArgs e)
		{
			base.OnLinkClicked(e);
			Execute();
		}

		LogosDataTypeReference m_reference;
	}
}
