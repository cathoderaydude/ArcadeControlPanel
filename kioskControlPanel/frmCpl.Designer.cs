namespace kioskControlPanel
{
    partial class frmCpl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCpl));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txtDebug = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnStatus4 = new System.Windows.Forms.Button();
            this.btnStatus3 = new System.Windows.Forms.Button();
            this.btnStatus2 = new System.Windows.Forms.Button();
            this.btnStatus1 = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtDelay4 = new System.Windows.Forms.TextBox();
            this.txtDelay3 = new System.Windows.Forms.TextBox();
            this.txtDelay2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDelay1 = new System.Windows.Forms.TextBox();
            this.txtButton4 = new System.Windows.Forms.TextBox();
            this.txtButton3 = new System.Windows.Forms.TextBox();
            this.txtButton2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtButton1 = new System.Windows.Forms.TextBox();
            this.chkBinds = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.eventTimer = new System.Windows.Forms.Timer(this.components);
            this.txtDelay8 = new System.Windows.Forms.TextBox();
            this.txtDelay7 = new System.Windows.Forms.TextBox();
            this.txtDelay6 = new System.Windows.Forms.TextBox();
            this.txtDelay5 = new System.Windows.Forms.TextBox();
            this.txtButton8 = new System.Windows.Forms.TextBox();
            this.txtButton7 = new System.Windows.Forms.TextBox();
            this.txtButton6 = new System.Windows.Forms.TextBox();
            this.txtButton5 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.btnStatus8 = new System.Windows.Forms.Button();
            this.btnStatus7 = new System.Windows.Forms.Button();
            this.btnStatus6 = new System.Windows.Forms.Button();
            this.btnStatus5 = new System.Windows.Forms.Button();
            this.ntiIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.ctxIcon = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ctiExit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ctiShow = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.ctxIcon.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 32;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // txtDebug
            // 
            this.txtDebug.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDebug.Location = new System.Drawing.Point(3, 16);
            this.txtDebug.Margin = new System.Windows.Forms.Padding(10);
            this.txtDebug.Multiline = true;
            this.txtDebug.Name = "txtDebug";
            this.txtDebug.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDebug.Size = new System.Drawing.Size(291, 463);
            this.txtDebug.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtDebug);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(439, 3);
            this.groupBox2.Name = "groupBox2";
            this.tableLayoutPanel1.SetRowSpan(this.groupBox2, 2);
            this.groupBox2.Size = new System.Drawing.Size(297, 482);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Debug output";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnStatus8);
            this.groupBox3.Controls.Add(this.btnStatus7);
            this.groupBox3.Controls.Add(this.btnStatus6);
            this.groupBox3.Controls.Add(this.btnStatus5);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.btnStatus4);
            this.groupBox3.Controls.Add(this.btnStatus3);
            this.groupBox3.Controls.Add(this.btnStatus2);
            this.groupBox3.Controls.Add(this.btnStatus1);
            this.groupBox3.Location = new System.Drawing.Point(3, 3);
            this.groupBox3.Name = "groupBox3";
            this.tableLayoutPanel1.SetRowSpan(this.groupBox3, 2);
            this.groupBox3.Size = new System.Drawing.Size(236, 482);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Button status";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(48, 19);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(165, 39);
            this.label10.TabIndex = 5;
            this.label10.Text = "Click a button to test its binding\r\nThere will be a five second delay,\r\nand a bee" +
    "p when the test fires";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(6, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "Test:";
            // 
            // btnStatus4
            // 
            this.btnStatus4.BackColor = System.Drawing.Color.Maroon;
            this.btnStatus4.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnStatus4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStatus4.Font = new System.Drawing.Font("Lucida Console", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStatus4.ForeColor = System.Drawing.Color.White;
            this.btnStatus4.Location = new System.Drawing.Point(121, 167);
            this.btnStatus4.Name = "btnStatus4";
            this.btnStatus4.Size = new System.Drawing.Size(109, 83);
            this.btnStatus4.TabIndex = 3;
            this.btnStatus4.Text = "4";
            this.btnStatus4.UseVisualStyleBackColor = false;
            // 
            // btnStatus3
            // 
            this.btnStatus3.BackColor = System.Drawing.Color.Maroon;
            this.btnStatus3.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnStatus3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStatus3.Font = new System.Drawing.Font("Lucida Console", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStatus3.ForeColor = System.Drawing.Color.White;
            this.btnStatus3.Location = new System.Drawing.Point(6, 167);
            this.btnStatus3.Name = "btnStatus3";
            this.btnStatus3.Size = new System.Drawing.Size(109, 83);
            this.btnStatus3.TabIndex = 2;
            this.btnStatus3.Text = "3";
            this.btnStatus3.UseVisualStyleBackColor = false;
            // 
            // btnStatus2
            // 
            this.btnStatus2.BackColor = System.Drawing.Color.Maroon;
            this.btnStatus2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnStatus2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStatus2.Font = new System.Drawing.Font("Lucida Console", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStatus2.ForeColor = System.Drawing.Color.White;
            this.btnStatus2.Location = new System.Drawing.Point(121, 79);
            this.btnStatus2.Name = "btnStatus2";
            this.btnStatus2.Size = new System.Drawing.Size(109, 83);
            this.btnStatus2.TabIndex = 1;
            this.btnStatus2.Text = "2";
            this.btnStatus2.UseVisualStyleBackColor = false;
            // 
            // btnStatus1
            // 
            this.btnStatus1.BackColor = System.Drawing.Color.Maroon;
            this.btnStatus1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnStatus1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStatus1.Font = new System.Drawing.Font("Lucida Console", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStatus1.ForeColor = System.Drawing.Color.White;
            this.btnStatus1.Location = new System.Drawing.Point(6, 79);
            this.btnStatus1.Name = "btnStatus1";
            this.btnStatus1.Size = new System.Drawing.Size(109, 83);
            this.btnStatus1.TabIndex = 0;
            this.btnStatus1.Text = "1";
            this.btnStatus1.UseVisualStyleBackColor = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Controls.Add(this.label17);
            this.groupBox4.Controls.Add(this.label18);
            this.groupBox4.Controls.Add(this.label19);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.txtDelay8);
            this.groupBox4.Controls.Add(this.txtDelay7);
            this.groupBox4.Controls.Add(this.txtDelay6);
            this.groupBox4.Controls.Add(this.txtDelay5);
            this.groupBox4.Controls.Add(this.txtButton8);
            this.groupBox4.Controls.Add(this.txtButton7);
            this.groupBox4.Controls.Add(this.txtButton6);
            this.groupBox4.Controls.Add(this.txtButton5);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.txtDelay4);
            this.groupBox4.Controls.Add(this.txtDelay3);
            this.groupBox4.Controls.Add(this.txtDelay2);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.txtDelay1);
            this.groupBox4.Controls.Add(this.txtButton4);
            this.groupBox4.Controls.Add(this.txtButton3);
            this.groupBox4.Controls.Add(this.txtButton2);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.txtButton1);
            this.groupBox4.Controls.Add(this.chkBinds);
            this.groupBox4.Location = new System.Drawing.Point(248, 3);
            this.groupBox4.Name = "groupBox4";
            this.tableLayoutPanel1.SetRowSpan(this.groupBox4, 2);
            this.groupBox4.Size = new System.Drawing.Size(182, 473);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Bindings (NOT SAVED)";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(6, 434);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(170, 26);
            this.label11.TabIndex = 17;
            this.label11.Text = "Multiply \"Delay\" by 10 milliseconds\r\n(Delay 10 = 100 milliseconds)";
            // 
            // txtDelay4
            // 
            this.txtDelay4.Location = new System.Drawing.Point(112, 188);
            this.txtDelay4.Name = "txtDelay4";
            this.txtDelay4.Size = new System.Drawing.Size(64, 20);
            this.txtDelay4.TabIndex = 15;
            this.txtDelay4.Tag = "3";
            this.txtDelay4.Text = "0";
            this.txtDelay4.TextChanged += new System.EventHandler(this.event_validateDelay);
            // 
            // txtDelay3
            // 
            this.txtDelay3.Location = new System.Drawing.Point(112, 144);
            this.txtDelay3.Name = "txtDelay3";
            this.txtDelay3.Size = new System.Drawing.Size(64, 20);
            this.txtDelay3.TabIndex = 13;
            this.txtDelay3.Tag = "2";
            this.txtDelay3.Text = "0";
            this.txtDelay3.TextChanged += new System.EventHandler(this.event_validateDelay);
            // 
            // txtDelay2
            // 
            this.txtDelay2.Location = new System.Drawing.Point(112, 100);
            this.txtDelay2.Name = "txtDelay2";
            this.txtDelay2.Size = new System.Drawing.Size(64, 20);
            this.txtDelay2.TabIndex = 11;
            this.txtDelay2.Tag = "1";
            this.txtDelay2.Text = "0";
            this.txtDelay2.TextChanged += new System.EventHandler(this.event_validateDelay);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(109, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Delay";
            // 
            // txtDelay1
            // 
            this.txtDelay1.Location = new System.Drawing.Point(112, 56);
            this.txtDelay1.Name = "txtDelay1";
            this.txtDelay1.Size = new System.Drawing.Size(64, 20);
            this.txtDelay1.TabIndex = 9;
            this.txtDelay1.Tag = "0";
            this.txtDelay1.Text = "0";
            this.txtDelay1.TextChanged += new System.EventHandler(this.event_validateDelay);
            // 
            // txtButton4
            // 
            this.txtButton4.Location = new System.Drawing.Point(6, 188);
            this.txtButton4.Name = "txtButton4";
            this.txtButton4.Size = new System.Drawing.Size(100, 20);
            this.txtButton4.TabIndex = 7;
            // 
            // txtButton3
            // 
            this.txtButton3.Location = new System.Drawing.Point(6, 144);
            this.txtButton3.Name = "txtButton3";
            this.txtButton3.Size = new System.Drawing.Size(100, 20);
            this.txtButton3.TabIndex = 5;
            // 
            // txtButton2
            // 
            this.txtButton2.Location = new System.Drawing.Point(6, 100);
            this.txtButton2.Name = "txtButton2";
            this.txtButton2.Size = new System.Drawing.Size(100, 20);
            this.txtButton2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Button 1";
            // 
            // txtButton1
            // 
            this.txtButton1.Location = new System.Drawing.Point(6, 56);
            this.txtButton1.Name = "txtButton1";
            this.txtButton1.Size = new System.Drawing.Size(100, 20);
            this.txtButton1.TabIndex = 1;
            // 
            // chkBinds
            // 
            this.chkBinds.AutoSize = true;
            this.chkBinds.Location = new System.Drawing.Point(6, 18);
            this.chkBinds.Name = "chkBinds";
            this.chkBinds.Size = new System.Drawing.Size(88, 17);
            this.chkBinds.TabIndex = 0;
            this.chkBinds.Text = "Enable Binds";
            this.chkBinds.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 245F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 191F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox4, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox3, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(739, 488);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // eventTimer
            // 
            this.eventTimer.Enabled = true;
            this.eventTimer.Interval = 10;
            this.eventTimer.Tick += new System.EventHandler(this.eventTimer_Tick);
            // 
            // txtDelay8
            // 
            this.txtDelay8.Location = new System.Drawing.Point(112, 364);
            this.txtDelay8.Name = "txtDelay8";
            this.txtDelay8.Size = new System.Drawing.Size(64, 20);
            this.txtDelay8.TabIndex = 32;
            this.txtDelay8.Tag = "7";
            this.txtDelay8.Text = "0";
            // 
            // txtDelay7
            // 
            this.txtDelay7.Location = new System.Drawing.Point(112, 320);
            this.txtDelay7.Name = "txtDelay7";
            this.txtDelay7.Size = new System.Drawing.Size(64, 20);
            this.txtDelay7.TabIndex = 30;
            this.txtDelay7.Tag = "6";
            this.txtDelay7.Text = "50";
            // 
            // txtDelay6
            // 
            this.txtDelay6.Location = new System.Drawing.Point(112, 276);
            this.txtDelay6.Name = "txtDelay6";
            this.txtDelay6.Size = new System.Drawing.Size(64, 20);
            this.txtDelay6.TabIndex = 28;
            this.txtDelay6.Tag = "5";
            this.txtDelay6.Text = "50";
            // 
            // txtDelay5
            // 
            this.txtDelay5.Location = new System.Drawing.Point(112, 232);
            this.txtDelay5.Name = "txtDelay5";
            this.txtDelay5.Size = new System.Drawing.Size(64, 20);
            this.txtDelay5.TabIndex = 26;
            this.txtDelay5.Tag = "4";
            this.txtDelay5.Text = "0";
            // 
            // txtButton8
            // 
            this.txtButton8.Location = new System.Drawing.Point(6, 364);
            this.txtButton8.Name = "txtButton8";
            this.txtButton8.Size = new System.Drawing.Size(100, 20);
            this.txtButton8.TabIndex = 24;
            this.txtButton8.Text = "^%+{U}";
            // 
            // txtButton7
            // 
            this.txtButton7.Location = new System.Drawing.Point(6, 320);
            this.txtButton7.Name = "txtButton7";
            this.txtButton7.Size = new System.Drawing.Size(100, 20);
            this.txtButton7.TabIndex = 22;
            this.txtButton7.Text = "{Escape}";
            // 
            // txtButton6
            // 
            this.txtButton6.Location = new System.Drawing.Point(6, 276);
            this.txtButton6.Name = "txtButton6";
            this.txtButton6.Size = new System.Drawing.Size(100, 20);
            this.txtButton6.TabIndex = 20;
            this.txtButton6.Text = "%{F4}";
            // 
            // txtButton5
            // 
            this.txtButton5.Location = new System.Drawing.Point(6, 232);
            this.txtButton5.Name = "txtButton5";
            this.txtButton5.Size = new System.Drawing.Size(100, 20);
            this.txtButton5.TabIndex = 18;
            this.txtButton5.Text = "{5}";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(109, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 34;
            this.label2.Text = "Delay";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 33;
            this.label3.Text = "Button 2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(109, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 38;
            this.label4.Text = "Delay";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 172);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 37;
            this.label6.Text = "Button 4";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(109, 128);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 36;
            this.label7.Text = "Delay";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 128);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 13);
            this.label8.TabIndex = 35;
            this.label8.Text = "Button 3";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(109, 260);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(34, 13);
            this.label12.TabIndex = 42;
            this.label12.Text = "Delay";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 260);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(47, 13);
            this.label13.TabIndex = 41;
            this.label13.Text = "Button 6";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(109, 216);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(34, 13);
            this.label14.TabIndex = 40;
            this.label14.Text = "Delay";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 216);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(47, 13);
            this.label15.TabIndex = 39;
            this.label15.Text = "Button 5";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(109, 348);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(34, 13);
            this.label16.TabIndex = 46;
            this.label16.Text = "Delay";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(6, 348);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(47, 13);
            this.label17.TabIndex = 45;
            this.label17.Text = "Button 8";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(109, 304);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(34, 13);
            this.label18.TabIndex = 44;
            this.label18.Text = "Delay";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(6, 304);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(47, 13);
            this.label19.TabIndex = 43;
            this.label19.Text = "Button 7";
            // 
            // btnStatus8
            // 
            this.btnStatus8.BackColor = System.Drawing.Color.Maroon;
            this.btnStatus8.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnStatus8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStatus8.Font = new System.Drawing.Font("Lucida Console", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStatus8.ForeColor = System.Drawing.Color.White;
            this.btnStatus8.Location = new System.Drawing.Point(121, 344);
            this.btnStatus8.Name = "btnStatus8";
            this.btnStatus8.Size = new System.Drawing.Size(109, 83);
            this.btnStatus8.TabIndex = 9;
            this.btnStatus8.Text = "8";
            this.btnStatus8.UseVisualStyleBackColor = false;
            // 
            // btnStatus7
            // 
            this.btnStatus7.BackColor = System.Drawing.Color.Maroon;
            this.btnStatus7.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnStatus7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStatus7.Font = new System.Drawing.Font("Lucida Console", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStatus7.ForeColor = System.Drawing.Color.White;
            this.btnStatus7.Location = new System.Drawing.Point(6, 344);
            this.btnStatus7.Name = "btnStatus7";
            this.btnStatus7.Size = new System.Drawing.Size(109, 83);
            this.btnStatus7.TabIndex = 8;
            this.btnStatus7.Text = "7";
            this.btnStatus7.UseVisualStyleBackColor = false;
            // 
            // btnStatus6
            // 
            this.btnStatus6.BackColor = System.Drawing.Color.Maroon;
            this.btnStatus6.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnStatus6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStatus6.Font = new System.Drawing.Font("Lucida Console", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStatus6.ForeColor = System.Drawing.Color.White;
            this.btnStatus6.Location = new System.Drawing.Point(121, 256);
            this.btnStatus6.Name = "btnStatus6";
            this.btnStatus6.Size = new System.Drawing.Size(109, 83);
            this.btnStatus6.TabIndex = 7;
            this.btnStatus6.Text = "6";
            this.btnStatus6.UseVisualStyleBackColor = false;
            // 
            // btnStatus5
            // 
            this.btnStatus5.BackColor = System.Drawing.Color.Maroon;
            this.btnStatus5.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnStatus5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStatus5.Font = new System.Drawing.Font("Lucida Console", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStatus5.ForeColor = System.Drawing.Color.White;
            this.btnStatus5.Location = new System.Drawing.Point(6, 256);
            this.btnStatus5.Name = "btnStatus5";
            this.btnStatus5.Size = new System.Drawing.Size(109, 83);
            this.btnStatus5.TabIndex = 6;
            this.btnStatus5.Text = "5";
            this.btnStatus5.UseVisualStyleBackColor = false;
            // 
            // ntiIcon
            // 
            this.ntiIcon.ContextMenuStrip = this.ctxIcon;
            this.ntiIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("ntiIcon.Icon")));
            this.ntiIcon.Text = "Kiosk Control Panel";
            this.ntiIcon.Visible = true;
            // 
            // ctxIcon
            // 
            this.ctxIcon.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctiShow,
            this.toolStripSeparator1,
            this.ctiExit});
            this.ctxIcon.Name = "ctxIcon";
            this.ctxIcon.Size = new System.Drawing.Size(141, 54);
            // 
            // ctiExit
            // 
            this.ctiExit.Name = "ctiExit";
            this.ctiExit.Size = new System.Drawing.Size(140, 22);
            this.ctiExit.Text = "Exit";
            this.ctiExit.Click += new System.EventHandler(this.ctiExit_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(137, 6);
            // 
            // ctiShow
            // 
            this.ctiShow.Name = "ctiShow";
            this.ctiShow.Size = new System.Drawing.Size(140, 22);
            this.ctiShow.Text = "Show config";
            this.ctiShow.Click += new System.EventHandler(this.ctiShow_Click);
            // 
            // frmCpl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 488);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(2100, 100);
            this.MinimumSize = new System.Drawing.Size(755, 343);
            this.Name = "frmCpl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Kiosk Control Panel";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ctxIcon.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox txtDebug;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnStatus4;
        private System.Windows.Forms.Button btnStatus3;
        private System.Windows.Forms.Button btnStatus2;
        private System.Windows.Forms.Button btnStatus1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtDelay4;
        private System.Windows.Forms.TextBox txtDelay3;
        private System.Windows.Forms.TextBox txtDelay2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDelay1;
        private System.Windows.Forms.TextBox txtButton4;
        private System.Windows.Forms.TextBox txtButton3;
        private System.Windows.Forms.TextBox txtButton2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtButton1;
        private System.Windows.Forms.CheckBox chkBinds;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Timer eventTimer;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDelay8;
        private System.Windows.Forms.TextBox txtDelay7;
        private System.Windows.Forms.TextBox txtDelay6;
        private System.Windows.Forms.TextBox txtDelay5;
        private System.Windows.Forms.TextBox txtButton8;
        private System.Windows.Forms.TextBox txtButton7;
        private System.Windows.Forms.TextBox txtButton6;
        private System.Windows.Forms.TextBox txtButton5;
        private System.Windows.Forms.Button btnStatus8;
        private System.Windows.Forms.Button btnStatus7;
        private System.Windows.Forms.Button btnStatus6;
        private System.Windows.Forms.Button btnStatus5;
        private System.Windows.Forms.NotifyIcon ntiIcon;
        private System.Windows.Forms.ContextMenuStrip ctxIcon;
        private System.Windows.Forms.ToolStripMenuItem ctiShow;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem ctiExit;
    }
}

