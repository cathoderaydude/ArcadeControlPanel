﻿using System.Reflection;
using System.Diagnostics;

namespace ArcadeControlPanel
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
            this.btnStatus8 = new System.Windows.Forms.Button();
            this.btnStatus7 = new System.Windows.Forms.Button();
            this.btnStatus6 = new System.Windows.Forms.Button();
            this.btnStatus5 = new System.Windows.Forms.Button();
            this.btnStatus4 = new System.Windows.Forms.Button();
            this.btnStatus3 = new System.Windows.Forms.Button();
            this.btnStatus2 = new System.Windows.Forms.Button();
            this.btnStatus1 = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.ChkBinds = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel16 = new System.Windows.Forms.Panel();
            this.panel14 = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel24 = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.txtDelay8 = new System.Windows.Forms.TextBox();
            this.panel23 = new System.Windows.Forms.Panel();
            this.label18 = new System.Windows.Forms.Label();
            this.txtDelay7 = new System.Windows.Forms.TextBox();
            this.panel22 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.txtDelay6 = new System.Windows.Forms.TextBox();
            this.panel21 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.txtDelay5 = new System.Windows.Forms.TextBox();
            this.panel20 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDelay4 = new System.Windows.Forms.TextBox();
            this.panel19 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDelay3 = new System.Windows.Forms.TextBox();
            this.panel18 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDelay2 = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.chkSnd1 = new System.Windows.Forms.CheckBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.chkSnd2 = new System.Windows.Forms.CheckBox();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.chkSnd3 = new System.Windows.Forms.CheckBox();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.chkSnd4 = new System.Windows.Forms.CheckBox();
            this.flowLayoutPanel5 = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.chkSnd5 = new System.Windows.Forms.CheckBox();
            this.flowLayoutPanel6 = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.chkSnd6 = new System.Windows.Forms.CheckBox();
            this.flowLayoutPanel7 = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.chkSnd7 = new System.Windows.Forms.CheckBox();
            this.flowLayoutPanel8 = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.chkSnd8 = new System.Windows.Forms.CheckBox();
            this.panel17 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDelay1 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtButton1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtButton2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtButton3 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.txtButton4 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.txtButton5 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.panel11 = new System.Windows.Forms.Panel();
            this.txtButton6 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.panel13 = new System.Windows.Forms.Panel();
            this.label19 = new System.Windows.Forms.Label();
            this.txtButton7 = new System.Windows.Forms.TextBox();
            this.panel15 = new System.Windows.Forms.Panel();
            this.label17 = new System.Windows.Forms.Label();
            this.txtButton8 = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.eventTimer = new System.Windows.Forms.Timer(this.components);
            this.ntiIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.ctxIcon = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ctiShow = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ctiExit = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel16.SuspendLayout();
            this.panel14.SuspendLayout();
            this.panel12.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel24.SuspendLayout();
            this.panel23.SuspendLayout();
            this.panel22.SuspendLayout();
            this.panel21.SuspendLayout();
            this.panel20.SuspendLayout();
            this.panel19.SuspendLayout();
            this.panel18.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.flowLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.flowLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.flowLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.flowLayoutPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.flowLayoutPanel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.flowLayoutPanel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            this.panel17.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel13.SuspendLayout();
            this.panel15.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.ctxIcon.SuspendLayout();
            this.SuspendLayout();
            // 
            // tmrPoll
            // 
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
            this.txtDebug.Size = new System.Drawing.Size(291, 445);
            this.txtDebug.TabIndex = 34;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtDebug);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(423, 3);
            this.groupBox2.Name = "groupBox2";
            this.tableLayoutPanel1.SetRowSpan(this.groupBox2, 2);
            this.groupBox2.Size = new System.Drawing.Size(297, 464);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Log";
            // 
            // btnStatus8
            // 
            this.btnStatus8.BackColor = System.Drawing.Color.Maroon;
            this.btnStatus8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnStatus8.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnStatus8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStatus8.Font = new System.Drawing.Font("Lucida Console", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStatus8.ForeColor = System.Drawing.Color.White;
            this.btnStatus8.Location = new System.Drawing.Point(0, 0);
            this.btnStatus8.Name = "btnStatus8";
            this.btnStatus8.Size = new System.Drawing.Size(74, 43);
            this.btnStatus8.TabIndex = 30;
            this.btnStatus8.Text = "8";
            this.btnStatus8.UseVisualStyleBackColor = false;
            // 
            // btnStatus7
            // 
            this.btnStatus7.BackColor = System.Drawing.Color.Maroon;
            this.btnStatus7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnStatus7.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnStatus7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStatus7.Font = new System.Drawing.Font("Lucida Console", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStatus7.ForeColor = System.Drawing.Color.White;
            this.btnStatus7.Location = new System.Drawing.Point(0, 0);
            this.btnStatus7.Name = "btnStatus7";
            this.btnStatus7.Size = new System.Drawing.Size(74, 40);
            this.btnStatus7.TabIndex = 26;
            this.btnStatus7.Text = "7";
            this.btnStatus7.UseVisualStyleBackColor = false;
            // 
            // btnStatus6
            // 
            this.btnStatus6.BackColor = System.Drawing.Color.Maroon;
            this.btnStatus6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnStatus6.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnStatus6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStatus6.Font = new System.Drawing.Font("Lucida Console", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStatus6.ForeColor = System.Drawing.Color.White;
            this.btnStatus6.Location = new System.Drawing.Point(0, 0);
            this.btnStatus6.Name = "btnStatus6";
            this.btnStatus6.Size = new System.Drawing.Size(74, 40);
            this.btnStatus6.TabIndex = 22;
            this.btnStatus6.Text = "6";
            this.btnStatus6.UseVisualStyleBackColor = false;
            // 
            // btnStatus5
            // 
            this.btnStatus5.BackColor = System.Drawing.Color.Maroon;
            this.btnStatus5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnStatus5.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnStatus5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStatus5.Font = new System.Drawing.Font("Lucida Console", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStatus5.ForeColor = System.Drawing.Color.White;
            this.btnStatus5.Location = new System.Drawing.Point(0, 0);
            this.btnStatus5.Name = "btnStatus5";
            this.btnStatus5.Size = new System.Drawing.Size(74, 40);
            this.btnStatus5.TabIndex = 18;
            this.btnStatus5.Text = "5";
            this.btnStatus5.UseVisualStyleBackColor = false;
            // 
            // btnStatus4
            // 
            this.btnStatus4.BackColor = System.Drawing.Color.Maroon;
            this.btnStatus4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnStatus4.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnStatus4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStatus4.Font = new System.Drawing.Font("Lucida Console", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStatus4.ForeColor = System.Drawing.Color.White;
            this.btnStatus4.Location = new System.Drawing.Point(0, 0);
            this.btnStatus4.Name = "btnStatus4";
            this.btnStatus4.Size = new System.Drawing.Size(74, 40);
            this.btnStatus4.TabIndex = 14;
            this.btnStatus4.Text = "4";
            this.btnStatus4.UseVisualStyleBackColor = false;
            // 
            // btnStatus3
            // 
            this.btnStatus3.BackColor = System.Drawing.Color.Maroon;
            this.btnStatus3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnStatus3.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnStatus3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStatus3.Font = new System.Drawing.Font("Lucida Console", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStatus3.ForeColor = System.Drawing.Color.White;
            this.btnStatus3.Location = new System.Drawing.Point(0, 0);
            this.btnStatus3.Name = "btnStatus3";
            this.btnStatus3.Size = new System.Drawing.Size(74, 40);
            this.btnStatus3.TabIndex = 10;
            this.btnStatus3.Text = "3";
            this.btnStatus3.UseVisualStyleBackColor = false;
            // 
            // btnStatus2
            // 
            this.btnStatus2.BackColor = System.Drawing.Color.Maroon;
            this.btnStatus2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnStatus2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnStatus2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStatus2.Font = new System.Drawing.Font("Lucida Console", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStatus2.ForeColor = System.Drawing.Color.White;
            this.btnStatus2.Location = new System.Drawing.Point(0, 0);
            this.btnStatus2.Name = "btnStatus2";
            this.btnStatus2.Size = new System.Drawing.Size(74, 40);
            this.btnStatus2.TabIndex = 6;
            this.btnStatus2.Text = "2";
            this.btnStatus2.UseVisualStyleBackColor = false;
            // 
            // btnStatus1
            // 
            this.btnStatus1.BackColor = System.Drawing.Color.Maroon;
            this.btnStatus1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnStatus1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnStatus1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStatus1.Font = new System.Drawing.Font("Lucida Console", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStatus1.ForeColor = System.Drawing.Color.White;
            this.btnStatus1.Location = new System.Drawing.Point(0, 0);
            this.btnStatus1.Name = "btnStatus1";
            this.btnStatus1.Size = new System.Drawing.Size(74, 40);
            this.btnStatus1.TabIndex = 2;
            this.btnStatus1.Text = "1";
            this.btnStatus1.UseVisualStyleBackColor = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.tableLayoutPanel3);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(3, 3);
            this.groupBox4.Name = "groupBox4";
            this.tableLayoutPanel1.SetRowSpan(this.groupBox4, 2);
            this.groupBox4.Size = new System.Drawing.Size(414, 464);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Bindings";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.ChkBinds, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.label11, 0, 2);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(408, 445);
            this.tableLayoutPanel3.TabIndex = 48;
            // 
            // ChkBinds
            // 
            this.ChkBinds.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ChkBinds.Appearance = System.Windows.Forms.Appearance.Button;
            this.ChkBinds.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ChkBinds.Checked = true;
            this.ChkBinds.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ChkBinds.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ChkBinds.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ChkBinds.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ChkBinds.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChkBinds.Image = global::ArcadeControlPanel.Properties.Resources.check;
            this.ChkBinds.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ChkBinds.Location = new System.Drawing.Point(276, 3);
            this.ChkBinds.Margin = new System.Windows.Forms.Padding(6, 3, 3, 3);
            this.ChkBinds.Name = "ChkBinds";
            this.ChkBinds.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.ChkBinds.Size = new System.Drawing.Size(129, 29);
            this.ChkBinds.TabIndex = 1;
            this.ChkBinds.Text = "Binds Armed";
            this.ChkBinds.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ChkBinds.UseVisualStyleBackColor = false;
            this.ChkBinds.CheckedChanged += new System.EventHandler(this.ChkBinds_CheckedChanged);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tableLayoutPanel2.Controls.Add(this.panel16, 0, 7);
            this.tableLayoutPanel2.Controls.Add(this.panel14, 0, 6);
            this.tableLayoutPanel2.Controls.Add(this.panel12, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.panel10, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.panel8, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.panel6, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.panel4, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.panel24, 2, 7);
            this.tableLayoutPanel2.Controls.Add(this.panel23, 2, 6);
            this.tableLayoutPanel2.Controls.Add(this.panel22, 2, 5);
            this.tableLayoutPanel2.Controls.Add(this.panel21, 2, 4);
            this.tableLayoutPanel2.Controls.Add(this.panel20, 2, 3);
            this.tableLayoutPanel2.Controls.Add(this.panel19, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.panel18, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.flowLayoutPanel1, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.flowLayoutPanel2, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.flowLayoutPanel3, 3, 2);
            this.tableLayoutPanel2.Controls.Add(this.flowLayoutPanel4, 3, 3);
            this.tableLayoutPanel2.Controls.Add(this.flowLayoutPanel5, 3, 4);
            this.tableLayoutPanel2.Controls.Add(this.flowLayoutPanel6, 3, 5);
            this.tableLayoutPanel2.Controls.Add(this.flowLayoutPanel7, 3, 6);
            this.tableLayoutPanel2.Controls.Add(this.flowLayoutPanel8, 3, 7);
            this.tableLayoutPanel2.Controls.Add(this.panel17, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel3, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.panel5, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.panel7, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.panel9, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.panel11, 1, 5);
            this.tableLayoutPanel2.Controls.Add(this.panel13, 1, 6);
            this.tableLayoutPanel2.Controls.Add(this.panel15, 1, 7);
            this.tableLayoutPanel2.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 38);
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
            this.tableLayoutPanel2.Size = new System.Drawing.Size(402, 371);
            this.tableLayoutPanel2.TabIndex = 47;
            // 
            // panel16
            // 
            this.panel16.Controls.Add(this.btnStatus8);
            this.panel16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel16.Location = new System.Drawing.Point(3, 325);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(74, 43);
            this.panel16.TabIndex = 87;
            // 
            // panel14
            // 
            this.panel14.Controls.Add(this.btnStatus7);
            this.panel14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel14.Location = new System.Drawing.Point(3, 279);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(74, 40);
            this.panel14.TabIndex = 86;
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.btnStatus6);
            this.panel12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel12.Location = new System.Drawing.Point(3, 233);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(74, 40);
            this.panel12.TabIndex = 85;
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.btnStatus5);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel10.Location = new System.Drawing.Point(3, 187);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(74, 40);
            this.panel10.TabIndex = 84;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.btnStatus4);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(3, 141);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(74, 40);
            this.panel8.TabIndex = 83;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.btnStatus3);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(3, 95);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(74, 40);
            this.panel6.TabIndex = 82;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnStatus2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(3, 49);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(74, 40);
            this.panel4.TabIndex = 81;
            // 
            // panel24
            // 
            this.panel24.Controls.Add(this.label16);
            this.panel24.Controls.Add(this.txtDelay8);
            this.panel24.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel24.Location = new System.Drawing.Point(343, 325);
            this.panel24.Name = "panel24";
            this.panel24.Size = new System.Drawing.Size(34, 43);
            this.panel24.TabIndex = 79;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(0, 6);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(34, 13);
            this.label16.TabIndex = 46;
            this.label16.Text = "Delay";
            // 
            // txtDelay8
            // 
            this.txtDelay8.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtDelay8.Location = new System.Drawing.Point(0, 23);
            this.txtDelay8.Name = "txtDelay8";
            this.txtDelay8.Size = new System.Drawing.Size(34, 20);
            this.txtDelay8.TabIndex = 32;
            this.txtDelay8.Tag = "7";
            this.txtDelay8.Text = "0";
            // 
            // panel23
            // 
            this.panel23.Controls.Add(this.label18);
            this.panel23.Controls.Add(this.txtDelay7);
            this.panel23.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel23.Location = new System.Drawing.Point(343, 279);
            this.panel23.Name = "panel23";
            this.panel23.Size = new System.Drawing.Size(34, 40);
            this.panel23.TabIndex = 78;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(0, 6);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(34, 13);
            this.label18.TabIndex = 44;
            this.label18.Text = "Delay";
            // 
            // txtDelay7
            // 
            this.txtDelay7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtDelay7.Location = new System.Drawing.Point(0, 20);
            this.txtDelay7.Name = "txtDelay7";
            this.txtDelay7.Size = new System.Drawing.Size(34, 20);
            this.txtDelay7.TabIndex = 28;
            this.txtDelay7.Tag = "6";
            this.txtDelay7.Text = "50";
            // 
            // panel22
            // 
            this.panel22.Controls.Add(this.label12);
            this.panel22.Controls.Add(this.txtDelay6);
            this.panel22.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel22.Location = new System.Drawing.Point(343, 233);
            this.panel22.Name = "panel22";
            this.panel22.Size = new System.Drawing.Size(34, 40);
            this.panel22.TabIndex = 77;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(0, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(34, 13);
            this.label12.TabIndex = 42;
            this.label12.Text = "Delay";
            // 
            // txtDelay6
            // 
            this.txtDelay6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtDelay6.Location = new System.Drawing.Point(0, 20);
            this.txtDelay6.Name = "txtDelay6";
            this.txtDelay6.Size = new System.Drawing.Size(34, 20);
            this.txtDelay6.TabIndex = 24;
            this.txtDelay6.Tag = "5";
            this.txtDelay6.Text = "50";
            // 
            // panel21
            // 
            this.panel21.Controls.Add(this.label14);
            this.panel21.Controls.Add(this.txtDelay5);
            this.panel21.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel21.Location = new System.Drawing.Point(343, 187);
            this.panel21.Name = "panel21";
            this.panel21.Size = new System.Drawing.Size(34, 40);
            this.panel21.TabIndex = 76;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(0, 6);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(34, 13);
            this.label14.TabIndex = 40;
            this.label14.Text = "Delay";
            // 
            // txtDelay5
            // 
            this.txtDelay5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtDelay5.Location = new System.Drawing.Point(0, 20);
            this.txtDelay5.Name = "txtDelay5";
            this.txtDelay5.Size = new System.Drawing.Size(34, 20);
            this.txtDelay5.TabIndex = 20;
            this.txtDelay5.Tag = "4";
            this.txtDelay5.Text = "0";
            // 
            // panel20
            // 
            this.panel20.Controls.Add(this.label4);
            this.panel20.Controls.Add(this.txtDelay4);
            this.panel20.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel20.Location = new System.Drawing.Point(343, 141);
            this.panel20.Name = "panel20";
            this.panel20.Size = new System.Drawing.Size(34, 40);
            this.panel20.TabIndex = 75;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(0, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 38;
            this.label4.Text = "Delay";
            // 
            // txtDelay4
            // 
            this.txtDelay4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtDelay4.Location = new System.Drawing.Point(0, 20);
            this.txtDelay4.Name = "txtDelay4";
            this.txtDelay4.Size = new System.Drawing.Size(34, 20);
            this.txtDelay4.TabIndex = 16;
            this.txtDelay4.Tag = "3";
            this.txtDelay4.Text = "0";
            // 
            // panel19
            // 
            this.panel19.Controls.Add(this.label7);
            this.panel19.Controls.Add(this.txtDelay3);
            this.panel19.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel19.Location = new System.Drawing.Point(343, 95);
            this.panel19.Name = "panel19";
            this.panel19.Size = new System.Drawing.Size(34, 40);
            this.panel19.TabIndex = 74;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(0, 6);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 36;
            this.label7.Text = "Delay";
            // 
            // txtDelay3
            // 
            this.txtDelay3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtDelay3.Location = new System.Drawing.Point(0, 20);
            this.txtDelay3.Name = "txtDelay3";
            this.txtDelay3.Size = new System.Drawing.Size(34, 20);
            this.txtDelay3.TabIndex = 12;
            this.txtDelay3.Tag = "2";
            this.txtDelay3.Text = "0";
            // 
            // panel18
            // 
            this.panel18.Controls.Add(this.label2);
            this.panel18.Controls.Add(this.txtDelay2);
            this.panel18.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel18.Location = new System.Drawing.Point(343, 49);
            this.panel18.Name = "panel18";
            this.panel18.Size = new System.Drawing.Size(34, 40);
            this.panel18.TabIndex = 73;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 34;
            this.label2.Text = "Delay";
            // 
            // txtDelay2
            // 
            this.txtDelay2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtDelay2.Location = new System.Drawing.Point(0, 20);
            this.txtDelay2.Name = "txtDelay2";
            this.txtDelay2.Size = new System.Drawing.Size(34, 20);
            this.txtDelay2.TabIndex = 8;
            this.txtDelay2.Tag = "1";
            this.txtDelay2.Text = "0";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.pictureBox1);
            this.flowLayoutPanel1.Controls.Add(this.chkSnd1);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(383, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(16, 40);
            this.flowLayoutPanel1.TabIndex = 64;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(2, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(20, 19);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // chkSnd1
            // 
            this.chkSnd1.AutoSize = true;
            this.chkSnd1.Location = new System.Drawing.Point(3, 25);
            this.chkSnd1.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.chkSnd1.Name = "chkSnd1";
            this.chkSnd1.Size = new System.Drawing.Size(15, 14);
            this.chkSnd1.TabIndex = 5;
            this.chkSnd1.Tag = "0";
            this.chkSnd1.UseVisualStyleBackColor = true;
            this.chkSnd1.CheckedChanged += new System.EventHandler(this.Event_SetSoundEffect);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.pictureBox2);
            this.flowLayoutPanel2.Controls.Add(this.chkSnd2);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(383, 49);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(16, 40);
            this.flowLayoutPanel2.TabIndex = 65;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.InitialImage")));
            this.pictureBox2.Location = new System.Drawing.Point(2, 0);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(20, 19);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // chkSnd2
            // 
            this.chkSnd2.AutoSize = true;
            this.chkSnd2.Location = new System.Drawing.Point(3, 25);
            this.chkSnd2.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.chkSnd2.Name = "chkSnd2";
            this.chkSnd2.Size = new System.Drawing.Size(15, 14);
            this.chkSnd2.TabIndex = 9;
            this.chkSnd2.Tag = "1";
            this.chkSnd2.UseVisualStyleBackColor = true;
            this.chkSnd2.CheckedChanged += new System.EventHandler(this.Event_SetSoundEffect);
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.pictureBox3);
            this.flowLayoutPanel3.Controls.Add(this.chkSnd3);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(383, 95);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(16, 40);
            this.flowLayoutPanel3.TabIndex = 66;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.InitialImage")));
            this.pictureBox3.Location = new System.Drawing.Point(2, 0);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(20, 19);
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // chkSnd3
            // 
            this.chkSnd3.AutoSize = true;
            this.chkSnd3.Location = new System.Drawing.Point(3, 25);
            this.chkSnd3.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.chkSnd3.Name = "chkSnd3";
            this.chkSnd3.Size = new System.Drawing.Size(15, 14);
            this.chkSnd3.TabIndex = 13;
            this.chkSnd3.Tag = "2";
            this.chkSnd3.UseVisualStyleBackColor = true;
            this.chkSnd3.CheckedChanged += new System.EventHandler(this.Event_SetSoundEffect);
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.Controls.Add(this.pictureBox4);
            this.flowLayoutPanel4.Controls.Add(this.chkSnd4);
            this.flowLayoutPanel4.Location = new System.Drawing.Point(383, 141);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(16, 40);
            this.flowLayoutPanel4.TabIndex = 67;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox4.InitialImage")));
            this.pictureBox4.Location = new System.Drawing.Point(2, 0);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(20, 19);
            this.pictureBox4.TabIndex = 0;
            this.pictureBox4.TabStop = false;
            // 
            // chkSnd4
            // 
            this.chkSnd4.AutoSize = true;
            this.chkSnd4.Location = new System.Drawing.Point(3, 25);
            this.chkSnd4.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.chkSnd4.Name = "chkSnd4";
            this.chkSnd4.Size = new System.Drawing.Size(15, 14);
            this.chkSnd4.TabIndex = 17;
            this.chkSnd4.Tag = "3";
            this.chkSnd4.UseVisualStyleBackColor = true;
            this.chkSnd4.CheckedChanged += new System.EventHandler(this.Event_SetSoundEffect);
            // 
            // flowLayoutPanel5
            // 
            this.flowLayoutPanel5.Controls.Add(this.pictureBox5);
            this.flowLayoutPanel5.Controls.Add(this.chkSnd5);
            this.flowLayoutPanel5.Location = new System.Drawing.Point(383, 187);
            this.flowLayoutPanel5.Name = "flowLayoutPanel5";
            this.flowLayoutPanel5.Size = new System.Drawing.Size(16, 40);
            this.flowLayoutPanel5.TabIndex = 68;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox5.InitialImage")));
            this.pictureBox5.Location = new System.Drawing.Point(2, 0);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(20, 19);
            this.pictureBox5.TabIndex = 0;
            this.pictureBox5.TabStop = false;
            // 
            // chkSnd5
            // 
            this.chkSnd5.AutoSize = true;
            this.chkSnd5.Location = new System.Drawing.Point(3, 25);
            this.chkSnd5.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.chkSnd5.Name = "chkSnd5";
            this.chkSnd5.Size = new System.Drawing.Size(15, 14);
            this.chkSnd5.TabIndex = 21;
            this.chkSnd5.Tag = "4";
            this.chkSnd5.UseVisualStyleBackColor = true;
            this.chkSnd5.CheckedChanged += new System.EventHandler(this.Event_SetSoundEffect);
            // 
            // flowLayoutPanel6
            // 
            this.flowLayoutPanel6.Controls.Add(this.pictureBox6);
            this.flowLayoutPanel6.Controls.Add(this.chkSnd6);
            this.flowLayoutPanel6.Location = new System.Drawing.Point(383, 233);
            this.flowLayoutPanel6.Name = "flowLayoutPanel6";
            this.flowLayoutPanel6.Size = new System.Drawing.Size(16, 40);
            this.flowLayoutPanel6.TabIndex = 69;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox6.InitialImage")));
            this.pictureBox6.Location = new System.Drawing.Point(2, 0);
            this.pictureBox6.Margin = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(20, 19);
            this.pictureBox6.TabIndex = 0;
            this.pictureBox6.TabStop = false;
            // 
            // chkSnd6
            // 
            this.chkSnd6.AutoSize = true;
            this.chkSnd6.Location = new System.Drawing.Point(3, 25);
            this.chkSnd6.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.chkSnd6.Name = "chkSnd6";
            this.chkSnd6.Size = new System.Drawing.Size(15, 14);
            this.chkSnd6.TabIndex = 25;
            this.chkSnd6.Tag = "5";
            this.chkSnd6.UseVisualStyleBackColor = true;
            this.chkSnd6.CheckedChanged += new System.EventHandler(this.Event_SetSoundEffect);
            // 
            // flowLayoutPanel7
            // 
            this.flowLayoutPanel7.Controls.Add(this.pictureBox7);
            this.flowLayoutPanel7.Controls.Add(this.chkSnd7);
            this.flowLayoutPanel7.Location = new System.Drawing.Point(383, 279);
            this.flowLayoutPanel7.Name = "flowLayoutPanel7";
            this.flowLayoutPanel7.Size = new System.Drawing.Size(16, 40);
            this.flowLayoutPanel7.TabIndex = 70;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox7.InitialImage")));
            this.pictureBox7.Location = new System.Drawing.Point(2, 0);
            this.pictureBox7.Margin = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(20, 19);
            this.pictureBox7.TabIndex = 0;
            this.pictureBox7.TabStop = false;
            // 
            // chkSnd7
            // 
            this.chkSnd7.AutoSize = true;
            this.chkSnd7.Location = new System.Drawing.Point(3, 25);
            this.chkSnd7.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.chkSnd7.Name = "chkSnd7";
            this.chkSnd7.Size = new System.Drawing.Size(15, 14);
            this.chkSnd7.TabIndex = 29;
            this.chkSnd7.Tag = "6";
            this.chkSnd7.UseVisualStyleBackColor = true;
            this.chkSnd7.CheckedChanged += new System.EventHandler(this.Event_SetSoundEffect);
            // 
            // flowLayoutPanel8
            // 
            this.flowLayoutPanel8.Controls.Add(this.pictureBox8);
            this.flowLayoutPanel8.Controls.Add(this.chkSnd8);
            this.flowLayoutPanel8.Location = new System.Drawing.Point(383, 325);
            this.flowLayoutPanel8.Name = "flowLayoutPanel8";
            this.flowLayoutPanel8.Size = new System.Drawing.Size(16, 42);
            this.flowLayoutPanel8.TabIndex = 71;
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
            this.pictureBox8.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox8.InitialImage")));
            this.pictureBox8.Location = new System.Drawing.Point(2, 0);
            this.pictureBox8.Margin = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(20, 19);
            this.pictureBox8.TabIndex = 0;
            this.pictureBox8.TabStop = false;
            // 
            // chkSnd8
            // 
            this.chkSnd8.AutoSize = true;
            this.chkSnd8.Location = new System.Drawing.Point(3, 25);
            this.chkSnd8.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.chkSnd8.Name = "chkSnd8";
            this.chkSnd8.Size = new System.Drawing.Size(15, 14);
            this.chkSnd8.TabIndex = 33;
            this.chkSnd8.Tag = "7";
            this.chkSnd8.UseVisualStyleBackColor = true;
            this.chkSnd8.CheckedChanged += new System.EventHandler(this.Event_SetSoundEffect);
            // 
            // panel17
            // 
            this.panel17.Controls.Add(this.label5);
            this.panel17.Controls.Add(this.txtDelay1);
            this.panel17.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel17.Location = new System.Drawing.Point(343, 3);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(34, 40);
            this.panel17.TabIndex = 72;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(0, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Delay";
            // 
            // txtDelay1
            // 
            this.txtDelay1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtDelay1.Location = new System.Drawing.Point(0, 20);
            this.txtDelay1.Name = "txtDelay1";
            this.txtDelay1.Size = new System.Drawing.Size(34, 20);
            this.txtDelay1.TabIndex = 4;
            this.txtDelay1.Tag = "0";
            this.txtDelay1.Text = "0";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtButton1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(83, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(254, 40);
            this.panel1.TabIndex = 48;
            // 
            // txtButton1
            // 
            this.txtButton1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtButton1.Location = new System.Drawing.Point(0, 20);
            this.txtButton1.Name = "txtButton1";
            this.txtButton1.Size = new System.Drawing.Size(254, 20);
            this.txtButton1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Key Macro:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtButton2);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(83, 49);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(254, 40);
            this.panel3.TabIndex = 50;
            // 
            // txtButton2
            // 
            this.txtButton2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtButton2.Location = new System.Drawing.Point(0, 20);
            this.txtButton2.Name = "txtButton2";
            this.txtButton2.Size = new System.Drawing.Size(254, 20);
            this.txtButton2.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(-3, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 33;
            this.label3.Text = "Key Macro:";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.txtButton3);
            this.panel5.Controls.Add(this.label8);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(83, 95);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(254, 40);
            this.panel5.TabIndex = 52;
            // 
            // txtButton3
            // 
            this.txtButton3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtButton3.Location = new System.Drawing.Point(0, 20);
            this.txtButton3.Name = "txtButton3";
            this.txtButton3.Size = new System.Drawing.Size(254, 20);
            this.txtButton3.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(-3, 6);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 13);
            this.label8.TabIndex = 35;
            this.label8.Text = "Key Macro:";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.txtButton4);
            this.panel7.Controls.Add(this.label6);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(83, 141);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(254, 40);
            this.panel7.TabIndex = 54;
            // 
            // txtButton4
            // 
            this.txtButton4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtButton4.Location = new System.Drawing.Point(0, 20);
            this.txtButton4.Name = "txtButton4";
            this.txtButton4.Size = new System.Drawing.Size(254, 20);
            this.txtButton4.TabIndex = 155;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(-3, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 37;
            this.label6.Text = "Key Macro:";
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.txtButton5);
            this.panel9.Controls.Add(this.label15);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel9.Location = new System.Drawing.Point(83, 187);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(254, 40);
            this.panel9.TabIndex = 56;
            // 
            // txtButton5
            // 
            this.txtButton5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtButton5.Location = new System.Drawing.Point(0, 20);
            this.txtButton5.Name = "txtButton5";
            this.txtButton5.Size = new System.Drawing.Size(254, 20);
            this.txtButton5.TabIndex = 19;
            this.txtButton5.Text = "{5}";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(-3, 6);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(61, 13);
            this.label15.TabIndex = 39;
            this.label15.Text = "Key Macro:";
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.txtButton6);
            this.panel11.Controls.Add(this.label13);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel11.Location = new System.Drawing.Point(83, 233);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(254, 40);
            this.panel11.TabIndex = 58;
            // 
            // txtButton6
            // 
            this.txtButton6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtButton6.Location = new System.Drawing.Point(0, 20);
            this.txtButton6.Name = "txtButton6";
            this.txtButton6.Size = new System.Drawing.Size(254, 20);
            this.txtButton6.TabIndex = 23;
            this.txtButton6.Text = "%{F4}";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(-3, 6);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(61, 13);
            this.label13.TabIndex = 41;
            this.label13.Text = "Key Macro:";
            // 
            // panel13
            // 
            this.panel13.Controls.Add(this.label19);
            this.panel13.Controls.Add(this.txtButton7);
            this.panel13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel13.Location = new System.Drawing.Point(83, 279);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(254, 40);
            this.panel13.TabIndex = 60;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(-3, 6);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(61, 13);
            this.label19.TabIndex = 43;
            this.label19.Text = "Key Macro:";
            // 
            // txtButton7
            // 
            this.txtButton7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtButton7.Location = new System.Drawing.Point(0, 20);
            this.txtButton7.Name = "txtButton7";
            this.txtButton7.Size = new System.Drawing.Size(254, 20);
            this.txtButton7.TabIndex = 27;
            this.txtButton7.Text = "{Escape}";
            // 
            // panel15
            // 
            this.panel15.Controls.Add(this.label17);
            this.panel15.Controls.Add(this.txtButton8);
            this.panel15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel15.Location = new System.Drawing.Point(83, 325);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(254, 43);
            this.panel15.TabIndex = 62;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(-3, 6);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(61, 13);
            this.label17.TabIndex = 45;
            this.label17.Text = "Key Macro:";
            // 
            // txtButton8
            // 
            this.txtButton8.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtButton8.Location = new System.Drawing.Point(0, 23);
            this.txtButton8.Name = "txtButton8";
            this.txtButton8.Size = new System.Drawing.Size(254, 20);
            this.txtButton8.TabIndex = 31;
            this.txtButton8.Text = "^%+{U}";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnStatus1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(74, 40);
            this.panel2.TabIndex = 80;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Dock = System.Windows.Forms.DockStyle.Right;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(235, 412);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(170, 33);
            this.label11.TabIndex = 17;
            this.label11.Text = "Multiply \"Delay\" by 10 milliseconds\r\n(10 = 100 milliseconds)";
            this.label11.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox4, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(723, 470);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // eventTimer
            // 
            this.eventTimer.Interval = 10;
            this.eventTimer.Tick += new System.EventHandler(this.EventTimer_Tick);
            // 
            // ntiIcon
            // 
            this.ntiIcon.ContextMenuStrip = this.ctxIcon;
            this.ntiIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("ntiIcon.Icon")));
            this.ntiIcon.Text = "Arcade Control Panel";
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
            // frmCpl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 470);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(739, 509);
            this.Name = "frmCpl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Arcade Control Panel";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmCpl_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmCpl_FormClosed);
            this.SizeChanged += new System.EventHandler(this.FrmCpl_SizeChanged);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel16.ResumeLayout(false);
            this.panel14.ResumeLayout(false);
            this.panel12.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel24.ResumeLayout(false);
            this.panel24.PerformLayout();
            this.panel23.ResumeLayout(false);
            this.panel23.PerformLayout();
            this.panel22.ResumeLayout(false);
            this.panel22.PerformLayout();
            this.panel21.ResumeLayout(false);
            this.panel21.PerformLayout();
            this.panel20.ResumeLayout(false);
            this.panel20.PerformLayout();
            this.panel19.ResumeLayout(false);
            this.panel19.PerformLayout();
            this.panel18.ResumeLayout(false);
            this.panel18.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.flowLayoutPanel4.ResumeLayout(false);
            this.flowLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.flowLayoutPanel5.ResumeLayout(false);
            this.flowLayoutPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.flowLayoutPanel6.ResumeLayout(false);
            this.flowLayoutPanel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.flowLayoutPanel7.ResumeLayout(false);
            this.flowLayoutPanel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.flowLayoutPanel8.ResumeLayout(false);
            this.flowLayoutPanel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            this.panel17.ResumeLayout(false);
            this.panel17.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.panel13.ResumeLayout(false);
            this.panel13.PerformLayout();
            this.panel15.ResumeLayout(false);
            this.panel15.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ctxIcon.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer tmrPoll;
        private System.Windows.Forms.TextBox txtDebug;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnStatus4;
        private System.Windows.Forms.Button btnStatus3;
        private System.Windows.Forms.Button btnStatus2;
        private System.Windows.Forms.Button btnStatus1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtButton4;
        private System.Windows.Forms.TextBox txtButton3;
        private System.Windows.Forms.TextBox txtButton2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtButton1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
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
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox chkSnd1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel8;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.CheckBox chkSnd8;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel7;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.CheckBox chkSnd7;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel6;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.CheckBox chkSnd6;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel5;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.CheckBox chkSnd5;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.CheckBox chkSnd4;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.CheckBox chkSnd3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.CheckBox chkSnd2;
        private System.Windows.Forms.Panel panel16;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel24;
        private System.Windows.Forms.TextBox txtDelay8;
        private System.Windows.Forms.Panel panel23;
        private System.Windows.Forms.TextBox txtDelay7;
        private System.Windows.Forms.Panel panel22;
        private System.Windows.Forms.TextBox txtDelay6;
        private System.Windows.Forms.Panel panel21;
        private System.Windows.Forms.TextBox txtDelay5;
        private System.Windows.Forms.Panel panel20;
        private System.Windows.Forms.TextBox txtDelay4;
        private System.Windows.Forms.Panel panel19;
        private System.Windows.Forms.TextBox txtDelay3;
        private System.Windows.Forms.Panel panel18;
        private System.Windows.Forms.TextBox txtDelay2;
        private System.Windows.Forms.Panel panel17;
        private System.Windows.Forms.TextBox txtDelay1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckBox ChkBinds;
    }
}

