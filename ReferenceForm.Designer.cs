namespace Logos4ComApiDemo
{
	partial class ReferenceForm
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
			this.ReferenceLabel = new System.Windows.Forms.Label();
			this.ReferenceTextBox = new System.Windows.Forms.TextBox();
			this.DataTypeLabel = new System.Windows.Forms.Label();
			this.DataTypeLink = new System.Windows.Forms.LinkLabel();
			this.RangeStartLabel = new System.Windows.Forms.Label();
			this.RangeStartLink = new System.Windows.Forms.LinkLabel();
			this.RangeEndLabel = new System.Windows.Forms.Label();
			this.RangeEndLink = new System.Windows.Forms.LinkLabel();
			this.BackLink = new System.Windows.Forms.LinkLabel();
			this.RenderShortTextBox = new System.Windows.Forms.TextBox();
			this.RenderShortLabel = new System.Windows.Forms.Label();
			this.RenderMediumTextBox = new System.Windows.Forms.TextBox();
			this.RenderMediumLabel = new System.Windows.Forms.Label();
			this.RenderLongTextBox = new System.Windows.Forms.TextBox();
			this.RenderLongLabel = new System.Windows.Forms.Label();
			this.RenderDisplayTextBox = new System.Windows.Forms.TextBox();
			this.RenderDisplayLabel = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// ReferenceLabel
			// 
			this.ReferenceLabel.AutoSize = true;
			this.ReferenceLabel.Location = new System.Drawing.Point(12, 13);
			this.ReferenceLabel.Name = "ReferenceLabel";
			this.ReferenceLabel.Size = new System.Drawing.Size(60, 13);
			this.ReferenceLabel.TabIndex = 3;
			this.ReferenceLabel.Text = "Reference:";
			// 
			// ReferenceTextBox
			// 
			this.ReferenceTextBox.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.ReferenceTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.ReferenceTextBox.Location = new System.Drawing.Point(85, 13);
			this.ReferenceTextBox.Name = "ReferenceTextBox";
			this.ReferenceTextBox.ReadOnly = true;
			this.ReferenceTextBox.Size = new System.Drawing.Size(342, 13);
			this.ReferenceTextBox.TabIndex = 4;
			// 
			// DataTypeLabel
			// 
			this.DataTypeLabel.AutoSize = true;
			this.DataTypeLabel.Location = new System.Drawing.Point(12, 32);
			this.DataTypeLabel.Name = "DataTypeLabel";
			this.DataTypeLabel.Size = new System.Drawing.Size(60, 13);
			this.DataTypeLabel.TabIndex = 5;
			this.DataTypeLabel.Text = "Data Type:";
			// 
			// DataTypeLink
			// 
			this.DataTypeLink.AutoSize = true;
			this.DataTypeLink.Location = new System.Drawing.Point(82, 32);
			this.DataTypeLink.Name = "DataTypeLink";
			this.DataTypeLink.Size = new System.Drawing.Size(57, 13);
			this.DataTypeLink.TabIndex = 6;
			this.DataTypeLink.TabStop = true;
			this.DataTypeLink.Text = "(data type)";
			this.DataTypeLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.DataTypeLink_LinkClicked);
			// 
			// RangeStartLabel
			// 
			this.RangeStartLabel.AutoSize = true;
			this.RangeStartLabel.Location = new System.Drawing.Point(12, 51);
			this.RangeStartLabel.Name = "RangeStartLabel";
			this.RangeStartLabel.Size = new System.Drawing.Size(67, 13);
			this.RangeStartLabel.TabIndex = 5;
			this.RangeStartLabel.Text = "Range Start:";
			// 
			// RangeStartLink
			// 
			this.RangeStartLink.AutoSize = true;
			this.RangeStartLink.Location = new System.Drawing.Point(82, 51);
			this.RangeStartLink.Name = "RangeStartLink";
			this.RangeStartLink.Size = new System.Drawing.Size(63, 13);
			this.RangeStartLink.TabIndex = 6;
			this.RangeStartLink.TabStop = true;
			this.RangeStartLink.Text = "(range start)";
			this.RangeStartLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.RangeStartLink_LinkClicked);
			// 
			// RangeEndLabel
			// 
			this.RangeEndLabel.AutoSize = true;
			this.RangeEndLabel.Location = new System.Drawing.Point(12, 70);
			this.RangeEndLabel.Name = "RangeEndLabel";
			this.RangeEndLabel.Size = new System.Drawing.Size(64, 13);
			this.RangeEndLabel.TabIndex = 5;
			this.RangeEndLabel.Text = "Range End:";
			// 
			// RangeEndLink
			// 
			this.RangeEndLink.AutoSize = true;
			this.RangeEndLink.Location = new System.Drawing.Point(82, 70);
			this.RangeEndLink.Name = "RangeEndLink";
			this.RangeEndLink.Size = new System.Drawing.Size(61, 13);
			this.RangeEndLink.TabIndex = 6;
			this.RangeEndLink.TabStop = true;
			this.RangeEndLink.Text = "(range end)";
			this.RangeEndLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.RangeEndLink_LinkClicked);
			// 
			// BackLink
			// 
			this.BackLink.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.BackLink.AutoSize = true;
			this.BackLink.Location = new System.Drawing.Point(433, 13);
			this.BackLink.Name = "BackLink";
			this.BackLink.Size = new System.Drawing.Size(32, 13);
			this.BackLink.TabIndex = 7;
			this.BackLink.TabStop = true;
			this.BackLink.Text = "Back";
			this.BackLink.Visible = false;
			this.BackLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.BackLink_LinkClicked);
			// 
			// RenderShortTextBox
			// 
			this.RenderShortTextBox.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.RenderShortTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.RenderShortTextBox.Location = new System.Drawing.Point(85, 89);
			this.RenderShortTextBox.Name = "RenderShortTextBox";
			this.RenderShortTextBox.ReadOnly = true;
			this.RenderShortTextBox.Size = new System.Drawing.Size(380, 13);
			this.RenderShortTextBox.TabIndex = 9;
			// 
			// RenderShortLabel
			// 
			this.RenderShortLabel.AutoSize = true;
			this.RenderShortLabel.Location = new System.Drawing.Point(12, 89);
			this.RenderShortLabel.Name = "RenderShortLabel";
			this.RenderShortLabel.Size = new System.Drawing.Size(35, 13);
			this.RenderShortLabel.TabIndex = 8;
			this.RenderShortLabel.Text = "Short:";
			// 
			// RenderMediumTextBox
			// 
			this.RenderMediumTextBox.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.RenderMediumTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.RenderMediumTextBox.Location = new System.Drawing.Point(85, 108);
			this.RenderMediumTextBox.Name = "RenderMediumTextBox";
			this.RenderMediumTextBox.ReadOnly = true;
			this.RenderMediumTextBox.Size = new System.Drawing.Size(380, 13);
			this.RenderMediumTextBox.TabIndex = 11;
			// 
			// RenderMediumLabel
			// 
			this.RenderMediumLabel.AutoSize = true;
			this.RenderMediumLabel.Location = new System.Drawing.Point(12, 108);
			this.RenderMediumLabel.Name = "RenderMediumLabel";
			this.RenderMediumLabel.Size = new System.Drawing.Size(47, 13);
			this.RenderMediumLabel.TabIndex = 10;
			this.RenderMediumLabel.Text = "Medium:";
			// 
			// RenderLongTextBox
			// 
			this.RenderLongTextBox.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.RenderLongTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.RenderLongTextBox.Location = new System.Drawing.Point(85, 127);
			this.RenderLongTextBox.Name = "RenderLongTextBox";
			this.RenderLongTextBox.ReadOnly = true;
			this.RenderLongTextBox.Size = new System.Drawing.Size(380, 13);
			this.RenderLongTextBox.TabIndex = 13;
			// 
			// RenderLongLabel
			// 
			this.RenderLongLabel.AutoSize = true;
			this.RenderLongLabel.Location = new System.Drawing.Point(12, 127);
			this.RenderLongLabel.Name = "RenderLongLabel";
			this.RenderLongLabel.Size = new System.Drawing.Size(34, 13);
			this.RenderLongLabel.TabIndex = 12;
			this.RenderLongLabel.Text = "Long:";
			// 
			// RenderDisplayTextBox
			// 
			this.RenderDisplayTextBox.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.RenderDisplayTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.RenderDisplayTextBox.Location = new System.Drawing.Point(85, 146);
			this.RenderDisplayTextBox.Name = "RenderDisplayTextBox";
			this.RenderDisplayTextBox.ReadOnly = true;
			this.RenderDisplayTextBox.Size = new System.Drawing.Size(380, 13);
			this.RenderDisplayTextBox.TabIndex = 15;
			// 
			// RenderDisplayLabel
			// 
			this.RenderDisplayLabel.AutoSize = true;
			this.RenderDisplayLabel.Location = new System.Drawing.Point(12, 146);
			this.RenderDisplayLabel.Name = "RenderDisplayLabel";
			this.RenderDisplayLabel.Size = new System.Drawing.Size(44, 13);
			this.RenderDisplayLabel.TabIndex = 14;
			this.RenderDisplayLabel.Text = "Display:";
			// 
			// ReferenceForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(484, 262);
			this.Controls.Add(this.RenderDisplayTextBox);
			this.Controls.Add(this.RenderDisplayLabel);
			this.Controls.Add(this.RenderLongTextBox);
			this.Controls.Add(this.RenderLongLabel);
			this.Controls.Add(this.RenderMediumTextBox);
			this.Controls.Add(this.RenderMediumLabel);
			this.Controls.Add(this.RenderShortTextBox);
			this.Controls.Add(this.RenderShortLabel);
			this.Controls.Add(this.BackLink);
			this.Controls.Add(this.RangeEndLink);
			this.Controls.Add(this.RangeStartLink);
			this.Controls.Add(this.DataTypeLink);
			this.Controls.Add(this.RangeEndLabel);
			this.Controls.Add(this.RangeStartLabel);
			this.Controls.Add(this.DataTypeLabel);
			this.Controls.Add(this.ReferenceTextBox);
			this.Controls.Add(this.ReferenceLabel);
			this.MinimumSize = new System.Drawing.Size(500, 300);
			this.Name = "ReferenceForm";
			this.Text = "Data Type Reference Viewer";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label ReferenceLabel;
		private System.Windows.Forms.TextBox ReferenceTextBox;
		private System.Windows.Forms.Label DataTypeLabel;
		private System.Windows.Forms.LinkLabel DataTypeLink;
		private System.Windows.Forms.Label RangeStartLabel;
		private System.Windows.Forms.LinkLabel RangeStartLink;
		private System.Windows.Forms.Label RangeEndLabel;
		private System.Windows.Forms.LinkLabel RangeEndLink;
		private System.Windows.Forms.LinkLabel BackLink;
		private System.Windows.Forms.TextBox RenderShortTextBox;
		private System.Windows.Forms.Label RenderShortLabel;
		private System.Windows.Forms.TextBox RenderMediumTextBox;
		private System.Windows.Forms.Label RenderMediumLabel;
		private System.Windows.Forms.TextBox RenderLongTextBox;
		private System.Windows.Forms.Label RenderLongLabel;
		private System.Windows.Forms.TextBox RenderDisplayTextBox;
		private System.Windows.Forms.Label RenderDisplayLabel;
	}
}

