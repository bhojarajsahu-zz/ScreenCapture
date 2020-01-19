namespace ScreenCapture
{
	partial class Home
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
			this.buttonCapture = new System.Windows.Forms.Button();
			this.radioButtonReadText = new System.Windows.Forms.RadioButton();
			this.radioButtonScreenShot = new System.Windows.Forms.RadioButton();
			this.SuspendLayout();
			// 
			// buttonCapture
			// 
			this.buttonCapture.Location = new System.Drawing.Point(9, 10);
			this.buttonCapture.Margin = new System.Windows.Forms.Padding(2);
			this.buttonCapture.Name = "buttonCapture";
			this.buttonCapture.Size = new System.Drawing.Size(58, 24);
			this.buttonCapture.TabIndex = 0;
			this.buttonCapture.Text = "Capture";
			this.buttonCapture.UseVisualStyleBackColor = true;
			this.buttonCapture.Click += new System.EventHandler(this.buttonCapture_Click);
			// 
			// radioButtonReadText
			// 
			this.radioButtonReadText.AutoSize = true;
			this.radioButtonReadText.Checked = true;
			this.radioButtonReadText.Location = new System.Drawing.Point(9, 48);
			this.radioButtonReadText.Name = "radioButtonReadText";
			this.radioButtonReadText.Size = new System.Drawing.Size(75, 17);
			this.radioButtonReadText.TabIndex = 2;
			this.radioButtonReadText.TabStop = true;
			this.radioButtonReadText.Text = "Read Text";
			this.radioButtonReadText.UseVisualStyleBackColor = true;
			this.radioButtonReadText.CheckedChanged += new System.EventHandler(this.radioButtonReadText_CheckedChanged);
			// 
			// radioButtonScreenShot
			// 
			this.radioButtonScreenShot.AutoSize = true;
			this.radioButtonScreenShot.Location = new System.Drawing.Point(9, 71);
			this.radioButtonScreenShot.Name = "radioButtonScreenShot";
			this.radioButtonScreenShot.Size = new System.Drawing.Size(81, 17);
			this.radioButtonScreenShot.TabIndex = 3;
			this.radioButtonScreenShot.Text = "ScreenShot";
			this.radioButtonScreenShot.UseVisualStyleBackColor = true;
			this.radioButtonScreenShot.CheckedChanged += new System.EventHandler(this.radioButtonScreenShot_CheckedChanged);
			// 
			// Home
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(112, 100);
			this.Controls.Add(this.radioButtonScreenShot);
			this.Controls.Add(this.radioButtonReadText);
			this.Controls.Add(this.buttonCapture);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(2);
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(128, 139);
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(128, 139);
			this.Name = "Home";
			this.Text = "Capture";
			this.TopMost = true;
			this.Load += new System.EventHandler(this.Home_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button buttonCapture;
		private System.Windows.Forms.RadioButton radioButtonReadText;
		private System.Windows.Forms.RadioButton radioButtonScreenShot;
	}
}

