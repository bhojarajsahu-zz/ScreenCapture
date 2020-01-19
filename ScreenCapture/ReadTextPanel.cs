using System;
using System.IO;
using System.Windows.Forms;

namespace ScreenCapture
{
	public partial class ReadTextPanel : Form
	{
		public string copiedText = string.Empty;

		public ReadTextPanel()
		{
			InitializeComponent();
		}

		public void setText(string value)
		{
			//if (value.Contains("IronOcr License Exception"))
			//{
			//	int start = value.IndexOf("IronOcr License Exception");
			//	int end = value.Length - 1;
			//	value = value.Substring(0, start);
			//}

			copiedText = value;
		}

		private void ReadTextPanel_Load(object sender, EventArgs e)
		{
			this.FormClosing += ReadTextPanel_FormClosing;
			textBoxReadText.Text = "";
			textBoxReadText.Text = copiedText;
		}

		private void ReadTextPanel_FormClosing(object sender, FormClosingEventArgs e)
		{
			try
			{
				if (File.Exists(@"Temp.png"))
				{
					File.Delete(@"Temp.png");
				}
			}
			catch (Exception Ex)
			{ }
		}
	}
}