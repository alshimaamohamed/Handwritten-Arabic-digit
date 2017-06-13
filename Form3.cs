using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ReadingMNISTDatabase
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            //=============================================================================
            double digonal = 0, finalTotal = 0;
            double[] total1 = new double[10];
            DataGridViewRow data;
            for (int j = 1; j <= 10; j++)
            {

                 data = (DataGridViewRow)dataGridView1.Rows[j - 1].Clone();

                data.Cells[0].Value = "classs "+(j - 1);
                double total = 0;
                for (int i = 0; i < 10; i++)
                {
                    if (i == (j - 1))
                        digonal += Form2.Confusin_Matrix[j - 1, i];
                    total += Form2.Confusin_Matrix[j - 1, i];
                    total1[i] += Form2.Confusin_Matrix[j - 1, i];
                    data.Cells[i + 1].Value = Form2.Confusin_Matrix[j - 1, i];
                }
                finalTotal += total;
                data.Cells[11].Value = total;
                dataGridView1.Rows.Add(data);
            }
            data = (DataGridViewRow)dataGridView1.Rows[10].Clone();
            data.Cells[0].Value = "total";
            for (int l = 1; l <= 10; l++) 
            data.Cells[l].Value=total1[l-1];
            data.Cells[11].Value = finalTotal;
            dataGridView1.Rows.Add(data);

            //====================================================================
            double overallAcc =Math.Round((digonal / finalTotal) * 100);
            label1.Text = "Overall Accuracy= " + overallAcc.ToString() + " % ";
        }
    }
}
