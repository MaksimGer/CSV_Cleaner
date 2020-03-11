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

        char[] delimiters = { ',', ';', '|' };
        string[] types = { "String", "Integet", "Double", "Bool" };
        List<int> usedAttributes = new List<int>();
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

                dgvAttributes.Rows[rowNumber].Cells[0].Value = false;
                dgvAttributes.Rows[rowNumber].Cells[1].Value = header;

                attributes.Add(new MyAttribute(header));
            }

            int rowCount = reader.getRowCount() - 1;        // the reader started from the 1-st row 
                                                            // (the 0-th row is the headers)
                                                            // and stopes on the n-th rows(n = getRowCount() - 1)

            for (int i = 0; i < rowCount; i++)
            {
                string[] items = reader.getNextLine();
                int index = 0;

                try { 
                    foreach (string item in items)
                    {
                        attributes[index].addValue(item);           // filling List<Attribute> 

                        index++;
                    }
                }
                catch(ArgumentOutOfRangeException e)
                {
                    MessageBox.Show("В " + i + "строке элементов больше, чем в строке заголовков!" +
                        "\nПожалуйста проверьте символ разделения элементов!");
                    break;
                }
            }
        }

        private void cmbBoxSepar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (reader != null)
            {
                reader.refreshReader();
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
                attributes.Clear();

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
                showDataForm.StartPosition = FormStartPosition.CenterParent;
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
                showAttributeForm.StartPosition = FormStartPosition.CenterParent;
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
                string[] curLine;

                for (int i = 0; i < reader.getRowCount() - 1; i++)
                {
                    curLine = reader.getNextLine();   // считываем строку(получаем массив значений)

                    if (checkBoxDelMissVal.Checked) // удаляем строку, если есть пропуск
                    {
                        curLine = Cleaner.cleaningMissingValues(curLine, "N/A");   
                    }
                    if (checkBoxDelSingCases.Checked) // удаляем строку с единичным значением
                    {
                        fillUsedeAttr();
                        curLine = Cleaner.cleaningSingleCases(curLine, ref attributes, usedAttributes.ToArray());
                    }
                                        
                    writer.writeLine(curLine);                    
                }

                writer.closeWriter();
            }
            else
            {
                MessageBox.Show("Выберите исходный файл!");
            }
        }

        private void fillUsedeAttr()
        {
            usedAttributes.Clear();

            if (dgvAttributes.Rows.Count > 0)
            {
                for(int i = 0; i < dgvAttributes.Rows.Count - 1; i++)
                {
                    if ((bool)dgvAttributes.Rows[i].Cells[0].Value)
                    {
                        usedAttributes.Add(i);
                    }
                }
            }
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
