using CSV_Cleaner.sources;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSV_Cleaner.forms
{
    public partial class ShowDataForm : Form
    {
        MainForm mainForm;
        Reader reader;

        public ShowDataForm()
        {
            InitializeComponent();
        }

        public ShowDataForm(MainForm mainForm, ref Reader reader)
        {
            this.mainForm = mainForm;
            this.reader = reader;
            this.reader.refreshReader();
            InitializeComponent();
            fillTable();
        }

        private void ShowDataForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            mainForm.Show();
        }

        private void fillTable()
        {
            int rowCount = reader.getRowCount() - 1;
            List<string> headers = reader.getHeaders();

            foreach (string header in headers)
            {
                DataGridViewTextBoxColumn newCol = new DataGridViewTextBoxColumn();
                newCol.Name = header + "Col";
                newCol.HeaderText = header;
                dgvDataset.Columns.Add(newCol);
            }

            for (int i = 0; i < rowCount; i++)
            {
                int rowNumber = dgvDataset.Rows.Add();

                string[] items = reader.getNextLine();
                int index = 0;
                foreach (string item in items)
                {
                    dgvDataset.Rows[rowNumber].Cells[index].Value = item;

                    index++;
                }
            }
        }
    }
}
