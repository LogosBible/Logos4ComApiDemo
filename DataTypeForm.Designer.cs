namespace Logos4ComApiDemo
{
	partial class DataTypeForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.DataTypeLabel = new System.Windows.Forms.Label();
			this.DataTypeTextBox = new System.Windows.Forms.TextBox();
			this.TitleLabel = new System.Windows.Forms.Label();
			this.TitleTextBox = new System.Windows.Forms.TextBox();
			this.SortTitleLabel = new System.Windows.Forms.Label();
			this.SortTitleTextBox = new System.Windows.Forms.TextBox();
			this.AbbrevLabel = new System.Windows.Forms.Label();
			this.AbbrevTextBox = new System.Windows.Forms.TextBox();
			this.ParseLabel = new System.Windows.Forms.Label();
			this.ParseTextBox = new System.Windows.Forms.TextBox();
			this.BackLink = new System.Windows.Forms.LinkLabel();
			this.ThePanel = new System.Windows.Forms.Panel();
			this.ParseLink = new Logos4ComApiDemo.ReferenceLinkLabel();
			this.SuspendLayout();
			// 
			// DataTypeLabel
			// 
			this.DataTypeLabel.AutoSize = true;
			this.DataTypeLabel.Location = new System.Drawing.Point(12, 13);
			this.DataTypeLabel.Name = "DataTypeLabel";
			this.DataTypeLabel.Size = new System.Drawing.Size(60, 13);
			this.DataTypeLabel.TabIndex = 0;
			this.DataTypeLabel.Text = "Data Type:";
			// 
			// DataTypeTextBox
			// 
			this.DataTypeTextBox.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.DataTypeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.DataTypeTextBox.Location = new System.Drawing.Point(78, 13);
			this.DataTypeTextBox.Name = "DataTypeTextBox";
			this.DataTypeTextBox.ReadOnly = true;
			this.DataTypeTextBox.Size = new System.Drawing.Size(356, 13);
			this.DataTypeTextBox.TabIndex = 1;
			// 
			// TitleLabel
			// 
			this.TitleLabel.AutoSize = true;
			this.TitleLabel.Location = new System.Drawing.Point(12, 32);
			this.TitleLabel.Name = "TitleLabel";
			this.TitleLabel.Size = new System.Drawing.Size(30, 13);
			this.TitleLabel.TabIndex = 2;
			this.TitleLabel.Text = "Title:";
			// 
			// TitleTextBox
			// 
			this.TitleTextBox.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.TitleTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.TitleTextBox.Location = new System.Drawing.Point(78, 32);
			this.TitleTextBox.Name = "TitleTextBox";
			this.TitleTextBox.ReadOnly = true;
			this.TitleTextBox.Size = new System.Drawing.Size(394, 13);
			this.TitleTextBox.TabIndex = 3;
			// 
			// SortTitleLabel
			// 
			this.SortTitleLabel.AutoSize = true;
			this.SortTitleLabel.Location = new System.Drawing.Point(12, 51);
			this.SortTitleLabel.Name = "SortTitleLabel";
			this.SortTitleLabel.Size = new System.Drawing.Size(52, 13);
			this.SortTitleLabel.TabIndex = 4;
			this.SortTitleLabel.Text = "Sort Title:";
			// 
			// SortTitleTextBox
			// 
			this.SortTitleTextBox.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.SortTitleTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.SortTitleTextBox.Location = new System.Drawing.Point(78, 51);
			this.SortTitleTextBox.Name = "SortTitleTextBox";
			this.SortTitleTextBox.ReadOnly = true;
			this.SortTitleTextBox.Size = new System.Drawing.Size(394, 13);
			this.SortTitleTextBox.TabIndex = 5;
			// 
			// AbbrevLabel
			// 
			this.AbbrevLabel.AutoSize = true;
			this.AbbrevLabel.Location = new System.Drawing.Point(12, 70);
			this.AbbrevLabel.Name = "AbbrevLabel";
			this.AbbrevLabel.Size = new System.Drawing.Size(44, 13);
			this.AbbrevLabel.TabIndex = 6;
			this.AbbrevLabel.Text = "Abbrev:";
			// 
			// AbbrevTextBox
			// 
			this.AbbrevTextBox.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.AbbrevTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.AbbrevTextBox.Location = new System.Drawing.Point(78, 70);
			this.AbbrevTextBox.Name = "AbbrevTextBox";
			this.AbbrevTextBox.ReadOnly = true;
			this.AbbrevTextBox.Size = new System.Drawing.Size(394, 13);
			this.AbbrevTextBox.TabIndex = 7;
			// 
			// ParseLabel
			// 
			this.ParseLabel.AutoSize = true;
			this.ParseLabel.Location = new System.Drawing.Point(12, 92);
			this.ParseLabel.Name = "ParseLabel";
			this.ParseLabel.Size = new System.Drawing.Size(37, 13);
			this.ParseLabel.TabIndex = 8;
			this.ParseLabel.Text = "Parse:";
			// 
			// ParseTextBox
			// 
			this.ParseTextBox.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.ParseTextBox.Location = new System.Drawing.Point(78, 89);
			this.ParseTextBox.Name = "ParseTextBox";
			this.ParseTextBox.Size = new System.Drawing.Size(394, 20);
			this.ParseTextBox.TabIndex = 9;
			this.ParseTextBox.TextChanged += new System.EventHandler(this.ParseTextBox_TextChanged);
			// 
			// BackLink
			// 
			this.BackLink.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.BackLink.AutoSize = true;
			this.BackLink.Location = new System.Drawing.Point(440, 13);
			this.BackLink.Name = "BackLink";
			this.BackLink.Size = new System.Drawing.Size(32, 13);
			this.BackLink.TabIndex = 12;
			this.BackLink.TabStop = true;
			this.BackLink.Text = "Back";
			this.BackLink.Visible = false;
			this.BackLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.BackLink_LinkClicked);
			// 
			// ThePanel
			// 
			this.ThePanel.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.ThePanel.Location = new System.Drawing.Point(15, 127);
			this.ThePanel.Name = "ThePanel";
			this.ThePanel.Size = new System.Drawing.Size(457, 123);
			this.ThePanel.TabIndex = 11;
			// 
			// ParseLink
			// 
			this.ParseLink.AutoSize = true;
			this.ParseLink.Location = new System.Drawing.Point(78, 112);
			this.ParseLink.Name = "ParseLink";
			this.ParseLink.Reference = null;
			this.ParseLink.Size = new System.Drawing.Size(0, 13);
			this.ParseLink.TabIndex = 10;
			// 
			// DataTypeForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(484, 262);
			this.Controls.Add(this.ParseLink);
			this.Controls.Add(this.ThePanel);
			this.Controls.Add(this.BackLink);
			this.Controls.Add(this.ParseTextBox);
			this.Controls.Add(this.AbbrevTextBox);
			this.Controls.Add(this.SortTitleTextBox);
			this.Controls.Add(this.TitleTextBox);
			this.Controls.Add(this.DataTypeTextBox);
			this.Controls.Add(this.ParseLabel);
			this.Controls.Add(this.AbbrevLabel);
			this.Controls.Add(this.SortTitleLabel);
			this.Controls.Add(this.TitleLabel);
			this.Controls.Add(this.DataTypeLabel);
			this.MinimumSize = new System.Drawing.Size(500, 300);
			this.Name = "DataTypeForm";
			this.Text = "Data Type Viewer";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label DataTypeLabel;
		private System.Windows.Forms.TextBox DataTypeTextBox;
		private System.Windows.Forms.Label TitleLabel;
		private System.Windows.Forms.TextBox TitleTextBox;
		private System.Windows.Forms.Label SortTitleLabel;
		private System.Windows.Forms.TextBox SortTitleTextBox;
		private System.Windows.Forms.Label AbbrevLabel;
		private System.Windows.Forms.TextBox AbbrevTextBox;
		private System.Windows.Forms.Label ParseLabel;
		private System.Windows.Forms.TextBox ParseTextBox;
		private System.Windows.Forms.LinkLabel BackLink;
		private System.Windows.Forms.Panel ThePanel;
		private ReferenceLinkLabel ParseLink;
	}
}

