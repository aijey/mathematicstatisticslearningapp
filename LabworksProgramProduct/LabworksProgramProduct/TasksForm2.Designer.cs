﻿namespace LabworksProgramProduct
{
    partial class TasksForm2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(61, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(430, 37);
            this.label1.TabIndex = 10;
            this.label1.Text = "Оберіть одну з заданих опцій";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(26, 69);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(245, 54);
            this.button2.TabIndex = 12;
            this.button2.Text = "Показати задану кореляційну таблицю";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(26, 129);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(245, 54);
            this.button1.TabIndex = 13;
            this.button1.Text = "Знайти статистичний розподіл варіант x";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(26, 189);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(245, 54);
            this.button3.TabIndex = 14;
            this.button3.Text = "Знайти статистичний розподіл варіант y";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(26, 249);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(496, 54);
            this.button4.TabIndex = 15;
            this.button4.Text = "Знайти вибіркові середні, вибіркові середньоквадратичні відхилення варіант х та у" +
    ", вибірковий коефіцієнт кореляції та вибіркове рівняння регресії";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(277, 129);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(245, 54);
            this.button5.TabIndex = 16;
            this.button5.Text = "Знайти розподіли умовних середніх варіант х";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.Button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(277, 189);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(245, 54);
            this.button6.TabIndex = 17;
            this.button6.Text = "Знайти розподіли умовних середніх варіант у";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.Button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(277, 69);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(245, 54);
            this.button7.TabIndex = 18;
            this.button7.Text = "Побудувати емпіричну ламану функцію розподілу";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.Button7_Click);
            // 
            // TasksForm2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 326);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Name = "TasksForm2";
            this.Text = "Оберіть завдання";
            this.Load += new System.EventHandler(this.TasksForm2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
    }
}