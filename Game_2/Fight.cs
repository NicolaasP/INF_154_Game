using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace Game_2
{
    public partial class Fight : Form
    {
        public Fight(int level)
        {
            InitializeComponent();
            Init(level);

        }

        private void Init(int level)
        {
            music.settings.setMode("loop", true);
            this.bHealth = level * 100;
            l = level;
            damageMul *= (level * 25);
            bHL.Text = "Knight Health: " + this.bHealth;
            bHealthPBX.Size = new Size(this.bHealth, 30);
            bHealthPBX.BackColor = Color.Green;
            bHBack.Size = new Size(bHealth, 30);
            bHBack.BackColor = Color.Red;
            pHealthPBX.Size = new Size(400, 30);
            pHealthPBX.BackColor = Color.Green;
            pHBack.Size = new Size(400, 30);
            pHBack.BackColor = Color.Red;
        }

        public Form game { get; set; }
        private int damageMul = 1, pHealth = 400, bHealth = 0, pDam = 50, l = 0;
        private System.Media.SoundPlayer win = new System.Media.SoundPlayer("Sounds\\effects\\win.wav");
        private System.Media.SoundPlayer attack = new System.Media.SoundPlayer("Sounds\\effects\\fight.wav");


        private void Fight_FormClosing(object sender, FormClosingEventArgs e)
        {
            music.Ctlcontrols.stop();
        }

        private void fight(int opt)
        {
            int pualineChoice = new Random().Next(0, 3);
            String message = "";
            attack.Play();
            switch (pualineChoice)
            {
                case 0:
                    message += "Dragon used \"Block\"\n";
                    if (opt == 0) message += "Knight used \"Block\"\nNo Damage";
                    else if (opt == 1) message += "Knight used \"Punch\"\nNo Damage";
                    else
                    {
                        message += "Knight used \"Kick\"\n" + damageMul + " Damage to Dragon";
                        damageP();
                    }
                    break;
                case 1:
                    message += "Dragon used \"Punch\"\n";
                    if (opt == 0) message += "Knight used \"Block\"\nNo Damage";
                    else if (opt == 1)
                    {
                        message += "Knight used \"Punch\"\n" + pDam + " to Knight\n" + damageMul + " to Pualine";
                        damageB();
                        damageP();
                    }
                    else
                    {
                        message += "Knight used \"Kick\"\n" + pDam + " Damage to Knight";
                        damageB();
                    }
                    break;
                case 2:
                    message += "Dragon used \"Kick\"\n";
                    if (opt == 0)
                    {
                        message += "Knight used \"Block\"\n" + pDam + " Damage to Knight";
                        damageB();
                    }
                    else if (opt == 1)
                    {
                        message += "Knight used \"Punch\"\n" + damageMul + " to Dragon";
                        damageP();
                    }
                    else
                    {
                        message += "Knight used \"Kick\"\n" + pDam + " to Knight\n" + damageMul + " to Pualine";
                        damageB();
                        damageP();
                    }
                    break;
            }
            MessageBox.Show(message);
            if (bHealth <= 0 && pHealth <= 0) draw();
            else if (bHealth <= 0)
            {
                MessageBox.Show("You Died");
                ret();
            }
            else if (pHealth <= 0)
            {
                music.Ctlcontrols.stop();
                win.Play();
                new Wincs().Show();
                this.Dispose();
            }
        }

        private void draw()
        {
            MessageBox.Show("Draw!");
            pHealth = 400;
            bHealth = l * 100;

        }

        private void damageP()
        {
            pHealth -= damageMul;
            pHL.Text = "Dragon Health: " + pHealth;
            pHealthPBX.Size = new Size(pHealth, 30);
            pHealthPBX.Location = new Point((pHealthPBX.Location.X + damageMul), pHealthPBX.Location.Y);
            this.Refresh();
        }

        private void damageB()
        {
            bHealth -= 50;
            bHL.Text = "Knight Health: " + bHealth;
            bHealthPBX.Size = new Size(bHealth, 30);
            this.Refresh();
        }

        private void BHL_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, System.EventArgs e)
        {
            fight(0);
        }

        private void PunchBTN_Click(object sender, System.EventArgs e)
        {
            fight(1);
        }

        private void KickBTN_Click(object sender, System.EventArgs e)
        {
            fight(2);
        }

        private void ret()
        {
            this.Close();
            game.Show();
        }
    }
}
