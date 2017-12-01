using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace ExportHelper.FileReader
{
    public class CSVReader
    {
        private List<string> sourceFile;
        private static CSVReader _instance = null;

        protected  CSVReader()
        {
            sourceFile = new List<string>();
        }

        public static CSVReader Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new CSVReader();
                return _instance;
            }
        }

        public List<string> SourceFile(string path)
        {
            try
            {
                using (var reader = new StreamReader(path))
                {
                    while(!reader.EndOfStream)
                    {
                        var line = reader.ReadLine();
                        var values = line.Split(';');
                        sourceFile.Add(values[0]);
                    }
                }
            }
            catch(IOException ex)
            {
                MessageBox.Show(null,ex.Message,null,MessageBoxButtons.OK);
            }
            
            return sourceFile;
        }
    }
}
