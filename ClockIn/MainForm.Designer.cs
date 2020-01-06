namespace ClockIn
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClock = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cmbDetail = new System.Windows.Forms.ComboBox();
            this.panelCenter = new System.Windows.Forms.Panel();
            this.textBoxDetail = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelCenter.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 20000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.Location = new System.Drawing.Point(10, 0);
            this.btnOpenFile.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(75, 23);
            this.btnOpenFile.TabIndex = 1;
            this.btnOpenFile.Text = "Open DB";
            this.btnOpenFile.UseVisualStyleBackColor = true;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnClock);
            this.panel1.Controls.Add(this.btnOpenFile);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 278);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(450, 25);
            this.panel1.TabIndex = 1;
            // 
            // btnClock
            // 
            this.btnClock.Location = new System.Drawing.Point(365, 0);
            this.btnClock.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.btnClock.Name = "btnClock";
            this.btnClock.Size = new System.Drawing.Size(75, 23);
            this.btnClock.TabIndex = 0;
            this.btnClock.Text = "...";
            this.btnClock.UseVisualStyleBackColor = true;
            this.btnClock.Click += new System.EventHandler(this.btnClock_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cmbDetail);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(450, 72);
            this.panel2.TabIndex = 4;
            // 
            // cmbDetail
            // 
            this.cmbDetail.Dock = System.Windows.Forms.DockStyle.Top;
            this.cmbDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDetail.FormattingEnabled = true;
            this.cmbDetail.Location = new System.Drawing.Point(0, 0);
            this.cmbDetail.Name = "cmbDetail";
            this.cmbDetail.Size = new System.Drawing.Size(450, 28);
            this.cmbDetail.TabIndex = 7;
            // 
            // panelCenter
            // 
            this.panelCenter.Controls.Add(this.textBoxDetail);
            this.panelCenter.Controls.Add(this.textBox1);
            this.panelCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCenter.Location = new System.Drawing.Point(0, 72);
            this.panelCenter.Name = "panelCenter";
            this.panelCenter.Size = new System.Drawing.Size(450, 206);
            this.panelCenter.TabIndex = 6;
            // 
            // textBoxDetail
            // 
            this.textBoxDetail.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxDetail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxDetail.Dock = System.Windows.Forms.DockStyle.Right;
            this.textBoxDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDetail.Location = new System.Drawing.Point(243, 0);
            this.textBoxDetail.Multiline = true;
            this.textBoxDetail.Name = "textBoxDetail";
            this.textBoxDetail.ReadOnly = true;
            this.textBoxDetail.Size = new System.Drawing.Size(207, 206);
            this.textBoxDetail.TabIndex = 7;
            this.textBoxDetail.Text = "-";
            this.textBoxDetail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Control;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(0, 0);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(243, 206);
            this.textBox1.TabIndex = 6;
            this.textBox1.Text = "-";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 303);
            this.Controls.Add(this.panelCenter);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ClockIn";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panelCenter.ResumeLayout(false);
            this.panelCenter.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.Button btnOpenFile;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button btnClock;
        private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.ComboBox cmbDetail;
        private System.Windows.Forms.Panel panelCenter;
        private System.Windows.Forms.TextBox textBoxDetail;
        private System.Windows.Forms.TextBox textBox1;
	}
}

