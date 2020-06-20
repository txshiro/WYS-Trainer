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

namespace WYSTrainer
{
    public partial class HP : UserControl
    {
        public static bool saveMR = false;
        public static string collectiblesLevels;
        public HP()
        {
            InitializeComponent();
        }
        public void NotifyValueChanged()
        {
           
        }
        private void customHP_TextChanged(object sender, EventArgs e)
        {
        }

        private void SaveHPMR_Click(object sender, EventArgs e)
        {
            if(customHP.Text != "" && Regex.IsMatch(customHP.Text, @"^\d+$"))
            {
                SaveHPMR.Text = "Saved!";
                SaveHPMR.BackColor = Color.DarkGray;
                saveMR = true;

            }
            else
            {
                SaveHPMR.Text = "Can't Save!";
                SaveHPMR.BackColor = Color.Red;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void HP_Load(object sender, EventArgs e)
        {
        }

    }
}
