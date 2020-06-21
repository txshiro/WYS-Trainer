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

        //ROOM VARS
        public static bool isRoom;
        public static dynamic roomIDD;
        
        //DEATH VARS
        public static string deathCount;
        public static bool isDeath;
        
        //disable textures
        public static bool dontknow = false;
        public static bool disableTexturesB;
        
        public static bool saved;

       
        //y pos
        public static bool yPosChange;
        public static dynamic yPos;

        //x pos
        public static bool xPosChange;
        public static dynamic xPos;

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
            if (deathBox.Text == "" || !Regex.IsMatch(deathBox.Text, @"^\d+$") || string.IsNullOrEmpty(deathBox.Text))
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
            if (roomBox.Text == "" || !Regex.IsMatch(roomBox.Text, @"^\d+$") || string.IsNullOrEmpty(roomBox.Text))
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
           
            
            saved = true;

            var backgroundWorker = new BackgroundWorker();
            backgroundWorker.DoWork += (s, ea) => Thread.Sleep(TimeSpan.FromSeconds(1));

            // ...and then set the text back to the original when the sleep is done
            // (also, re-enable the button)
            backgroundWorker.RunWorkerCompleted += (s, ea) =>
            {
                saveSet.Text = "Save";
                saveSet.BackColor = Color.White;
                deathBox.Text = string.Empty;
                xPosBox.Text = string.Empty;
                roomBox.Text = string.Empty;
                yPosBox.Text = string.Empty;
             
            };

            saveSet.Text = "Saved";
            if (isDeath == true)
            {
                deathCount = deathBox.Text;

            }
            if (isRoom == true)
            {
                roomIDD = roomBox.Text;
            }

            if (xPosChange == true)
            {
                xPos = xPosBox.Text;
            }

            if (yPosChange == true)
            {
                yPos = yPosBox.Text;
            }
            saveSet.BackColor = Color.Green;

            backgroundWorker.RunWorkerAsync();
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void xPosBox_TextChanged(object sender, EventArgs e)
        {

            if (xPosBox.Text == "" || !Regex.IsMatch(xPosBox.Text, @"^\d+$") || string.IsNullOrEmpty(xPosBox.Text))
            {
                xPosChange = false;
            }
            else
            {
                xPosChange = true;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void yPosBox_TextChanged(object sender, EventArgs e)
        {
            if (yPosBox.Text == "" || !Regex.IsMatch(yPosBox.Text, @"^\d+$") || string.IsNullOrEmpty(yPosBox.Text))
            {
                yPosChange = false;
            }
            else
            {
                yPosChange = true;
            }
        }

    }
}
