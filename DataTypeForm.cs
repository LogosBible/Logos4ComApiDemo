
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Logos4Lib;

namespace Logos4ComApiDemo
{
	public partial class DataTypeForm : Form
	{
		public DataTypeForm()
		{
			m_history = new Stack<LogosDataType>();

			InitializeComponent();

			UpdateControls();
		}

		public LogosDataType DataType
		{
			get { return m_dataType; }
			set { SetDataType(value, false); }
		}

		private void SetDataType(LogosDataType dataType, bool bInHistory)
		{
			if (!bInHistory && m_dataType != null)
				m_history.Push(m_dataType);

			m_dataType = dataType;
			UpdateControls();

			DataTypeTextBox.Text = dataType.Alias;
			TitleTextBox.Text = dataType.Title;
			SortTitleTextBox.Text = dataType.SortTitle;
			AbbrevTextBox.Text = dataType.AbbreviatedTitle;

			ThePanel.Controls.Clear();
			object details = dataType.Details;
			if (details is ILogosBibleDataTypeDetails)
				ThePanel.Controls.Add(new BibleDataTypePane(dataType));
		}

		private void BackLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			if (m_history.Count != 0)
			{
				SetDataType(m_history.Pop(), true);
				UpdateControls();
			}
		}

		private void ParseTextBox_TextChanged(object sender, EventArgs e)
		{
			ParseLink.Reference = m_dataType.ParseReference(ParseTextBox.Text);
			UpdateControls();
		}

		private void UpdateControls()
		{
			BackLink.Visible = m_history.Count != 0;
		}

		LogosDataType m_dataType;
		readonly Stack<LogosDataType> m_history;
	}
}
