namespace Logos4ComApiDemo
{
	partial class LaunchPane
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
			this.ApplicationReadyLabel = new System.Windows.Forms.Label();
			this.LaunchButton = new System.Windows.Forms.Button();
			this.CommandLineLabel = new System.Windows.Forms.Label();
			this.CommandLineComboBox = new System.Windows.Forms.ComboBox();
			this.RefreshLabel = new System.Windows.Forms.LinkLabel();
			this.SuspendLayout();
			// 
			// ApplicationReadyLabel
			// 
			this.ApplicationReadyLabel.AutoSize = true;
			this.ApplicationReadyLabel.Location = new System.Drawing.Point(3, 4);
			this.ApplicationReadyLabel.Name = "ApplicationReadyLabel";
			this.ApplicationReadyLabel.Size = new System.Drawing.Size(67, 13);
			this.ApplicationReadyLabel.TabIndex = 0;
			this.ApplicationReadyLabel.Text = "Logos 4 is ...";
			// 
			// LaunchButton
			// 
			this.LaunchButton.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.LaunchButton.Location = new System.Drawing.Point(222, 76);
			this.LaunchButton.Name = "LaunchButton";
			this.LaunchButton.Size = new System.Drawing.Size(75, 23);
			this.LaunchButton.TabIndex = 4;
			this.LaunchButton.Text = "Launch!";
			this.LaunchButton.UseVisualStyleBackColor = true;
			this.LaunchButton.Click += new System.EventHandler(this.LaunchButton_Click);
			// 
			// CommandLineLabel
			// 
			this.CommandLineLabel.AutoSize = true;
			this.CommandLineLabel.Location = new System.Drawing.Point(3, 32);
			this.CommandLineLabel.Name = "CommandLineLabel";
			this.CommandLineLabel.Size = new System.Drawing.Size(169, 13);
			this.CommandLineLabel.TabIndex = 2;
			this.CommandLineLabel.Text = "Optional command-line arguments:";
			// 
			// CommandLineComboBox
			// 
			this.CommandLineComboBox.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.CommandLineComboBox.FormattingEnabled = true;
			this.CommandLineComboBox.Items.AddRange(new object[] {
            "logosref:Bible.Ge1.1",
            "logosres:esv",
            "logos4:people;id=Moses"});
			this.CommandLineComboBox.Location = new System.Drawing.Point(6, 49);
			this.CommandLineComboBox.Name = "CommandLineComboBox";
			this.CommandLineComboBox.Size = new System.Drawing.Size(291, 21);
			this.CommandLineComboBox.TabIndex = 3;
			// 
			// RefreshLabel
			// 
			this.RefreshLabel.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.RefreshLabel.AutoSize = true;
			this.RefreshLabel.Location = new System.Drawing.Point(253, 4);
			this.RefreshLabel.Name = "RefreshLabel";
			this.RefreshLabel.Size = new System.Drawing.Size(44, 13);
			this.RefreshLabel.TabIndex = 1;
			this.RefreshLabel.TabStop = true;
			this.RefreshLabel.Text = "Refresh";
			this.RefreshLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
			this.RefreshLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.RefreshLabel_LinkClicked);
			// 
			// LaunchPane
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.RefreshLabel);
			this.Controls.Add(this.CommandLineComboBox);
			this.Controls.Add(this.CommandLineLabel);
			this.Controls.Add(this.LaunchButton);
			this.Controls.Add(this.ApplicationReadyLabel);
			this.Name = "LaunchPane";
			this.Size = new System.Drawing.Size(300, 300);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label ApplicationReadyLabel;
		private System.Windows.Forms.Button LaunchButton;
		private System.Windows.Forms.Label CommandLineLabel;
		private System.Windows.Forms.ComboBox CommandLineComboBox;
		private System.Windows.Forms.LinkLabel RefreshLabel;
	}
}
