namespace Lab4Home
{
	partial class NewPubForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewPubForm));
			this.pubTypeGroupBox = new System.Windows.Forms.GroupBox();
			this.magazineRadioButton = new System.Windows.Forms.RadioButton();
			this.newsRadioButton = new System.Windows.Forms.RadioButton();
			this.pubNameTextBox = new System.Windows.Forms.TextBox();
			this.pubNameLabel = new System.Windows.Forms.Label();
			this.publishButton = new System.Windows.Forms.Button();
			this.pubTypeGroupBox.SuspendLayout();
			this.SuspendLayout();
			// 
			// pubTypeGroupBox
			// 
			this.pubTypeGroupBox.Controls.Add(this.magazineRadioButton);
			this.pubTypeGroupBox.Controls.Add(this.newsRadioButton);
			this.pubTypeGroupBox.Location = new System.Drawing.Point(12, 12);
			this.pubTypeGroupBox.Name = "pubTypeGroupBox";
			this.pubTypeGroupBox.Size = new System.Drawing.Size(149, 72);
			this.pubTypeGroupBox.TabIndex = 0;
			this.pubTypeGroupBox.TabStop = false;
			this.pubTypeGroupBox.Text = "Тип издания";
			// 
			// magazineRadioButton
			// 
			this.magazineRadioButton.AutoSize = true;
			this.magazineRadioButton.Location = new System.Drawing.Point(6, 42);
			this.magazineRadioButton.Name = "magazineRadioButton";
			this.magazineRadioButton.Size = new System.Drawing.Size(65, 17);
			this.magazineRadioButton.TabIndex = 1;
			this.magazineRadioButton.TabStop = true;
			this.magazineRadioButton.Text = "Журнал";
			this.magazineRadioButton.UseVisualStyleBackColor = true;
			// 
			// newsRadioButton
			// 
			this.newsRadioButton.AutoSize = true;
			this.newsRadioButton.Location = new System.Drawing.Point(6, 19);
			this.newsRadioButton.Name = "newsRadioButton";
			this.newsRadioButton.Size = new System.Drawing.Size(60, 17);
			this.newsRadioButton.TabIndex = 0;
			this.newsRadioButton.TabStop = true;
			this.newsRadioButton.Text = "Газета";
			this.newsRadioButton.UseVisualStyleBackColor = true;
			// 
			// pubNameTextBox
			// 
			this.pubNameTextBox.Location = new System.Drawing.Point(180, 31);
			this.pubNameTextBox.Name = "pubNameTextBox";
			this.pubNameTextBox.Size = new System.Drawing.Size(204, 20);
			this.pubNameTextBox.TabIndex = 1;
			// 
			// pubNameLabel
			// 
			this.pubNameLabel.AutoSize = true;
			this.pubNameLabel.Location = new System.Drawing.Point(177, 12);
			this.pubNameLabel.Name = "pubNameLabel";
			this.pubNameLabel.Size = new System.Drawing.Size(60, 13);
			this.pubNameLabel.TabIndex = 2;
			this.pubNameLabel.Text = "Название:";
			// 
			// publishButton
			// 
			this.publishButton.Location = new System.Drawing.Point(145, 104);
			this.publishButton.Name = "publishButton";
			this.publishButton.Size = new System.Drawing.Size(92, 23);
			this.publishButton.TabIndex = 3;
			this.publishButton.Text = "Опубликовать";
			this.publishButton.UseVisualStyleBackColor = true;
			this.publishButton.Click += new System.EventHandler(this.publishButton_Click);
			// 
			// NewPubForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(396, 139);
			this.Controls.Add(this.publishButton);
			this.Controls.Add(this.pubNameLabel);
			this.Controls.Add(this.pubNameTextBox);
			this.Controls.Add(this.pubTypeGroupBox);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "NewPubForm";
			this.Text = "Открытие нового издания";
			this.pubTypeGroupBox.ResumeLayout(false);
			this.pubTypeGroupBox.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.GroupBox pubTypeGroupBox;
		private System.Windows.Forms.RadioButton magazineRadioButton;
		private System.Windows.Forms.RadioButton newsRadioButton;
		private System.Windows.Forms.TextBox pubNameTextBox;
		private System.Windows.Forms.Label pubNameLabel;
		private System.Windows.Forms.Button publishButton;
	}
}