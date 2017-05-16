using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _90mfApp
{
    public partial class formRepCalc : Form
    {
        //opens a connection to the db
        SqlConnection connection;
        string connectionString;


        public formRepCalc()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["_90mfApp.Properties.Settings._90MFAppConnectionString"].ConnectionString;
        }


        //calculates the seasonal rep given the league rep and cup rep for that season
        static string seasonsRep(double leaguerep, double cuprep)
        {

            double half;
            double rep;




            if (leaguerep >= cuprep)
            {
                half = leaguerep / 2;
                rep = (leaguerep + half) + cuprep;
            }
            else
            {
                half = cuprep / 2;
                rep = (cuprep + half) + leaguerep;
            }

            string result = rep.ToString();
            return result;

        }


        //methods to calculate pass the league rep and cup rep for that season to seasonsrep()
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            double leaguerep = double.Parse(textBox2.Text);
            double cuprep = double.Parse(textBox7.Text);

            leaguerep = leaguerep / 2;
            cuprep = cuprep / 2;

            label23.Text = seasonsRep(leaguerep, cuprep);

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            double leaguerep = double.Parse(textBox3.Text);
            double cuprep = double.Parse(textBox8.Text);

            leaguerep = leaguerep / 2;
            cuprep = cuprep / 2;

            label24.Text = seasonsRep(leaguerep, cuprep);
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            double leaguerep = double.Parse(textBox4.Text);
            double cuprep = double.Parse(textBox8.Text);

            leaguerep = leaguerep / 2;
            cuprep = cuprep / 2;

            label25.Text = seasonsRep(leaguerep, cuprep);
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            double leaguerep = double.Parse(textBox5.Text);
            double cuprep = double.Parse(textBox10.Text);

            leaguerep = leaguerep / 2;
            cuprep = cuprep / 2;

            label26.Text = seasonsRep(leaguerep, cuprep);
        }


        //updates team rep based on seasons rep and weighting
        private void label23_TextChanged(object sender, EventArgs e)
        {
            double r = double.Parse(label23.Text);
            r = r * 25 / 100;

            String x = r.ToString();
            label18.Text = x;
        }

        private void label24_TextChanged(object sender, EventArgs e)
        {
            double r = double.Parse(label24.Text);
            r = r * 20 / 100;

            String x = r.ToString();
            label19.Text = x;
        }

        private void label25_TextChanged(object sender, EventArgs e)
        {
            double r = double.Parse(label25.Text);
            r = r * 15 / 100;

            String x = r.ToString();
            label20.Text = x;
        }

        private void label26_TextChanged(object sender, EventArgs e)
        {
            double r = double.Parse(label26.Text);
            r = r * 10 / 100;

            String x = r.ToString();
            label21.Text = x;
        }

        private void label22_TextChanged(object sender, EventArgs e)
        {
            double r = double.Parse(label22.Text);
            r = r * 10 / 100;

            String x = r.ToString();
            label17.Text = x;
        }


        //loads the Db when form laods and populates the FA listbox
        private void formRepCalc_Load(object sender, EventArgs e)
        {

            this.fATableAdapter.Fill(this._90MFAppDataSet.FA);


        }


        //populates div list box based on the FA chosen
        private void populateDiv()
        {
            string query = "SELECT a.Division FROM div a " +
                "INNER JOIN FADiv b ON a.Id = b.divId " +
                "WHERE b.FAId = @FAId";

            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                command.Parameters.AddWithValue("@FAId", comboBox1.SelectedValue);

                DataTable divtab = new DataTable();
                adapter.Fill(divtab);



                //div combo box selector
                comboDiv.DisplayMember = "Division";
                comboDiv.ValueMember = "Id";
                comboDiv.DataSource = divtab;
            }
        }


        //populates div box based on fa selected
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            populateDiv();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            //todo
        }

        private void btncalc_Click(object sender, EventArgs e)
        {
            string fa = comboBox1.Text;
            string div = comboDiv.Text;
            string place = comboPos.Text;

            int pos = int.Parse(place);


            using (connection = new SqlConnection(connectionString))
            using (SqlDataAdapter adapt = new SqlDataAdapter( "SELECT * FROM FA" +
                  " WHERE Name = " + fa + " ", connection))
            {
                DataSet ds = new DataSet();
                adapt.Fill(ds);
                dataGridView1.DataSource = ds;
                dataGridView1.Refresh();
            }


        }


        //calculate button to add all the season reps together to make final predicted rep
        private void btnRep_Click(object sender, EventArgs e)
        {
            double a = double.Parse(label17.Text);
            double b = double.Parse(label18.Text);
            double c = double.Parse(label19.Text);
            double d = double.Parse(label20.Text);
            double f = double.Parse(label21.Text);

            double r = a + b + c + d + f;
            string x = r.ToString();
            label41.Text = x;
        }
    }
}
