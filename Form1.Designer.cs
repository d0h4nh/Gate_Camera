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
            this.tlp_main = new System.Windows.Forms.TableLayoutPanel();
            this.grp_Gate = new System.Windows.Forms.GroupBox();
            this.btn_stoptrack = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_savepath = new System.Windows.Forms.Button();
            this.txt_filesave = new System.Windows.Forms.TextBox();
            this.btn_browse = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.lbl_status = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_starttrack = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rd_gateout = new System.Windows.Forms.RadioButton();
            this.rd_gatein = new System.Windows.Forms.RadioButton();
            this.rb_Scale2 = new System.Windows.Forms.RadioButton();
            this.rb_Scale1 = new System.Windows.Forms.RadioButton();
            this.rb_Gate4 = new System.Windows.Forms.RadioButton();
            this.rb_Gate3 = new System.Windows.Forms.RadioButton();
            this.rb_Gate1 = new System.Windows.Forms.RadioButton();
            this.rb_Gate2 = new System.Windows.Forms.RadioButton();
            this.tlp_picture = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.tlp_main.SuspendLayout();
            this.grp_Gate.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tlp_picture.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tlp_main
            // 
            this.tlp_main.ColumnCount = 4;
            this.tlp_main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlp_main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlp_main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlp_main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlp_main.Controls.Add(this.grp_Gate, 0, 0);
            this.tlp_main.Controls.Add(this.tlp_picture, 0, 1);
            this.tlp_main.Controls.Add(this.dataGridView1, 0, 2);
            this.tlp_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_main.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.AddColumns;
            this.tlp_main.Location = new System.Drawing.Point(0, 0);
            this.tlp_main.Name = "tlp_main";
            this.tlp_main.RowCount = 3;
            this.tlp_main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tlp_main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_main.Size = new System.Drawing.Size(1628, 1161);
            this.tlp_main.TabIndex = 0;
            // 
            // grp_Gate
            // 
            this.tlp_main.SetColumnSpan(this.grp_Gate, 4);
            this.grp_Gate.Controls.Add(this.btn_stoptrack);
            this.grp_Gate.Controls.Add(this.groupBox2);
            this.grp_Gate.Controls.Add(this.richTextBox1);
            this.grp_Gate.Controls.Add(this.lbl_status);
            this.grp_Gate.Controls.Add(this.label8);
            this.grp_Gate.Controls.Add(this.btn_starttrack);
            this.grp_Gate.Controls.Add(this.groupBox1);
            this.grp_Gate.Controls.Add(this.rb_Scale2);
            this.grp_Gate.Controls.Add(this.rb_Scale1);
            this.grp_Gate.Controls.Add(this.rb_Gate4);
            this.grp_Gate.Controls.Add(this.rb_Gate3);
            this.grp_Gate.Controls.Add(this.rb_Gate1);
            this.grp_Gate.Controls.Add(this.rb_Gate2);
            this.grp_Gate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grp_Gate.Location = new System.Drawing.Point(3, 3);
            this.grp_Gate.Name = "grp_Gate";
            this.grp_Gate.Size = new System.Drawing.Size(1622, 64);
            this.grp_Gate.TabIndex = 0;
            this.grp_Gate.TabStop = false;
            this.grp_Gate.Text = "Control";
            // 
            // btn_stoptrack
            // 
            this.btn_stoptrack.Location = new System.Drawing.Point(479, 34);
            this.btn_stoptrack.Name = "btn_stoptrack";
            this.btn_stoptrack.Size = new System.Drawing.Size(87, 23);
            this.btn_stoptrack.TabIndex = 15;
            this.btn_stoptrack.Text = "Stop Tracking";
            this.btn_stoptrack.UseVisualStyleBackColor = true;
            this.btn_stoptrack.Click += new System.EventHandler(this.btn_stoptrack_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_savepath);
            this.groupBox2.Controls.Add(this.txt_filesave);
            this.groupBox2.Controls.Add(this.btn_browse);
            this.groupBox2.Location = new System.Drawing.Point(942, 10);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(306, 48);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Picture Save Path";
            // 
            // btn_savepath
            // 
            this.btn_savepath.Location = new System.Drawing.Point(229, 15);
            this.btn_savepath.Name = "btn_savepath";
            this.btn_savepath.Size = new System.Drawing.Size(75, 23);
            this.btn_savepath.TabIndex = 2;
            this.btn_savepath.Text = "Save";
            this.btn_savepath.UseVisualStyleBackColor = true;
            this.btn_savepath.Click += new System.EventHandler(this.btn_savepath_Click);
            // 
            // txt_filesave
            // 
            this.txt_filesave.Location = new System.Drawing.Point(7, 17);
            this.txt_filesave.Name = "txt_filesave";
            this.txt_filesave.Size = new System.Drawing.Size(137, 20);
            this.txt_filesave.TabIndex = 1;
            // 
            // btn_browse
            // 
            this.btn_browse.Location = new System.Drawing.Point(150, 15);
            this.btn_browse.Name = "btn_browse";
            this.btn_browse.Size = new System.Drawing.Size(75, 23);
            this.btn_browse.TabIndex = 0;
            this.btn_browse.Text = "Browse";
            this.btn_browse.UseVisualStyleBackColor = true;
            this.btn_browse.Click += new System.EventHandler(this.btn_browse_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(668, 10);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(268, 48);
            this.richTextBox1.TabIndex = 13;
            this.richTextBox1.Text = "";
            // 
            // lbl_status
            // 
            this.lbl_status.AutoSize = true;
            this.lbl_status.Location = new System.Drawing.Point(614, 28);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(47, 13);
            this.lbl_status.TabIndex = 12;
            this.lbl_status.Text = "Stopped";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(573, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Status:";
            // 
            // btn_starttrack
            // 
            this.btn_starttrack.Location = new System.Drawing.Point(479, 11);
            this.btn_starttrack.Name = "btn_starttrack";
            this.btn_starttrack.Size = new System.Drawing.Size(87, 24);
            this.btn_starttrack.TabIndex = 9;
            this.btn_starttrack.Text = "Start Tracking";
            this.btn_starttrack.UseVisualStyleBackColor = true;
            this.btn_starttrack.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rd_gateout);
            this.groupBox1.Controls.Add(this.rd_gatein);
            this.groupBox1.Location = new System.Drawing.Point(272, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 49);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "In/Out";
            // 
            // rd_gateout
            // 
            this.rd_gateout.AutoSize = true;
            this.rd_gateout.Location = new System.Drawing.Point(108, 19);
            this.rd_gateout.Name = "rd_gateout";
            this.rd_gateout.Size = new System.Drawing.Size(68, 17);
            this.rd_gateout.TabIndex = 0;
            this.rd_gateout.TabStop = true;
            this.rd_gateout.Text = "Gate Out";
            this.rd_gateout.UseVisualStyleBackColor = true;
            this.rd_gateout.CheckedChanged += new System.EventHandler(this.rd_gateout_CheckedChanged);
            // 
            // rd_gatein
            // 
            this.rd_gatein.AutoSize = true;
            this.rd_gatein.Checked = true;
            this.rd_gatein.Location = new System.Drawing.Point(17, 20);
            this.rd_gatein.Name = "rd_gatein";
            this.rd_gatein.Size = new System.Drawing.Size(60, 17);
            this.rd_gatein.TabIndex = 0;
            this.rd_gatein.TabStop = true;
            this.rd_gatein.Text = "Gate In";
            this.rd_gatein.UseVisualStyleBackColor = true;
            this.rd_gatein.CheckedChanged += new System.EventHandler(this.rd_gatein_CheckedChanged);
            // 
            // rb_Scale2
            // 
            this.rb_Scale2.AutoSize = true;
            this.rb_Scale2.Location = new System.Drawing.Point(187, 41);
            this.rb_Scale2.Name = "rb_Scale2";
            this.rb_Scale2.Size = new System.Drawing.Size(67, 17);
            this.rb_Scale2.TabIndex = 7;
            this.rb_Scale2.TabStop = true;
            this.rb_Scale2.Text = "Scale 02";
            this.rb_Scale2.UseVisualStyleBackColor = true;
            this.rb_Scale2.CheckedChanged += new System.EventHandler(this.RadioButton6_CheckedChanged);
            // 
            // rb_Scale1
            // 
            this.rb_Scale1.AutoSize = true;
            this.rb_Scale1.Location = new System.Drawing.Point(187, 19);
            this.rb_Scale1.Name = "rb_Scale1";
            this.rb_Scale1.Size = new System.Drawing.Size(67, 17);
            this.rb_Scale1.TabIndex = 6;
            this.rb_Scale1.TabStop = true;
            this.rb_Scale1.Text = "Scale 01";
            this.rb_Scale1.UseVisualStyleBackColor = true;
            this.rb_Scale1.CheckedChanged += new System.EventHandler(this.RadioButton5_CheckedChanged);
            // 
            // rb_Gate4
            // 
            this.rb_Gate4.AutoSize = true;
            this.rb_Gate4.Location = new System.Drawing.Point(100, 41);
            this.rb_Gate4.Name = "rb_Gate4";
            this.rb_Gate4.Size = new System.Drawing.Size(63, 17);
            this.rb_Gate4.TabIndex = 5;
            this.rb_Gate4.TabStop = true;
            this.rb_Gate4.Text = "Gate 04";
            this.rb_Gate4.UseVisualStyleBackColor = true;
            this.rb_Gate4.CheckedChanged += new System.EventHandler(this.RadioButton4_CheckedChanged);
            // 
            // rb_Gate3
            // 
            this.rb_Gate3.AutoSize = true;
            this.rb_Gate3.Location = new System.Drawing.Point(100, 19);
            this.rb_Gate3.Name = "rb_Gate3";
            this.rb_Gate3.Size = new System.Drawing.Size(63, 17);
            this.rb_Gate3.TabIndex = 4;
            this.rb_Gate3.TabStop = true;
            this.rb_Gate3.Text = "Gate 03";
            this.rb_Gate3.UseVisualStyleBackColor = true;
            this.rb_Gate3.CheckedChanged += new System.EventHandler(this.RadioButton3_CheckedChanged);
            // 
            // rb_Gate1
            // 
            this.rb_Gate1.AutoSize = true;
            this.rb_Gate1.Checked = true;
            this.rb_Gate1.Location = new System.Drawing.Point(9, 19);
            this.rb_Gate1.Name = "rb_Gate1";
            this.rb_Gate1.Size = new System.Drawing.Size(63, 17);
            this.rb_Gate1.TabIndex = 3;
            this.rb_Gate1.TabStop = true;
            this.rb_Gate1.Text = "Gate 01";
            this.rb_Gate1.UseVisualStyleBackColor = true;
            this.rb_Gate1.CheckedChanged += new System.EventHandler(this.RadioButton1_CheckedChanged);
            // 
            // rb_Gate2
            // 
            this.rb_Gate2.AutoSize = true;
            this.rb_Gate2.Location = new System.Drawing.Point(9, 41);
            this.rb_Gate2.Name = "rb_Gate2";
            this.rb_Gate2.Size = new System.Drawing.Size(63, 17);
            this.rb_Gate2.TabIndex = 2;
            this.rb_Gate2.Text = "Gate 02";
            this.rb_Gate2.UseVisualStyleBackColor = true;
            this.rb_Gate2.CheckedChanged += new System.EventHandler(this.RadioButton2_CheckedChanged);
            // 
            // tlp_picture
            // 
            this.tlp_picture.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlp_picture.ColumnCount = 4;
            this.tlp_picture.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlp_picture.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tlp_picture.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlp_picture.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tlp_picture.Controls.Add(this.pictureBox1, 0, 0);
            this.tlp_picture.Controls.Add(this.pictureBox2, 2, 0);
            this.tlp_picture.Controls.Add(this.pictureBox3, 0, 1);
            this.tlp_picture.Controls.Add(this.textBox1, 1, 3);
            this.tlp_picture.Controls.Add(this.textBox3, 1, 5);
            this.tlp_picture.Controls.Add(this.textBox4, 1, 6);
            this.tlp_picture.Controls.Add(this.textBox5, 1, 7);
            this.tlp_picture.Controls.Add(this.textBox2, 1, 4);
            this.tlp_picture.Controls.Add(this.label2, 0, 4);
            this.tlp_picture.Controls.Add(this.label1, 0, 3);
            this.tlp_picture.Controls.Add(this.label3, 0, 5);
            this.tlp_picture.Controls.Add(this.label4, 0, 6);
            this.tlp_picture.Controls.Add(this.pictureBox4, 2, 1);
            this.tlp_picture.Controls.Add(this.label5, 0, 7);
            this.tlp_picture.Controls.Add(this.label6, 2, 5);
            this.tlp_picture.Controls.Add(this.label7, 2, 6);
            this.tlp_picture.Controls.Add(this.textBox6, 3, 5);
            this.tlp_picture.Controls.Add(this.textBox7, 3, 6);
            this.tlp_picture.Controls.Add(this.pictureBox5, 0, 2);
            this.tlp_picture.Location = new System.Drawing.Point(3, 73);
            this.tlp_picture.Name = "tlp_picture";
            this.tlp_picture.RowCount = 8;
            this.tlp_picture.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26.31579F));
            this.tlp_picture.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26.31579F));
            this.tlp_picture.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26.31579F));
            this.tlp_picture.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.210526F));
            this.tlp_picture.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.210526F));
            this.tlp_picture.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.210526F));
            this.tlp_picture.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.210526F));
            this.tlp_picture.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.210526F));
            this.tlp_picture.Size = new System.Drawing.Size(401, 539);
            this.tlp_picture.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.tlp_picture.SetColumnSpan(this.pictureBox1, 2);
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(194, 135);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.tlp_picture.SetColumnSpan(this.pictureBox2, 2);
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(203, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(195, 135);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.tlp_picture.SetColumnSpan(this.pictureBox3, 2);
            this.pictureBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(3, 144);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(194, 135);
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(83, 426);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(114, 20);
            this.textBox1.TabIndex = 4;
            // 
            // textBox3
            // 
            this.textBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox3.Location = new System.Drawing.Point(83, 470);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(114, 20);
            this.textBox3.TabIndex = 6;
            // 
            // textBox4
            // 
            this.textBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox4.Location = new System.Drawing.Point(83, 492);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(114, 20);
            this.textBox4.TabIndex = 7;
            // 
            // textBox5
            // 
            this.textBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox5.Location = new System.Drawing.Point(83, 514);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(114, 20);
            this.textBox5.TabIndex = 8;
            // 
            // textBox2
            // 
            this.textBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox2.Location = new System.Drawing.Point(83, 448);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(114, 20);
            this.textBox2.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 445);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 22);
            this.label2.TabIndex = 10;
            this.label2.Text = "Trailer Number";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 423);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 22);
            this.label1.TabIndex = 9;
            this.label1.Text = "Truck Number";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 467);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 22);
            this.label3.TabIndex = 11;
            this.label3.Text = "Container No 1";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 489);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 22);
            this.label4.TabIndex = 12;
            this.label4.Text = "Container No 2";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox4
            // 
            this.tlp_picture.SetColumnSpan(this.pictureBox4, 2);
            this.pictureBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(203, 144);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(195, 135);
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 518);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Gate Time";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(203, 471);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Size";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(203, 493);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Size";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox6
            // 
            this.textBox6.Dock = System.Windows.Forms.DockStyle.Left;
            this.textBox6.Location = new System.Drawing.Point(243, 470);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(50, 20);
            this.textBox6.TabIndex = 16;
            // 
            // textBox7
            // 
            this.textBox7.Dock = System.Windows.Forms.DockStyle.Left;
            this.textBox7.Location = new System.Drawing.Point(243, 492);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(50, 20);
            this.textBox7.TabIndex = 17;
            // 
            // pictureBox5
            // 
            this.tlp_picture.SetColumnSpan(this.pictureBox5, 2);
            this.pictureBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(3, 285);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(194, 135);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 18;
            this.pictureBox5.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tlp_main.SetColumnSpan(this.dataGridView1, 2);
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 618);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(808, 540);
            this.dataGridView1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1628, 1161);
            this.Controls.Add(this.tlp_main);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tlp_main.ResumeLayout(false);
            this.grp_Gate.ResumeLayout(false);
            this.grp_Gate.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tlp_picture.ResumeLayout(false);
            this.tlp_picture.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

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
    }
}

