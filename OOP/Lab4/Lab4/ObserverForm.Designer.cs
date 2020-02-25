namespace Lab4
{
	partial class ObserverForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ObserverForm));
			this.controlPanelGrpBox = new System.Windows.Forms.GroupBox();
			this.eventCRadioBtn = new System.Windows.Forms.RadioButton();
			this.eventListBox = new System.Windows.Forms.ListBox();
			this.eventBRadioBtn = new System.Windows.Forms.RadioButton();
			this.eventARadioBtn = new System.Windows.Forms.RadioButton();
			this.subBtn = new System.Windows.Forms.Button();
			this.unsubBtn = new System.Windows.Forms.Button();
			this.controlPanelGrpBox.SuspendLayout();
			this.SuspendLayout();
			// 
			// controlPanelGrpBox
			// 
			this.controlPanelGrpBox.Controls.Add(this.eventCRadioBtn);
			this.controlPanelGrpBox.Controls.Add(this.eventListBox);
			this.controlPanelGrpBox.Controls.Add(this.eventBRadioBtn);
			this.controlPanelGrpBox.Controls.Add(this.eventARadioBtn);
			this.controlPanelGrpBox.Location = new System.Drawing.Point(12, 12);
			this.controlPanelGrpBox.Name = "controlPanelGrpBox";
			this.controlPanelGrpBox.Size = new System.Drawing.Size(244, 228);
			this.controlPanelGrpBox.TabIndex = 0;
			this.controlPanelGrpBox.TabStop = false;
			this.controlPanelGrpBox.Text = "Панель управления";
			// 
			// eventCRadioBtn
			// 
			this.eventCRadioBtn.AutoSize = true;
			this.eventCRadioBtn.Location = new System.Drawing.Point(16, 43);
			this.eventCRadioBtn.Name = "eventCRadioBtn";
			this.eventCRadioBtn.Size = new System.Drawing.Size(79, 17);
			this.eventCRadioBtn.TabIndex = 3;
			this.eventCRadioBtn.TabStop = true;
			this.eventCRadioBtn.Text = "Событие C";
			this.eventCRadioBtn.UseVisualStyleBackColor = true;
			// 
			// eventListBox
			// 
			this.eventListBox.FormattingEnabled = true;
			this.eventListBox.Items.AddRange(new object[] {
            "Временно окрасить",
            "Переставить влево",
            "Временно обезглавить",
            "Сделать форму невидимой на 1 секунду"});
			this.eventListBox.Location = new System.Drawing.Point(16, 101);
			this.eventListBox.Name = "eventListBox";
			this.eventListBox.Size = new System.Drawing.Size(210, 121);
			this.eventListBox.TabIndex = 2;
			// 
			// eventBRadioBtn
			// 
			this.eventBRadioBtn.AutoSize = true;
			this.eventBRadioBtn.Location = new System.Drawing.Point(147, 19);
			this.eventBRadioBtn.Name = "eventBRadioBtn";
			this.eventBRadioBtn.Size = new System.Drawing.Size(79, 17);
			this.eventBRadioBtn.TabIndex = 1;
			this.eventBRadioBtn.TabStop = true;
			this.eventBRadioBtn.Text = "Событие B";
			this.eventBRadioBtn.UseVisualStyleBackColor = true;
			// 
			// eventARadioBtn
			// 
			this.eventARadioBtn.AutoSize = true;
			this.eventARadioBtn.Location = new System.Drawing.Point(16, 20);
			this.eventARadioBtn.Name = "eventARadioBtn";
			this.eventARadioBtn.Size = new System.Drawing.Size(79, 17);
			this.eventARadioBtn.TabIndex = 0;
			this.eventARadioBtn.TabStop = true;
			this.eventARadioBtn.Text = "Событие А";
			this.eventARadioBtn.UseVisualStyleBackColor = true;
			// 
			// subBtn
			// 
			this.subBtn.Location = new System.Drawing.Point(28, 246);
			this.subBtn.Name = "subBtn";
			this.subBtn.Size = new System.Drawing.Size(75, 23);
			this.subBtn.TabIndex = 1;
			this.subBtn.Text = "Подписать";
			this.subBtn.UseVisualStyleBackColor = true;
			this.subBtn.Click += new System.EventHandler(this.subBtn_Click);
			// 
			// unsubBtn
			// 
			this.unsubBtn.Location = new System.Drawing.Point(163, 246);
			this.unsubBtn.Name = "unsubBtn";
			this.unsubBtn.Size = new System.Drawing.Size(75, 23);
			this.unsubBtn.TabIndex = 2;
			this.unsubBtn.Text = "Отписать";
			this.unsubBtn.UseVisualStyleBackColor = true;
			this.unsubBtn.Click += new System.EventHandler(this.unsubBtn_Click);
			// 
			// ObserverForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(272, 281);
			this.Controls.Add(this.unsubBtn);
			this.Controls.Add(this.subBtn);
			this.Controls.Add(this.controlPanelGrpBox);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "ObserverForm";
			this.Text = "Наблюдатель";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ObserverForm_FormClosing);
			this.controlPanelGrpBox.ResumeLayout(false);
			this.controlPanelGrpBox.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox controlPanelGrpBox;
		private System.Windows.Forms.RadioButton eventBRadioBtn;
		private System.Windows.Forms.RadioButton eventARadioBtn;
		private System.Windows.Forms.ListBox eventListBox;
		private System.Windows.Forms.Button subBtn;
		private System.Windows.Forms.Button unsubBtn;
		private System.Windows.Forms.RadioButton eventCRadioBtn;
	}
}