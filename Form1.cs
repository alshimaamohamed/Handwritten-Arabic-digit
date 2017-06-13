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
    public partial class Form1 : Form
    {
        //MNIST Data set
      public static MNIST_Database _MnistTrainingDatabase;
      public  static MNIST_Database _MinstTestingDatabase;

        public Form1()
        {
            InitializeComponent();
            _MnistTrainingDatabase = new MNIST_Database();
            _MinstTestingDatabase = new MNIST_Database();
        }

        private void Read_Click(object sender, EventArgs e)
        {
            _MnistTrainingDatabase.LoadMinstFiles();
            _MinstTestingDatabase.LoadMinstFiles();
        }

        private void btn_Show_Click(object sender, EventArgs e)
        {
            Bitmap Bmap = new Bitmap(28, 28);
            int End = 28;
            int i = 0, j = 0, k = 0;
            byte PixelValue;
            ImagePattern IP = null;
            if (rdoBtn_TrainingSet.Checked)
                IP = _MnistTrainingDatabase.m_pImagePatterns[(int)(numericUpDown1.Value - 1)];
            else if (rdoBtn_TestingSet.Checked)
                IP = _MinstTestingDatabase.m_pImagePatterns[(int)(numericUpDown1.Value - 1)];
            while (i < 28)
            {
                k = 0;
                for (j = i * 28; j < End; j++)
                {
                    PixelValue = IP.pPattern[j];
                    if (chckBx_Threshold.Checked && PixelValue < 255)
                        PixelValue = 0;
                    Bmap.SetPixel(k, i, Color.FromArgb(PixelValue, PixelValue, PixelValue));
                    label1.Text = IP.nLabel.ToString();
                    k++;
                }
                i++;
                End = (i + 1) * 28;
            }
            pictureBox1.Image = (Image)Bmap;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f2=new Form2();
            f2.Show();

        }
    }
}
