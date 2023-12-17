namespace GateCamera
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            tlp_main = new System.Windows.Forms.TableLayoutPanel();
            grp_Gate = new System.Windows.Forms.GroupBox();
            btn_testpic = new System.Windows.Forms.Button();
            btn_stoptrack = new System.Windows.Forms.Button();
            groupBox2 = new System.Windows.Forms.GroupBox();
            btn_savepath = new System.Windows.Forms.Button();
            txt_filesave = new System.Windows.Forms.TextBox();
            btn_browse = new System.Windows.Forms.Button();
            richTextBox1 = new System.Windows.Forms.RichTextBox();
            lbl_status = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            btn_starttrack = new System.Windows.Forms.Button();
            groupBox1 = new System.Windows.Forms.GroupBox();
            rd_gateout = new System.Windows.Forms.RadioButton();
            rd_gatein = new System.Windows.Forms.RadioButton();
            rb_Scale2 = new System.Windows.Forms.RadioButton();
            rb_Scale1 = new System.Windows.Forms.RadioButton();
            rb_Gate4 = new System.Windows.Forms.RadioButton();
            rb_Gate3 = new System.Windows.Forms.RadioButton();
            rb_Gate1 = new System.Windows.Forms.RadioButton();
            rb_Gate2 = new System.Windows.Forms.RadioButton();
            tlp_picture = new System.Windows.Forms.TableLayoutPanel();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            pictureBox2 = new System.Windows.Forms.PictureBox();
            pictureBox3 = new System.Windows.Forms.PictureBox();
            textBox1 = new System.Windows.Forms.TextBox();
            textBox3 = new System.Windows.Forms.TextBox();
            textBox4 = new System.Windows.Forms.TextBox();
            textBox5 = new System.Windows.Forms.TextBox();
            textBox2 = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            pictureBox4 = new System.Windows.Forms.PictureBox();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            textBox6 = new System.Windows.Forms.TextBox();
            textBox7 = new System.Windows.Forms.TextBox();
            pictureBox5 = new System.Windows.Forms.PictureBox();
            dataGridView1 = new System.Windows.Forms.DataGridView();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            tlp_main.SuspendLayout();
            grp_Gate.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            tlp_picture.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // tlp_main
            // 
            tlp_main.ColumnCount = 4;
            tlp_main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            tlp_main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            tlp_main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            tlp_main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            tlp_main.Controls.Add(grp_Gate, 0, 0);
            tlp_main.Controls.Add(tlp_picture, 0, 1);
            tlp_main.Controls.Add(dataGridView1, 0, 2);
            tlp_main.Dock = System.Windows.Forms.DockStyle.Fill;
            tlp_main.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.AddColumns;
            tlp_main.Location = new System.Drawing.Point(0, 0);
            tlp_main.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tlp_main.Name = "tlp_main";
            tlp_main.RowCount = 3;
            tlp_main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 81F));
            tlp_main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tlp_main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tlp_main.Size = new System.Drawing.Size(1684, 791);
            tlp_main.TabIndex = 0;
            // 
            // grp_Gate
            // 
            tlp_main.SetColumnSpan(grp_Gate, 4);
            grp_Gate.Controls.Add(btn_testpic);
            grp_Gate.Controls.Add(btn_stoptrack);
            grp_Gate.Controls.Add(groupBox2);
            grp_Gate.Controls.Add(richTextBox1);
            grp_Gate.Controls.Add(lbl_status);
            grp_Gate.Controls.Add(label8);
            grp_Gate.Controls.Add(btn_starttrack);
            grp_Gate.Controls.Add(groupBox1);
            grp_Gate.Controls.Add(rb_Scale2);
            grp_Gate.Controls.Add(rb_Scale1);
            grp_Gate.Controls.Add(rb_Gate4);
            grp_Gate.Controls.Add(rb_Gate3);
            grp_Gate.Controls.Add(rb_Gate1);
            grp_Gate.Controls.Add(rb_Gate2);
            grp_Gate.Dock = System.Windows.Forms.DockStyle.Fill;
            grp_Gate.Location = new System.Drawing.Point(4, 3);
            grp_Gate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            grp_Gate.Name = "grp_Gate";
            grp_Gate.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            grp_Gate.Size = new System.Drawing.Size(1676, 75);
            grp_Gate.TabIndex = 0;
            grp_Gate.TabStop = false;
            grp_Gate.Text = "Control";
            // 
            // btn_testpic
            // 
            btn_testpic.Location = new System.Drawing.Point(1488, 29);
            btn_testpic.Name = "btn_testpic";
            btn_testpic.Size = new System.Drawing.Size(75, 26);
            btn_testpic.TabIndex = 16;
            btn_testpic.Text = "Test Picture";
            btn_testpic.UseVisualStyleBackColor = true;
            btn_testpic.Click += btn_testpic_Click;
            // 
            // btn_stoptrack
            // 
            btn_stoptrack.Location = new System.Drawing.Point(559, 39);
            btn_stoptrack.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btn_stoptrack.Name = "btn_stoptrack";
            btn_stoptrack.Size = new System.Drawing.Size(102, 27);
            btn_stoptrack.TabIndex = 15;
            btn_stoptrack.Text = "Stop Tracking";
            btn_stoptrack.UseVisualStyleBackColor = true;
            btn_stoptrack.Click += btn_stoptrack_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btn_savepath);
            groupBox2.Controls.Add(txt_filesave);
            groupBox2.Controls.Add(btn_browse);
            groupBox2.Location = new System.Drawing.Point(1099, 12);
            groupBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBox2.Size = new System.Drawing.Size(357, 55);
            groupBox2.TabIndex = 14;
            groupBox2.TabStop = false;
            groupBox2.Text = "Picture Save Path";
            // 
            // btn_savepath
            // 
            btn_savepath.Location = new System.Drawing.Point(267, 17);
            btn_savepath.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btn_savepath.Name = "btn_savepath";
            btn_savepath.Size = new System.Drawing.Size(88, 27);
            btn_savepath.TabIndex = 2;
            btn_savepath.Text = "Save";
            btn_savepath.UseVisualStyleBackColor = true;
            btn_savepath.Click += btn_savepath_Click;
            // 
            // txt_filesave
            // 
            txt_filesave.Location = new System.Drawing.Point(8, 20);
            txt_filesave.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txt_filesave.Name = "txt_filesave";
            txt_filesave.Size = new System.Drawing.Size(159, 23);
            txt_filesave.TabIndex = 1;
            // 
            // btn_browse
            // 
            btn_browse.Location = new System.Drawing.Point(175, 17);
            btn_browse.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btn_browse.Name = "btn_browse";
            btn_browse.Size = new System.Drawing.Size(88, 27);
            btn_browse.TabIndex = 0;
            btn_browse.Text = "Browse";
            btn_browse.UseVisualStyleBackColor = true;
            btn_browse.Click += btn_browse_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new System.Drawing.Point(779, 12);
            richTextBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new System.Drawing.Size(312, 55);
            richTextBox1.TabIndex = 13;
            richTextBox1.Text = "";
            // 
            // lbl_status
            // 
            lbl_status.AutoSize = true;
            lbl_status.Location = new System.Drawing.Point(716, 32);
            lbl_status.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lbl_status.Name = "lbl_status";
            lbl_status.Size = new System.Drawing.Size(51, 15);
            lbl_status.TabIndex = 12;
            lbl_status.Text = "Stopped";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(668, 32);
            label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(42, 15);
            label8.TabIndex = 10;
            label8.Text = "Status:";
            // 
            // btn_starttrack
            // 
            btn_starttrack.Location = new System.Drawing.Point(559, 13);
            btn_starttrack.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btn_starttrack.Name = "btn_starttrack";
            btn_starttrack.Size = new System.Drawing.Size(102, 28);
            btn_starttrack.TabIndex = 9;
            btn_starttrack.Text = "Start Tracking";
            btn_starttrack.UseVisualStyleBackColor = true;
            btn_starttrack.Click += button1_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rd_gateout);
            groupBox1.Controls.Add(rd_gatein);
            groupBox1.Location = new System.Drawing.Point(317, 10);
            groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBox1.Size = new System.Drawing.Size(233, 57);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "In/Out";
            // 
            // rd_gateout
            // 
            rd_gateout.AutoSize = true;
            rd_gateout.Location = new System.Drawing.Point(126, 22);
            rd_gateout.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            rd_gateout.Name = "rd_gateout";
            rd_gateout.Size = new System.Drawing.Size(72, 19);
            rd_gateout.TabIndex = 0;
            rd_gateout.TabStop = true;
            rd_gateout.Text = "Gate Out";
            rd_gateout.UseVisualStyleBackColor = true;
            rd_gateout.CheckedChanged += rd_gateout_CheckedChanged;
            // 
            // rd_gatein
            // 
            rd_gatein.AutoSize = true;
            rd_gatein.Checked = true;
            rd_gatein.Location = new System.Drawing.Point(20, 23);
            rd_gatein.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            rd_gatein.Name = "rd_gatein";
            rd_gatein.Size = new System.Drawing.Size(62, 19);
            rd_gatein.TabIndex = 0;
            rd_gatein.TabStop = true;
            rd_gatein.Text = "Gate In";
            rd_gatein.UseVisualStyleBackColor = true;
            rd_gatein.CheckedChanged += rd_gatein_CheckedChanged;
            // 
            // rb_Scale2
            // 
            rb_Scale2.AutoSize = true;
            rb_Scale2.Location = new System.Drawing.Point(218, 47);
            rb_Scale2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            rb_Scale2.Name = "rb_Scale2";
            rb_Scale2.Size = new System.Drawing.Size(67, 19);
            rb_Scale2.TabIndex = 7;
            rb_Scale2.TabStop = true;
            rb_Scale2.Text = "Scale 02";
            rb_Scale2.UseVisualStyleBackColor = true;
            rb_Scale2.CheckedChanged += RadioButton6_CheckedChanged;
            // 
            // rb_Scale1
            // 
            rb_Scale1.AutoSize = true;
            rb_Scale1.Location = new System.Drawing.Point(218, 22);
            rb_Scale1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            rb_Scale1.Name = "rb_Scale1";
            rb_Scale1.Size = new System.Drawing.Size(67, 19);
            rb_Scale1.TabIndex = 6;
            rb_Scale1.TabStop = true;
            rb_Scale1.Text = "Scale 01";
            rb_Scale1.UseVisualStyleBackColor = true;
            rb_Scale1.CheckedChanged += RadioButton5_CheckedChanged;
            // 
            // rb_Gate4
            // 
            rb_Gate4.AutoSize = true;
            rb_Gate4.Location = new System.Drawing.Point(117, 47);
            rb_Gate4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            rb_Gate4.Name = "rb_Gate4";
            rb_Gate4.Size = new System.Drawing.Size(64, 19);
            rb_Gate4.TabIndex = 5;
            rb_Gate4.TabStop = true;
            rb_Gate4.Text = "Gate 04";
            rb_Gate4.UseVisualStyleBackColor = true;
            rb_Gate4.CheckedChanged += RadioButton4_CheckedChanged;
            // 
            // rb_Gate3
            // 
            rb_Gate3.AutoSize = true;
            rb_Gate3.Location = new System.Drawing.Point(117, 22);
            rb_Gate3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            rb_Gate3.Name = "rb_Gate3";
            rb_Gate3.Size = new System.Drawing.Size(64, 19);
            rb_Gate3.TabIndex = 4;
            rb_Gate3.TabStop = true;
            rb_Gate3.Text = "Gate 03";
            rb_Gate3.UseVisualStyleBackColor = true;
            rb_Gate3.CheckedChanged += RadioButton3_CheckedChanged;
            // 
            // rb_Gate1
            // 
            rb_Gate1.AutoSize = true;
            rb_Gate1.Checked = true;
            rb_Gate1.Location = new System.Drawing.Point(10, 22);
            rb_Gate1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            rb_Gate1.Name = "rb_Gate1";
            rb_Gate1.Size = new System.Drawing.Size(64, 19);
            rb_Gate1.TabIndex = 3;
            rb_Gate1.TabStop = true;
            rb_Gate1.Text = "Gate 01";
            rb_Gate1.UseVisualStyleBackColor = true;
            rb_Gate1.CheckedChanged += RadioButton1_CheckedChanged;
            // 
            // rb_Gate2
            // 
            rb_Gate2.AutoSize = true;
            rb_Gate2.Location = new System.Drawing.Point(10, 47);
            rb_Gate2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            rb_Gate2.Name = "rb_Gate2";
            rb_Gate2.Size = new System.Drawing.Size(64, 19);
            rb_Gate2.TabIndex = 2;
            rb_Gate2.Text = "Gate 02";
            rb_Gate2.UseVisualStyleBackColor = true;
            rb_Gate2.CheckedChanged += RadioButton2_CheckedChanged;
            // 
            // tlp_picture
            // 
            tlp_picture.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            tlp_picture.ColumnCount = 4;
            tlp_picture.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            tlp_picture.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            tlp_picture.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            tlp_picture.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            tlp_picture.Controls.Add(pictureBox1, 0, 0);
            tlp_picture.Controls.Add(pictureBox2, 2, 0);
            tlp_picture.Controls.Add(pictureBox3, 0, 1);
            tlp_picture.Controls.Add(textBox1, 1, 3);
            tlp_picture.Controls.Add(textBox3, 1, 5);
            tlp_picture.Controls.Add(textBox4, 1, 6);
            tlp_picture.Controls.Add(textBox5, 1, 7);
            tlp_picture.Controls.Add(textBox2, 1, 4);
            tlp_picture.Controls.Add(label2, 0, 4);
            tlp_picture.Controls.Add(label1, 0, 3);
            tlp_picture.Controls.Add(label3, 0, 5);
            tlp_picture.Controls.Add(label4, 0, 6);
            tlp_picture.Controls.Add(pictureBox4, 2, 1);
            tlp_picture.Controls.Add(label5, 0, 7);
            tlp_picture.Controls.Add(label6, 2, 5);
            tlp_picture.Controls.Add(label7, 2, 6);
            tlp_picture.Controls.Add(textBox6, 3, 5);
            tlp_picture.Controls.Add(textBox7, 3, 6);
            tlp_picture.Controls.Add(pictureBox5, 0, 2);
            tlp_picture.Location = new System.Drawing.Point(4, 84);
            tlp_picture.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tlp_picture.Name = "tlp_picture";
            tlp_picture.RowCount = 8;
            tlp_picture.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26.31579F));
            tlp_picture.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26.31579F));
            tlp_picture.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26.31579F));
            tlp_picture.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.210526F));
            tlp_picture.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.210526F));
            tlp_picture.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.210526F));
            tlp_picture.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.210526F));
            tlp_picture.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.210526F));
            tlp_picture.Size = new System.Drawing.Size(413, 349);
            tlp_picture.TabIndex = 1;
            // 
            // pictureBox1
            // 
            tlp_picture.SetColumnSpan(pictureBox1, 2);
            pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new System.Drawing.Point(4, 3);
            pictureBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(197, 85);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            tlp_picture.SetColumnSpan(pictureBox2, 2);
            pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            pictureBox2.Image = (System.Drawing.Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new System.Drawing.Point(209, 3);
            pictureBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new System.Drawing.Size(200, 85);
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            tlp_picture.SetColumnSpan(pictureBox3, 2);
            pictureBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            pictureBox3.Image = (System.Drawing.Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new System.Drawing.Point(4, 94);
            pictureBox3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new System.Drawing.Size(197, 85);
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            textBox1.Location = new System.Drawing.Point(86, 276);
            textBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(115, 23);
            textBox1.TabIndex = 4;
            // 
            // textBox3
            // 
            textBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            textBox3.Location = new System.Drawing.Point(86, 304);
            textBox3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            textBox3.Name = "textBox3";
            textBox3.Size = new System.Drawing.Size(115, 23);
            textBox3.TabIndex = 6;
            // 
            // textBox4
            // 
            textBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            textBox4.Location = new System.Drawing.Point(86, 318);
            textBox4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            textBox4.Name = "textBox4";
            textBox4.Size = new System.Drawing.Size(115, 23);
            textBox4.TabIndex = 7;
            // 
            // textBox5
            // 
            textBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            textBox5.Location = new System.Drawing.Point(86, 332);
            textBox5.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            textBox5.Name = "textBox5";
            textBox5.Size = new System.Drawing.Size(115, 23);
            textBox5.TabIndex = 8;
            // 
            // textBox2
            // 
            textBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            textBox2.Location = new System.Drawing.Point(86, 290);
            textBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            textBox2.Name = "textBox2";
            textBox2.Size = new System.Drawing.Size(115, 23);
            textBox2.TabIndex = 5;
            // 
            // label2
            // 
            label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(27, 287);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(51, 14);
            label2.TabIndex = 10;
            label2.Text = "Trailer Number";
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(27, 273);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(51, 14);
            label1.TabIndex = 9;
            label1.Text = "Truck Number";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(19, 301);
            label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(59, 14);
            label3.TabIndex = 11;
            label3.Text = "Container No 1";
            label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(19, 315);
            label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(59, 14);
            label4.TabIndex = 12;
            label4.Text = "Container No 2";
            label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox4
            // 
            tlp_picture.SetColumnSpan(pictureBox4, 2);
            pictureBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            pictureBox4.Image = (System.Drawing.Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new System.Drawing.Point(209, 94);
            pictureBox4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new System.Drawing.Size(200, 85);
            pictureBox4.TabIndex = 3;
            pictureBox4.TabStop = false;
            // 
            // label5
            // 
            label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(18, 331);
            label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(60, 15);
            label5.TabIndex = 13;
            label5.Text = "Gate Time";
            label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(209, 301);
            label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(27, 14);
            label6.TabIndex = 14;
            label6.Text = "Size";
            label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(209, 315);
            label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(27, 14);
            label7.TabIndex = 15;
            label7.Text = "Size";
            label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox6
            // 
            textBox6.Dock = System.Windows.Forms.DockStyle.Left;
            textBox6.Location = new System.Drawing.Point(250, 304);
            textBox6.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            textBox6.Name = "textBox6";
            textBox6.Size = new System.Drawing.Size(58, 23);
            textBox6.TabIndex = 16;
            // 
            // textBox7
            // 
            textBox7.Dock = System.Windows.Forms.DockStyle.Left;
            textBox7.Location = new System.Drawing.Point(250, 318);
            textBox7.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            textBox7.Name = "textBox7";
            textBox7.Size = new System.Drawing.Size(58, 23);
            textBox7.TabIndex = 17;
            // 
            // pictureBox5
            // 
            tlp_picture.SetColumnSpan(pictureBox5, 2);
            pictureBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            pictureBox5.Image = (System.Drawing.Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new System.Drawing.Point(4, 185);
            pictureBox5.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new System.Drawing.Size(197, 85);
            pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 18;
            pictureBox5.TabStop = false;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            dataGridView1.Location = new System.Drawing.Point(4, 439);
            dataGridView1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new System.Drawing.Size(413, 349);
            dataGridView1.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1684, 791);
            Controls.Add(tlp_main);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "Form1";
            Text = "Form1";
            WindowState = System.Windows.Forms.FormWindowState.Maximized;
            tlp_main.ResumeLayout(false);
            grp_Gate.ResumeLayout(false);
            grp_Gate.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            tlp_picture.ResumeLayout(false);
            tlp_picture.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlp_main;
        private System.Windows.Forms.GroupBox grp_Gate;
        private System.Windows.Forms.RadioButton rb_Scale1;
        private System.Windows.Forms.RadioButton rb_Gate4;
        private System.Windows.Forms.RadioButton rb_Gate3;
        private System.Windows.Forms.RadioButton rb_Gate1;
        private System.Windows.Forms.RadioButton rb_Gate2;
        private System.Windows.Forms.RadioButton rb_Scale2;
        private System.Windows.Forms.TableLayoutPanel tlp_picture;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.RadioButton rd_gateout;
        private System.Windows.Forms.RadioButton rd_gatein;
        private System.Windows.Forms.Label lbl_status;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_starttrack;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button btn_browse;
        private System.Windows.Forms.Button btn_savepath;
        private System.Windows.Forms.TextBox txt_filesave;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Button btn_stoptrack;
        private System.Windows.Forms.Button btn_testpic;
    }
}

