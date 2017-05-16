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
    public partial class formWage : Form
    {
        public formWage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int bid = Int32.Parse(textBox1.Text, System.Globalization.NumberStyles.AllowThousands);  
            String ageS = comboBox1.Text;
            int age = Int32.Parse(ageS);

            double m = 0;

            if (age == 17)
            {
                m = 4;
            }
            else if (age == 18)
            {
                m = 4.5;
            }
            else if (age == 19)
            {
                m = 5;
            }
            else if (age == 20)
            {
                m = 5.5;
            }
            else if (age == 21)
            {
                m = 6;
            }
            else if (age == 22)
            {
                m = 6.5;
            }
            else if (age == 23)
            {
                m = 7;
            }
            else if (age == 24)
            {
                m = 7.5;
            }
            else if (age == 25)
            {
                m = 8;
            }
            else if (age == 26)
            {
                m = 8.5;
            }
            else if (age == 27)
            {
                m = 9;
            }
            else if (age == 28)
            {
                m = 9.5;
            }
            else if (age == 29)
            {
                m = 10;
            }
            else if (age == 30)
            {
                m = 10.5;
            }

            double r = m * bid / 1000;

            r = Math.Round(r / 1000);

            int i = (int)r;

            if(checkBox1.Checked)
            {
                int disc = i / 3;
                i = i - disc;
            }

            this.label3.Text = " " + i + "k";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
            
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                System.Globalization.CultureInfo culture = new System.Globalization.CultureInfo("en-US");
                int valueBefore = Int32.Parse(textBox1.Text, System.Globalization.NumberStyles.AllowThousands);
                textBox1.Text = String.Format(culture, "{0:N0}", valueBefore);
                textBox1.Select(textBox1.Text.Length, 0);
            }
        }
    }
    
}
