using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace WYSTrainer
{
    public partial class Statisticts : UserControl
    {
        public static dynamic vlCount;
        public static dynamic roomID;
        public static dynamic diff;
        public static dynamic death;
        public static dynamic chapter;
        public static dynamic xpos1;

        public Statisticts()
        {
            InitializeComponent();
        }
        public void NotifyValueChanged()
        {
            VLCOUNT.Invoke((Action)delegate
            {
                VLCOUNT.Text = vlCount.ToString();
            });
            xpos.Invoke((Action)delegate
            {
                if(roomID == 130)
                {
                    xpos.Text = "Not in level";
                }
                else 
                {
                    xpos.Text = xpos1.ToString();
                }
            });
            chptText.Invoke((Action)delegate
            {
                chptText.Text = chapter.ToString();
            });

            label5.Invoke((Action)delegate
            {
                label5.Text = roomID.ToString();
            });

            label7.Invoke((Action)delegate
            {
                label7.Text = death.ToString();
            });
            if (diff == 3)
            {
                label6.Invoke((Action)delegate
                {
                    label6.Text = "Easy (3)";
                });
            }

            if (diff == 2)
            {
                label6.Invoke((Action)delegate
                {
                    label6.Text = "Very Easy";
                });
            }

            if (diff == 1)
            {
                label6.Invoke((Action)delegate
                {
                    label6.Text = "Extremely Easy";
                });
            }


            if (diff == 0)
            {
                label6.Invoke((Action)delegate
                {
                    label6.Text = "Infinitely Easy";
                });
            }
        }

        private void Statisticts_Load(object sender, EventArgs e)
        {
            
        }

        private void chptText_Click(object sender, EventArgs e)
        {

        }

        private void xpos_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
