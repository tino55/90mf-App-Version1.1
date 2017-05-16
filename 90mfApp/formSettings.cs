using System;
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
    public partial class formSettings : Form
    {
        public formSettings()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            formEditFA form = new formEditFA();
            form.Show();
            this.Hide();
        }


        private void button3_Click(object sender, EventArgs e)
        {
            testcsv form = new testcsv();
            form.Show();
            this.Hide();
        }
    }
}
