namespace ScreenCapture
{
	partial class ReadTextPanel
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReadTextPanel));
			this.textBoxReadText = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// textBoxReadText
			// 
			this.textBoxReadText.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textBoxReadText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxReadText.Location = new System.Drawing.Point(0, 0);
			this.textBoxReadText.Multiline = true;
			this.textBoxReadText.Name = "textBoxReadText";
			this.textBoxReadText.Size = new System.Drawing.Size(395, 220);
			this.textBoxReadText.TabIndex = 0;
			// 
			// ReadTextPanel
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(395, 220);
			this.Controls.Add(this.textBoxReadText);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "ReadTextPanel";
			this.Text = "ReadTextPanel";
			this.TopMost = true;
			this.Load += new System.EventHandler(this.ReadTextPanel_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox textBoxReadText;
	}
}