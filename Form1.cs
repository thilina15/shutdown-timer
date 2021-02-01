using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace shoutDowwnTimer
{
    public partial class Form1 : Form
    {
        public int timerSec;
        public bool isRunning;
        public Form1()
        {
            InitializeComponent();
            timerSec = 0;
            isRunning = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timerSec <= 0)
            {
                if (isRunning)
                {
                    isRunning = false;
                    BTN_SP.Text = "start";
                    timer1.Stop();
                    shutDown();
                }
            }
            else
            {
                if (isRunning)
                {
                    timerSec--;
                    setTimer(timerSec);
                }
            }
        }

        public void shutDown()
        {
            System.Diagnostics.Process.Start("shutdown", "/s /t 0");
            
            //MessageBox.Show("hellow");
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            if (isRunning)
            {
                isRunning = false;
                BTN_SP.Text = "start";
                label1.Text = "Shut Down Manager";
                timer1.Stop();
            }
            else
            {
                
                timerSec = getTimer();
                
                

                isRunning = true;
                BTN_SP.Text = "pause";
                label1.Text = "System will Shut Down in..";
                timer1.Start();
            }
        }

        public int getTimer()
        {
            int value;
            int sec = Convert.ToInt32(NUM_Seconds.Value);
            int min = Convert.ToInt32(NUM_Minutes.Value);
            int hrs = Convert.ToInt32(NUM_Hours.Value);

            value = sec + (min * 60) + (hrs * 3600);
            
            return value;
        }

        public void setTimer(int time)
        {
            int temp,sec, min, hrs;
            hrs = time / 3600;
            temp = time % 3600;
            min = temp / 60;
            sec = temp % 60;

            NUM_Hours.Value = hrs;
            NUM_Minutes.Value = min;
            NUM_Seconds.Value = sec;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("1.0v build of shut down manager by thilina aluthge", "about");
            
        }
    }
}
