namespace Lab4Home
{
	partial class NewSubForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewSubForm));
			this.subNameLabel = new System.Windows.Forms.Label();
			this.subNameTextBox = new System.Windows.Forms.TextBox();
			this.regSubButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// subNameLabel
			// 
			this.subNameLabel.AutoSize = true;
			this.subNameLabel.Location = new System.Drawing.Point(14, 15);
			this.subNameLabel.Name = "subNameLabel";
			this.subNameLabel.Size = new System.Drawing.Size(94, 13);
			this.subNameLabel.TabIndex = 4;
			this.subNameLabel.Text = "Имя подписчика:";
			// 
			// subNameTextBox
			// 
			this.subNameTextBox.Location = new System.Drawing.Point(114, 12);
			this.subNameTextBox.Name = "subNameTextBox";
			this.subNameTextBox.Size = new System.Drawing.Size(204, 20);
			this.subNameTextBox.TabIndex = 3;
			this.subNameTextBox.TextChanged += new System.EventHandler(this.subNameTextBox_TextChanged);
			// 
			// regSubButton
			// 
			this.regSubButton.Enabled = false;
			this.regSubButton.Location = new System.Drawing.Point(114, 45);
			this.regSubButton.Name = "regSubButton";
			this.regSubButton.Size = new System.Drawing.Size(123, 23);
			this.regSubButton.TabIndex = 5;
			this.regSubButton.Text = "Зарегистрировать";
			this.regSubButton.UseVisualStyleBackColor = true;
			this.regSubButton.Click += new System.EventHandler(this.regSubButton_Click);
			// 
			// NewSubForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(338, 80);
			this.Controls.Add(this.regSubButton);
			this.Controls.Add(this.subNameLabel);
			this.Controls.Add(this.subNameTextBox);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "NewSubForm";
			this.Text = "Регистрация нового подписчика";
			this.Load += new System.EventHandler(this.NewSubForm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label subNameLabel;
		private System.Windows.Forms.TextBox subNameTextBox;
		private System.Windows.Forms.Button regSubButton;
	}
}