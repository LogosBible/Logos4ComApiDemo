
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
			m_parsedReference = m_dataType.ParseReference(ParseTextBox.Text);
			UpdateControls();
		}

		private void UpdateControls()
		{
			BackLink.Visible = m_history.Count != 0;
			ParseLink.Text = m_parsedReference == null ? string.Empty : m_parsedReference.Save();
		}

		private void ParseLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			if (m_parsedReference != null)
				MainForm.Instance.ReferenceForm.Reference = m_parsedReference;
		}

		LogosDataType m_dataType;
		readonly Stack<LogosDataType> m_history;
		LogosDataTypeReference m_parsedReference;
	}
}
