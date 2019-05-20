using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_2
{
    public partial class Help : Form
    {
        Image[] pics = new Image[7];
        public Form ms { get; set; }
        private int i = 0;

        public Help()
        {
            InitializeComponent();
            pics[0] = Game_2.Properties.Resources.mainMenuSCRShot;
            pics[1] = Game_2.Properties.Resources.gameSCRShot;
            pics[2] = Game_2.Properties.Resources.levelUpScrShot;
            pics[3] = Game_2.Properties.Resources.gotLevelScr;
            pics[4] = Game_2.Properties.Resources.fightMainScr;
            pics[5] = Game_2.Properties.Resources.fightDeathScr;
            pics[6] = Game_2.Properties.Resources.returned;
        }

        private void Next_Click(object sender, EventArgs e)
        {
        }

        private void Help_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
            ms.Show();
        }

        private void Bak_Click(object sender, EventArgs e)
        {
            i = clamp(--i);
            output.BackgroundImage = pics[i];
        }

        private void Forw_Click(object sender, EventArgs e)
        {
            i = clamp(++i);
            output.BackgroundImage = pics[i];
        }

        private int clamp(int num)
        {
            if (num > 6) return 6;
            if (num < 0) return 0;
            return num;
        }
    }
}
