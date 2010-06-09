namespace Logos4ComApiDemo
{
	partial class MainForm
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
			this.components = new System.ComponentModel.Container();
			this.ThePanel = new System.Windows.Forms.Panel();
			this.RefreshApplicationTimer = new System.Windows.Forms.Timer(this.components);
			this.FeaturesLabel = new System.Windows.Forms.Label();
			this.FeaturesListBox = new System.Windows.Forms.ListBox();
			this.EventsLabel = new System.Windows.Forms.Label();
			this.EventsListBox = new System.Windows.Forms.ListBox();
			this.EventCountLabel = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// ThePanel
			// 
			this.ThePanel.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.ThePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.ThePanel.Location = new System.Drawing.Point(172, 12);
			this.ThePanel.Name = "ThePanel";
			this.ThePanel.Size = new System.Drawing.Size(300, 290);
			this.ThePanel.TabIndex = 2;
			// 
			// RefreshApplicationTimer
			// 
			this.RefreshApplicationTimer.Interval = 1000;
			// 
			// FeaturesLabel
			// 
			this.FeaturesLabel.AutoSize = true;
			this.FeaturesLabel.Location = new System.Drawing.Point(12, 9);
			this.FeaturesLabel.Name = "FeaturesLabel";
			this.FeaturesLabel.Size = new System.Drawing.Size(51, 13);
			this.FeaturesLabel.TabIndex = 0;
			this.FeaturesLabel.Text = "&Features:";
			// 
			// FeaturesListBox
			// 
			this.FeaturesListBox.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)));
			this.FeaturesListBox.FormattingEnabled = true;
			this.FeaturesListBox.Items.AddRange(new object[] {
            "Launch",
            "Application",
            "Navigate",
            "DataTypes"});
			this.FeaturesListBox.Location = new System.Drawing.Point(12, 25);
			this.FeaturesListBox.Name = "FeaturesListBox";
			this.FeaturesListBox.Size = new System.Drawing.Size(154, 277);
			this.FeaturesListBox.TabIndex = 1;
			this.FeaturesListBox.SelectedIndexChanged += new System.EventHandler(this.FeaturesListBox_SelectedIndexChanged);
			// 
			// EventsLabel
			// 
			this.EventsLabel.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.EventsLabel.AutoSize = true;
			this.EventsLabel.Location = new System.Drawing.Point(12, 315);
			this.EventsLabel.Name = "EventsLabel";
			this.EventsLabel.Size = new System.Drawing.Size(43, 13);
			this.EventsLabel.TabIndex = 3;
			this.EventsLabel.Text = "&Events:";
			// 
			// EventsListBox
			// 
			this.EventsListBox.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.EventsListBox.FormattingEnabled = true;
			this.EventsListBox.Location = new System.Drawing.Point(12, 331);
			this.EventsListBox.Name = "EventsListBox";
			this.EventsListBox.Size = new System.Drawing.Size(460, 121);
			this.EventsListBox.TabIndex = 4;
			// 
			// EventCountLabel
			// 
			this.EventCountLabel.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.EventCountLabel.Location = new System.Drawing.Point(422, 315);
			this.EventCountLabel.Name = "EventCountLabel";
			this.EventCountLabel.Size = new System.Drawing.Size(50, 13);
			this.EventCountLabel.TabIndex = 5;
			this.EventCountLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(484, 462);
			this.Controls.Add(this.EventCountLabel);
			this.Controls.Add(this.EventsListBox);
			this.Controls.Add(this.EventsLabel);
			this.Controls.Add(this.FeaturesListBox);
			this.Controls.Add(this.FeaturesLabel);
			this.Controls.Add(this.ThePanel);
			this.MinimumSize = new System.Drawing.Size(500, 500);
			this.Name = "MainForm";
			this.Text = "Logos 4 COM API Demo";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel ThePanel;
		private System.Windows.Forms.Timer RefreshApplicationTimer;
		private System.Windows.Forms.Label FeaturesLabel;
		private System.Windows.Forms.ListBox FeaturesListBox;
		private System.Windows.Forms.Label EventsLabel;
		private System.Windows.Forms.ListBox EventsListBox;
		private System.Windows.Forms.Label EventCountLabel;
	}
}

