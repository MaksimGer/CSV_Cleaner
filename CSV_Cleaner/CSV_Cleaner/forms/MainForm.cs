using CSV_Cleaner.forms;
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

namespace CSV_Cleaner
{
    public partial class MainForm : Form
    {
        Reader reader;
        Writer writer;

        char[] delimiters = { ';', ',', '|' };
        string[] types = { "String", "Integet", "Double", "Bool" };
        List<MyAttribute> attributes = new List<MyAttribute>();

        public MainForm()
        {
            InitializeComponent();

            foreach (char item in delimiters)
            {
                cmbBoxDelimiter.Items.Add(item);
            }

            cmbBoxDelimiter.SelectedIndex = 0;
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)  // open file
        {
            OpenFileDialog ofd = new OpenFileDialog();

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                reader = new Reader(ofd.FileName);
                lblFileName.Text = reader.getFilePath();
                
                clearTable();
            }
        }

        private void fillTable()   // fill DataGridView
        {
            dgvAttributes.Rows.Clear();

            List<string> headers = reader.getHeaders();

            typeCol.Items.AddRange(types.ToArray());
            showInfoCol.Text = "Инфо";
            showInfoCol.UseColumnTextForButtonValue = true;

            int rowNumber;                                     

            foreach (string header in headers)
            {
                rowNumber = dgvAttributes.Rows.Add();

                dgvAttributes.Rows[rowNumber].Cells[0].Value = true;
                dgvAttributes.Rows[rowNumber].Cells[1].Value = header;

                attributes.Add(new MyAttribute(header));
            }

            for (int i = 0; i < reader.getRowCount() - 1; i++)  // the reader started from the 1-st row 
                                                                // (the 0-th row is the headers)
                                                                // and stopes on the n-th rows(n = getRowCount() - 1)
            {
                string[] items = reader.getNextLine();
                int index = 0;

                foreach (string item in items)
                {
                    attributes[index].addValue(item);           // filling List<Attribute> 

                    index++;
                }
            }
        }

        private void cmbBoxSepar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (reader != null)
            {
                reader.refreshReader();
                fillTable();
            }
        }

        private void clearTable()
        {
            dgvAttributes.Rows.Clear();
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            if(reader != null && reader.getFilePath() != null)
            {
                reader.setDelimiter(delimiters[cmbBoxDelimiter.SelectedIndex]);
                reader.refreshReader();
                clearTable();

                fillTable();
            }
            else
            {
                MessageBox.Show("Файл не выбран!");
            }
        }

        private void btnShowTable_Click(object sender, EventArgs e)
        {
            if (reader != null && reader.getFilePath() != null)
            {
                ShowDataForm showDataForm = new ShowDataForm(this, ref reader);
                showDataForm.Show();
            }
            else
            {
                MessageBox.Show("Файл не выбран!");
            }
        }

        private void dgvAttributes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                ShowAttributeForm showAttributeForm = new ShowAttributeForm(attributes[e.RowIndex]);
                showAttributeForm.Show();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (reader != null && reader.getFilePath() != null)
            {
                reader.refreshReader();
                SaveFileDialog sfd = new SaveFileDialog();

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    writer = new Writer(sfd.FileName);
                }

                writer.writeLine(reader.getHeaders().ToArray());

                for (int i = 0; i < reader.getRowCount() - 1; i++)
                {
                    // --------------------- Add cleaning functions ---------------------
                    //
                    //  if(checkBoxSomeMethod.Checked){
                    //      writer.writeLine(cleaner.someMethod(reader.getNextLine()))
                    //  }
                    writer.writeLine(reader.getNextLine()); 
                }

                writer.closeWriter();
            }
            else
            {
                MessageBox.Show("Выберите исходный файл!");
            }
        }
    }
}
