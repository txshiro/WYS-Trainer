using System;
using System.ComponentModel;
using System.Drawing;
using System.Threading;
using Memory;
using System.Windows.Forms;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;

//base+3F40DC, "byte" , "142" - reset non stop


//base+3F40DC, "byte" , "134" -  stop reset non stop

namespace WYSTrainer
{
    public partial class MainForm : Form
    {
        public Mem m = new Mem();


        public double currentgmTime;
        public double currentchptTime;
        public double currentlvlTime;

        public static bool canShow;

        //AI and COllisiosn
        public static bool aion;
        public static dynamic collisionoff;

        //Game
        public static bool stopGameTimer;
        public static bool getGameTimer;

        //Chapter
        public static bool stopCHPTTimer;
        public static bool getCHPTTimer;

        //Level
        public static bool stopLVLTimer;
        public static bool getLVLTimer;

        //poss
        public static float xpos1;
        public static float ypos1;
        public MainForm()
        {
            InitializeComponent();
            timer1.Start();
        }

        bool ProcOpen = false;
        private void bgWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            ProcOpen = m.OpenProcess("Will You Snail");

            if (!ProcOpen)
            {
                ProcOpenLabel.Text = "Not found!";
                ProcOpenLabel.ForeColor = Color.Red;
                Thread.Sleep(1000);
            }
            else
            {

            }
            bgWorker.ReportProgress(0);
           if(ProcOpen)
            {
                ProcOpenLabel.Text = "Found!";
                ProcOpenLabel.ForeColor = Color.LightGreen;
                while (true)
                {
                    int vlInt = m.Read2Byte("base+007C1DAC,14,4");
                    int roomID = m.Read2Byte("base+003CA150,0");

                    double diffValue = m.ReadDouble("base+007B4A3C,0,2c,10,7ec,300");
                    double deathValue = m.ReadDouble("base+007B9CB0,2c,10,6d8,6f0");
                    double chapter = m.ReadDouble("base+007B9CB0,2c,10,2F4,380");
                    xpos1 = m.ReadFloat("base+00A0A850,C");
                    ypos1 = m.ReadFloat("base+009E003C,4");

                    Statisticts.vlCount = vlInt;
                    Statisticts.roomID = roomID;
                    Statisticts.diff = diffValue;
                    Statisticts.death = deathValue;
                    Statisticts.chapter = chapter;
                    Statisticts.xpos1 = xpos1;
                    Statisticts.ypos1 = ypos1;

                  
                    statisticts1.NotifyValueChanged();
                    //Get current timers
                    if (getLVLTimer == true)
                    {
                        currentlvlTime = m.ReadDouble("base+007B9CB0,2c,10,480,4a0");
                        getLVLTimer = false;
                    }

                    if (getGameTimer == true)
                    {
                        currentgmTime = m.ReadDouble("base+007B4A3C,0,2c,10,108,50");
                        getGameTimer = false;
                    }

                    else
                    {
                        m.WriteMemory("base+360CDE", "byte", "0");
                    }
                    //CHAPTER TIME
                    if (getCHPTTimer == true)
                    {
                        currentchptTime = m.ReadDouble("base+007B4A3C,0,2c,10,798,3c0");
                        getCHPTTimer = false;
                    }

                    //OTHER THINGS
                    if (aion == true)
                    {
                        m.WriteMemory("base+211FAA", "byte", "3");
                    }
                    else
                    {
                        m.WriteMemory("base+211FAA", "byte", "4");
                    }

                    if (Settable.dontknow == true)
                    {
                        m.WriteMemory("Will You Snail.exe+46A50A", "byte", "0x10");
                        //m.WriteMemory("Will You Snail.exe+46A50B", "byte", "0x90");
                    }
                    else
                    {
                        m.WriteMemory("Will You Snail.exe+46A50A", "byte", "0x11");
                        //m.WriteMemory("Will You Snail.exe+46A50B", "byte", "0x46");
                    }

                    if (Settable.disableTexturesB == true)
                    {
                        m.WriteMemory("base+3DAEE4", "byte", "A3");
                    }
                    else
                    {
                        m.WriteMemory("base+3DAEE4", "byte", "A4");
                    }

                    //Deaths
                    if (Settable.saved == true)
                    {
                        if (Settable.isDeath == true)
                        {
                            m.WriteMemory("base+007B9CB0,2c,10,6d8,6f0", "double", Settable.deathCount);
                        }
                        if (Settable.isRoom == true)
                        {
                            m.WriteMemory("base+003CA150,0", "2bytes", Settable.roomIDD);
                            Thread.Sleep(1000);
                        }

                        if (Settable.yPosChange == true)
                        {
                            m.WriteMemory("base+007C41C4,0,248,c,38,8,a4", "float", Settable.yPos);
                            Thread.Sleep(1000);
                           // m.WriteMemory("base+007C41C4,0,24c,c,44,8,a4", "float", ypos1.ToString());
                        }

                        if (Settable.xPosChange == true)
                        {
                            m.WriteMemory("base+007C41E8,0,134,130,A0", "float", Settable.xPos);
                        }

                    }

                    //GAME TIMER

                    if (Timers.save == true)
                    {

                        //game time
                        m.WriteMemory("base+007B4A3C,0,2c,10,108,50", "double", Timers.customGMTIME);

                        //chapter time
                        m.WriteMemory("base+007B4A3C,0,2c,10,798,3c0", "double", Timers.customCHPTTIME);

                        //level time
                        m.WriteMemory("base+007B9CB0,2c,10,480,4a0", "double", Timers.customLVLTIME);
                        Timers.save = false;
                    }

                    //Game
                    if (stopGameTimer == true)
                    {
                        m.FreezeValue("base+007B4A3C,0,2c,10,108,50", "double", currentgmTime.ToString());
                    }
                    else
                    {
                        m.UnfreezeValue("base+007B4A3C,0,2c,10,108,50");
                    }


                    //Chapter
                    if (stopCHPTTimer == true)
                    {
                        m.FreezeValue("base+007B4A3C,0,2c,10,798,3c0", "double", currentchptTime.ToString());
                    }
                    else
                    {
                        m.UnfreezeValue("base+007B4A3C,0,2c,10,798,3c0");
                    }

                    //LEVEL TIME


                    if (stopLVLTimer == true)
                    {
                        m.FreezeValue("base+007B9CB0,2c,10,480,4a0", "double", currentlvlTime.ToString());
                    }
                    else
                    {
                        m.UnfreezeValue("base+007B9CB0,2c,10,480,4a0");
                    }

                    Thread.Sleep(250);




               


            }
        }
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            bgWorker.RunWorkerAsync();

        }

