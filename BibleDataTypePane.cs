
using System.Windows.Forms;
using Logos4Lib;

namespace Logos4ComApiDemo
{
	public partial class BibleDataTypePane : UserControl
	{
		public BibleDataTypePane(LogosDataType dataType)
		{
			m_dataType = dataType;

			InitializeComponent();
		}

		protected override void OnLoad(System.EventArgs e)
		{
			base.OnLoad(e);

			FirstBookLink.Reference = ((LogosBibleDataTypeDetails) m_dataType.Details).FirstBook;
			LastBookLink.Reference = ((LogosBibleDataTypeDetails) m_dataType.Details).LastBook;
		}

		readonly LogosDataType m_dataType;
	}
}
