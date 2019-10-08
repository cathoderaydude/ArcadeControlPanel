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
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnStatus4 = new System.Windows.Forms.Button();
            this.btnStatus3 = new System.Windows.Forms.Button();
            this.btnStatus2 = new System.Windows.Forms.Button();
            this.btnStatus1 = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 29);
            this.button1.TabIndex = 0;
            this.button1.Text = "Send \"5\" (coin in)";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 32;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(236, 95);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Send test buttons (with 5 second delay)";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(121, 59);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(109, 29);
            this.button4.TabIndex = 3;
            this.button4.Text = "Send \"5\" (coin in)";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(6, 59);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(109, 29);
            this.button3.TabIndex = 2;
            this.button3.Text = "Send \"5\" (coin in)";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(121, 24);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(109, 29);
            this.button2.TabIndex = 1;
            this.button2.Text = "Send \"5\" (coin in)";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(3, 16);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(167, 281);
            this.textBox1.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Location = new System.Drawing.Point(442, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(173, 300);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Debug output";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnStatus4);
            this.groupBox3.Controls.Add(this.btnStatus3);
            this.groupBox3.Controls.Add(this.btnStatus2);
            this.groupBox3.Controls.Add(this.btnStatus1);
            this.groupBox3.Location = new System.Drawing.Point(12, 113);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(236, 199);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Button status";
            // 
            // btnStatus4
            // 
            this.btnStatus4.BackColor = System.Drawing.Color.Maroon;
            this.btnStatus4.Enabled = false;
            this.btnStatus4.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnStatus4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStatus4.Font = new System.Drawing.Font("Lucida Console", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStatus4.ForeColor = System.Drawing.Color.White;
            this.btnStatus4.Location = new System.Drawing.Point(121, 107);
            this.btnStatus4.Name = "btnStatus4";
            this.btnStatus4.Size = new System.Drawing.Size(109, 83);
            this.btnStatus4.TabIndex = 3;
            this.btnStatus4.Text = "4";
            this.btnStatus4.UseVisualStyleBackColor = false;
            // 
            // btnStatus3
            // 
            this.btnStatus3.BackColor = System.Drawing.Color.Maroon;
            this.btnStatus3.Enabled = false;
            this.btnStatus3.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnStatus3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStatus3.Font = new System.Drawing.Font("Lucida Console", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStatus3.ForeColor = System.Drawing.Color.White;
            this.btnStatus3.Location = new System.Drawing.Point(6, 107);
            this.btnStatus3.Name = "btnStatus3";
            this.btnStatus3.Size = new System.Drawing.Size(109, 83);
            this.btnStatus3.TabIndex = 2;
            this.btnStatus3.Text = "3";
            this.btnStatus3.UseVisualStyleBackColor = false;
            // 
            // btnStatus2
            // 
            this.btnStatus2.BackColor = System.Drawing.Color.Maroon;
            this.btnStatus2.Enabled = false;
            this.btnStatus2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnStatus2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStatus2.Font = new System.Drawing.Font("Lucida Console", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStatus2.ForeColor = System.Drawing.Color.White;
            this.btnStatus2.Location = new System.Drawing.Point(121, 19);
            this.btnStatus2.Name = "btnStatus2";
            this.btnStatus2.Size = new System.Drawing.Size(109, 83);
            this.btnStatus2.TabIndex = 1;
            this.btnStatus2.Text = "2";
            this.btnStatus2.UseVisualStyleBackColor = false;
            // 
            // btnStatus1
            // 
            this.btnStatus1.BackColor = System.Drawing.Color.Maroon;
            this.btnStatus1.Enabled = false;
            this.btnStatus1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnStatus1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStatus1.Font = new System.Drawing.Font("Lucida Console", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStatus1.ForeColor = System.Drawing.Color.White;
            this.btnStatus1.Location = new System.Drawing.Point(6, 19);
            this.btnStatus1.Name = "btnStatus1";
            this.btnStatus1.Size = new System.Drawing.Size(109, 83);
            this.btnStatus1.TabIndex = 0;
            this.btnStatus1.Text = "1";
            this.btnStatus1.UseVisualStyleBackColor = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.textBox9);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.textBox8);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.textBox7);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.textBox6);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.textBox5);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.textBox4);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.textBox3);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.textBox2);
            this.groupBox4.Controls.Add(this.checkBox1);
            this.groupBox4.Location = new System.Drawing.Point(254, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(182, 297);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Bindings (NOT SAVED)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(109, 220);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Delay";
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(112, 236);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(64, 20);
            this.textBox9.TabIndex = 15;
            this.textBox9.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(109, 167);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Delay";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(112, 183);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(64, 20);
            this.textBox8.TabIndex = 13;
            this.textBox8.Text = "500";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(109, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Delay";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(112, 120);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(64, 20);
            this.textBox7.TabIndex = 11;
            this.textBox7.Text = "500";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(109, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Delay";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(112, 68);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(64, 20);
            this.textBox6.TabIndex = 9;
            this.textBox6.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Button 4";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(6, 236);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 7;
            this.textBox5.Text = "^%+{U}";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Button 3";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(6, 183);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 5;
            this.textBox4.Text = "{Escape}";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Button 2";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(6, 120);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 3;
            this.textBox3.Text = "{Alt-F4}";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Button 1";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(6, 68);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 1;
            this.textBox2.Text = "{5}";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(6, 18);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(88, 17);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Enable Binds";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // frmCpl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 313);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCpl";
            this.Text = "Auxiliary Key Interface";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnStatus4;
        private System.Windows.Forms.Button btnStatus3;
        private System.Windows.Forms.Button btnStatus2;
        private System.Windows.Forms.Button btnStatus1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

