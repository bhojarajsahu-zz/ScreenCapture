using System;
using System.Windows.Forms;

namespace ScreenCapture
{
	public partial class Home : Form
	{
		public bool saveScreenShot = false;

		public Home()
		{
			InitializeComponent();
		}

		private void buttonCapture_Click(object sender, EventArgs e)
		{
			this.Hide();
			ControlScreen form1 = new ControlScreen();
			form1.SetScreenShot(saveScreenShot);
			form1.InstanceRef = this;
			form1.Show();
		}

		private Form m_InstanceRef = null;

		public Form InstanceRef
		{
			get
			{
				return m_InstanceRef;
			}
			set
			{
				m_InstanceRef = value;
			}
		}

		private void Home_Load(object sender, EventArgs e)
		{
			int Height = Screen.AllScreens[0].WorkingArea.Height;
			int Width = Screen.AllScreens[0].WorkingArea.Width;
			this.Location = new System.Drawing.Point(Width - 150, Height - 150);
		}

		private void radioButtonReadText_CheckedChanged(object sender, EventArgs e)
		{
			setSaveScreenValue();
		}

		public void setSaveScreenValue()
		{
			if (radioButtonReadText.Checked)
				saveScreenShot = false;
			else
				saveScreenShot = true;
		}

		private void radioButtonScreenShot_CheckedChanged(object sender, EventArgs e)
		{
			setSaveScreenValue();
		}
	}
}