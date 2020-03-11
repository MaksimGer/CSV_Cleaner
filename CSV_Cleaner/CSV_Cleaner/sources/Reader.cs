using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSV_Cleaner.sources
{
    public class Reader
    {
        private string filePath;
        private TextFieldParser csvParser;
        private char delimiter = ';';
        private List<string> headers = new List<string>();
        private int rowCount = 0;

        public Reader(string filePath)
        {
            this.filePath = filePath;
        }

        public string getFilePath() { return filePath; }

        public char getDelimiter() { return delimiter; }

        public List<string> getHeaders() { return headers; }

        public int getCountParams() { return headers.Count(); }

        public bool setFilePath(string filePath)
        {
            if (!this.filePath.Equals(filePath))
            {
                this.filePath = filePath;
                rowCount = 0;

                return createCSVParser();
            }
            return false;
        }

        public void setDelimiter(char delimiter)
        {
            this.delimiter = delimiter;
            setHeaders();
        }

        private void setHeaders()
        {
            if (headers.Any())
            {
                headers.Clear();
            }

            using (TextFieldParser tfpHeader = new TextFieldParser(filePath))
            {
                tfpHeader.SetDelimiters(delimiter.ToString());
                tfpHeader.HasFieldsEnclosedInQuotes = true;

                string[] headers = tfpHeader.ReadFields();
                if(headers.Length > 0)
                {
                    foreach (string header in headers)
                    {
                        this.headers.Add(header);
                    }
                }
            }
        }

        public string[] getNextLine()
        {
            if (!csvParser.EndOfData)
            {
                return csvParser.ReadFields();
            }

            refreshReader();
            return null;
        }

        public void refreshReader()
        {
            closeCSVParser();
            createCSVParser();
            setHeaders();
        }

        public int getRowCount()
        {
            if (rowCount == 0)
            {
                using (TextFieldParser tfpRowCount = new TextFieldParser(filePath))
                {
                    while (!tfpRowCount.EndOfData)
                    {
                        tfpRowCount.ReadLine();
                        rowCount++;
                    }
                }
            }

            return rowCount;
        }

        private bool createCSVParser()
        {
            if (!String.IsNullOrEmpty(filePath))
            {
                try
                {
                    csvParser = new TextFieldParser(filePath);
                    csvParser.SetDelimiters(delimiter.ToString());
                    csvParser.HasFieldsEnclosedInQuotes = true;

                    csvParser.ReadLine();
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

        public void closeCSVParser()
        {
            if (csvParser != null)
            {
                csvParser.Close();
            }
        }
    }
}
