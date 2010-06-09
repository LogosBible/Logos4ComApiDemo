
using System.Windows.Forms;
using Logos4Lib;

namespace Logos4ComApiDemo
{
	public class DataTypeLinkLabel : LinkLabel
	{
		public DataTypeLinkLabel()
		{
		}

		public LogosDataType DataType
		{
			get
			{
				return m_dataType;
			}
			set
			{
				m_dataType = value;
				Text = m_dataType == null ? string.Empty : m_dataType.Alias;
			}
		}

		public void Execute()
		{
			if (m_dataType != null)
			{
				MainForm.Instance.DataTypeForm.DataType = m_dataType;
				MainForm.Instance.DataTypeForm.Activate();
			}
		}

		protected override void OnLinkClicked(LinkLabelLinkClickedEventArgs e)
		{
			base.OnLinkClicked(e);
			Execute();
		}

		LogosDataType m_dataType;
	}
}
