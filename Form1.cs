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
        public Form1()
        {
            InitializeComponent();
            InitializeTypingProgerss();
        }

        private void InitializeTypingProgerss()
        {
            TypingProgress.Maximum = labelTextOriginal.Text.Length;
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
            if (TextsAreSame())
            {
                AllowTyping();
                TypingProgress.Value++;
                //fine, continue
            }
            else
            {
                //block, change color to red
                BlockTyping();
            }
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
    }
}
