using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Threading;

namespace WYSTrainer
{
    public partial class Timers : UserControl
    {

        public static bool gmTimerStop = false;
        public static bool gmGetTime = true;

        public static bool chptTimerStop = false;
        public static bool chptGetTime = true;

        public static bool lvlTimerStop = false;
        public static bool lvlGetTime = true;

        public static string customGMTIME;
        public static string customCHPTTIME;
        public static string customLVLTIME;

        public static bool save;
        public static bool cantsave;
        int count = 0;

        public Timers()
        {
            InitializeComponent();
        }

        private void gmTimer_CheckedChanged(object sender, EventArgs e)
        {
            if(gmTimer.Checked)
            {
                MainForm.stopGameTimer = true;
                MainForm.getGameTimer = true;
            }
            else
            {
                MainForm.stopGameTimer = false;
            }
        }

        private void Timers_MouseDown(object sender, MouseEventArgs e)
        {
        }

        private void chptTimer_CheckedChanged(object sender, EventArgs e)
        {

            if (chptTimer.Checked)
            {
                MainForm.stopCHPTTimer = true;
                MainForm.getCHPTTimer = true;
            }
            else
            {
                MainForm.stopCHPTTimer = false;
            }
        }

        private void lvlTimer_CheckedChanged(object sender, EventArgs e)
        {
            if (lvlTimer.Checked)
            {
                MainForm.stopLVLTimer = true;
                MainForm.getLVLTimer = true;
            }
            else
            {
                MainForm.stopLVLTimer = false;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CustomGMTIME_TextChanged(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(CustomGMTIME.Text))
            {
                customGMTIME = "";
            }
            else
            {
                customGMTIME = CustomGMTIME.Text;


            }
        }

        private void customCHPTTimer_TextChanged(object sender, EventArgs e)
        {

                customCHPTTIME = customCHPTTimer.Text;

        }

        private void customLVLTIMER_TextChanged(object sender, EventArgs e)
        {

                customLVLTIME = customLVLTIMER.Text;

        }

        private void Save_Click(object sender, EventArgs e)
        {
            if(cantsave)
            {
                Save.BackColor = Color.Red;
                Save.Text = "NO";
            }
            else
            {
                save = true;

                var backgroundWorker = new BackgroundWorker();
                backgroundWorker.DoWork += (s, ea) => Thread.Sleep(TimeSpan.FromSeconds(1));

                // ...and then set the text back to the original when the sleep is done
                // (also, re-enable the button)
                backgroundWorker.RunWorkerCompleted += (s, ea) =>
                {
                    Save.Text = "Save";
                    Save.BackColor = Color.Gray;
                    customCHPTTimer.Text = string.Empty;
                    customLVLTIMER.Text = string.Empty;
                    CustomGMTIME.Text = string.Empty;

                };
                Save.BackColor = Color.Green;
                Save.Text = "Saved";

            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            count++;
            button1.Text = count.ToString();
            if(count >= 5)
            {
                clap.Visible = true;
            }

            if(count >= 10)
            {
                clap2.Visible = true;
            }
        

            if(count >= 15)
            {
                clap3.Visible = true;
            }
         

            if (count >= 25)
            {
                clap4.Visible = true;
            }
       

            if (count >= 50)
            {
                clap5.Visible = true;
            }
        

            if (count >= 69)
            {
                clap6.Visible = true;
            }
     

            if (count >= 75)
            {
                clap7.Visible = true;
            }
 

            if (count >= 100)
            {
                clap8.Visible = true;
                enough.Visible = true;
            }

        }
    }
}
