using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace timerApp
{

    public partial class Form1 : Form
    {
        DateTime startTime;
        TimeSpan countdownTime = new TimeSpan(0, 0, 0);
        TimeSpan targetTime = new TimeSpan(0, 0, 0);
        TimeSpan customTime;
        string fpath = @"C:\\Stream_txts\";
        string fname = "timers.txt";
        string message;

        public Form1()
        {
            InitializeComponent();
            tbCustomMins.Text = string.Empty;
            tbCustomSecs.Text = string.Empty;
            labStatus.Text = "Stopped";
            lbTargetTime.Text = targetTime.ToString();
            lbTimer.Text = countdownTime.ToString();
            timer1.Start();
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

        private void btnCustom_Click(object sender, EventArgs e)
        {
            if (tbCustomMessage.Text == string.Empty)
            {
                message = "Be back in: ";
            }
            else
            {
                message = tbCustomMessage.Text;
            }
            
            startTime = DateTime.Now;
            TimeSpan customTime;
            if (tryMakeCustomTimeSpan(tbCustomMins.Text, tbCustomSecs.Text, out customTime))
            {
                targetTime = getTargetTime(customTime);
                timer2.Start();
            }
            else
            {
                MessageBox.Show("Non-number value entered for either Custom Minutes or Custom Seconds", "Error", MessageBoxButtons.OK);
                return;
            }
            //customTime = new TimeSpan(0, Int32.Parse(tbCustomMins.Text), Int32.Parse(tbCustomSecs.Text));            
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            message = "Stream Starting Soon!";
            customTime = new TimeSpan(0, 5, 0);
            targetTime = getTargetTime(customTime);
            startTime = DateTime.Now;
            timer2.Start();

        }

        private void btn10_Click(object sender, EventArgs e)
        {
            message = "Quick Dog Walk! Be back in: ";
            customTime = new TimeSpan(0, 10, 0);
            targetTime = getTargetTime(customTime);
            startTime = DateTime.Now;
            timer2.Start();
        }

        private void btn15_Click(object sender, EventArgs e)
        {
            message = "Walking the dog! Be back in: ";
            customTime = new TimeSpan(0, 15, 0);
            targetTime = getTargetTime(customTime);
            startTime = DateTime.Now;
            timer2.Start();
        }

        private void btn20_Click(object sender, EventArgs e)
        {
            message = "Extended Break. Be back in: ";
            customTime = new TimeSpan(0, 20, 0);
            targetTime = getTargetTime(customTime);
            startTime = DateTime.Now;
            timer2.Start();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            message = string.Empty;
            customTime = new TimeSpan(0, 0, 0);
            targetTime = new TimeSpan(0, 0, 0);
            startTime = DateTime.Now;
            timer2.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private TimeSpan getTargetTime(TimeSpan timeMod)
        {
            TimeSpan currentTime = TimeSpan.Parse(DateTime.Now.ToString("HH:mm:ss"));
            TimeSpan combinedTime = currentTime.Add(timeMod);
            return(combinedTime);
        }

        private bool tryMakeCustomTimeSpan(string minutes, string seconds, out TimeSpan time)
        {
            if (tbCustomMins.Text == string.Empty)
            {
                tbCustomMins.Text = "0";
            }
            if (tbCustomSecs.Text == string.Empty)
            {
                tbCustomSecs.Text = "0";
            }

            int number;
            bool minRes = int.TryParse(tbCustomMins.Text, out number);
            bool secRes = int.TryParse(tbCustomSecs.Text, out number);
            if (minRes == true && secRes == true)
            {
                time = new TimeSpan(0, int.Parse(tbCustomMins.Text), int.Parse(tbCustomSecs.Text));
                return true;
            }
            //if ((minRes == true && secRes == false) || (minRes == false && secRes == true))
            //{
            //    time = new TimeSpan(0, 0, 0);
            //    return false;
            //}
            else
            {
                time = new TimeSpan(0, 0, 0);
                return false;
            }

        }

        private void writeTimeFile(string timeMod)
        {
            string text = string.Join(Environment.NewLine, new string[] {
                message,
                timeMod
            });

            if (!System.IO.File.Exists(fpath))
            {
                System.IO.Directory.CreateDirectory(fpath);
            }
            System.IO.File.WriteAllText(fpath+fname, text);
        }

        private void cleanTimeFile()
        {
            if (System.IO.File.Exists(fpath+fname))
            {
                System.IO.File.Delete(fpath+fname);
            } 
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.lbCurrentTime.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            labStatus.Text = "Running...";
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
            }

            writeTimeFile(countdownTime.ToString());

            if (countdownTime <= TimeSpan.Zero)
            {
                timer2.Stop();
                cleanTimeFile();
                labStatus.Text = "Stopped";
            }

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            cleanTimeFile();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
