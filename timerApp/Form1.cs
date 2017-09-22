using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Configuration;

namespace timerApp
{

    public partial class Form1 : Form
    {
        DateTime startTime;
        TimeSpan countdownTime = new TimeSpan(0, 0, 0);
        TimeSpan targetTime = new TimeSpan(0, 0, 0);
        TimeSpan customTime;
        string fname = "TwitchTimers.txt";
        string fpath = Properties.Settings.Default.tbStorageText;
        string message = Properties.Settings.Default.tbAwayMessage;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (fpath == string.Empty)
            {
                cleanStart();
            }
            tbStorageFolder.Text = fpath;
            tbCustomMins.Text = string.Empty;
            tbCustomSecs.Text = string.Empty;
            lbTargetTime.Text = targetTime.ToString();
            lbTimer.Text = countdownTime.ToString();
            timer1.Start();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            cleanTimeFile();
            Properties.Settings.Default.Save();
        }

        private void tbCustomMins_TextChanged(object sender, EventArgs e)
        {
            int number;
            bool result = (Int32.TryParse(tbCustomMins.Text, out number));
            if (result)
            {
                Console.WriteLine("converted {0} to {1}", tbCustomMins.Text, number);
            }
            else
            {
                Console.WriteLine("Failed to convert {0} to integer.", tbCustomMins.Text);
            }
        }

        private void tbCustomSecs_TextChanged(object sender, EventArgs e)
        {
            int number;
            bool result = (Int32.TryParse(tbCustomMins.Text, out number));
            if (result)
            {
                Console.WriteLine("converted {0} to {1}", tbCustomMins.Text, number);
            }
            else
            {
                Console.WriteLine("Failed to convert {0} to integer.", tbCustomMins.Text);
            }

        }

        private void tbCustomMessage_TextChanged(object sender, EventArgs e)
        {
            message = tbCustomMessage.Text;
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    btnStop.PerformClick();
                    cleanTimeFile();
                    this.tbStorageFolder.Text = fbd.SelectedPath.ToString() + "\\";
                    fpath = tbStorageFolder.Text;
                    Properties.Settings.Default.tbStorageText = tbStorageFolder.Text;
                }

            }
        }

        private void btnCustom_Click(object sender, EventArgs e)
        {
            startTime = DateTime.Now;
            TimeSpan customTime;
            if (tryMakeCustomTimeSpan(tbCustomHrs.Text, tbCustomMins.Text, tbCustomSecs.Text, out customTime))
            {
                targetTime = getTargetTime(customTime);
                timer2.Start();
            }
            else
            {
                MessageBox.Show("Non-number value entered for either Custom Minutes or Custom Seconds", "Error", MessageBoxButtons.OK);
                return;
            }          
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            //message = "Stream Starting Soon!";
            customTime = new TimeSpan(0, 5, 0);
            targetTime = getTargetTime(customTime);
            startTime = DateTime.Now;
            timer2.Start();

        }

        private void btn10_Click(object sender, EventArgs e)
        {
            //message = "Returning in: ";
            customTime = new TimeSpan(0, 10, 0);
            targetTime = getTargetTime(customTime);
            startTime = DateTime.Now;
            timer2.Start();
        }

        private void btn15_Click(object sender, EventArgs e)
        {
            //message = "Walking the dog! Be back in: ";
            customTime = new TimeSpan(0, 15, 0);
            targetTime = getTargetTime(customTime);
            startTime = DateTime.Now;
            timer2.Start();
        }

        private void btn20_Click(object sender, EventArgs e)
        {
            //message = "Extended Break. Be back in: ";
            customTime = new TimeSpan(0, 20, 0);
            targetTime = getTargetTime(customTime);
            startTime = DateTime.Now;
            timer2.Start();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            timer2.Stop();
            customTime = new TimeSpan(0, 0, 0);
            targetTime = new TimeSpan(0, 0, 0);
            startTime = DateTime.Now;
            timer2.Start();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            cleanTimeFile();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool tryMakeCustomTimeSpan(string hours, string minutes, string seconds, out TimeSpan time)
        {
            if (hours == string.Empty)
            {
                hours = "0";
            }
            if (minutes == string.Empty)
            {
                minutes = "0";
            }
            if (seconds == string.Empty)
            {
                seconds = "0";
            }

            int number;
            bool hrRes = int.TryParse(hours, out number);
            bool minRes = int.TryParse(minutes, out number);
            bool secRes = int.TryParse(seconds, out number);
            if (hrRes && minRes == true && secRes == true)
            {
                time = new TimeSpan(int.Parse(hours), int.Parse(minutes), int.Parse(seconds));
                return true;
            }
            else
            {
                time = new TimeSpan(0, 0, 0);
                return false;
            }

        }

        private TimeSpan getTargetTime(TimeSpan timeMod)
        {
            TimeSpan currentTime = TimeSpan.Parse(DateTime.Now.ToString("HH:mm:ss"));
            TimeSpan combinedTime = currentTime.Add(timeMod);
            return (combinedTime);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.lbCurrentTime.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (tbCustomMessage.Text != string.Empty)
            {
                message = tbCustomMessage.Text;
            }

            this.lbTargetTime.Text = targetTime.ToString();
            TimeSpan elapsedTime = DateTime.Now - startTime;
            countdownTime = targetTime - TimeSpan.Parse(DateTime.Now.ToString("HH:mm:ss"));

            if (countdownTime >= TimeSpan.Zero)
            {
                lbTimer.Text = countdownTime.ToString();
            }
            else
            {
                lbTimer.Text = new TimeSpan(0, 0, 0).ToString();
                countdownTime = new TimeSpan(0, 0, 0);
            }

            writeTimeFile(countdownTime.ToString());

            if (countdownTime <= TimeSpan.Zero)
            {
                timer2.Stop();
                if (cbClear.Checked)
                {
                    cleanTimeFile();
                }
            }

        }

        private void writeTimeFile(string timeMod)
        {
            string text;
            if (message != string.Empty)
            {
                text = string.Join(Environment.NewLine, new string[] 
                {
                message,
                timeMod
                });
            }
            else
            {
                text = timeMod;
            }
            
            if (!File.Exists(fpath))
            {
                Directory.CreateDirectory(fpath);
            }
            File.WriteAllText(fpath + fname, text);
        }

        private void fbdChooseStorage_HelpRequest(object sender, EventArgs e)
        {

        }

        private void cleanTimeFile()
        {
            if (System.IO.File.Exists(fpath + fname))
            {
                System.IO.File.WriteAllText(fpath + fname, "");
            }
        }

        private void cleanStart()
        {
            string userDocuments = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string twitchTimerFolder = userDocuments + "\\TwitchTimers";
            if (!System.IO.Directory.Exists(twitchTimerFolder))
            {
                System.IO.Directory.CreateDirectory(twitchTimerFolder);
                System.IO.File.Create(System.IO.Path.Combine(twitchTimerFolder, "TwitchTimers.txt"));
            }
            else
            {
                System.IO.File.Create(System.IO.Path.Combine(twitchTimerFolder, "TwitchTimers.txt")).Close();
            }
            
            fpath = twitchTimerFolder.ToString()+"\\";
        }

    }
}
