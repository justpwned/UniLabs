namespace Lab4Home.Forms
{
	partial class InfoForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InfoForm));
			this.subListBox = new System.Windows.Forms.ListBox();
			this.pubListBox = new System.Windows.Forms.ListBox();
			this.dateLabel = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.numLabel = new System.Windows.Forms.Label();
			this.statusLabel = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.inceptionDateLabel = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.pubTypeLabel = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// subListBox
			// 
			this.subListBox.FormattingEnabled = true;
			this.subListBox.Location = new System.Drawing.Point(412, 45);
			this.subListBox.Name = "subListBox";
			this.subListBox.Size = new System.Drawing.Size(201, 225);
			this.subListBox.TabIndex = 8;
			// 
			// pubListBox
			// 
			this.pubListBox.FormattingEnabled = true;
			this.pubListBox.Location = new System.Drawing.Point(16, 45);
			this.pubListBox.Name = "pubListBox";
			this.pubListBox.Size = new System.Drawing.Size(201, 225);
			this.pubListBox.TabIndex = 7;
			this.pubListBox.SelectedIndexChanged += new System.EventHandler(this.pubListBox_SelectedIndexChanged);
			// 
			// dateLabel
			// 
			this.dateLabel.AutoSize = true;
			this.dateLabel.Location = new System.Drawing.Point(13, 20);
			this.dateLabel.Name = "dateLabel";
			this.dateLabel.Size = new System.Drawing.Size(35, 13);
			this.dateLabel.TabIndex = 9;
			this.dateLabel.Text = "label1";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(223, 45);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(44, 13);
			this.label1.TabIndex = 10;
			this.label1.Text = "Номер:";
			// 
			// numLabel
			// 
			this.numLabel.AutoSize = true;
			this.numLabel.Location = new System.Drawing.Point(273, 45);
			this.numLabel.Name = "numLabel";
			this.numLabel.Size = new System.Drawing.Size(0, 13);
			this.numLabel.TabIndex = 11;
			// 
			// statusLabel
			// 
			this.statusLabel.AutoSize = true;
			this.statusLabel.Location = new System.Drawing.Point(272, 68);
			this.statusLabel.Name = "statusLabel";
			this.statusLabel.Size = new System.Drawing.Size(0, 13);
			this.statusLabel.TabIndex = 13;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(222, 68);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(44, 13);
			this.label3.TabIndex = 12;
			this.label3.Text = "Статус:";
			// 
			// inceptionDateLabel
			// 
			this.inceptionDateLabel.AutoSize = true;
			this.inceptionDateLabel.Location = new System.Drawing.Point(316, 90);
			this.inceptionDateLabel.Name = "inceptionDateLabel";
			this.inceptionDateLabel.Size = new System.Drawing.Size(0, 13);
			this.inceptionDateLabel.TabIndex = 15;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(223, 90);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(87, 13);
			this.label4.TabIndex = 14;
			this.label4.Text = "Дата открытия:";
			// 
			// pubTypeLabel
			// 
			this.pubTypeLabel.AutoSize = true;
			this.pubTypeLabel.Location = new System.Drawing.Point(258, 112);
			this.pubTypeLabel.Name = "pubTypeLabel";
			this.pubTypeLabel.Size = new System.Drawing.Size(0, 13);
			this.pubTypeLabel.TabIndex = 17;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(223, 112);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(29, 13);
			this.label5.TabIndex = 16;
			this.label5.Text = "Тип:";
			// 
			// InfoForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(624, 283);
			this.Controls.Add(this.pubTypeLabel);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.inceptionDateLabel);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.statusLabel);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.numLabel);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dateLabel);
			this.Controls.Add(this.subListBox);
			this.Controls.Add(this.pubListBox);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "InfoForm";
			this.Text = "Информация";
			this.Load += new System.EventHandler(this.InfoForm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListBox subListBox;
		private System.Windows.Forms.ListBox pubListBox;
		private System.Windows.Forms.Label dateLabel;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label numLabel;
		private System.Windows.Forms.Label statusLabel;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label inceptionDateLabel;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label pubTypeLabel;
		private System.Windows.Forms.Label label5;
	}
}