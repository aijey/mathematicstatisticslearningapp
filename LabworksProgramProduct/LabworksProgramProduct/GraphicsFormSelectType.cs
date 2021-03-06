﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabworksProgramProduct
{
    public partial class GraphicsFormSelectType : Form
    {
        public GraphicsFormSelectType()
        {
            InitializeComponent();
        }

        private void ButtonManual1_Click(object sender, EventArgs e)
        {
            var form = new AskingFormDataSource(AskingForms.VariantRow, Forms.GraphicsTasksForm);
            form.Show();
            Close();
        }

        private void ButtonManualStatic_Click(object sender, EventArgs e)
        {
            var form = new AskingFormDataSource(AskingForms.StatisticDistr, Forms.GraphicsTasksForm);
            form.Show();
            Close();
        }

        private void ButtonManualInterval_Click(object sender, EventArgs e)
        {
            var form = new AskingFormDataSource(AskingForms.IntervalDistr, Forms.GraphicsTasksForm);
            form.Show();
        }

        private void ButtonStaticFromFile_Click(object sender, EventArgs e)
        {
            var form = new AskingFormDataSource(AskingForms.StatisticDistrFromFile, Forms.GraphicsTasksForm);
            Close();
        }
    }
}
