namespace Lab4Home
{
	partial class SubscriberForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SubscriberForm));
			this.availablePubsListBox = new System.Windows.Forms.ListBox();
			this.availablePubsLabel = new System.Windows.Forms.Label();
			this.unsubButton = new System.Windows.Forms.Button();
			this.subButton = new System.Windows.Forms.Button();
			this.logsTextBox = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// availablePubsListBox
			// 
			this.availablePubsListBox.FormattingEnabled = true;
			this.availablePubsListBox.Location = new System.Drawing.Point(12, 34);
			this.availablePubsListBox.Name = "availablePubsListBox";
			this.availablePubsListBox.Size = new System.Drawing.Size(187, 186);
			this.availablePubsListBox.TabIndex = 0;
			this.availablePubsListBox.SelectedIndexChanged += new System.EventHandler(this.availablePubsListBox_SelectedIndexChanged);
			// 
			// availablePubsLabel
			// 
			this.availablePubsLabel.AutoSize = true;
			this.availablePubsLabel.Location = new System.Drawing.Point(12, 9);
			this.availablePubsLabel.Name = "availablePubsLabel";
			this.availablePubsLabel.Size = new System.Drawing.Size(187, 13);
			this.availablePubsLabel.TabIndex = 1;
			this.availablePubsLabel.Text = "Доступные издания для подписки: ";
			// 
			// unsubButton
			// 
			this.unsubButton.Enabled = false;
			this.unsubButton.Location = new System.Drawing.Point(240, 114);
			this.unsubButton.Name = "unsubButton";
			this.unsubButton.Size = new System.Drawing.Size(149, 23);
			this.unsubButton.TabIndex = 10;
			this.unsubButton.Text = "Отписаться";
			this.unsubButton.UseVisualStyleBackColor = true;
			this.unsubButton.Click += new System.EventHandler(this.unsubButton_Click);
			// 
			// subButton
			// 
			this.subButton.Enabled = false;
			this.subButton.Location = new System.Drawing.Point(240, 85);
			this.subButton.Name = "subButton";
			this.subButton.Size = new System.Drawing.Size(149, 23);
			this.subButton.TabIndex = 9;
			this.subButton.Text = "Подписаться";
			this.subButton.UseVisualStyleBackColor = true;
			this.subButton.Click += new System.EventHandler(this.subButton_Click);
			// 
			// logsTextBox
			// 
			this.logsTextBox.Location = new System.Drawing.Point(12, 225);
			this.logsTextBox.Multiline = true;
			this.logsTextBox.Name = "logsTextBox";
			this.logsTextBox.ReadOnly = true;
			this.logsTextBox.Size = new System.Drawing.Size(398, 156);
			this.logsTextBox.TabIndex = 11;
			// 
			// SubscriberForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(422, 393);
			this.Controls.Add(this.logsTextBox);
			this.Controls.Add(this.unsubButton);
			this.Controls.Add(this.subButton);
			this.Controls.Add(this.availablePubsLabel);
			this.Controls.Add(this.availablePubsListBox);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "SubscriberForm";
			this.Text = "Подписчик";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SubscriberForm_FormClosing);
			this.Load += new System.EventHandler(this.SubscriberForm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListBox availablePubsListBox;
		private System.Windows.Forms.Label availablePubsLabel;
		private System.Windows.Forms.Button unsubButton;
		private System.Windows.Forms.Button subButton;
		private System.Windows.Forms.TextBox logsTextBox;
	}
}