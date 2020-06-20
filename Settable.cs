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
    public partial class Settable : UserControl
    {

        public static string deathCount;
        public static bool isRoom;
        public static dynamic roomIDD;
        public static bool saved;
        public static bool isDeath;
        public static bool dontknow = false;
        public static bool disableTexturesB;
        public static dynamic rid;
        public static bool freezBe;
        public static bool chalBool;
        public static bool die;
        public static bool isBlur;
        public static dynamic blurAmount;

        public Settable()
        {
            InitializeComponent();

        }

        private void turnAI_CheckedChanged(object sender, EventArgs e)
        {
            if (turnAI.Checked)
            {
                MainForm.aion = true;
            }
            else
            {
                MainForm.aion = false;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "" && Regex.IsMatch(textBox1.Text, @"^\d+$"))
            {
                isDeath = false;
            }
            else
            {
                isDeath = true;
            }

        }

        private void collisionsOFF_CheckedChanged(object sender, EventArgs e)
        {
            if (collisionsOFF.Checked)
            {
                MainForm.collisionoff = true;

            }
            else
            {
                MainForm.collisionoff = false;
            }
        }

        private void roomid_TextChanged(object sender, EventArgs e)
        {
            if (roomid.Text == "" && Regex.IsMatch(roomid.Text, @"^\d+$"))
            {
                isRoom = false;
            }
            else
            {
                isRoom = true;
            }
        }

        private void saveSet_Click(object sender, EventArgs e)
        {

        }

        private void dontknowB_CheckedChanged(object sender, EventArgs e)
        {

            if (dontknowB.Checked)
            {
                dontknow = true;
                label4.Visible = true;
            }
            else
            {
                dontknow = false;
                label4.Visible = false;
            }


        }

        private void disableTextures_CheckedChanged(object sender, EventArgs e)
        {
            if (disableTextures.Checked)
            {
                disableTexturesB = true;
            }
            else
            {
                disableTexturesB = false;
            }
        }

        private void Settable_Load(object sender, EventArgs e)
        {

        }

        private void saveSet_Click_1(object sender, EventArgs e)
        {
            deathCount = textBox1.Text;
            roomIDD = roomid.Text;
            blurAmount = int.Parse(textBox2.Text);

            
            saved = true;

            var backgroundWorker = new BackgroundWorker();
            backgroundWorker.DoWork += (s, ea) => Thread.Sleep(TimeSpan.FromSeconds(1));

            // ...and then set the text back to the original when the sleep is done
            // (also, re-enable the button)
            backgroundWorker.RunWorkerCompleted += (s, ea) =>
            {
                saveSet.Text = "Save";
                saveSet.BackColor = Color.White;
            };

            saveSet.Text = "Saved";
            saveSet.BackColor = Color.Green;

            backgroundWorker.RunWorkerAsync();
        }

        private void chal_CheckedChanged(object sender, EventArgs e)
        {

            if(chal.Checked)
            {
                chalBool = true;
          
               
            }
            else
            {
                chalBool = false;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

            if (textBox2.Text == "" && Regex.IsMatch(textBox2.Text, @"^\d+$"))
            {
                isBlur = false;
            }
            else
            {
                isBlur = true;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
