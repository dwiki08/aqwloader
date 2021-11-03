
namespace Loader
{
	partial class Main
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
			this.container = new System.Windows.Forms.Panel();
			this.btnLoad = new System.Windows.Forms.Button();
			this.nTray = new System.Windows.Forms.NotifyIcon(this.components);
			this.container.SuspendLayout();
			this.SuspendLayout();
			// 
			// container
			// 
			this.container.Controls.Add(this.btnLoad);
			this.container.Dock = System.Windows.Forms.DockStyle.Fill;
			this.container.Location = new System.Drawing.Point(0, 0);
			this.container.Name = "container";
			this.container.Size = new System.Drawing.Size(944, 541);
			this.container.TabIndex = 0;
			// 
			// btnLoad
			// 
			this.btnLoad.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.btnLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnLoad.Location = new System.Drawing.Point(934, 528);
			this.btnLoad.Name = "btnLoad";
			this.btnLoad.Size = new System.Drawing.Size(10, 13);
			this.btnLoad.TabIndex = 0;
			this.btnLoad.UseVisualStyleBackColor = false;
			this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
			// 
			// nTray
			// 
			this.nTray.Icon = ((System.Drawing.Icon)(resources.GetObject("nTray.Icon")));
			this.nTray.Text = "nTray";
			this.nTray.Visible = true;
			this.nTray.MouseClick += new System.Windows.Forms.MouseEventHandler(this.nTray_MouseClick);
			// 
			// Main
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(944, 541);
			this.Controls.Add(this.container);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Main";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.container.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel container;
		private System.Windows.Forms.NotifyIcon nTray;
		private System.Windows.Forms.Button btnLoad;
	}
}

