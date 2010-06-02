
using System.Windows.Forms;
using Logos4Lib;

namespace Logos4ComApiDemo
{
	public partial class DataTypesPane : UserControl
	{
		public DataTypesPane()
		{
			InitializeComponent();

			UpdateControls();
		}

		private void DataTypeViewLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			ViewDataType();
		}

		private void DataTypeComboBox_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
				ViewDataType();
		}

		private void DataTypeComboBox_TextChanged(object sender, System.EventArgs e)
		{
			m_dataType = MainForm.Instance.LogosApplication.DataTypes.GetDataType(DataTypeComboBox.Text);
			UpdateControls();
		}

		private void ViewDataType()
		{
			if (m_dataType != null)
				MainForm.Instance.DataTypeForm.DataType = m_dataType;
		}

		private void ReferenceViewLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			ViewReference();
		}

		private void ReferenceComboBox_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
				ViewReference();
		}

		private void ReferenceComboBox_TextChanged(object sender, System.EventArgs e)
		{
			m_reference = MainForm.Instance.LogosApplication.DataTypes.LoadReference(ReferenceComboBox.Text);
			UpdateControls();
		}

		private void ViewReference()
		{
			if (m_reference != null)
				MainForm.Instance.ReferenceForm.Reference = m_reference;
		}

		private void UpdateControls()
		{
			DataTypeViewLink.Text = m_dataType == null ? string.Empty : m_dataType.Alias;
			ReferenceViewLink.Text = m_reference == null ? string.Empty : m_reference.Save();
		}

		LogosDataType m_dataType;
		LogosDataTypeReference m_reference;
	}
}
