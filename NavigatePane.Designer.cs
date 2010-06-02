namespace Logos4ComApiDemo
{
	partial class NavigatePane
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
			this.ResourceIdLabel = new System.Windows.Forms.Label();
			this.ArticleLabel = new System.Windows.Forms.Label();
			this.ReferenceLabel = new System.Windows.Forms.Label();
			this.HeadwordLabel = new System.Windows.Forms.Label();
			this.HeadwordLanguageLabel = new System.Windows.Forms.Label();
			this.ResourceIdTextBox = new System.Windows.Forms.TextBox();
			this.ArticleTextBox = new System.Windows.Forms.TextBox();
			this.ReferenceTextBox = new System.Windows.Forms.TextBox();
			this.HeadwordTextBox = new System.Windows.Forms.TextBox();
			this.HeadwordLanguageTextBox = new System.Windows.Forms.TextBox();
			this.NavigateButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// ResourceIdLabel
			// 
			this.ResourceIdLabel.AutoSize = true;
			this.ResourceIdLabel.Location = new System.Drawing.Point(4, 7);
			this.ResourceIdLabel.Name = "ResourceIdLabel";
			this.ResourceIdLabel.Size = new System.Drawing.Size(70, 13);
			this.ResourceIdLabel.TabIndex = 0;
			this.ResourceIdLabel.Text = "Re&source ID:";
			// 
			// ArticleLabel
			// 
			this.ArticleLabel.AutoSize = true;
			this.ArticleLabel.Location = new System.Drawing.Point(4, 33);
			this.ArticleLabel.Name = "ArticleLabel";
			this.ArticleLabel.Size = new System.Drawing.Size(39, 13);
			this.ArticleLabel.TabIndex = 2;
			this.ArticleLabel.Text = "&Article:";
			// 
			// ReferenceLabel
			// 
			this.ReferenceLabel.AutoSize = true;
			this.ReferenceLabel.Location = new System.Drawing.Point(4, 59);
			this.ReferenceLabel.Name = "ReferenceLabel";
			this.ReferenceLabel.Size = new System.Drawing.Size(60, 13);
			this.ReferenceLabel.TabIndex = 4;
			this.ReferenceLabel.Text = "&Reference:";
			// 
			// HeadwordLabel
			// 
			this.HeadwordLabel.AutoSize = true;
			this.HeadwordLabel.Location = new System.Drawing.Point(4, 85);
			this.HeadwordLabel.Name = "HeadwordLabel";
			this.HeadwordLabel.Size = new System.Drawing.Size(59, 13);
			this.HeadwordLabel.TabIndex = 6;
			this.HeadwordLabel.Text = "&Headword:";
			// 
			// HeadwordLanguageLabel
			// 
			this.HeadwordLanguageLabel.AutoSize = true;
			this.HeadwordLanguageLabel.Location = new System.Drawing.Point(4, 111);
			this.HeadwordLanguageLabel.Name = "HeadwordLanguageLabel";
			this.HeadwordLanguageLabel.Size = new System.Drawing.Size(58, 13);
			this.HeadwordLanguageLabel.TabIndex = 8;
			this.HeadwordLanguageLabel.Text = "&Language:";
			// 
			// ResourceIdTextBox
			// 
			this.ResourceIdTextBox.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.ResourceIdTextBox.Location = new System.Drawing.Point(77, 4);
			this.ResourceIdTextBox.Name = "ResourceIdTextBox";
			this.ResourceIdTextBox.Size = new System.Drawing.Size(220, 20);
			this.ResourceIdTextBox.TabIndex = 1;
			this.ResourceIdTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.NavigateTextBox_KeyDown);
			// 
			// ArticleTextBox
			// 
			this.ArticleTextBox.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.ArticleTextBox.Location = new System.Drawing.Point(77, 30);
			this.ArticleTextBox.Name = "ArticleTextBox";
			this.ArticleTextBox.Size = new System.Drawing.Size(220, 20);
			this.ArticleTextBox.TabIndex = 3;
			this.ArticleTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.NavigateTextBox_KeyDown);
			// 
			// ReferenceTextBox
			// 
			this.ReferenceTextBox.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.ReferenceTextBox.Location = new System.Drawing.Point(77, 56);
			this.ReferenceTextBox.Name = "ReferenceTextBox";
			this.ReferenceTextBox.Size = new System.Drawing.Size(220, 20);
			this.ReferenceTextBox.TabIndex = 5;
			this.ReferenceTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.NavigateTextBox_KeyDown);
			// 
			// HeadwordTextBox
			// 
			this.HeadwordTextBox.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.HeadwordTextBox.Location = new System.Drawing.Point(77, 82);
			this.HeadwordTextBox.Name = "HeadwordTextBox";
			this.HeadwordTextBox.Size = new System.Drawing.Size(220, 20);
			this.HeadwordTextBox.TabIndex = 7;
			this.HeadwordTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.NavigateTextBox_KeyDown);
			// 
			// HeadwordLanguageTextBox
			// 
			this.HeadwordLanguageTextBox.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.HeadwordLanguageTextBox.Location = new System.Drawing.Point(77, 108);
			this.HeadwordLanguageTextBox.Name = "HeadwordLanguageTextBox";
			this.HeadwordLanguageTextBox.Size = new System.Drawing.Size(220, 20);
			this.HeadwordLanguageTextBox.TabIndex = 9;
			this.HeadwordLanguageTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.NavigateTextBox_KeyDown);
			// 
			// NavigateButton
			// 
			this.NavigateButton.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.NavigateButton.Location = new System.Drawing.Point(221, 135);
			this.NavigateButton.Name = "NavigateButton";
			this.NavigateButton.Size = new System.Drawing.Size(75, 23);
			this.NavigateButton.TabIndex = 10;
			this.NavigateButton.Text = "&Navigate";
			this.NavigateButton.UseVisualStyleBackColor = true;
			this.NavigateButton.Click += new System.EventHandler(this.NavigateButton_Click);
			// 
			// NavigatePane
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.NavigateButton);
			this.Controls.Add(this.HeadwordLanguageTextBox);
			this.Controls.Add(this.HeadwordTextBox);
			this.Controls.Add(this.ReferenceTextBox);
			this.Controls.Add(this.ArticleTextBox);
			this.Controls.Add(this.ResourceIdTextBox);
			this.Controls.Add(this.HeadwordLanguageLabel);
			this.Controls.Add(this.HeadwordLabel);
			this.Controls.Add(this.ReferenceLabel);
			this.Controls.Add(this.ArticleLabel);
			this.Controls.Add(this.ResourceIdLabel);
			this.Name = "NavigatePane";
			this.Size = new System.Drawing.Size(300, 300);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label ResourceIdLabel;
		private System.Windows.Forms.Label ArticleLabel;
		private System.Windows.Forms.Label ReferenceLabel;
		private System.Windows.Forms.Label HeadwordLabel;
		private System.Windows.Forms.Label HeadwordLanguageLabel;
		private System.Windows.Forms.TextBox ResourceIdTextBox;
		private System.Windows.Forms.TextBox ArticleTextBox;
		private System.Windows.Forms.TextBox ReferenceTextBox;
		private System.Windows.Forms.TextBox HeadwordTextBox;
		private System.Windows.Forms.TextBox HeadwordLanguageTextBox;
		private System.Windows.Forms.Button NavigateButton;

	}
}
