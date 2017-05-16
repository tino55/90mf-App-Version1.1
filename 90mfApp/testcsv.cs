using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _90mfApp
{
    public partial class testcsv : Form
    {
        SqlConnection connection;
        string connectionString;

        public testcsv()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["_90mfApp.Properties.Settings._90MFAppConnectionString"].ConnectionString;

        }


        private void button1_Click(object sender, EventArgs e)
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

                //ReadCSV temp = new ReadCSV();
                //temp.importcsv(openFileDialog1.FileName);

                Act();

                //populates datagridview1 with whats on the sql table
                using(connection = new SqlConnection(connectionString))
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



        /*
         * 
         * TEST METHOD TO IMPORT CSV FILE
         * 
         * HAD A PROBLEM WITH FILEDS WITH QUOTES
         * 
         * */
        //CSV FILE IMPORT TO DATAGRID
        /*var parsedData = new List<string[]>();
        using (var sr = new StreamReader(openFileDialog1.FileName))
        {
            string line;
            while ((line = sr.ReadLine()) != null)
            {
                string[] row = line.Split(',');
                parsedData.Add(row);
            }
        }

        dataGridView1.ColumnCount = 82;
        for (int i = 0; i < 82; i++)
        {
            var sb = new StringBuilder(parsedData[0][i]);
            sb.Replace('_', ' ');
            sb.Replace("\"", "");
            dataGridView1.Columns[i].Name = sb.ToString();
        }

        foreach (string[] row in parsedData)
        {
            dataGridView1.Rows.Add(row);
        }

        dataGridView1.Rows.Remove(dataGridView1.Rows[0]);*/






            //METHOD TO READ THE CSV FILE BEFORE WRITING TO THE TXT FILE
        private void Act()
        {

            TextFieldParser parser = new TextFieldParser(openFileDialog1.FileName);

            parser.HasFieldsEnclosedInQuotes = false;
            parser.SetDelimiters(",");

            DataTable ds = new DataTable();

            string[] fields;
            dataGridView1.ColumnCount = 82;

            while (!parser.EndOfData)
                {
                    fields = parser.ReadFields();

                    foreach (string field in fields)
                        {
                    if (!ds.Columns.Contains("0"))
                    {
                        ds.Columns.Add(field);
                    }

                    }
                }
            dataGridView1.DataSource = ds;
            
        }


        private void testgrid()
        {
            //to do write code to display player table into the datagridview1
        }


        
        



            }
        
    }

