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
            this.btn5 = new System.Windows.Forms.Button();
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
            this.btnStop = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.fbdChooseStorage = new System.Windows.Forms.FolderBrowserDialog();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.tbCustomHrs = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbClear = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.tbStorageFolder = new System.Windows.Forms.TextBox();
            this.tbCustomMessage = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCustom
            // 
            this.btnCustom.Location = new System.Drawing.Point(329, 180);
            this.btnCustom.Name = "btnCustom";
            this.btnCustom.Size = new System.Drawing.Size(100, 25);
            this.btnCustom.TabIndex = 0;
            this.btnCustom.Text = "Custom";
            this.btnCustom.UseVisualStyleBackColor = true;
            this.btnCustom.Click += new System.EventHandler(this.btnCustom_Click);
            // 
            // tbCustomMins
            // 
            this.tbCustomMins.Location = new System.Drawing.Point(37, 19);
            this.tbCustomMins.Name = "tbCustomMins";
            this.tbCustomMins.Size = new System.Drawing.Size(25, 20);
            this.tbCustomMins.TabIndex = 1;
            this.tbCustomMins.TextChanged += new System.EventHandler(this.tbCustomMins_TextChanged);
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(12, 180);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(100, 25);
            this.btn5.TabIndex = 2;
            this.btn5.Text = "5 Minutes";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btn10
            // 
            this.btn10.Location = new System.Drawing.Point(118, 180);
            this.btn10.Name = "btn10";
            this.btn10.Size = new System.Drawing.Size(100, 25);
            this.btn10.TabIndex = 3;
            this.btn10.Text = "10 Minutes";
            this.btn10.UseVisualStyleBackColor = true;
            this.btn10.Click += new System.EventHandler(this.btn10_Click);
            // 
            // btn15
            // 
            this.btn15.Location = new System.Drawing.Point(224, 180);
            this.btn15.Name = "btn15";
            this.btn15.Size = new System.Drawing.Size(100, 25);
            this.btn15.TabIndex = 4;
            this.btn15.Text = "15 minutes";
            this.btn15.UseVisualStyleBackColor = true;
            this.btn15.Click += new System.EventHandler(this.btn15_Click);
            // 
            // btn20
            // 
            this.btn20.Location = new System.Drawing.Point(12, 211);
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
            this.groupBox1.Location = new System.Drawing.Point(12, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(120, 53);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Current Time";
            // 
            // lbCurrentTime
            // 
            this.lbCurrentTime.AutoSize = true;
            this.lbCurrentTime.Location = new System.Drawing.Point(28, 22);
            this.lbCurrentTime.Name = "lbCurrentTime";
            this.lbCurrentTime.Size = new System.Drawing.Size(72, 13);
            this.lbCurrentTime.TabIndex = 0;
            this.lbCurrentTime.Text = "lbCurrentTime";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.tbCustomHrs);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.tbCustomMins);
            this.groupBox2.Controls.Add(this.tbCustomSecs);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(329, 111);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(102, 63);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Custom Time";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Sec";
            // 
            // tbCustomSecs
            // 
            this.tbCustomSecs.Location = new System.Drawing.Point(68, 19);
            this.tbCustomSecs.Name = "tbCustomSecs";
            this.tbCustomSecs.Size = new System.Drawing.Size(25, 20);
            this.tbCustomSecs.TabIndex = 5;
            this.tbCustomSecs.TextChanged += new System.EventHandler(this.tbCustomSecs_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Min";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lbTargetTime);
            this.groupBox3.Location = new System.Drawing.Point(161, 52);
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
            this.groupBox4.Controls.Add(this.lbTimer);
            this.groupBox4.Location = new System.Drawing.Point(312, 52);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(119, 53);
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
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(118, 211);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(100, 25);
            this.btnStop.TabIndex = 12;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label4);
            this.groupBox6.Controls.Add(this.cbClear);
            this.groupBox6.Controls.Add(this.tbCustomMessage);
            this.groupBox6.Location = new System.Drawing.Point(12, 111);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(312, 63);
            this.groupBox6.TabIndex = 14;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Away Message";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(329, 211);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 25);
            this.btnExit.TabIndex = 15;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // fbdChooseStorage
            // 
            this.fbdChooseStorage.HelpRequest += new System.EventHandler(this.fbdChooseStorage_HelpRequest);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.tbStorageFolder);
            this.groupBox7.Controls.Add(this.btnBrowse);
            this.groupBox7.Location = new System.Drawing.Point(12, 4);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(419, 42);
            this.groupBox7.TabIndex = 16;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Storage Folder";
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(335, 13);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 0;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // tbCustomHrs
            // 
            this.tbCustomHrs.Location = new System.Drawing.Point(6, 19);
            this.tbCustomHrs.Name = "tbCustomHrs";
            this.tbCustomHrs.Size = new System.Drawing.Size(25, 20);
            this.tbCustomHrs.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Hr";
            // 
            // cbClear
            // 
            this.cbClear.AutoSize = true;
            this.cbClear.Location = new System.Drawing.Point(209, 31);
            this.cbClear.Name = "cbClear";
            this.cbClear.Size = new System.Drawing.Size(15, 14);
            this.cbClear.TabIndex = 17;
            this.cbClear.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(225, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 41);
            this.label4.TabIndex = 18;
            this.label4.Text = "Clear message file on complete";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(224, 211);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(100, 25);
            this.btnClear.TabIndex = 17;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // tbStorageFolder
            // 
            this.tbStorageFolder.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::timerApp.Properties.Settings.Default, "tbStorageText", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tbStorageFolder.Location = new System.Drawing.Point(7, 15);
            this.tbStorageFolder.Name = "tbStorageFolder";
            this.tbStorageFolder.Size = new System.Drawing.Size(322, 20);
            this.tbStorageFolder.TabIndex = 1;
            this.tbStorageFolder.Text = global::timerApp.Properties.Settings.Default.tbStorageText;
            // 
            // tbCustomMessage
            // 
            this.tbCustomMessage.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::timerApp.Properties.Settings.Default, "tbAwayMessage", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tbCustomMessage.Location = new System.Drawing.Point(6, 19);
            this.tbCustomMessage.Multiline = true;
            this.tbCustomMessage.Name = "tbCustomMessage";
            this.tbCustomMessage.Size = new System.Drawing.Size(200, 36);
            this.tbCustomMessage.TabIndex = 13;
            this.tbCustomMessage.Text = global::timerApp.Properties.Settings.Default.tbAwayMessage;
            this.tbCustomMessage.TextChanged += new System.EventHandler(this.tbCustomMessage_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 245);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.btnCustom);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn20);
            this.Controls.Add(this.btn15);
            this.Controls.Add(this.btn10);
            this.Controls.Add(this.btn5);
            this.Name = "Form1";
            this.Text = "Twitch Timers Control";
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
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCustom;
        private System.Windows.Forms.TextBox tbCustomMins;
        private System.Windows.Forms.Button btn5;
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
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.TextBox tbCustomMessage;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.FolderBrowserDialog fbdChooseStorage;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.TextBox tbStorageFolder;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbCustomHrs;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox cbClear;
        private System.Windows.Forms.Button btnClear;
    }
}

