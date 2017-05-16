using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.FileIO;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace _90mfApp
{
    class ReadCSV
    {
        SqlConnection connection; 
        string connectionString;
        DataTable importedData = new DataTable();


        public void importcsv(string file)
        {
            using(TextFieldParser parser = new TextFieldParser(file))
                {

                parser.TextFieldType = FieldType.Delimited;
                parser.HasFieldsEnclosedInQuotes = false;
                parser.SetDelimiters(",");
                parser.TrimWhiteSpace = true;

                string[] fields;

               
                while (parser.PeekChars(1) !=null)
                {
                    fields = parser.ReadFields();
                    
                        foreach (string field in fields)
                        {
                            importedData.Columns.Add(field);
                        }
                        
                    
                }
            }

            
            sqlImport();
        }


            private void sqlImport()
        {
            connectionString = ConfigurationManager.ConnectionStrings["_90mfApp.Properties.Settings._90MFAppConnectionString"].ConnectionString;

            using (connection = new SqlConnection(connectionString))
            {
                connection.Open();
                                
                using (SqlBulkCopy bulkcopy = new SqlBulkCopy(connection))
                {
                    bulkcopy.DestinationTableName = "dbo.Player";

                    try
                    {
                        // Write from the source to the destination.
                        bulkcopy.WriteToServer(importedData);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                }
            }

        }

        }

}

