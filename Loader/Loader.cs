using System;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace Loader
{
	public partial class Main : Form
	{
		private AxShockwaveFlashObjects.AxShockwaveFlash flashPlayer;
		private OpenFileDialog openFileDialog;

		public Main()
		{
			InitializeComponent();

			flashPlayer = new AxShockwaveFlashObjects.AxShockwaveFlash();
			flashPlayer.BeginInit();
			flashPlayer.Name = "flashPlayer";
			flashPlayer.Dock = DockStyle.Fill;
			flashPlayer.TabIndex = 0;
			container.Controls.Add(flashPlayer);
			flashPlayer.EndInit();

			//InitFlashEmbed();
			InitFlashExternal();
		}

		private void InitFlashExternal()
		{
			string loader = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "Loader.swf");
			if (File.Exists(loader))
				flashPlayer.LoadMovie(0, loader);
		}

		private void InitFlashEmbed()
		{
			byte[] swf = Properties.Resources.Loader;
			using (MemoryStream memoryStream = new MemoryStream())
			{
				using (BinaryWriter binaryWriter = new BinaryWriter(memoryStream))
				{
					binaryWriter.Write(8 + swf.Length);
					binaryWriter.Write(1432769894);
					binaryWriter.Write(swf.Length);
					binaryWriter.Write(swf);
					memoryStream.Seek(0L, SeekOrigin.Begin);
					flashPlayer.OcxState = new AxHost.State(memoryStream, 1, false, null);
				}
			}
		}

		private void btnLoad_Click(object sender, EventArgs e)
		{
			openFileDialog = new OpenFileDialog();
			openFileDialog.InitialDirectory = "C:\\";
			openFileDialog.Filter = "SWF File (*.swf*)|*.swf*";
			openFileDialog.Title = "Select .swf file to load";
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				flashPlayer.LoadMovie(0, " ");
				flashPlayer.LoadMovie(0, openFileDialog.FileName);
			}
		}

		private void nTray_MouseClick(object sender, MouseEventArgs e)
		{
			ShowForm(this);
		}

		private void ShowForm(Form form)
		{
			if (form.WindowState == FormWindowState.Minimized)
			{
				form.WindowState = FormWindowState.Normal;
				form.Show();
				form.BringToFront();
				form.Focus();
				return;
			}
			else if (form.Visible)
			{
				form.Hide();
				return;
			}
			form.Show();
			form.BringToFront();
			form.Focus();
		}
	}
}
