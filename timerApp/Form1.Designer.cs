namespace timerApp
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
            this.components = new System.ComponentModel.Container();
            this.btnCustom = new System.Windows.Forms.Button();
            this.tbCustomMins = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.btn10 = new System.Windows.Forms.Button();
            this.btn15 = new System.Windows.Forms.Button();
            this.btn20 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbCurrentTime = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbCustomSecs = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lbTargetTime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lbTimer = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.labStatus = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnStop = new System.Windows.Forms.Button();
            this.tbCustomMessage = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCustom
            // 
            this.btnCustom.Location = new System.Drawing.Point(325, 140);
            this.btnCustom.Name = "btnCustom";
            this.btnCustom.Size = new System.Drawing.Size(100, 25);
            this.btnCustom.TabIndex = 0;
            this.btnCustom.Text = "Custom";
            this.btnCustom.UseVisualStyleBackColor = true;
            this.btnCustom.Click += new System.EventHandler(this.btnCustom_Click);
            // 
            // tbCustomMins
            // 
            this.tbCustomMins.Location = new System.Drawing.Point(6, 19);
            this.tbCustomMins.Name = "tbCustomMins";
            this.tbCustomMins.Size = new System.Drawing.Size(90, 20);
            this.tbCustomMins.TabIndex = 1;
            this.tbCustomMins.TextChanged += new System.EventHandler(this.tbCustomMins_TextChanged);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(14, 76);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(100, 25);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "5 Minutes";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btn10
            // 
            this.btn10.Location = new System.Drawing.Point(14, 107);
            this.btn10.Name = "btn10";
            this.btn10.Size = new System.Drawing.Size(100, 25);
            this.btn10.TabIndex = 3;
            this.btn10.Text = "10 Minutes";
            this.btn10.UseVisualStyleBackColor = true;
            this.btn10.Click += new System.EventHandler(this.btn10_Click);
            // 
            // btn15
            // 
            this.btn15.Location = new System.Drawing.Point(13, 138);
            this.btn15.Name = "btn15";
            this.btn15.Size = new System.Drawing.Size(100, 25);
            this.btn15.TabIndex = 4;
            this.btn15.Text = "15 minutes";
            this.btn15.UseVisualStyleBackColor = true;
            this.btn15.Click += new System.EventHandler(this.btn15_Click);
            // 
            // btn20
            // 
            this.btn20.Location = new System.Drawing.Point(13, 170);
            this.btn20.Name = "btn20";
            this.btn20.Size = new System.Drawing.Size(100, 25);
            this.btn20.TabIndex = 5;
            this.btn20.Text = "20 Minutes";
            this.btn20.UseVisualStyleBackColor = true;
            this.btn20.Click += new System.EventHandler(this.btn20_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbCurrentTime);
            this.groupBox1.Location = new System.Drawing.Point(13, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(120, 53);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Current Time";
            // 
            // lbCurrentTime
            // 
            this.lbCurrentTime.AutoSize = true;
            this.lbCurrentTime.Location = new System.Drawing.Point(19, 22);
            this.lbCurrentTime.Name = "lbCurrentTime";
            this.lbCurrentTime.Size = new System.Drawing.Size(72, 13);
            this.lbCurrentTime.TabIndex = 0;
            this.lbCurrentTime.Text = "lbCurrentTime";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.tbCustomMins);
            this.groupBox2.Controls.Add(this.tbCustomSecs);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(119, 140);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 63);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Custom Time";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(125, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Seconds";
            // 
            // tbCustomSecs
            // 
            this.tbCustomSecs.Location = new System.Drawing.Point(105, 19);
            this.tbCustomSecs.Name = "tbCustomSecs";
            this.tbCustomSecs.Size = new System.Drawing.Size(90, 20);
            this.tbCustomSecs.TabIndex = 5;
            this.tbCustomSecs.TextChanged += new System.EventHandler(this.tbCustomSecs_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Minutes";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lbTargetTime);
            this.groupBox3.Location = new System.Drawing.Point(162, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(120, 53);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Target Time";
            // 
            // lbTargetTime
            // 
            this.lbTargetTime.AutoSize = true;
            this.lbTargetTime.Location = new System.Drawing.Point(27, 22);
            this.lbTargetTime.Name = "lbTargetTime";
            this.lbTargetTime.Size = new System.Drawing.Size(69, 13);
            this.lbTargetTime.TabIndex = 1;
            this.lbTargetTime.Text = "lbTargetTime";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.lbTimer);
            this.groupBox4.Location = new System.Drawing.Point(313, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(120, 53);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Count Down Timer";
            // 
            // lbTimer
            // 
            this.lbTimer.AutoSize = true;
            this.lbTimer.Location = new System.Drawing.Point(36, 22);
            this.lbTimer.Name = "lbTimer";
            this.lbTimer.Size = new System.Drawing.Size(41, 13);
            this.lbTimer.TabIndex = 0;
            this.lbTimer.Text = "lbTimer";
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // labStatus
            // 
            this.labStatus.AutoSize = true;
            this.labStatus.Location = new System.Drawing.Point(49, 9);
            this.labStatus.Name = "labStatus";
            this.labStatus.Size = new System.Drawing.Size(51, 13);
            this.labStatus.TabIndex = 10;
            this.labStatus.Text = "labStatus";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.labStatus);
            this.groupBox5.Location = new System.Drawing.Point(142, 209);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(154, 25);
            this.groupBox5.TabIndex = 11;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Status";
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(325, 176);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(100, 25);
            this.btnStop.TabIndex = 12;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // tbCustomMessage
            // 
            this.tbCustomMessage.Location = new System.Drawing.Point(6, 19);
            this.tbCustomMessage.Multiline = true;
            this.tbCustomMessage.Name = "tbCustomMessage";
            this.tbCustomMessage.Size = new System.Drawing.Size(300, 36);
            this.tbCustomMessage.TabIndex = 13;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.tbCustomMessage);
            this.groupBox6.Location = new System.Drawing.Point(119, 71);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(312, 63);
            this.groupBox6.TabIndex = 14;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Custom Message";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(325, 212);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 25);
            this.btnExit.TabIndex = 15;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 246);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn20);
            this.Controls.Add(this.btn15);
            this.Controls.Add(this.btn10);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnCustom);
            this.Name = "Form1";
            this.Text = "Timer Control";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCustom;
        private System.Windows.Forms.TextBox tbCustomMins;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btn10;
        private System.Windows.Forms.Button btn15;
        private System.Windows.Forms.Button btn20;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lbCurrentTime;
        private System.Windows.Forms.Label lbTargetTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbCustomSecs;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lbTimer;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label labStatus;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.TextBox tbCustomMessage;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btnExit;
    }
}

