using CsvHelper;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RW_CSV
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string directoryName = "\\CSV Test";
            string absolutePath = path + directoryName;

            if (!Directory.Exists(absolutePath))
            {
                var res = Directory.CreateDirectory(absolutePath);
                List<string> lst = new List<string>();
                lst.Add("Deneme1");
                lst.Add("Deneme2");
                lst.Add("Deneme3");
                lst.Add("Deneme4");
                lst.Add("Deneme5");
                lst.Add("Deneme6");
                using (var textWriter = new StreamWriter(absolutePath+"\\"+DateTime.Now.ToShortDateString()+".csv"))
                {
                    var writer = new CsvWriter(textWriter);
                    writer.Configuration.Delimiter = ",";

                    foreach (var item in lst)
                    {
                        writer.WriteField(item);
                        writer.WriteField(item);
                        writer.WriteField(item);
                        writer.WriteField(item);
                        writer.NextRecord();
                    }
                }

            }
            else
            {
                List<string> lst = new List<string>();
                lst.Add("Deneme1");
                lst.Add("Deneme2");
                lst.Add("Deneme3");
                lst.Add("Deneme4");
                lst.Add("Deneme5");
                lst.Add("Deneme6");
                using (var textWriter = new StreamWriter(absolutePath + "\\" + DateTime.Now.ToShortDateString() + ".csv"))
                {
                    var writer = new CsvWriter(textWriter);
                    writer.Configuration.Delimiter = ",";

                    foreach (var item in lst)
                    {
                        writer.WriteField(item);
                        writer.WriteField(item);
                        writer.WriteField(item);
                        writer.WriteField(item);
                        writer.NextRecord();
                    }
                }
            }
        }
    }
}
