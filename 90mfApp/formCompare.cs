using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using Microsoft.VisualBasic.FileIO;

namespace _90mfApp
{
    public partial class formCompare : Form
    {
        SqlConnection connection;
        string connectionString;

        public formCompare()
        {
            InitializeComponent();

            connectionString = ConfigurationManager.ConnectionStrings["_90mfApp.Properties.Settings._90MFAppConnectionString"].ConnectionString;
        }


        private void formCompare_Load(object sender, EventArgs e)
        {
            
            populatecombobox();
        }



        private void btnimport1_Click(object sender, EventArgs e)
        {

            //file chooser
            int size = -1;
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                string file = openFileDialog1.FileName;
                string filePath = Path.GetDirectoryName(file);

                try
                {
                    string text = File.ReadAllText(file);
                    size = text.Length;
                }
                catch (IOException)
                {
                    MessageBox.Show("There was an error reading the file");
                }


                //sends opf filename to ReadCSV
                ReadCSV temp = new ReadCSV();
                temp.importcsv(openFileDialog1.FileName);


                //imports the data to a datatable
                DataTable importedData = new DataTable();

                TextFieldParser parser = new TextFieldParser(openFileDialog1.FileName);

            parser.HasFieldsEnclosedInQuotes = true;
            parser.SetDelimiters(",");

            string[] fields;

            bool firstline = true;
            while (!parser.EndOfData)
            {
                fields = parser.ReadFields();
                if (firstline)
                {
                    foreach (string field in fields)
                    {
                        importedData.Columns.Add(field);
                    }
                    firstline = false;

                    continue;
                }
            }

                dataGridView1.DataSource = importedData;


                //refreshes combolist
            populatecombobox();


                //connects to sql server and fills 2nd datagrid
                using (connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter("select * from Player", connection);
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    dataGridView2.DataSource = ds.Tables[0];
                    dataGridView2.Refresh();
                }
            }
        }



        //populates the combobox with names of players in the sql server
            private void populatecombobox()
        {
            using (connection = new SqlConnection(connectionString))
                using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Player", connection))
            {
                DataTable p1 = new DataTable();
                adapter.Fill(p1);

               //combobox1 populate
                comboP1.DisplayMember = "Last_Name";
                comboP1.ValueMember = "Player_Link";
                comboP1.DataSource = p1;

                //combobox2 populate
                comboP2.DisplayMember = "Last_Name";
                comboP2.ValueMember = "Player_Link";
                comboP2.DataSource = p1;
            }
        }

    }
}
