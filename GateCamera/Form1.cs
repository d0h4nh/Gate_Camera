using System;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Reflection;
using System.Security.Policy;
using System.Text;
using System.Threading;
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
        private string lane = "Lane 1";
        private string in_out = " - Gate IN";
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
            this.tlp_main.Controls.Add(cam1,1,1);

            cam2.BeginInit();
            cam2.VlcLibDirectory = libDirectory;
            cam2.Dock = DockStyle.Fill;
            cam2.EndInit();
            this.tlp_main.Controls.Add(cam2,1,2);

            cam3.BeginInit();
            cam3.VlcLibDirectory = libDirectory;
            cam3.Dock = DockStyle.Fill;
            cam3.EndInit();
            this.tlp_main.Controls.Add(cam3,2,1);

            cam4.BeginInit();
            cam4.VlcLibDirectory = libDirectory;
            cam4.Dock = DockStyle.Fill;
            cam4.EndInit();
            this.tlp_main.Controls.Add(cam4,2,2);


            Load_title(lane, in_out);
            LoadCamera(gate);
            BindData("ai_data.csv");
        }
        private void BindData(string filePath)
        {
            DataTable dt = new DataTable();
            string[] lines = System.IO.File.ReadAllLines(filePath);
            if (lines.Length > 0)
            {
                //first line to create header
                string firstLine = lines[0];
                string[] headerLabels = firstLine.Split(',');
                foreach (string headerWord in headerLabels)
                {
                    dt.Columns.Add(new DataColumn(headerWord));
                }
                //For Data
                for (int i = 1; i < lines.Length; i++)
                {
                    string[] dataWords = lines[i].Split(',');
                    DataRow dr = dt.NewRow();
                    int columnIndex = 0;
                    foreach (string headerWord in headerLabels)
                    {
                        dr[headerWord] = dataWords[columnIndex++];
                    }
                    dt.Rows.Add(dr);
                }
            }
            if (dt.Rows.Count > 0)
            {
                dataGridView1.DataSource = dt;
            }

        }
        private void LoadPicture (string filePath)
        {
            
        }
        private void LoadCamera(int i)
        {
            if (gate != 11)
            {
                Debug.WriteLine(Properties.Settings.Default["Password"].ToString());
                cam2.Play(new Uri(URIbuilder(Properties.Settings.Default["Cam" + i].ToString(), Properties.Settings.Default["User"].ToString(), Properties.Settings.Default["Password"].ToString(), Properties.Settings.Default["Viewlink"].ToString())));
                cam1.Play(new Uri(URIbuilder(Properties.Settings.Default["Cam" + (i+1)].ToString(), Properties.Settings.Default["User"].ToString(), Properties.Settings.Default["Password"].ToString(), Properties.Settings.Default["Viewlink"].ToString())));
                cam3.Stop();
                cam4.Stop();

            }
            
            if (gate==11)
            {
                cam2.Play(new Uri(URIbuilder(Properties.Settings.Default["Cam" + i].ToString(), Properties.Settings.Default["User"].ToString(), Properties.Settings.Default["Password"].ToString(), Properties.Settings.Default["Viewlink"].ToString())));
                cam1.Play(new Uri(URIbuilder(Properties.Settings.Default["Cam" + (i + 1)].ToString(), Properties.Settings.Default["User"].ToString(), Properties.Settings.Default["Password"].ToString(), Properties.Settings.Default["Viewlink"].ToString())));
                cam3.Play(new Uri(URIbuilder(Properties.Settings.Default["Cam" + (i + 2)].ToString(), Properties.Settings.Default["User"].ToString(), Properties.Settings.Default["Password"].ToString(), Properties.Settings.Default["Viewlink"].ToString())));
                cam4.Play(new Uri(URIbuilder(Properties.Settings.Default["Cam" + (i + 3)].ToString(), Properties.Settings.Default["User"].ToString(), Properties.Settings.Default["Password"].ToString(), Properties.Settings.Default["Viewlink"].ToString())));
            }
        }
        private void Load_title(string lane, string in_out)
        {
            this.Text = lane + in_out;
        }
        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            gate = 1;
            LoadCamera(gate);
            lane = "Lane 1";
            Load_title(lane, in_out);

        }

        private void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            gate = 3;
            LoadCamera(gate);
            lane = "Lane 2";
            Load_title(lane, in_out);
        }

        private void RadioButton3_CheckedChanged(object sender, EventArgs e)
        {
            gate = 5;
            LoadCamera(gate);
            lane = "Lane 3";
            Load_title(lane, in_out);
        }

        private void RadioButton4_CheckedChanged(object sender, EventArgs e)
        {
            gate = 7;
            LoadCamera(gate);
            lane = "Lane 4";
            Load_title(lane, in_out);
        }

        private void RadioButton5_CheckedChanged(object sender, EventArgs e)
        {
            gate = 9;
            LoadCamera(gate);
            lane = "Lane Scale 1";
            Load_title(lane, in_out);
        }

        private void RadioButton6_CheckedChanged(object sender, EventArgs e)
        {
            gate = 11;
            LoadCamera(gate);
            lane = "Lane Scale 2";
            Load_title(lane, in_out);
        }

        private void rd_gatein_CheckedChanged(object sender, EventArgs e)
        {
            in_out = " - Gate IN";
            Load_title(lane, in_out);
        }

        private void rd_gateout_CheckedChanged(object sender, EventArgs e)
        {
            in_out = " - Gate OUT";
            Load_title(lane, in_out);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Thread t = new Thread(() => {
                APIrequest("http://" + Properties.Settings.Default["Cam" + gate] + Properties.Settings.Default["APILink"], "admin", "abcd1234");
            });
            t.IsBackground = true;
            if (t.IsAlive)
            {
                this.lbl_status.Text = "Running";
            }
            else
            {
                this.lbl_status.Text = "Stopped";
                t.Start ();
                this.lbl_status.Text = "Running";
            }
        }
        private void APIrequest(string uri,string user,string password)
        {
            Uri myUri = new Uri(uri);
            WebRequest myWebRequest = HttpWebRequest.Create(myUri);

            HttpWebRequest myHttpWebRequest = (HttpWebRequest)myWebRequest;

            NetworkCredential myNetworkCredential = new NetworkCredential(user, password);

            CredentialCache myCredentialCache = new CredentialCache();
            myCredentialCache.Add(myUri, "Digest", myNetworkCredential);

            myHttpWebRequest.PreAuthenticate = true;
            myHttpWebRequest.Credentials = myCredentialCache;

            WebResponse myWebResponse = myWebRequest.GetResponse();

            Stream responseStream = myWebResponse.GetResponseStream();

            StreamReader myStreamReader = new StreamReader(responseStream, Encoding.Default);
            Char[] read = new Char[256];
            int count = myStreamReader.Read(read, 0, 256);
            Debug.WriteLine("HTML...\r\n");
            while (count > 0)
            {
                // Dumps the 256 characters on a string and displays the string to the console.
                String str = new String(read, 0, count);
                if (str.Contains("VMD"))
                {
                    Debug.Write(str);
                    try
                    {
                        requestFrame("http://" + Properties.Settings.Default["Cam" + gate] + Properties.Settings.Default["CaptureLink"], "E:\\" + DateTime.Now.ToString("yyMMddHHmmss") + lane+in_out+".jpg");
                        requestFrame("http://" + Properties.Settings.Default["Cam" + (gate+1)] + Properties.Settings.Default["CaptureLink"], "E:\\" + DateTime.Now.ToString("yyMMddHHmmss") + lane + in_out + ".jpg");
                    }
                    catch (Exception ex) { MessageBox.Show(ex.ToString()); }

                    Debug.Write("Captured");
                }
                count = myStreamReader.Read(read, 0, 256);


            }
            Debug.WriteLine("");
            //string pageContent = myStreamReader.ReadToEnd();
            responseStream.Close();

            myWebResponse.Close();

            this.lbl_status.Text = "Stopped";
        }
        private void requestFrame(string url, string filename)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Credentials = new NetworkCredential(Properties.Settings.Default["User"].ToString(), Properties.Settings.Default["Password"].ToString());
            request.Proxy = null;

            request.BeginGetResponse(result => {
                finishRequestFrame(result, request, filename);
            }, null);

        }
        void finishRequestFrame(IAsyncResult result,
                              HttpWebRequest request,
                              string filename)
        {
            using (HttpWebResponse response =
             (HttpWebResponse)request.EndGetResponse(result))
            {
                Stream responseStream = response.GetResponseStream();

                using (Bitmap frame = new Bitmap(responseStream))
                {
                    if (frame != null)
                    {
                        Bitmap camsaved = (Bitmap)frame.Clone();
                        camsaved.Save(filename);
                    }
                    else
                    {
                        MessageBox.Show("Không lưu được ảnh, vui lòng thử lại", "Lỗi");
                    }
                }
            }
        }
        private string URIbuilder(string cam, string u, string p, string link)
        {

            return "rtsp://" + u + ":" + p + "@" + cam + ":554" + link;
        }

        
    }
}
