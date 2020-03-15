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
			this.dayTimer = new System.Windows.Forms.Timer(this.components);
			this.openPub = new System.Windows.Forms.Button();
			this.pubListBox = new System.Windows.Forms.ListBox();
			this.logsTextBox = new System.Windows.Forms.TextBox();
			this.stopStartPubButton = new System.Windows.Forms.Button();
			this.closePubButton = new System.Windows.Forms.Button();
			this.subListBox = new System.Windows.Forms.ListBox();
			this.regSubButton = new System.Windows.Forms.Button();
			this.subButton = new System.Windows.Forms.Button();
			this.unsubButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// dayTimer
			// 
			this.dayTimer.Enabled = true;
			this.dayTimer.Interval = 5000;
			this.dayTimer.Tick += new System.EventHandler(this.dayTimer_Tick);
			// 
			// openPub
			// 
			this.openPub.Location = new System.Drawing.Point(12, 11);
			this.openPub.Name = "openPub";
			this.openPub.Size = new System.Drawing.Size(201, 23);
			this.openPub.TabIndex = 0;
			this.openPub.Text = "Открыть новое издание";
			this.openPub.UseVisualStyleBackColor = true;
			this.openPub.Click += new System.EventHandler(this.openPub_Click);
			// 
			// pubListBox
			// 
			this.pubListBox.FormattingEnabled = true;
			this.pubListBox.Location = new System.Drawing.Point(12, 40);
			this.pubListBox.Name = "pubListBox";
			this.pubListBox.Size = new System.Drawing.Size(201, 225);
			this.pubListBox.TabIndex = 1;
			this.pubListBox.SelectedIndexChanged += new System.EventHandler(this.pubListBox_SelectedIndexChanged);
			// 
			// logsTextBox
			// 
			this.logsTextBox.Location = new System.Drawing.Point(12, 271);
			this.logsTextBox.Multiline = true;
			this.logsTextBox.Name = "logsTextBox";
			this.logsTextBox.ReadOnly = true;
			this.logsTextBox.Size = new System.Drawing.Size(595, 156);
			this.logsTextBox.TabIndex = 2;
			// 
			// stopStartPubButton
			// 
			this.stopStartPubButton.Enabled = false;
			this.stopStartPubButton.Location = new System.Drawing.Point(234, 40);
			this.stopStartPubButton.Name = "stopStartPubButton";
			this.stopStartPubButton.Size = new System.Drawing.Size(149, 23);
			this.stopStartPubButton.TabIndex = 3;
			this.stopStartPubButton.Text = "Приостановить издание";
			this.stopStartPubButton.UseVisualStyleBackColor = true;
			this.stopStartPubButton.Click += new System.EventHandler(this.stopStartPubButton_Click);
			// 
			// closePubButton
			// 
			this.closePubButton.Enabled = false;
			this.closePubButton.Location = new System.Drawing.Point(234, 69);
			this.closePubButton.Name = "closePubButton";
			this.closePubButton.Size = new System.Drawing.Size(149, 23);
			this.closePubButton.TabIndex = 4;
			this.closePubButton.Text = "Закрыть издание";
			this.closePubButton.UseVisualStyleBackColor = true;
			this.closePubButton.Click += new System.EventHandler(this.closePubButton_Click);
			// 
			// subListBox
			// 
			this.subListBox.FormattingEnabled = true;
			this.subListBox.Location = new System.Drawing.Point(406, 40);
			this.subListBox.Name = "subListBox";
			this.subListBox.Size = new System.Drawing.Size(201, 225);
			this.subListBox.TabIndex = 6;
			this.subListBox.SelectedIndexChanged += new System.EventHandler(this.subListBox_SelectedIndexChanged);
			// 
			// regSubButton
			// 
			this.regSubButton.Location = new System.Drawing.Point(406, 11);
			this.regSubButton.Name = "regSubButton";
			this.regSubButton.Size = new System.Drawing.Size(201, 23);
			this.regSubButton.TabIndex = 5;
			this.regSubButton.Text = "Регистрация подписчика";
			this.regSubButton.UseVisualStyleBackColor = true;
			this.regSubButton.Click += new System.EventHandler(this.regSubButton_Click);
			// 
			// subButton
			// 
			this.subButton.Enabled = false;
			this.subButton.Location = new System.Drawing.Point(234, 187);
			this.subButton.Name = "subButton";
			this.subButton.Size = new System.Drawing.Size(149, 23);
			this.subButton.TabIndex = 7;
			this.subButton.Text = "Подписать";
			this.subButton.UseVisualStyleBackColor = true;
			this.subButton.Click += new System.EventHandler(this.subButton_Click);
			// 
			// unsubButton
			// 
			this.unsubButton.Enabled = false;
			this.unsubButton.Location = new System.Drawing.Point(234, 216);
			this.unsubButton.Name = "unsubButton";
			this.unsubButton.Size = new System.Drawing.Size(149, 23);
			this.unsubButton.TabIndex = 8;
			this.unsubButton.Text = "Отписать";
			this.unsubButton.UseVisualStyleBackColor = true;
			this.unsubButton.Click += new System.EventHandler(this.unsubButton_Click);
			// 
			// PublisherForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(621, 439);
			this.Controls.Add(this.unsubButton);
			this.Controls.Add(this.subButton);
			this.Controls.Add(this.subListBox);
			this.Controls.Add(this.pubListBox);
			this.Controls.Add(this.regSubButton);
			this.Controls.Add(this.closePubButton);
			this.Controls.Add(this.logsTextBox);
			this.Controls.Add(this.openPub);
			this.Controls.Add(this.stopStartPubButton);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "PublisherForm";
			this.Text = "Издатель";
			this.Load += new System.EventHandler(this.PublisherForm_Load);
			this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PublisherForm_MouseDown);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Timer dayTimer;
		private System.Windows.Forms.Button openPub;
		private System.Windows.Forms.ListBox pubListBox;
		internal System.Windows.Forms.TextBox logsTextBox;
		private System.Windows.Forms.Button stopStartPubButton;
		private System.Windows.Forms.Button closePubButton;
		private System.Windows.Forms.ListBox subListBox;
		private System.Windows.Forms.Button regSubButton;
		private System.Windows.Forms.Button subButton;
		private System.Windows.Forms.Button unsubButton;
	}
}

