namespace Lab2GUI
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
			this.createObjButton = new System.Windows.Forms.Button();
			this.objListBox = new System.Windows.Forms.ListBox();
			this.numObjTextBox = new System.Windows.Forms.TextBox();
			this.numObjLabel = new System.Windows.Forms.Label();
			this.figuresInfoTab = new System.Windows.Forms.TabControl();
			this.commonInfoTabPage = new System.Windows.Forms.TabPage();
			this.equalInfoTabPage = new System.Windows.Forms.TabPage();
			this.equalTextBox = new System.Windows.Forms.TextBox();
			this.crossInfoTabPage = new System.Windows.Forms.TabPage();
			this.crossingTextBox = new System.Windows.Forms.TextBox();
			this.graphTabPage = new System.Windows.Forms.TabPage();
			this.graphPictureBox = new System.Windows.Forms.PictureBox();
			this.figuresInfoTab.SuspendLayout();
			this.commonInfoTabPage.SuspendLayout();
			this.equalInfoTabPage.SuspendLayout();
			this.crossInfoTabPage.SuspendLayout();
			this.graphTabPage.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.graphPictureBox)).BeginInit();
			this.SuspendLayout();
			// 
			// createObjButton
			// 
			this.createObjButton.Enabled = false;
			this.createObjButton.Location = new System.Drawing.Point(15, 38);
			this.createObjButton.Name = "createObjButton";
			this.createObjButton.Size = new System.Drawing.Size(198, 23);
			this.createObjButton.TabIndex = 0;
			this.createObjButton.Text = "Создать объекты";
			this.createObjButton.UseVisualStyleBackColor = true;
			this.createObjButton.Click += new System.EventHandler(this.createObjButton_Click);
			// 
			// objListBox
			// 
			this.objListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.objListBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.objListBox.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.objListBox.FormattingEnabled = true;
			this.objListBox.Location = new System.Drawing.Point(3, 3);
			this.objListBox.Name = "objListBox";
			this.objListBox.Size = new System.Drawing.Size(474, 356);
			this.objListBox.TabIndex = 1;
			// 
			// numObjTextBox
			// 
			this.numObjTextBox.Location = new System.Drawing.Point(113, 12);
			this.numObjTextBox.Name = "numObjTextBox";
			this.numObjTextBox.Size = new System.Drawing.Size(100, 20);
			this.numObjTextBox.TabIndex = 2;
			this.numObjTextBox.TextChanged += new System.EventHandler(this.numObjTextBox_TextChanged);
			this.numObjTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numObjTextBox_KeyPress);
			// 
			// numObjLabel
			// 
			this.numObjLabel.AutoSize = true;
			this.numObjLabel.Location = new System.Drawing.Point(12, 15);
			this.numObjLabel.Name = "numObjLabel";
			this.numObjLabel.Size = new System.Drawing.Size(95, 13);
			this.numObjLabel.TabIndex = 3;
			this.numObjLabel.Text = "Кол-во объектов:";
			// 
			// figuresInfoTab
			// 
			this.figuresInfoTab.Controls.Add(this.commonInfoTabPage);
			this.figuresInfoTab.Controls.Add(this.equalInfoTabPage);
			this.figuresInfoTab.Controls.Add(this.crossInfoTabPage);
			this.figuresInfoTab.Controls.Add(this.graphTabPage);
			this.figuresInfoTab.Location = new System.Drawing.Point(229, 12);
			this.figuresInfoTab.Name = "figuresInfoTab";
			this.figuresInfoTab.SelectedIndex = 0;
			this.figuresInfoTab.Size = new System.Drawing.Size(488, 388);
			this.figuresInfoTab.TabIndex = 4;
			// 
			// commonInfoTabPage
			// 
			this.commonInfoTabPage.Controls.Add(this.objListBox);
			this.commonInfoTabPage.Location = new System.Drawing.Point(4, 22);
			this.commonInfoTabPage.Name = "commonInfoTabPage";
			this.commonInfoTabPage.Padding = new System.Windows.Forms.Padding(3);
			this.commonInfoTabPage.Size = new System.Drawing.Size(480, 362);
			this.commonInfoTabPage.TabIndex = 0;
			this.commonInfoTabPage.Text = "Общая информация";
			this.commonInfoTabPage.UseVisualStyleBackColor = true;
			// 
			// equalInfoTabPage
			// 
			this.equalInfoTabPage.Controls.Add(this.equalTextBox);
			this.equalInfoTabPage.Location = new System.Drawing.Point(4, 22);
			this.equalInfoTabPage.Name = "equalInfoTabPage";
			this.equalInfoTabPage.Size = new System.Drawing.Size(480, 362);
			this.equalInfoTabPage.TabIndex = 3;
			this.equalInfoTabPage.Text = "Таблица равенства";
			this.equalInfoTabPage.UseVisualStyleBackColor = true;
			// 
			// equalTextBox
			// 
			this.equalTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.equalTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.equalTextBox.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.equalTextBox.Location = new System.Drawing.Point(0, 0);
			this.equalTextBox.MaxLength = 32768;
			this.equalTextBox.Multiline = true;
			this.equalTextBox.Name = "equalTextBox";
			this.equalTextBox.ReadOnly = true;
			this.equalTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.equalTextBox.Size = new System.Drawing.Size(480, 362);
			this.equalTextBox.TabIndex = 1;
			this.equalTextBox.WordWrap = false;
			// 
			// crossInfoTabPage
			// 
			this.crossInfoTabPage.Controls.Add(this.crossingTextBox);
			this.crossInfoTabPage.Location = new System.Drawing.Point(4, 22);
			this.crossInfoTabPage.Name = "crossInfoTabPage";
			this.crossInfoTabPage.Padding = new System.Windows.Forms.Padding(3);
			this.crossInfoTabPage.Size = new System.Drawing.Size(480, 362);
			this.crossInfoTabPage.TabIndex = 1;
			this.crossInfoTabPage.Text = "Таблица пересечения";
			this.crossInfoTabPage.UseVisualStyleBackColor = true;
			// 
			// crossingTextBox
			// 
			this.crossingTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.crossingTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.crossingTextBox.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.crossingTextBox.Location = new System.Drawing.Point(3, 3);
			this.crossingTextBox.MaxLength = 32768;
			this.crossingTextBox.Multiline = true;
			this.crossingTextBox.Name = "crossingTextBox";
			this.crossingTextBox.ReadOnly = true;
			this.crossingTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.crossingTextBox.Size = new System.Drawing.Size(474, 356);
			this.crossingTextBox.TabIndex = 0;
			this.crossingTextBox.WordWrap = false;
			// 
			// graphTabPage
			// 
			this.graphTabPage.Controls.Add(this.graphPictureBox);
			this.graphTabPage.Location = new System.Drawing.Point(4, 22);
			this.graphTabPage.Name = "graphTabPage";
			this.graphTabPage.Padding = new System.Windows.Forms.Padding(3);
			this.graphTabPage.Size = new System.Drawing.Size(480, 362);
			this.graphTabPage.TabIndex = 2;
			this.graphTabPage.Text = "Графики";
			this.graphTabPage.UseVisualStyleBackColor = true;
			// 
			// graphPictureBox
			// 
			this.graphPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.graphPictureBox.Location = new System.Drawing.Point(3, 3);
			this.graphPictureBox.Name = "graphPictureBox";
			this.graphPictureBox.Size = new System.Drawing.Size(474, 356);
			this.graphPictureBox.TabIndex = 0;
			this.graphPictureBox.TabStop = false;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(729, 412);
			this.Controls.Add(this.figuresInfoTab);
			this.Controls.Add(this.numObjLabel);
			this.Controls.Add(this.numObjTextBox);
			this.Controls.Add(this.createObjButton);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "MainForm";
			this.Text = "Бочаров Кирилл. Лабораторная работа №2";
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.figuresInfoTab.ResumeLayout(false);
			this.commonInfoTabPage.ResumeLayout(false);
			this.equalInfoTabPage.ResumeLayout(false);
			this.equalInfoTabPage.PerformLayout();
			this.crossInfoTabPage.ResumeLayout(false);
			this.crossInfoTabPage.PerformLayout();
			this.graphTabPage.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.graphPictureBox)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button createObjButton;
		private System.Windows.Forms.ListBox objListBox;
		private System.Windows.Forms.TextBox numObjTextBox;
		private System.Windows.Forms.Label numObjLabel;
		private System.Windows.Forms.TabControl figuresInfoTab;
		private System.Windows.Forms.TabPage commonInfoTabPage;
		private System.Windows.Forms.TabPage crossInfoTabPage;
		private System.Windows.Forms.TabPage graphTabPage;
		private System.Windows.Forms.TextBox crossingTextBox;
		private System.Windows.Forms.PictureBox graphPictureBox;
		private System.Windows.Forms.TabPage equalInfoTabPage;
		private System.Windows.Forms.TextBox equalTextBox;
	}
}

