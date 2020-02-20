using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace proyecto
{
    class Csv
    {
        public static List<string[]> LeeCSV(string ruta)
        {
            var reader = new StreamReader(ruta);
            List<string[]> lista = new List<string[]>();
            var line = reader.ReadLine();
            string[] coma = new string[] { "," };
            string[] inicio = new string[] { ",\"" };
            string[] fin = new string[] { "\"," };
            int i = line.Split(coma, StringSplitOptions.None).Length;
            while (!reader.EndOfStream)
            {
                string[] linea = new string[i];
                line = reader.ReadLine();
                string[] temp2;
                string descripcion;
                int j = 0;
                if (line.Contains(",\"") && line.Contains("\","))
                {
                    string[] temp = line.Split(inicio, StringSplitOptions.None);
                    foreach (string tmp in temp[0].Split(coma, StringSplitOptions.None))
                    {
                        linea[j] = tmp;
                        j++;
                    }
                    descripcion = temp[1].Split(fin, StringSplitOptions.None)[0];

                    linea[j] = descripcion;
                    foreach (string tmp in temp[1].Split(fin, StringSplitOptions.None)[1].Split(coma, StringSplitOptions.None))
                    {
                        j++;
                        linea[j] = tmp;
                    }
                }
                else if (line.Contains(",\""))
                {
                    string[] temp = line.Split(inicio, StringSplitOptions.None);
                    descripcion = temp[1];
                    foreach (string tmp in temp[0].Split(coma, StringSplitOptions.None))
                    {
                        linea[j] = tmp;
                        j++;
                    }
                    if (temp.Length == 2)
                    {
                        foreach (var cadena in temp)
                        {
                            descripcion += cadena;
                        }
                        while (!reader.EndOfStream)
                        {
                            var line2 = reader.ReadLine();
                            if (line2.Contains("\","))
                            {
                                temp2 = line2.Split(fin, StringSplitOptions.None);
                                descripcion += temp2[0];
                                linea[j] = descripcion;
                                foreach (string tmp in temp2[1].Split(coma, StringSplitOptions.None))
                                {
                                    j++;
                                    linea[j] = tmp;
                                }
                                break;
                            }
                        }
                    }
                }
                else
                {
                    if (line.Split(coma, StringSplitOptions.RemoveEmptyEntries).Length != 0)
                        linea = line.Split(coma, StringSplitOptions.None);
                }
                if (linea.Length == i)
                    lista.Add(linea);
            }
            return lista;
        }
    }

}