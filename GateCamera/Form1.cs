using System;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using Vlc.DotNet.Forms;

namespace GateCamera
{
    public partial class Form1 : Form
    {
        private VlcControl cam1 = new VlcControl();
        private VlcControl cam2 = new VlcControl();
        private VlcControl cam3 = new VlcControl();
        private VlcControl cam4 = new VlcControl();
        private int gate = 1;
        public Form1()
        {
            InitializeComponent();
            var currentAssembly = Assembly.GetEntryAssembly();
            var currentDirectory = new FileInfo(currentAssembly.Location).DirectoryName;
            // Default installation path of VideoLAN.LibVLC.Windows
            var libDirectory = new DirectoryInfo(Path.Combine(currentDirectory, "libvlc", IntPtr.Size == 4 ? "win-x86" : "win-x64"));

            cam1.BeginInit();
            cam1.VlcLibDirectory = libDirectory;
            cam1.Dock = DockStyle.Fill;
            cam1.EndInit();
            this.tableLayoutPanel1.Controls.Add(cam1,0,1);

            cam2.BeginInit();
            cam2.VlcLibDirectory = libDirectory;
            cam2.Dock = DockStyle.Fill;
            cam2.EndInit();
            this.tableLayoutPanel1.Controls.Add(cam2,0,2);

            cam3.BeginInit();
            cam3.VlcLibDirectory = libDirectory;
            cam3.Dock = DockStyle.Fill;
            cam3.EndInit();
            this.tableLayoutPanel1.Controls.Add(cam3,1,1);

            cam4.BeginInit();
            cam4.VlcLibDirectory = libDirectory;
            cam4.Dock = DockStyle.Fill;
            cam4.EndInit();
            this.tableLayoutPanel1.Controls.Add(cam4,1,2);

            /*if (radioButton1.Checked == true)
            {
                gate = 1;
            }
            else if (radioButton2.Checked == true)
            {
                gate = 3;
            }
            else if (radioButton3.Checked == true)
            {
                gate = 5;
            }
            else if (radioButton4.Checked == true)
            {
                gate = 7;
            }
            else if (radioButton5.Checked == true)
            {
                gate = 9;
            }*/
            this.Text = "Gate Camera v1.0 by HanhDD-ITNDP";
            LoadCamera(gate);
        }
        private void LoadCamera(int i)
        {
            if (gate != 11)
            {
                cam2.Play(Properties.Settings.Default["Cam" + i].ToString());
                cam1.Play(Properties.Settings.Default["Cam" + (i + 1)].ToString());
                cam3.Stop();
                cam4.Stop();

            }
            
            if (gate==11)
            {
                cam2.Play(Properties.Settings.Default["Cam" + i].ToString());
                cam1.Play(Properties.Settings.Default["Cam" + (i + 1)].ToString());
                cam3.Play(Properties.Settings.Default["Cam" + (i + 2)].ToString());
                cam4.Play(Properties.Settings.Default["Cam" + (i + 3)].ToString());
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            gate = 1;
            LoadCamera(gate);
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            gate = 3;
            LoadCamera(gate);
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            gate = 5;
            LoadCamera(gate);
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            gate = 7;
            LoadCamera(gate);
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            gate = 9;
            LoadCamera(gate);
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            gate = 11;
            LoadCamera(gate);
            
        }
    }
}
