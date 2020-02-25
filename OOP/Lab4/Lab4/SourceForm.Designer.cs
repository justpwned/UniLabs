namespace Lab4
{
	partial class SourceForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SourceForm));
			this.startEventABtn = new System.Windows.Forms.Button();
			this.eventALbl = new System.Windows.Forms.Label();
			this.eventBLbl = new System.Windows.Forms.Label();
			this.startEventBBtn = new System.Windows.Forms.Button();
			this.addObsBtn = new System.Windows.Forms.Button();
			this.obsCountLbl = new System.Windows.Forms.Label();
			this.eventCLbl = new System.Windows.Forms.Label();
			this.startEventCBtn = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// startEventABtn
			// 
			this.startEventABtn.Location = new System.Drawing.Point(46, 38);
			this.startEventABtn.Name = "startEventABtn";
			this.startEventABtn.Size = new System.Drawing.Size(75, 23);
			this.startEventABtn.TabIndex = 0;
			this.startEventABtn.Text = "Событие А";
			this.startEventABtn.UseVisualStyleBackColor = true;
			this.startEventABtn.Click += new System.EventHandler(this.startEventABtn_Click);
			// 
			// eventALbl
			// 
			this.eventALbl.AutoSize = true;
			this.eventALbl.Location = new System.Drawing.Point(161, 43);
			this.eventALbl.Name = "eventALbl";
			this.eventALbl.Size = new System.Drawing.Size(86, 13);
			this.eventALbl.TabIndex = 1;
			this.eventALbl.Text = "Подписчиков: 0";
			// 
			// eventBLbl
			// 
			this.eventBLbl.AutoSize = true;
			this.eventBLbl.Location = new System.Drawing.Point(161, 72);
			this.eventBLbl.Name = "eventBLbl";
			this.eventBLbl.Size = new System.Drawing.Size(86, 13);
			this.eventBLbl.TabIndex = 3;
			this.eventBLbl.Text = "Подписчиков: 0";
			// 
			// startEventBBtn
			// 
			this.startEventBBtn.Location = new System.Drawing.Point(46, 67);
			this.startEventBBtn.Name = "startEventBBtn";
			this.startEventBBtn.Size = new System.Drawing.Size(75, 23);
			this.startEventBBtn.TabIndex = 2;
			this.startEventBBtn.Text = "Событие В";
			this.startEventBBtn.UseVisualStyleBackColor = true;
			this.startEventBBtn.Click += new System.EventHandler(this.startEventBBtn_Click);
			// 
			// addObsBtn
			// 
			this.addObsBtn.Location = new System.Drawing.Point(46, 166);
			this.addObsBtn.Name = "addObsBtn";
			this.addObsBtn.Size = new System.Drawing.Size(156, 23);
			this.addObsBtn.TabIndex = 4;
			this.addObsBtn.Text = "Добавить наблюдателя";
			this.addObsBtn.UseVisualStyleBackColor = true;
			this.addObsBtn.Click += new System.EventHandler(this.addObsBtn_Click);
			// 
			// obsCountLbl
			// 
			this.obsCountLbl.AutoSize = true;
			this.obsCountLbl.Location = new System.Drawing.Point(47, 205);
			this.obsCountLbl.Name = "obsCountLbl";
			this.obsCountLbl.Size = new System.Drawing.Size(125, 13);
			this.obsCountLbl.TabIndex = 5;
			this.obsCountLbl.Text = "Всего наблюдателей: 0";
			// 
			// eventCLbl
			// 
			this.eventCLbl.AutoSize = true;
			this.eventCLbl.Location = new System.Drawing.Point(161, 101);
			this.eventCLbl.Name = "eventCLbl";
			this.eventCLbl.Size = new System.Drawing.Size(86, 13);
			this.eventCLbl.TabIndex = 7;
			this.eventCLbl.Text = "Подписчиков: 0";
			// 
			// startEventCBtn
			// 
			this.startEventCBtn.Location = new System.Drawing.Point(46, 96);
			this.startEventCBtn.Name = "startEventCBtn";
			this.startEventCBtn.Size = new System.Drawing.Size(75, 23);
			this.startEventCBtn.TabIndex = 6;
			this.startEventCBtn.Text = "Событие C";
			this.startEventCBtn.UseVisualStyleBackColor = true;
			this.startEventCBtn.Click += new System.EventHandler(this.startEventCBtn_Click);
			// 
			// SourceForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(292, 248);
			this.Controls.Add(this.eventCLbl);
			this.Controls.Add(this.startEventCBtn);
			this.Controls.Add(this.obsCountLbl);
			this.Controls.Add(this.addObsBtn);
			this.Controls.Add(this.eventBLbl);
			this.Controls.Add(this.startEventBBtn);
			this.Controls.Add(this.eventALbl);
			this.Controls.Add(this.startEventABtn);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "SourceForm";
			this.Text = "Источник";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button startEventABtn;
		private System.Windows.Forms.Label eventALbl;
		private System.Windows.Forms.Label eventBLbl;
		private System.Windows.Forms.Button startEventBBtn;
		private System.Windows.Forms.Button addObsBtn;
		private System.Windows.Forms.Label obsCountLbl;
		private System.Windows.Forms.Label eventCLbl;
		private System.Windows.Forms.Button startEventCBtn;
	}
}

