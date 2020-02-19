namespace Lab1GUI
{
	partial class EditForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditForm));
			this.GroupTextBox = new System.Windows.Forms.TextBox();
			this.GroupLabel = new System.Windows.Forms.Label();
			this.SpecTextBox = new System.Windows.Forms.TextBox();
			this.SpecLabel = new System.Windows.Forms.Label();
			this.YearTextBox = new System.Windows.Forms.TextBox();
			this.YearLabel = new System.Windows.Forms.Label();
			this.PatronymicTextBox = new System.Windows.Forms.TextBox();
			this.PatronymicLabel = new System.Windows.Forms.Label();
			this.SurnameTextBox = new System.Windows.Forms.TextBox();
			this.SurnameLabel = new System.Windows.Forms.Label();
			this.NameTextBox = new System.Windows.Forms.TextBox();
			this.NameLabel = new System.Windows.Forms.Label();
			this.SubjectsTextBox = new System.Windows.Forms.TextBox();
			this.SubjectsLabel = new System.Windows.Forms.Label();
			this.AddEntryButton = new System.Windows.Forms.Button();
			this.CancelEntryButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// GroupTextBox
			// 
			this.GroupTextBox.Location = new System.Drawing.Point(121, 142);
			this.GroupTextBox.Name = "GroupTextBox";
			this.GroupTextBox.Size = new System.Drawing.Size(208, 20);
			this.GroupTextBox.TabIndex = 28;
			this.GroupTextBox.TextChanged += new System.EventHandler(this.NameTextBox_TextChanged);
			this.GroupTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SpecTextBox_KeyPress);
			// 
			// GroupLabel
			// 
			this.GroupLabel.AutoSize = true;
			this.GroupLabel.Location = new System.Drawing.Point(11, 149);
			this.GroupLabel.Name = "GroupLabel";
			this.GroupLabel.Size = new System.Drawing.Size(42, 13);
			this.GroupLabel.TabIndex = 27;
			this.GroupLabel.Text = "Группа";
			// 
			// SpecTextBox
			// 
			this.SpecTextBox.Location = new System.Drawing.Point(121, 116);
			this.SpecTextBox.Name = "SpecTextBox";
			this.SpecTextBox.Size = new System.Drawing.Size(208, 20);
			this.SpecTextBox.TabIndex = 26;
			this.SpecTextBox.TextChanged += new System.EventHandler(this.NameTextBox_TextChanged);
			this.SpecTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SpecTextBox_KeyPress);
			// 
			// SpecLabel
			// 
			this.SpecLabel.AutoSize = true;
			this.SpecLabel.Location = new System.Drawing.Point(11, 123);
			this.SpecLabel.Name = "SpecLabel";
			this.SpecLabel.Size = new System.Drawing.Size(85, 13);
			this.SpecLabel.TabIndex = 25;
			this.SpecLabel.Text = "Специальность";
			// 
			// YearTextBox
			// 
			this.YearTextBox.Location = new System.Drawing.Point(121, 90);
			this.YearTextBox.Name = "YearTextBox";
			this.YearTextBox.Size = new System.Drawing.Size(208, 20);
			this.YearTextBox.TabIndex = 24;
			this.YearTextBox.TextChanged += new System.EventHandler(this.NameTextBox_TextChanged);
			this.YearTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.YearTextBox_KeyPress);
			// 
			// YearLabel
			// 
			this.YearLabel.AutoSize = true;
			this.YearLabel.Location = new System.Drawing.Point(11, 97);
			this.YearLabel.Name = "YearLabel";
			this.YearLabel.Size = new System.Drawing.Size(25, 13);
			this.YearLabel.TabIndex = 23;
			this.YearLabel.Text = "Год";
			// 
			// PatronymicTextBox
			// 
			this.PatronymicTextBox.Location = new System.Drawing.Point(121, 64);
			this.PatronymicTextBox.Name = "PatronymicTextBox";
			this.PatronymicTextBox.Size = new System.Drawing.Size(208, 20);
			this.PatronymicTextBox.TabIndex = 22;
			this.PatronymicTextBox.TextChanged += new System.EventHandler(this.NameTextBox_TextChanged);
			this.PatronymicTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NameTextBox_KeyPress);
			// 
			// PatronymicLabel
			// 
			this.PatronymicLabel.AutoSize = true;
			this.PatronymicLabel.Location = new System.Drawing.Point(11, 71);
			this.PatronymicLabel.Name = "PatronymicLabel";
			this.PatronymicLabel.Size = new System.Drawing.Size(54, 13);
			this.PatronymicLabel.TabIndex = 21;
			this.PatronymicLabel.Text = "Отчество";
			// 
			// SurnameTextBox
			// 
			this.SurnameTextBox.Location = new System.Drawing.Point(121, 38);
			this.SurnameTextBox.Name = "SurnameTextBox";
			this.SurnameTextBox.Size = new System.Drawing.Size(208, 20);
			this.SurnameTextBox.TabIndex = 20;
			this.SurnameTextBox.TextChanged += new System.EventHandler(this.NameTextBox_TextChanged);
			this.SurnameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NameTextBox_KeyPress);
			// 
			// SurnameLabel
			// 
			this.SurnameLabel.AutoSize = true;
			this.SurnameLabel.Location = new System.Drawing.Point(11, 44);
			this.SurnameLabel.Name = "SurnameLabel";
			this.SurnameLabel.Size = new System.Drawing.Size(56, 13);
			this.SurnameLabel.TabIndex = 19;
			this.SurnameLabel.Text = "Фамилия";
			// 
			// NameTextBox
			// 
			this.NameTextBox.Location = new System.Drawing.Point(121, 12);
			this.NameTextBox.Name = "NameTextBox";
			this.NameTextBox.Size = new System.Drawing.Size(208, 20);
			this.NameTextBox.TabIndex = 18;
			this.NameTextBox.TextChanged += new System.EventHandler(this.NameTextBox_TextChanged);
			this.NameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NameTextBox_KeyPress);
			// 
			// NameLabel
			// 
			this.NameLabel.AutoSize = true;
			this.NameLabel.Location = new System.Drawing.Point(11, 19);
			this.NameLabel.Name = "NameLabel";
			this.NameLabel.Size = new System.Drawing.Size(29, 13);
			this.NameLabel.TabIndex = 17;
			this.NameLabel.Text = "Имя";
			// 
			// SubjectsTextBox
			// 
			this.SubjectsTextBox.Location = new System.Drawing.Point(362, 28);
			this.SubjectsTextBox.Multiline = true;
			this.SubjectsTextBox.Name = "SubjectsTextBox";
			this.SubjectsTextBox.Size = new System.Drawing.Size(217, 125);
			this.SubjectsTextBox.TabIndex = 29;
			this.SubjectsTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SubjectsTextBox_KeyPress);
			// 
			// SubjectsLabel
			// 
			this.SubjectsLabel.AutoSize = true;
			this.SubjectsLabel.Location = new System.Drawing.Point(359, 12);
			this.SubjectsLabel.Name = "SubjectsLabel";
			this.SubjectsLabel.Size = new System.Drawing.Size(63, 13);
			this.SubjectsLabel.TabIndex = 30;
			this.SubjectsLabel.Text = "Предметы:";
			// 
			// AddEntryButton
			// 
			this.AddEntryButton.Enabled = false;
			this.AddEntryButton.Location = new System.Drawing.Point(187, 189);
			this.AddEntryButton.Name = "AddEntryButton";
			this.AddEntryButton.Size = new System.Drawing.Size(87, 23);
			this.AddEntryButton.TabIndex = 31;
			this.AddEntryButton.Text = "Добавить";
			this.AddEntryButton.UseVisualStyleBackColor = true;
			this.AddEntryButton.Click += new System.EventHandler(this.EditFormButtons_Click);
			// 
			// CancelEntryButton
			// 
			this.CancelEntryButton.Location = new System.Drawing.Point(290, 189);
			this.CancelEntryButton.Name = "CancelEntryButton";
			this.CancelEntryButton.Size = new System.Drawing.Size(87, 23);
			this.CancelEntryButton.TabIndex = 32;
			this.CancelEntryButton.Text = "Отмена";
			this.CancelEntryButton.UseVisualStyleBackColor = true;
			this.CancelEntryButton.Click += new System.EventHandler(this.EditFormButtons_Click);
			// 
			// EditForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(591, 235);
			this.Controls.Add(this.CancelEntryButton);
			this.Controls.Add(this.AddEntryButton);
			this.Controls.Add(this.SubjectsLabel);
			this.Controls.Add(this.SubjectsTextBox);
			this.Controls.Add(this.GroupTextBox);
			this.Controls.Add(this.GroupLabel);
			this.Controls.Add(this.SpecTextBox);
			this.Controls.Add(this.SpecLabel);
			this.Controls.Add(this.YearTextBox);
			this.Controls.Add(this.YearLabel);
			this.Controls.Add(this.PatronymicTextBox);
			this.Controls.Add(this.PatronymicLabel);
			this.Controls.Add(this.SurnameTextBox);
			this.Controls.Add(this.SurnameLabel);
			this.Controls.Add(this.NameTextBox);
			this.Controls.Add(this.NameLabel);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.KeyPreview = true;
			this.Name = "EditForm";
			this.Text = "EditForm";
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EditForm_KeyDown);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox GroupTextBox;
		private System.Windows.Forms.Label GroupLabel;
		private System.Windows.Forms.TextBox SpecTextBox;
		private System.Windows.Forms.Label SpecLabel;
		private System.Windows.Forms.TextBox YearTextBox;
		private System.Windows.Forms.Label YearLabel;
		private System.Windows.Forms.TextBox PatronymicTextBox;
		private System.Windows.Forms.Label PatronymicLabel;
		private System.Windows.Forms.TextBox SurnameTextBox;
		private System.Windows.Forms.Label SurnameLabel;
		private System.Windows.Forms.TextBox NameTextBox;
		private System.Windows.Forms.Label NameLabel;
		private System.Windows.Forms.TextBox SubjectsTextBox;
		private System.Windows.Forms.Label SubjectsLabel;
		private System.Windows.Forms.Button AddEntryButton;
		private System.Windows.Forms.Button CancelEntryButton;
	}
}