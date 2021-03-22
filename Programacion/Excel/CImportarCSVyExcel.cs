using Microsoft.VisualBasic.FileIO;
using MultiFashion.Programacion.Utilerias;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiFashion.Programacion
{
    class CImportarCSVyExcel
    {
        public string GetFileName()
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Title = "Select file";
            openFile.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            openFile.Filter = "CSV(*.csv)|*.csv|All Files(*.*)|*.*";
            openFile.FilterIndex = 1;
            openFile.Multiselect = false;
            openFile.RestoreDirectory = true;
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                return openFile.FileName;
            }
            return "";
        }

        public DataTable ImportarCSV(string FileName)
        {
            DataTable result = new DataTable();
            try
            {
                string delimiters = ",";
                string extension = Path.GetExtension(FileName);
                bool firstRowContainsFieldNames = true;

                if (extension.ToLower() == "txt")
                    delimiters = "\t";
                else if (extension.ToLower() == "csv")
                    delimiters = ",";

                //string file = File.ReadAllText(FileName, Encoding.Unicode);

                using (TextFieldParser tfp = new TextFieldParser(FileName))
                {
                    
                    tfp.SetDelimiters(delimiters);

                    // Get The Column Names
                    if (!tfp.EndOfData)
                    {
                        string[] fields = tfp.ReadFields();

                        for (int i = 0; i < fields.Count(); i++)
                        {
                            if (firstRowContainsFieldNames)
                                result.Columns.Add(fields[i]);
                            else
                                result.Columns.Add("Col" + i);
                        }

                        // If first line is data then add it
                        if (!firstRowContainsFieldNames)
                            result.Rows.Add(fields);
                    }

                    // Get Remaining Rows from the CSV
                    while (!tfp.EndOfData)
                    {
                        result.Rows.Add(tfp.ReadFields());
                    }
                }
                return result;
            }
            catch(Exception ex)
            {
                CMsgBox.DisplayError($"Archivo invalido o imposible de leer \n Mensaje: \n {ex}");
            }
            return result;
        }
    }
}
