using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSV_Cleaner.sources
{
    public class Writer
    {
        private string filePath;
        private char delimiter = ';';
        private StreamWriter streamWriter;

        public Writer(string filePath)
        {
            this.filePath = filePath;
            createWriter();
        }

        public void setDelimiter(char delimiter) { this.delimiter = delimiter; }

        public bool setFilePath(string filePath)
        {
            if (!this.filePath.Equals(filePath))
            {
                this.filePath = filePath;

                return createWriter();
            }

            return false;
        }

        private bool createWriter()
        {
            if (!String.IsNullOrEmpty(filePath))
            {
                try
                {
                    streamWriter = new StreamWriter(filePath);
                    return true;
                }
                catch (FileNotFoundException e)
                {
                    Console.Write("File: " + e.FileName + " not found!");
                    filePath = null;
                }
            }
            return false;
        }

        public void writeLine(string line)
        {
            streamWriter.WriteLine(line);
        }

        public void writeLine(string[] attributes)
        {
            if(attributes != null && attributes.Length > 0)
            {
                StringBuilder line = new StringBuilder(180);

                foreach (string attribute in attributes)
                {
                    line.Append(attribute + delimiter);
                }

                line.Remove(line.Length - 1, 1);                    

                streamWriter.WriteLine(line);
            }
        }

        public void closeWriter()
        {
            if (streamWriter != null)
            {
                streamWriter.Close();
            }
        }
    }
}
