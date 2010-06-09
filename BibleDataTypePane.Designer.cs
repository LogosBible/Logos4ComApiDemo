namespace Logos4ComApiDemo
{
	partial class BibleDataTypePane
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
			this.FirstBookLabel = new System.Windows.Forms.Label();
			this.LastBookLabel = new System.Windows.Forms.Label();
			this.LastBookLink = new Logos4ComApiDemo.ReferenceLinkLabel();
			this.FirstBookLink = new Logos4ComApiDemo.ReferenceLinkLabel();
			this.SuspendLayout();
			// 
			// FirstBookLabel
			// 
			this.FirstBookLabel.AutoSize = true;
			this.FirstBookLabel.Location = new System.Drawing.Point(2, 4);
			this.FirstBookLabel.Name = "FirstBookLabel";
			this.FirstBookLabel.Size = new System.Drawing.Size(57, 13);
			this.FirstBookLabel.TabIndex = 0;
			this.FirstBookLabel.Text = "First Book:";
			// 
			// LastBookLabel
			// 
			this.LastBookLabel.AutoSize = true;
			this.LastBookLabel.Location = new System.Drawing.Point(2, 23);
			this.LastBookLabel.Name = "LastBookLabel";
			this.LastBookLabel.Size = new System.Drawing.Size(58, 13);
			this.LastBookLabel.TabIndex = 2;
			this.LastBookLabel.Text = "Last Book:";
			// 
			// LastBookLink
			// 
			this.LastBookLink.AutoSize = true;
			this.LastBookLink.Location = new System.Drawing.Point(66, 23);
			this.LastBookLink.Name = "LastBookLink";
			this.LastBookLink.Reference = null;
			this.LastBookLink.Size = new System.Drawing.Size(0, 13);
			this.LastBookLink.TabIndex = 3;
			// 
			// FirstBookLink
			// 
			this.FirstBookLink.AutoSize = true;
			this.FirstBookLink.Location = new System.Drawing.Point(66, 4);
			this.FirstBookLink.Name = "FirstBookLink";
			this.FirstBookLink.Reference = null;
			this.FirstBookLink.Size = new System.Drawing.Size(0, 13);
			this.FirstBookLink.TabIndex = 1;
			// 
			// BibleDataTypePane
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.LastBookLink);
			this.Controls.Add(this.FirstBookLink);
			this.Controls.Add(this.LastBookLabel);
			this.Controls.Add(this.FirstBookLabel);
			this.Name = "BibleDataTypePane";
			this.Size = new System.Drawing.Size(450, 120);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label FirstBookLabel;
		private System.Windows.Forms.Label LastBookLabel;
		private ReferenceLinkLabel FirstBookLink;
		private ReferenceLinkLabel LastBookLink;
	}
}
