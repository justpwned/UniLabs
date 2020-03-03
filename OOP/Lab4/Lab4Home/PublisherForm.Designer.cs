namespace Lab4Home
{
	partial class PublisherForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PublisherForm));
			this.newsTimer = new System.Windows.Forms.Timer(this.components);
			this.openPub = new System.Windows.Forms.Button();
			this.pubListBox = new System.Windows.Forms.ListBox();
			this.SuspendLayout();
			// 
			// openPub
			// 
			this.openPub.Location = new System.Drawing.Point(12, 12);
			this.openPub.Name = "openPub";
			this.openPub.Size = new System.Drawing.Size(133, 23);
			this.openPub.TabIndex = 0;
			this.openPub.Text = "Открыть издание";
			this.openPub.UseVisualStyleBackColor = true;
			this.openPub.Click += new System.EventHandler(this.openPub_Click);
			// 
			// pubListBox
			// 
			this.pubListBox.FormattingEnabled = true;
			this.pubListBox.Location = new System.Drawing.Point(12, 41);
			this.pubListBox.Name = "pubListBox";
			this.pubListBox.Size = new System.Drawing.Size(295, 225);
			this.pubListBox.TabIndex = 1;
			// 
			// PublisherForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(505, 489);
			this.Controls.Add(this.pubListBox);
			this.Controls.Add(this.openPub);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "PublisherForm";
			this.Text = "Издатель";
			this.Load += new System.EventHandler(this.PublisherForm_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Timer newsTimer;
		private System.Windows.Forms.Button openPub;
		private System.Windows.Forms.ListBox pubListBox;
	}
}

