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
    public partial class ShowAttributeForm : Form
    {
        private MyAttribute attribute;

        public ShowAttributeForm()
        {
            InitializeComponent();
        }

        public ShowAttributeForm(MyAttribute attribute)
        {
            this.attribute = attribute;
            InitializeComponent();
            fillTable();
        }

        private void fillTable()
        {
            if(attribute != null)
            {
                lblAttrName.Text = attribute.getName();
                lblUnicCases.Text = attribute.getCountValues().ToString();

                int rowNumber;

                Dictionary<string, int> a = attribute.getValues();

                foreach(string value in attribute.getValues().Keys)
                {
                    rowNumber = dgvShowAttr.Rows.Add();
                    dgvShowAttr.Rows[rowNumber].Cells[0].Value = value;
                    dgvShowAttr.Rows[rowNumber].Cells[1].Value = attribute.getCountValue(value);
                }
            }
        }
    }
}
