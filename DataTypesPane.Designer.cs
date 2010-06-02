namespace Logos4ComApiDemo
{
	partial class DataTypesPane
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.DataTypeLabel = new System.Windows.Forms.Label();
			this.DataTypeViewLink = new System.Windows.Forms.LinkLabel();
			this.ReferenceViewLink = new System.Windows.Forms.LinkLabel();
			this.ReferenceLabel = new System.Windows.Forms.Label();
			this.DataTypeComboBox = new System.Windows.Forms.ComboBox();
			this.ReferenceComboBox = new System.Windows.Forms.ComboBox();
			this.SuspendLayout();
			// 
			// DataTypeLabel
			// 
			this.DataTypeLabel.AutoSize = true;
			this.DataTypeLabel.Location = new System.Drawing.Point(3, 8);
			this.DataTypeLabel.Name = "DataTypeLabel";
			this.DataTypeLabel.Size = new System.Drawing.Size(60, 13);
			this.DataTypeLabel.TabIndex = 0;
			this.DataTypeLabel.Text = "Data Type:";
			// 
			// DataTypeViewLink
			// 
			this.DataTypeViewLink.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.DataTypeViewLink.AutoSize = true;
			this.DataTypeViewLink.Location = new System.Drawing.Point(71, 29);
			this.DataTypeViewLink.Name = "DataTypeViewLink";
			this.DataTypeViewLink.Size = new System.Drawing.Size(30, 13);
			this.DataTypeViewLink.TabIndex = 2;
			this.DataTypeViewLink.TabStop = true;
			this.DataTypeViewLink.Text = "View";
			this.DataTypeViewLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.DataTypeViewLink_LinkClicked);
			// 
			// ReferenceViewLink
			// 
			this.ReferenceViewLink.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.ReferenceViewLink.AutoSize = true;
			this.ReferenceViewLink.Location = new System.Drawing.Point(71, 74);
			this.ReferenceViewLink.Name = "ReferenceViewLink";
			this.ReferenceViewLink.Size = new System.Drawing.Size(30, 13);
			this.ReferenceViewLink.TabIndex = 5;
			this.ReferenceViewLink.TabStop = true;
			this.ReferenceViewLink.Text = "View";
			this.ReferenceViewLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ReferenceViewLink_LinkClicked);
			// 
			// ReferenceLabel
			// 
			this.ReferenceLabel.AutoSize = true;
			this.ReferenceLabel.Location = new System.Drawing.Point(3, 53);
			this.ReferenceLabel.Name = "ReferenceLabel";
			this.ReferenceLabel.Size = new System.Drawing.Size(60, 13);
			this.ReferenceLabel.TabIndex = 3;
			this.ReferenceLabel.Text = "Reference:";
			// 
			// DataTypeComboBox
			// 
			this.DataTypeComboBox.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.DataTypeComboBox.FormattingEnabled = true;
			this.DataTypeComboBox.Items.AddRange(new object[] {
            "Bible",
            "BibleESV",
            "LouwNida",
            "GreekStrongs"});
			this.DataTypeComboBox.Location = new System.Drawing.Point(69, 5);
			this.DataTypeComboBox.Name = "DataTypeComboBox";
			this.DataTypeComboBox.Size = new System.Drawing.Size(228, 21);
			this.DataTypeComboBox.TabIndex = 1;
			this.DataTypeComboBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DataTypeComboBox_KeyDown);
			this.DataTypeComboBox.TextChanged += new System.EventHandler(this.DataTypeComboBox_TextChanged);
			// 
			// ReferenceComboBox
			// 
			this.ReferenceComboBox.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.ReferenceComboBox.FormattingEnabled = true;
			this.ReferenceComboBox.Items.AddRange(new object[] {
            "Bible.Ge2.3",
            "BibleESV.Rev22.1-21",
            "LouwNida.30.100",
            "GreekStrongs.3056"});
			this.ReferenceComboBox.Location = new System.Drawing.Point(69, 50);
			this.ReferenceComboBox.Name = "ReferenceComboBox";
			this.ReferenceComboBox.Size = new System.Drawing.Size(228, 21);
			this.ReferenceComboBox.TabIndex = 4;
			this.ReferenceComboBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ReferenceComboBox_KeyDown);
			this.ReferenceComboBox.TextChanged += new System.EventHandler(this.ReferenceComboBox_TextChanged);
			// 
			// DataTypesPane
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.ReferenceComboBox);
			this.Controls.Add(this.DataTypeComboBox);
			this.Controls.Add(this.ReferenceViewLink);
			this.Controls.Add(this.ReferenceLabel);
			this.Controls.Add(this.DataTypeViewLink);
			this.Controls.Add(this.DataTypeLabel);
			this.Name = "DataTypesPane";
			this.Size = new System.Drawing.Size(300, 300);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label DataTypeLabel;
		private System.Windows.Forms.LinkLabel DataTypeViewLink;
		private System.Windows.Forms.LinkLabel ReferenceViewLink;
		private System.Windows.Forms.Label ReferenceLabel;
		private System.Windows.Forms.ComboBox DataTypeComboBox;
		private System.Windows.Forms.ComboBox ReferenceComboBox;



	}
}
