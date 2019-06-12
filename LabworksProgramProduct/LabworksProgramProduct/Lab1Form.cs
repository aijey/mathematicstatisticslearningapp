﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

namespace LabworksProgramProduct
{
    
    public partial class Lab1Form : Form
    {
        public Lab1Form()
        {
            InitializeComponent();

            Controls.Remove(panel1);
            Controls.Remove(panel2);
            Controls.Remove(panel3);
            InitializeComponents();
            
            ResizeForm();
        }
        private void Lab1Form_Resize(object sender, EventArgs e)
        {
            ResizeForm();
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            var form = new AskingFormDataSource("Варіаційний ряд");
            form.Show();
        }

        private void Lab1Form_Shown(object sender, EventArgs e)
        {
            VerticalScroll.Value = VerticalScroll.Minimum;
            ResizeForm();
            VerticalScroll.Value = VerticalScroll.Minimum;
            VerticalScroll.Value = VerticalScroll.Minimum;
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            var form = new AskingFormDataSource("Статистичний розподіл відносних частот");
            form.Show();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            var form = new AskingFormDataSource("Статистичний розподіл накопичуваних частот");
            form.Show();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            var form = new AskingFormDataSource("Статистичний розподіл відносних накопичуваних частот");
            form.Show();
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            var form = new AskingFormDataSource("Полігон частот");
            form.Show();
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            var form = new AskingFormDataSource("Полігон відносних частот");
            form.Show();
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            var form = new AskingFormDataSource("Емпірична функція розподілу");
            form.Show();
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            var form = new AskingFormDataSource("Емпірична функція розподілу");
            form.Show();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Oemplus)
            {
                //CurrentZoom += 5;
                ResizeForm();
                
            }
            if (e.KeyCode == Keys.OemMinus)
            {
               
               // CurrentZoom -= 5;
                ResizeForm();
                
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            var form = new AskingFormDataSource("Статистичний розподіл");
            form.Show();
        }

       
        private void Lab1Form_Load(object sender, EventArgs e)
        {
            ResizeForm();
        }

        private void Lab1Form_Scroll(object sender, ScrollEventArgs e)
        {
            leftPanel.Location = new Point(0, 0);
        }

        private void Lab1Form_MouseWheel1(object sender, MouseEventArgs e)
        {
            leftPanel.Location = new Point(0, 0);
        }
    }
}
