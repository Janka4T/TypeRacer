using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TypeRacer
{
    public partial class Form1 : Form
    {

        int sec = 0;
        bool typingStarted = false;

        public Form1()
        {
            InitializeComponent();
            InitializeTypingProgerss();
            InitalizeltypingTimer();
        }
        private void InitalizeltypingTimer()
        {
            typingTimer.Interval = 1000;
        }

        private void InitializeTypingProgerss()
        {
            TypingProgress.Maximum = labelTextOriginal.Text.Length;
            TimeProgress.Maximum = 60;
        }


        private void pictureBoxClose_MouseEnter(object sender, EventArgs e)
        {
            pictureBoxClose.Image = Properties.Resources.close_up;
        }

        private void pictureBoxClose_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxClose.Image = Properties.Resources.close;
        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBoxTextType_TextChanged(object sender, EventArgs e)
        {
            if (!typingStarted)
            {
                typingTimer.Start();
                typingStarted = true;
            }

            if (TextsAreSame())
            {
                AllowTyping();
                TypingProgress.Value = textBoxTextType.Text.Length;
                if(textBoxTextType.Text.Length == labelTextOriginal.Text.Length)
                {
                    TypingOver();
                }
                //fine, continue
            }
            else
            {
                //block, change color to red
                BlockTyping();
            }
            UpdateCPM();
        }

        private void UpdateCPM()
        {
            CurrentCPM.Text = "Current CPM:" +  CalculateCPM();
        }

        private bool TextsAreSame()
        {
            int charecterCount;
            charecterCount = textBoxTextType.Text.Length;
            string lablSubString = labelTextOriginal.Text.Substring(0, charecterCount);
            
            if (textBoxTextType.Text == lablSubString)
            {
                
                return true;
            }
            else
            {
                
                return false;
            }
        }

        private void BlockTyping()
        {                       
            textBoxTextType.MaxLength = textBoxTextType.Text.Length;
            textBoxTextType.BackColor = Color.Red;                                                             
        }

        private void AllowTyping()
        {
            
            textBoxTextType.MaxLength = labelTextOriginal.Text.Length;
            textBoxTextType.BackColor = Color.White;                        
        }

        private void textBoxTextType_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Space)
            {
             
            }
        }

        private void typingTimer_Tick(object sender, EventArgs e)
        {
            sec++;
            if(sec > 60)
            {
                TypingOver();
            }

            try
            {
                TimeProgress.Value = sec;
            }
            catch
            {

            }
            UpdateCPM();
        }

        private int CalculateCPM()
        {
            int cpm;
            try
            {
                cpm =  textBoxTextType.Text.Length * 60 / sec;
                return cpm;
            }
            catch
            {
                return 0;
            }
             
        }
        
        private void TypingOver()
        {
            typingTimer.Stop();
            textBoxTextType.Enabled = false;
            MessageBox.Show("time is up!!! your result is" + CalculateCPM());
        }
    }
}
