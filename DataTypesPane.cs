
using System.Windows.Forms;

namespace Logos4ComApiDemo
{
	public partial class DataTypesPane : UserControl
	{
		public DataTypesPane()
		{
			InitializeComponent();
		}

		private void DataTypeComboBox_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
				DataTypeViewLink.Execute();
		}

		private void DataTypeComboBox_TextChanged(object sender, System.EventArgs e)
		{
			DataTypeViewLink.DataType = MainForm.Instance.LogosApplication.DataTypes.GetDataType(DataTypeComboBox.Text);
		}

		private void ReferenceComboBox_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
				ReferenceViewLink.Execute();
		}

		private void ReferenceComboBox_TextChanged(object sender, System.EventArgs e)
		{
			ReferenceViewLink.Reference = MainForm.Instance.LogosApplication.DataTypes.LoadReference(ReferenceComboBox.Text);
		}
	}
}
