using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _90mfApp
{
    public partial class formHome : Form
    {
        public static formHome keepIndex = null; //to call form back
        public static ArrayList allFAs = new ArrayList();
        public static ArrayList allTeams = new ArrayList();
        public static ArrayList allPlayers = new ArrayList();
        public static string inputTeam = @"../team.txt";
        public static string inputPlayers = @"../player.txt";
        public static string inputFA = @"../fas.txt";

        public formHome()
        {
            InitializeComponent();
            keepIndex = this;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            formRepCalc formRep = new formRepCalc();
            formRep.Show();
            this.Hide();
            formRep.FormClosing += Form_Closing;
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            formSettings formset = new formSettings();
            formset.Show();
            this.Hide();
            formset.FormClosing += Form_Closing;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            formWage formwage = new formWage();
            formwage.Show();
            this.Hide();
            formwage.FormClosing += Form_Closing;
        }

        private void Form_Closing(object sender, FormClosingEventArgs e)
        {
            this.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            formCompare formcomp = new formCompare();
            formcomp.Show();
            this.Hide();
            formcomp.FormClosing += Form_Closing;
        }
    }
}
