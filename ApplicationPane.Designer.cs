namespace Logos4ComApiDemo
{
	partial class ApplicationPane
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
			this.ApiVersionLabel = new System.Windows.Forms.Label();
			this.ActivateLink = new System.Windows.Forms.LinkLabel();
			this.ExitLink = new System.Windows.Forms.LinkLabel();
			this.UriLabel = new System.Windows.Forms.Label();
			this.UriComboBox = new System.Windows.Forms.ComboBox();
			this.UriGoButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// ApiVersionLabel
			// 
			this.ApiVersionLabel.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.ApiVersionLabel.AutoSize = true;
			this.ApiVersionLabel.Location = new System.Drawing.Point(5, 278);
			this.ApiVersionLabel.Name = "ApiVersionLabel";
			this.ApiVersionLabel.Size = new System.Drawing.Size(62, 13);
			this.ApiVersionLabel.TabIndex = 5;
			this.ApiVersionLabel.Text = "API Version";
			// 
			// ActivateLink
			// 
			this.ActivateLink.AutoSize = true;
			this.ActivateLink.Location = new System.Drawing.Point(3, 39);
			this.ActivateLink.Name = "ActivateLink";
			this.ActivateLink.Size = new System.Drawing.Size(87, 13);
			this.ActivateLink.TabIndex = 3;
			this.ActivateLink.TabStop = true;
			this.ActivateLink.Text = "Activate Logos 4";
			this.ActivateLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ActivateLink_LinkClicked);
			// 
			// ExitLink
			// 
			this.ExitLink.AutoSize = true;
			this.ExitLink.Location = new System.Drawing.Point(3, 61);
			this.ExitLink.Name = "ExitLink";
			this.ExitLink.Size = new System.Drawing.Size(65, 13);
			this.ExitLink.TabIndex = 4;
			this.ExitLink.TabStop = true;
			this.ExitLink.Text = "Exit Logos 4";
			this.ExitLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ExitLink_LinkClicked);
			// 
			// UriLabel
			// 
			this.UriLabel.AutoSize = true;
			this.UriLabel.Location = new System.Drawing.Point(5, 9);
			this.UriLabel.Name = "UriLabel";
			this.UriLabel.Size = new System.Drawing.Size(23, 13);
			this.UriLabel.TabIndex = 0;
			this.UriLabel.Text = "Uri:";
			// 
			// UriComboBox
			// 
			this.UriComboBox.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.UriComboBox.FormattingEnabled = true;
			this.UriComboBox.Items.AddRange(new object[] {
            "logosref:Bible.Ge1.1",
            "logosres:esv",
            "logos4:people;id=Moses"});
			this.UriComboBox.Location = new System.Drawing.Point(34, 6);
			this.UriComboBox.Name = "UriComboBox";
			this.UriComboBox.Size = new System.Drawing.Size(216, 21);
			this.UriComboBox.TabIndex = 1;
			// 
			// UriGoButton
			// 
			this.UriGoButton.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.UriGoButton.AutoSize = true;
			this.UriGoButton.Location = new System.Drawing.Point(256, 4);
			this.UriGoButton.Name = "UriGoButton";
			this.UriGoButton.Size = new System.Drawing.Size(41, 23);
			this.UriGoButton.TabIndex = 2;
			this.UriGoButton.Text = "Go";
			this.UriGoButton.UseVisualStyleBackColor = true;
			this.UriGoButton.Click += new System.EventHandler(this.UriGoButton_Click);
			// 
			// ApplicationPane
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.UriGoButton);
			this.Controls.Add(this.UriComboBox);
			this.Controls.Add(this.UriLabel);
			this.Controls.Add(this.ExitLink);
			this.Controls.Add(this.ActivateLink);
			this.Controls.Add(this.ApiVersionLabel);
			this.Name = "ApplicationPane";
			this.Size = new System.Drawing.Size(300, 300);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label ApiVersionLabel;
		private System.Windows.Forms.LinkLabel ActivateLink;
		private System.Windows.Forms.LinkLabel ExitLink;
		private System.Windows.Forms.Label UriLabel;
		private System.Windows.Forms.ComboBox UriComboBox;
		private System.Windows.Forms.Button UriGoButton;
	}
}
