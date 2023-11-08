using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MetronomeTimer
{
    public partial class Form1 : Form
    {

        int bpm = 50;

 

        public Form1()
        {
            InitializeComponent();
        }


        private int bpmToMS(int ms)
        {
            int waitTime = 60000 / ms;
            return waitTime;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void playSimpleSound()
        {
            SoundPlayer simpleSound = new SoundPlayer(@"C:\Users\Creeper Gang\source\repos\MetronomeTimer\metronome-tempo-single-sound_G_major.wav");
            simpleSound.Play();
        }

        private void trackBPM_Scroll(object sender, EventArgs e)
        {
            bpm = trackBPM.Value;
            BPMnumUpDown.Value = bpm;
        }

        private async void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            lblStart.Text = "Tick tock!";

            while (checkBoxStart.Checked)
            {
                playSimpleSound();
                await Task.Delay(bpmToMS(bpm));
            }
        }    

        private void lblStart_Click(object sender, EventArgs e)
        {

        }

        private void PomodoroProgressBar_Click(object sender, EventArgs e)
        {

        }

        private void BPMnumUpDown_ValueChanged(object sender, EventArgs e)
        {
            bpm = (int)BPMnumUpDown.Value;
        }

        private void BPMlabel_Click(object sender, EventArgs e)
        {

        }

        private async void TimerButton_Click(object sender, EventArgs e)
        {
            
        }

        private void timeLeftLabel_Click(object sender, EventArgs e)
        {
            
        }

        private void TimerNumUpDown_ValueChanged(object sender, EventArgs e)
        {

        }

        private async void TimerStartCheck_CheckedChanged(object sender, EventArgs e)
        {
            while (TimerNumUpDown.Value > 0 && TimerStartCheck.Checked)
            {
                TimerNumUpDown.Value--;
                await Task.Delay(1000);
            }
            
            if(TimerNumUpDown.Value == 0)
            {
                checkBoxStart.Checked = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void PomoTimer_Tick(object sender, EventArgs e)
        {

        }
    }
}