        private void bgWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if (ProcOpen == true)
            {
                ProcOpenLabel.Text = "Found!";
                ProcOpenLabel.ForeColor = Color.LightGreen;
           
            }
            else
            {
                ProcOpenLabel.Text = "Not found!";
                ProcOpenLabel.ForeColor = Color.Red;

            }

        }

        private void bgWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
           
            bgWorker.RunWorkerAsync();


        }

        private void deathCount_TextChanged(object sender, EventArgs e)
        {

        }

        private void Save_Click(object sender, EventArgs e)
        {

            /*if(deathCount.Text != "" && Regex.IsMatch(deathCount.Text, @"^\d+$"))
            {
                m.WriteMemory("base+007B9CB0,2c,10,6d8,6f0", "double", deathCount.Text);
                Save.Text = "Saved!";
                deathCount.BackColor = Color.White;
            }
            else
            {
                Save.Text = "Can't Save!";
                deathCount.BackColor = Color.Red;
            }*/
        }

        private void VLCount_Click(object sender, EventArgs e)
        {

        }

        private void RoomID_Click(object sender, EventArgs e)
        {

        }

        private void Diff_Click(object sender, EventArgs e)
        {

        }

        private void Statisticts2_Click(object sender, EventArgs e)
        {
            statisticts1.Show();
            timers1.Hide();
            //hp1.Hide();
            settable1.Hide();
            //label8.Text = "Statisticts";
            HPBOSS.BackColor = Color.FromArgb(22, 22, 23);
            SettableB.BackColor = Color.FromArgb(22, 22, 23);
            Info.BackColor = Color.FromArgb(22, 22, 23);
            Timers2.BackColor = Color.FromArgb(22, 22, 23);
            Statisticts2.BackColor = Color.FromArgb(22, 22, 30);
        }


        private void Timers2_Click(object sender, EventArgs e)
        {
            statisticts1.Hide();
            timers1.Show();
           // label8.Text = "Timers";
            //hp1.Hide(); 
            settable1.Hide();
            HPBOSS.BackColor = Color.FromArgb(22, 22, 23);
            Info.BackColor = Color.FromArgb(22, 22, 23);
            SettableB.BackColor = Color.FromArgb(22, 22, 23);
            Statisticts2.BackColor = Color.FromArgb(22, 22, 23);
            Timers2.BackColor = Color.FromArgb(22, 22, 30);
        }

        private void firstCustomControl2_Load(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            statisticts1.Hide();
            timers1.Hide();
            //hp1.Hide();
            settable1.Hide();
        }

        private void Info_Click(object sender, EventArgs e)
        {
            statisticts1.Hide();
            timers1.Hide();
            //hp1.Hide();
            settable1.Hide();
            // label8.Text = "Will You Snail Trainer";
            SettableB.BackColor = Color.FromArgb(22, 22, 23);
            HPBOSS.BackColor = Color.FromArgb(22, 22, 23);
            Statisticts2.BackColor = Color.FromArgb(22, 22, 23);
            Timers2.BackColor = Color.FromArgb(22, 22, 23);
            Info.BackColor = Color.FromArgb(22, 22, 30);
        }

        private void firstCustomControl2_Load_1(object sender, EventArgs e)
        {

        }

        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void MainForm_MouseDown_1(object sender, MouseEventArgs e)
        {

        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
 
        }

        private void HPBOSS_Click(object sender, EventArgs e)
        {
            statisticts1.Hide();
            timers1.Hide();
            //hp1.Show();
            //label8.Text = "HP";
            settable1.Hide();
            HPBOSS.BackColor = Color.FromArgb(22, 22, 30);
            SettableB.BackColor = Color.FromArgb(22, 22, 23);

            Statisticts2.BackColor = Color.FromArgb(22, 22, 23);
            Timers2.BackColor = Color.FromArgb(22, 22, 23);
            Info.BackColor = Color.FromArgb(22, 22, 23);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void SettableB_Click(object sender, EventArgs e)
        {
            statisticts1.Hide();
            timers1.Hide();
            //hp1.Hide();
            //label8.Text = "HP";
            settable1.Show();
            HPBOSS.BackColor = Color.FromArgb(22, 22, 23);
            SettableB.BackColor = Color.FromArgb(22, 22, 30);
            Statisticts2.BackColor = Color.FromArgb(22, 22, 23);
            Timers2.BackColor = Color.FromArgb(22, 22, 23);
            Info.BackColor = Color.FromArgb(22, 22, 23);
        }

        private void timers1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random rand = new Random();
            int A = rand.Next(0, 255);
            int R = rand.Next(0, 255);
            int G = rand.Next(0, 255);
            int B = rand.Next(0, 255); label7.ForeColor = Color.FromArgb(A, R, G, B);
        }

        private void settable1_Load(object sender, EventArgs e)
        {

        }
    }
}
