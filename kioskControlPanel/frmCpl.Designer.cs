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
            this.tmrPoll = new System.Windows.Forms.Timer(this.components);
            this.txtDebug = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnStatus8 = new System.Windows.Forms.Button();
            this.btnStatus7 = new System.Windows.Forms.Button();
            this.btnStatus6 = new System.Windows.Forms.Button();
            this.btnStatus5 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnStatus4 = new System.Windows.Forms.Button();
            this.btnStatus3 = new System.Windows.Forms.Button();
            this.btnStatus2 = new System.Windows.Forms.Button();
            this.btnStatus1 = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDelay8 = new System.Windows.Forms.TextBox();
            this.txtDelay7 = new System.Windows.Forms.TextBox();
            this.txtDelay6 = new System.Windows.Forms.TextBox();
            this.txtDelay5 = new System.Windows.Forms.TextBox();
            this.txtButton8 = new System.Windows.Forms.TextBox();
            this.txtButton7 = new System.Windows.Forms.TextBox();
            this.txtButton6 = new System.Windows.Forms.TextBox();
            this.txtButton5 = new System.Windows.Forms.TextBox();
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
            this.ChkBinds = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.eventTimer = new System.Windows.Forms.Timer(this.components);
            this.ntiIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.ctxIcon = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ctiShow = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ctiExit = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.panel13 = new System.Windows.Forms.Panel();
            this.panel14 = new System.Windows.Forms.Panel();
            this.panel15 = new System.Windows.Forms.Panel();
            this.panel16 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.ctxIcon.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel12.SuspendLayout();
            this.panel13.SuspendLayout();
            this.panel14.SuspendLayout();
            this.panel15.SuspendLayout();
            this.panel16.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tmrPoll
            // 
            this.tmrPoll.Enabled = true;
            this.tmrPoll.Interval = 32;
            this.tmrPoll.Tick += new System.EventHandler(this.TmrPoll_Tick);
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
            this.groupBox2.Location = new System.Drawing.Point(679, 3);
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
            this.groupBox4.Controls.Add(this.tableLayoutPanel3);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(248, 3);
            this.groupBox4.Name = "groupBox4";
            this.tableLayoutPanel1.SetRowSpan(this.groupBox4, 2);
            this.groupBox4.Size = new System.Drawing.Size(425, 482);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Bindings (NOT SAVED)";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(3, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(34, 13);
            this.label16.TabIndex = 46;
            this.label16.Text = "Delay";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(6, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(47, 13);
            this.label17.TabIndex = 45;
            this.label17.Text = "Button 8";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(3, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(34, 13);
            this.label18.TabIndex = 44;
            this.label18.Text = "Delay";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(6, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(47, 13);
            this.label19.TabIndex = 43;
            this.label19.Text = "Button 7";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(3, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(34, 13);
            this.label12.TabIndex = 42;
            this.label12.Text = "Delay";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(47, 13);
            this.label13.TabIndex = 41;
            this.label13.Text = "Button 6";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(3, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(34, 13);
            this.label14.TabIndex = 40;
            this.label14.Text = "Delay";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, -2);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(47, 13);
            this.label15.TabIndex = 39;
            this.label15.Text = "Button 5";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 38;
            this.label4.Text = "Delay";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 37;
            this.label6.Text = "Button 4";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 36;
            this.label7.Text = "Delay";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 13);
            this.label8.TabIndex = 35;
            this.label8.Text = "Button 3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 34;
            this.label2.Text = "Delay";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 33;
            this.label3.Text = "Button 2";
            // 
            // txtDelay8
            // 
            this.txtDelay8.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtDelay8.Location = new System.Drawing.Point(0, 27);
            this.txtDelay8.Name = "txtDelay8";
            this.txtDelay8.Size = new System.Drawing.Size(74, 20);
            this.txtDelay8.TabIndex = 32;
            this.txtDelay8.Tag = "7";
            this.txtDelay8.Text = "0";
            // 
            // txtDelay7
            // 
            this.txtDelay7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtDelay7.Location = new System.Drawing.Point(0, 22);
            this.txtDelay7.Name = "txtDelay7";
            this.txtDelay7.Size = new System.Drawing.Size(74, 20);
            this.txtDelay7.TabIndex = 30;
            this.txtDelay7.Tag = "6";
            this.txtDelay7.Text = "50";
            // 
            // txtDelay6
            // 
            this.txtDelay6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtDelay6.Location = new System.Drawing.Point(0, 22);
            this.txtDelay6.Name = "txtDelay6";
            this.txtDelay6.Size = new System.Drawing.Size(74, 20);
            this.txtDelay6.TabIndex = 28;
            this.txtDelay6.Tag = "5";
            this.txtDelay6.Text = "50";
            // 
            // txtDelay5
            // 
            this.txtDelay5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtDelay5.Location = new System.Drawing.Point(0, 22);
            this.txtDelay5.Name = "txtDelay5";
            this.txtDelay5.Size = new System.Drawing.Size(74, 20);
            this.txtDelay5.TabIndex = 26;
            this.txtDelay5.Tag = "4";
            this.txtDelay5.Text = "0";
            // 
            // txtButton8
            // 
            this.txtButton8.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtButton8.Location = new System.Drawing.Point(0, 27);
            this.txtButton8.Name = "txtButton8";
            this.txtButton8.Size = new System.Drawing.Size(327, 20);
            this.txtButton8.TabIndex = 24;
            this.txtButton8.Text = "^%+{U}";
            // 
            // txtButton7
            // 
            this.txtButton7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtButton7.Location = new System.Drawing.Point(0, 22);
            this.txtButton7.Name = "txtButton7";
            this.txtButton7.Size = new System.Drawing.Size(327, 20);
            this.txtButton7.TabIndex = 22;
            this.txtButton7.Text = "{Escape}";
            // 
            // txtButton6
            // 
            this.txtButton6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtButton6.Location = new System.Drawing.Point(0, 22);
            this.txtButton6.Name = "txtButton6";
            this.txtButton6.Size = new System.Drawing.Size(327, 20);
            this.txtButton6.TabIndex = 20;
            this.txtButton6.Text = "%{F4}";
            // 
            // txtButton5
            // 
            this.txtButton5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtButton5.Location = new System.Drawing.Point(0, 22);
            this.txtButton5.Name = "txtButton5";
            this.txtButton5.Size = new System.Drawing.Size(327, 20);
            this.txtButton5.TabIndex = 18;
            this.txtButton5.Text = "{5}";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(3, 421);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(170, 26);
            this.label11.TabIndex = 17;
            this.label11.Text = "Multiply \"Delay\" by 10 milliseconds\r\n(Delay 10 = 100 milliseconds)";
            // 
            // txtDelay4
            // 
            this.txtDelay4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtDelay4.Location = new System.Drawing.Point(0, 22);
            this.txtDelay4.Name = "txtDelay4";
            this.txtDelay4.Size = new System.Drawing.Size(74, 20);
            this.txtDelay4.TabIndex = 15;
            this.txtDelay4.Tag = "3";
            this.txtDelay4.Text = "0";
            this.txtDelay4.TextChanged += new System.EventHandler(this.Event_ValidateDelay);
            // 
            // txtDelay3
            // 
            this.txtDelay3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtDelay3.Location = new System.Drawing.Point(0, 22);
            this.txtDelay3.Name = "txtDelay3";
            this.txtDelay3.Size = new System.Drawing.Size(74, 20);
            this.txtDelay3.TabIndex = 13;
            this.txtDelay3.Tag = "2";
            this.txtDelay3.Text = "0";
            this.txtDelay3.TextChanged += new System.EventHandler(this.Event_ValidateDelay);
            // 
            // txtDelay2
            // 
            this.txtDelay2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtDelay2.Location = new System.Drawing.Point(0, 22);
            this.txtDelay2.Name = "txtDelay2";
            this.txtDelay2.Size = new System.Drawing.Size(74, 20);
            this.txtDelay2.TabIndex = 11;
            this.txtDelay2.Tag = "1";
            this.txtDelay2.Text = "0";
            this.txtDelay2.TextChanged += new System.EventHandler(this.Event_ValidateDelay);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Delay";
            // 
            // txtDelay1
            // 
            this.txtDelay1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtDelay1.Location = new System.Drawing.Point(0, 22);
            this.txtDelay1.Name = "txtDelay1";
            this.txtDelay1.Size = new System.Drawing.Size(74, 20);
            this.txtDelay1.TabIndex = 9;
            this.txtDelay1.Tag = "0";
            this.txtDelay1.Text = "0";
            this.txtDelay1.TextChanged += new System.EventHandler(this.Event_ValidateDelay);
            // 
            // txtButton4
            // 
            this.txtButton4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtButton4.Location = new System.Drawing.Point(0, 22);
            this.txtButton4.Name = "txtButton4";
            this.txtButton4.Size = new System.Drawing.Size(327, 20);
            this.txtButton4.TabIndex = 7;
            // 
            // txtButton3
            // 
            this.txtButton3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtButton3.Location = new System.Drawing.Point(0, 22);
            this.txtButton3.Name = "txtButton3";
            this.txtButton3.Size = new System.Drawing.Size(327, 20);
            this.txtButton3.TabIndex = 5;
            // 
            // txtButton2
            // 
            this.txtButton2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtButton2.Location = new System.Drawing.Point(0, 22);
            this.txtButton2.Name = "txtButton2";
            this.txtButton2.Size = new System.Drawing.Size(327, 20);
            this.txtButton2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Button 1";
            // 
            // txtButton1
            // 
            this.txtButton1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtButton1.Location = new System.Drawing.Point(0, 22);
            this.txtButton1.Name = "txtButton1";
            this.txtButton1.Size = new System.Drawing.Size(327, 20);
            this.txtButton1.TabIndex = 1;
            // 
            // ChkBinds
            // 
            this.ChkBinds.AutoSize = true;
            this.ChkBinds.Location = new System.Drawing.Point(3, 3);
            this.ChkBinds.Name = "ChkBinds";
            this.ChkBinds.Size = new System.Drawing.Size(88, 17);
            this.ChkBinds.TabIndex = 0;
            this.ChkBinds.Text = "Enable Binds";
            this.ChkBinds.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 245F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(979, 488);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // eventTimer
            // 
            this.eventTimer.Enabled = true;
            this.eventTimer.Interval = 10;
            this.eventTimer.Tick += new System.EventHandler(this.EventTimer_Tick);
            // 
            // ntiIcon
            // 
            this.ntiIcon.ContextMenuStrip = this.ctxIcon;
            this.ntiIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("ntiIcon.Icon")));
            this.ntiIcon.Text = "Kiosk Control Panel";
            this.ntiIcon.Visible = true;
            this.ntiIcon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.NtiIcon_MouseClick);
            // 
            // ctxIcon
            // 
            this.ctxIcon.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctiShow,
            this.toolStripSeparator1,
            this.ctiExit});
            this.ctxIcon.Name = "ctxIcon";
            this.ctxIcon.Size = new System.Drawing.Size(141, 54);
            this.ctxIcon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.CtiShow_Click);
            // 
            // ctiShow
            // 
            this.ctiShow.Name = "ctiShow";
            this.ctiShow.Size = new System.Drawing.Size(140, 22);
            this.ctiShow.Text = "Show config";
            this.ctiShow.Click += new System.EventHandler(this.CtiShow_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(137, 6);
            // 
            // ctiExit
            // 
            this.ctiExit.Name = "ctiExit";
            this.ctiExit.Size = new System.Drawing.Size(140, 22);
            this.ctiExit.Text = "Exit";
            this.ctiExit.Click += new System.EventHandler(this.CtiExit_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel2.Controls.Add(this.panel16, 1, 7);
            this.tableLayoutPanel2.Controls.Add(this.panel15, 0, 7);
            this.tableLayoutPanel2.Controls.Add(this.panel14, 1, 6);
            this.tableLayoutPanel2.Controls.Add(this.panel13, 0, 6);
            this.tableLayoutPanel2.Controls.Add(this.panel12, 1, 5);
            this.tableLayoutPanel2.Controls.Add(this.panel11, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.panel10, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.panel9, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.panel8, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.panel7, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.panel6, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.panel5, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.panel4, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.panel3, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 29);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 8;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(413, 389);
            this.tableLayoutPanel2.TabIndex = 47;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtButton1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(327, 42);
            this.panel1.TabIndex = 48;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txtDelay1);
            this.panel2.Location = new System.Drawing.Point(336, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(74, 42);
            this.panel2.TabIndex = 49;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtButton2);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 51);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(327, 42);
            this.panel3.TabIndex = 50;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.txtDelay2);
            this.panel4.Location = new System.Drawing.Point(336, 51);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(74, 42);
            this.panel4.TabIndex = 51;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.txtButton3);
            this.panel5.Controls.Add(this.label8);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(3, 99);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(327, 42);
            this.panel5.TabIndex = 52;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.label7);
            this.panel6.Controls.Add(this.txtDelay3);
            this.panel6.Location = new System.Drawing.Point(336, 99);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(74, 42);
            this.panel6.TabIndex = 53;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.txtButton4);
            this.panel7.Controls.Add(this.label6);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(3, 147);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(327, 42);
            this.panel7.TabIndex = 54;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.label4);
            this.panel8.Controls.Add(this.txtDelay4);
            this.panel8.Location = new System.Drawing.Point(336, 147);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(74, 42);
            this.panel8.TabIndex = 55;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.txtButton5);
            this.panel9.Controls.Add(this.label15);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel9.Location = new System.Drawing.Point(3, 195);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(327, 42);
            this.panel9.TabIndex = 56;
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.label14);
            this.panel10.Controls.Add(this.txtDelay5);
            this.panel10.Location = new System.Drawing.Point(336, 195);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(74, 42);
            this.panel10.TabIndex = 57;
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.txtButton6);
            this.panel11.Controls.Add(this.label13);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel11.Location = new System.Drawing.Point(3, 243);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(327, 42);
            this.panel11.TabIndex = 58;
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.label12);
            this.panel12.Controls.Add(this.txtDelay6);
            this.panel12.Location = new System.Drawing.Point(336, 243);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(74, 42);
            this.panel12.TabIndex = 59;
            // 
            // panel13
            // 
            this.panel13.Controls.Add(this.label19);
            this.panel13.Controls.Add(this.txtButton7);
            this.panel13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel13.Location = new System.Drawing.Point(3, 291);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(327, 42);
            this.panel13.TabIndex = 60;
            // 
            // panel14
            // 
            this.panel14.Controls.Add(this.label18);
            this.panel14.Controls.Add(this.txtDelay7);
            this.panel14.Location = new System.Drawing.Point(336, 291);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(74, 42);
            this.panel14.TabIndex = 61;
            // 
            // panel15
            // 
            this.panel15.Controls.Add(this.label17);
            this.panel15.Controls.Add(this.txtButton8);
            this.panel15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel15.Location = new System.Drawing.Point(3, 339);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(327, 47);
            this.panel15.TabIndex = 62;
            // 
            // panel16
            // 
            this.panel16.Controls.Add(this.label16);
            this.panel16.Controls.Add(this.txtDelay8);
            this.panel16.Location = new System.Drawing.Point(336, 339);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(74, 47);
            this.panel16.TabIndex = 63;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.label11, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.ChkBinds, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(419, 463);
            this.tableLayoutPanel3.TabIndex = 48;
            // 
            // frmCpl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 488);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(2100, 100);
            this.MinimumSize = new System.Drawing.Size(755, 343);
            this.Name = "frmCpl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Kiosk Control Panel";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmCpl_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmCpl_FormClosed);
            this.SizeChanged += new System.EventHandler(this.FrmCpl_SizeChanged);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ctxIcon.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.panel12.ResumeLayout(false);
            this.panel12.PerformLayout();
            this.panel13.ResumeLayout(false);
            this.panel13.PerformLayout();
            this.panel14.ResumeLayout(false);
            this.panel14.PerformLayout();
            this.panel15.ResumeLayout(false);
            this.panel15.PerformLayout();
            this.panel16.ResumeLayout(false);
            this.panel16.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer tmrPoll;
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
        private System.Windows.Forms.CheckBox ChkBinds;
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
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel16;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}

