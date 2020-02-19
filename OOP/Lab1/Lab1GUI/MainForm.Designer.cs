namespace Lab1GUI
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.PersonListButton = new System.Windows.Forms.Button();
			this.StudListButton = new System.Windows.Forms.Button();
			this.ProfListButton = new System.Windows.Forms.Button();
			this.SaveButton = new System.Windows.Forms.Button();
			this.LoadButton = new System.Windows.Forms.Button();
			this.NameLabel = new System.Windows.Forms.Label();
			this.NameTextBox = new System.Windows.Forms.TextBox();
			this.SurnameTextBox = new System.Windows.Forms.TextBox();
			this.SurnameLabel = new System.Windows.Forms.Label();
			this.PatronymicTextBox = new System.Windows.Forms.TextBox();
			this.PatronymicLabel = new System.Windows.Forms.Label();
			this.YearTextBox = new System.Windows.Forms.TextBox();
			this.YearLabel = new System.Windows.Forms.Label();
			this.SpecTextBox = new System.Windows.Forms.TextBox();
			this.SpecLabel = new System.Windows.Forms.Label();
			this.GroupTextBox = new System.Windows.Forms.TextBox();
			this.GroupLabel = new System.Windows.Forms.Label();
			this.SubjectsListBox = new System.Windows.Forms.ListBox();
			this.SubjectsLabel = new System.Windows.Forms.Label();
			this.CountLabel = new System.Windows.Forms.Label();
			this.ToBegButton = new System.Windows.Forms.Button();
			this.ToEndButton = new System.Windows.Forms.Button();
			this.EditButton = new System.Windows.Forms.Button();
			this.RemoveButton = new System.Windows.Forms.Button();
			this.AddStudButton = new System.Windows.Forms.Button();
			this.AddProfButton = new System.Windows.Forms.Button();
			this.NextYearButton = new System.Windows.Forms.Button();
			this.NextButton = new System.Windows.Forms.Button();
			this.PrevButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// PersonListButton
			// 
			this.PersonListButton.Location = new System.Drawing.Point(373, 94);
			this.PersonListButton.Name = "PersonListButton";
			this.PersonListButton.Size = new System.Drawing.Size(149, 23);
			this.PersonListButton.TabIndex = 0;
			this.PersonListButton.Text = "Список всех";
			this.PersonListButton.UseVisualStyleBackColor = true;
			this.PersonListButton.Click += new System.EventHandler(this.ListButton_Click);
			// 
			// StudListButton
			// 
			this.StudListButton.Location = new System.Drawing.Point(373, 123);
			this.StudListButton.Name = "StudListButton";
			this.StudListButton.Size = new System.Drawing.Size(149, 23);
			this.StudListButton.TabIndex = 1;
			this.StudListButton.Text = "Список студентов";
			this.StudListButton.UseVisualStyleBackColor = true;
			this.StudListButton.Click += new System.EventHandler(this.ListButton_Click);
			// 
			// ProfListButton
			// 
			this.ProfListButton.Location = new System.Drawing.Point(373, 152);
			this.ProfListButton.Name = "ProfListButton";
			this.ProfListButton.Size = new System.Drawing.Size(149, 23);
			this.ProfListButton.TabIndex = 2;
			this.ProfListButton.Text = "Список преподавателей";
			this.ProfListButton.UseVisualStyleBackColor = true;
			this.ProfListButton.Click += new System.EventHandler(this.ListButton_Click);
			// 
			// SaveButton
			// 
			this.SaveButton.Location = new System.Drawing.Point(373, 12);
			this.SaveButton.Name = "SaveButton";
			this.SaveButton.Size = new System.Drawing.Size(149, 23);
			this.SaveButton.TabIndex = 3;
			this.SaveButton.Text = "Сохранить";
			this.SaveButton.UseVisualStyleBackColor = true;
			this.SaveButton.Click += new System.EventHandler(this.SaveLoadButton_Click);
			// 
			// LoadButton
			// 
			this.LoadButton.Location = new System.Drawing.Point(373, 41);
			this.LoadButton.Name = "LoadButton";
			this.LoadButton.Size = new System.Drawing.Size(149, 23);
			this.LoadButton.TabIndex = 4;
			this.LoadButton.Text = "Загрузить";
			this.LoadButton.UseVisualStyleBackColor = true;
			this.LoadButton.Click += new System.EventHandler(this.SaveLoadButton_Click);
			// 
			// NameLabel
			// 
			this.NameLabel.AutoSize = true;
			this.NameLabel.Location = new System.Drawing.Point(17, 26);
			this.NameLabel.Name = "NameLabel";
			this.NameLabel.Size = new System.Drawing.Size(29, 13);
			this.NameLabel.TabIndex = 5;
			this.NameLabel.Text = "Имя";
			// 
			// NameTextBox
			// 
			this.NameTextBox.Location = new System.Drawing.Point(127, 19);
			this.NameTextBox.Name = "NameTextBox";
			this.NameTextBox.ReadOnly = true;
			this.NameTextBox.Size = new System.Drawing.Size(208, 20);
			this.NameTextBox.TabIndex = 6;
			// 
			// SurnameTextBox
			// 
			this.SurnameTextBox.Location = new System.Drawing.Point(127, 45);
			this.SurnameTextBox.Name = "SurnameTextBox";
			this.SurnameTextBox.ReadOnly = true;
			this.SurnameTextBox.Size = new System.Drawing.Size(208, 20);
			this.SurnameTextBox.TabIndex = 8;
			// 
			// SurnameLabel
			// 
			this.SurnameLabel.AutoSize = true;
			this.SurnameLabel.Location = new System.Drawing.Point(17, 51);
			this.SurnameLabel.Name = "SurnameLabel";
			this.SurnameLabel.Size = new System.Drawing.Size(56, 13);
			this.SurnameLabel.TabIndex = 7;
			this.SurnameLabel.Text = "Фамилия";
			// 
			// PatronymicTextBox
			// 
			this.PatronymicTextBox.Location = new System.Drawing.Point(127, 71);
			this.PatronymicTextBox.Name = "PatronymicTextBox";
			this.PatronymicTextBox.ReadOnly = true;
			this.PatronymicTextBox.Size = new System.Drawing.Size(208, 20);
			this.PatronymicTextBox.TabIndex = 10;
			// 
			// PatronymicLabel
			// 
			this.PatronymicLabel.AutoSize = true;
			this.PatronymicLabel.Location = new System.Drawing.Point(17, 78);
			this.PatronymicLabel.Name = "PatronymicLabel";
			this.PatronymicLabel.Size = new System.Drawing.Size(54, 13);
			this.PatronymicLabel.TabIndex = 9;
			this.PatronymicLabel.Text = "Отчество";
			// 
			// YearTextBox
			// 
			this.YearTextBox.Location = new System.Drawing.Point(127, 97);
			this.YearTextBox.Name = "YearTextBox";
			this.YearTextBox.ReadOnly = true;
			this.YearTextBox.Size = new System.Drawing.Size(208, 20);
			this.YearTextBox.TabIndex = 12;
			// 
			// YearLabel
			// 
			this.YearLabel.AutoSize = true;
			this.YearLabel.Location = new System.Drawing.Point(17, 104);
			this.YearLabel.Name = "YearLabel";
			this.YearLabel.Size = new System.Drawing.Size(25, 13);
			this.YearLabel.TabIndex = 11;
			this.YearLabel.Text = "Год";
			// 
			// SpecTextBox
			// 
			this.SpecTextBox.Location = new System.Drawing.Point(127, 123);
			this.SpecTextBox.Name = "SpecTextBox";
			this.SpecTextBox.ReadOnly = true;
			this.SpecTextBox.Size = new System.Drawing.Size(208, 20);
			this.SpecTextBox.TabIndex = 14;
			// 
			// SpecLabel
			// 
			this.SpecLabel.AutoSize = true;
			this.SpecLabel.Location = new System.Drawing.Point(17, 130);
			this.SpecLabel.Name = "SpecLabel";
			this.SpecLabel.Size = new System.Drawing.Size(85, 13);
			this.SpecLabel.TabIndex = 13;
			this.SpecLabel.Text = "Специальность";
			// 
			// GroupTextBox
			// 
			this.GroupTextBox.Location = new System.Drawing.Point(127, 149);
			this.GroupTextBox.Name = "GroupTextBox";
			this.GroupTextBox.ReadOnly = true;
			this.GroupTextBox.Size = new System.Drawing.Size(208, 20);
			this.GroupTextBox.TabIndex = 16;
			// 
			// GroupLabel
			// 
			this.GroupLabel.AutoSize = true;
			this.GroupLabel.Location = new System.Drawing.Point(17, 156);
			this.GroupLabel.Name = "GroupLabel";
			this.GroupLabel.Size = new System.Drawing.Size(42, 13);
			this.GroupLabel.TabIndex = 15;
			this.GroupLabel.Text = "Группа";
			// 
			// SubjectsListBox
			// 
			this.SubjectsListBox.FormattingEnabled = true;
			this.SubjectsListBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.SubjectsListBox.Location = new System.Drawing.Point(17, 237);
			this.SubjectsListBox.Name = "SubjectsListBox";
			this.SubjectsListBox.Size = new System.Drawing.Size(318, 134);
			this.SubjectsListBox.TabIndex = 17;
			// 
			// SubjectsLabel
			// 
			this.SubjectsLabel.AutoSize = true;
			this.SubjectsLabel.Location = new System.Drawing.Point(17, 204);
			this.SubjectsLabel.Name = "SubjectsLabel";
			this.SubjectsLabel.Size = new System.Drawing.Size(63, 13);
			this.SubjectsLabel.TabIndex = 18;
			this.SubjectsLabel.Text = "Предметы:";
			// 
			// CountLabel
			// 
			this.CountLabel.AutoSize = true;
			this.CountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.CountLabel.Location = new System.Drawing.Point(452, 415);
			this.CountLabel.Name = "CountLabel";
			this.CountLabel.Size = new System.Drawing.Size(54, 25);
			this.CountLabel.TabIndex = 19;
			this.CountLabel.Text = "0 / 0";
			// 
			// ToBegButton
			// 
			this.ToBegButton.BackgroundImage = global::Lab1GUI.Properties.Resources.beg_icon;
			this.ToBegButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ToBegButton.FlatAppearance.BorderSize = 0;
			this.ToBegButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.ToBegButton.Location = new System.Drawing.Point(373, 188);
			this.ToBegButton.Name = "ToBegButton";
			this.ToBegButton.Size = new System.Drawing.Size(35, 35);
			this.ToBegButton.TabIndex = 20;
			this.ToBegButton.UseVisualStyleBackColor = true;
			this.ToBegButton.Click += new System.EventHandler(this.NavButton_Click);
			// 
			// ToEndButton
			// 
			this.ToEndButton.BackgroundImage = global::Lab1GUI.Properties.Resources.end_icon;
			this.ToEndButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ToEndButton.FlatAppearance.BorderSize = 0;
			this.ToEndButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.ToEndButton.Location = new System.Drawing.Point(487, 188);
			this.ToEndButton.Name = "ToEndButton";
			this.ToEndButton.Size = new System.Drawing.Size(35, 35);
			this.ToEndButton.TabIndex = 21;
			this.ToEndButton.UseVisualStyleBackColor = true;
			this.ToEndButton.Click += new System.EventHandler(this.NavButton_Click);
			// 
			// EditButton
			// 
			this.EditButton.Location = new System.Drawing.Point(172, 386);
			this.EditButton.Name = "EditButton";
			this.EditButton.Size = new System.Drawing.Size(163, 23);
			this.EditButton.TabIndex = 24;
			this.EditButton.Text = "Редактировать";
			this.EditButton.UseVisualStyleBackColor = true;
			this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
			// 
			// RemoveButton
			// 
			this.RemoveButton.Location = new System.Drawing.Point(172, 415);
			this.RemoveButton.Name = "RemoveButton";
			this.RemoveButton.Size = new System.Drawing.Size(163, 23);
			this.RemoveButton.TabIndex = 25;
			this.RemoveButton.Text = "Удалить";
			this.RemoveButton.UseVisualStyleBackColor = true;
			this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
			// 
			// AddStudButton
			// 
			this.AddStudButton.Location = new System.Drawing.Point(17, 386);
			this.AddStudButton.Name = "AddStudButton";
			this.AddStudButton.Size = new System.Drawing.Size(149, 23);
			this.AddStudButton.TabIndex = 26;
			this.AddStudButton.Text = "Добавить студента";
			this.AddStudButton.UseVisualStyleBackColor = true;
			this.AddStudButton.Click += new System.EventHandler(this.EditButton_Click);
			// 
			// AddProfButton
			// 
			this.AddProfButton.Location = new System.Drawing.Point(17, 415);
			this.AddProfButton.Name = "AddProfButton";
			this.AddProfButton.Size = new System.Drawing.Size(149, 23);
			this.AddProfButton.TabIndex = 27;
			this.AddProfButton.Text = "Добавить преподавателя";
			this.AddProfButton.UseVisualStyleBackColor = true;
			this.AddProfButton.Click += new System.EventHandler(this.EditButton_Click);
			// 
			// NextYearButton
			// 
			this.NextYearButton.Location = new System.Drawing.Point(373, 348);
			this.NextYearButton.Name = "NextYearButton";
			this.NextYearButton.Size = new System.Drawing.Size(149, 23);
			this.NextYearButton.TabIndex = 28;
			this.NextYearButton.Text = "Следующий год";
			this.NextYearButton.UseVisualStyleBackColor = true;
			this.NextYearButton.Click += new System.EventHandler(this.NextYearButton_Click);
			// 
			// NextButton
			// 
			this.NextButton.BackgroundImage = global::Lab1GUI.Properties.Resources.next_icon;
			this.NextButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.NextButton.FlatAppearance.BorderSize = 0;
			this.NextButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.NextButton.Location = new System.Drawing.Point(449, 188);
			this.NextButton.Name = "NextButton";
			this.NextButton.Size = new System.Drawing.Size(35, 35);
			this.NextButton.TabIndex = 23;
			this.NextButton.UseVisualStyleBackColor = true;
			this.NextButton.Click += new System.EventHandler(this.NavButton_Click);
			// 
			// PrevButton
			// 
			this.PrevButton.BackgroundImage = global::Lab1GUI.Properties.Resources.prev_icon;
			this.PrevButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.PrevButton.FlatAppearance.BorderSize = 0;
			this.PrevButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.PrevButton.Location = new System.Drawing.Point(410, 188);
			this.PrevButton.Name = "PrevButton";
			this.PrevButton.Size = new System.Drawing.Size(35, 35);
			this.PrevButton.TabIndex = 22;
			this.PrevButton.UseVisualStyleBackColor = true;
			this.PrevButton.Click += new System.EventHandler(this.NavButton_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(534, 448);
			this.Controls.Add(this.NextYearButton);
			this.Controls.Add(this.AddProfButton);
			this.Controls.Add(this.AddStudButton);
			this.Controls.Add(this.RemoveButton);
			this.Controls.Add(this.EditButton);
			this.Controls.Add(this.NextButton);
			this.Controls.Add(this.PrevButton);
			this.Controls.Add(this.ToEndButton);
			this.Controls.Add(this.ToBegButton);
			this.Controls.Add(this.CountLabel);
			this.Controls.Add(this.SubjectsLabel);
			this.Controls.Add(this.SubjectsListBox);
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
			this.Controls.Add(this.LoadButton);
			this.Controls.Add(this.SaveButton);
			this.Controls.Add(this.ProfListButton);
			this.Controls.Add(this.StudListButton);
			this.Controls.Add(this.PersonListButton);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "MainForm";
			this.Text = "Бочаров Кирилл. Лабораторная работа №1";
			this.Shown += new System.EventHandler(this.Form1_Shown);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button PersonListButton;
		private System.Windows.Forms.Button StudListButton;
		private System.Windows.Forms.Button ProfListButton;
		private System.Windows.Forms.Button SaveButton;
		private System.Windows.Forms.Button LoadButton;
		private System.Windows.Forms.Label NameLabel;
		private System.Windows.Forms.TextBox NameTextBox;
		private System.Windows.Forms.TextBox SurnameTextBox;
		private System.Windows.Forms.Label SurnameLabel;
		private System.Windows.Forms.TextBox PatronymicTextBox;
		private System.Windows.Forms.Label PatronymicLabel;
		private System.Windows.Forms.TextBox YearTextBox;
		private System.Windows.Forms.Label YearLabel;
		private System.Windows.Forms.TextBox SpecTextBox;
		private System.Windows.Forms.Label SpecLabel;
		private System.Windows.Forms.TextBox GroupTextBox;
		private System.Windows.Forms.Label GroupLabel;
		private System.Windows.Forms.ListBox SubjectsListBox;
		private System.Windows.Forms.Label SubjectsLabel;
		private System.Windows.Forms.Label CountLabel;
		private System.Windows.Forms.Button ToBegButton;
		private System.Windows.Forms.Button ToEndButton;
		private System.Windows.Forms.Button PrevButton;
		private System.Windows.Forms.Button NextButton;
		private System.Windows.Forms.Button EditButton;
		private System.Windows.Forms.Button RemoveButton;
		private System.Windows.Forms.Button AddStudButton;
		private System.Windows.Forms.Button AddProfButton;
		private System.Windows.Forms.Button NextYearButton;
	}
}

