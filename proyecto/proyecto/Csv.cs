using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Microsoft.VisualBasic.FileIO;

namespace proyecto
{
    class Csv
    {
        public static List<string[]> LeeCSV(string path)
        {
            List<string[]> lista = new List<string[]>();
            TextFieldParser parser = new TextFieldParser(path);
            parser.SetDelimiters(",");
            parser.HasFieldsEnclosedInQuotes = true;            
            int j = 0;
            while (!parser.EndOfData)
            {
                var fields = parser.ReadFields();
                string[] arrayLinea = new string[fields.Length];
                foreach (var item in fields)
                {
                    arrayLinea[j] = item;
                    j++;
                    if (j == fields.Length)
                    {
                        lista.Add(arrayLinea);
                        j = 0;
                    }
                }
            }
            parser.Close();
            return lista;
        }
    }

}
