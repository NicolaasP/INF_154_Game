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
    public partial class Wincs : Form
    {
        public Wincs()
        {
            InitializeComponent();
            this.Text = "You Won!!!";
            MessageBox.Show("You Saved the princess!!");
        }

        private void WinBTN_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Wincs_Load(object sender, EventArgs e)
        {
            Credits.Text = "u19021306    Nicolaas Iván Pretorius\n" +
                "u19034101    Alwyn Potgieter\n" +
                "u19009756    Dries Moolman\n" +
                "Andrew Nel";
        }

        private void Wincs_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
