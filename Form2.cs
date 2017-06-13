using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.IO;

namespace ReadingMNISTDatabase
{
    public partial class Form2 : Form
    {

        public FileStream[] f = new FileStream[10];

        public FileStream fp;
       
        List<List<double>> zero = new List<List<double>>();
        List<List<double>> one = new List<List<double>>();
        List<List<double>> two = new List<List<double>>();
        List<List<double>> three = new List<List<double>>();
        List<List<double>> four = new List<List<double>>();
        List<List<double>> five = new List<List<double>>();
        List<List<double>> six = new List<List<double>>();
        List<List<double>> seven = new List<List<double>>();
        List<List<double>> eight = new List<List<double>>();
        List<List<double>> nine = new List<List<double>>();
        ImagePattern p;
        List<double> temp;
        public const int num_of_features = 28 * 28;
        public const int num_of_classes = 10;
        public static double[,] Confusin_Matrix = new double[10, 10];




        //==================================================================
        public Form2()
        {
            InitializeComponent();
        }
        //===============================================================
        public double[] GetMean(List<List<double>> l)
        {
            int num_of_samples = l.Count();
            double[] Mean = new double[num_of_features];
         
            for (int j = 0; j < num_of_features; j++)
            {
               for (int i = 0; i < num_of_samples; i++)
               {
                   Mean[j] += l[i][j];
               }
            }
                for (int k = 0; k < num_of_features; k++)
                    Mean[k] = Mean[k] / num_of_samples;
            
            return Mean;

        }
        //==========================================================
        public double[] Getvariance(List<List<double>> l, double[] mean)
        {
            int num_of_samples = l.Count();
            double[] variance = new double[num_of_features];
            for (int i = 0; i < num_of_features; i++) //28 * 28 
            {
                for (int k = 0; k < num_of_samples; k++) //
                {
                    variance[i] += (l[k][i] - mean[i]) * (l[k][i] - mean[i]);
                }
            }
            for (int k = 0; k < num_of_features; k++)
                variance[k] = variance[k] /( num_of_samples-1);
            return variance;
        }
        //======================================================================================


        private void button2_Click(object sender, EventArgs e)
        {
            if (!(File.Exists("0.txt")))
            {
               
                for (int i = 0; i < num_of_classes; i++)
                {
                    f[i] = new FileStream(i + ".txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);

                }

                for (int j = 0; j < Form1._MnistTrainingDatabase.m_pImagePatterns.Count(); j++) //60000 images
                {
                    p = Form1._MnistTrainingDatabase.m_pImagePatterns[j];

                    temp = new List<double>();
                    for (int i = 0; i < p.pPattern.Count(); i++)
                    {
                        if (p.pPattern[i]>=8)
                            temp.Add(0);
                        else
                            temp.Add(255);
                       
                    }

                    if (p.nLabel == 0)
                        zero.Add(temp);
                    else if (p.nLabel == 1)
                        one.Add(temp);
                    else if (p.nLabel == 2)
                        two.Add(temp);
                    else if (p.nLabel == 3)
                        three.Add(temp);
                    else if (p.nLabel == 4)
                        four.Add(temp);
                    else if (p.nLabel == 5)
                        five.Add(temp);
                    else if (p.nLabel == 6)
                        six.Add(temp);
                    else if (p.nLabel == 7)
                        seven.Add(temp);
                    else if (p.nLabel == 8)
                        eight.Add(temp);
                    else
                        nine.Add(temp);
                }
                fp = new FileStream("Prior.txt", FileMode.OpenOrCreate, FileAccess.Write);
                StreamWriter s = new StreamWriter(fp);
               
                s.WriteLine((double)zero.Count() / 60000);
                s.WriteLine((double)one.Count() / 60000);
                s.WriteLine((double)two.Count() / 60000);
                s.WriteLine((double)three.Count() / 60000);
                s.WriteLine((double)four.Count() / 60000);
                s.WriteLine((double)five.Count() / 60000);
                s.WriteLine((double)six.Count() / 60000);
                s.WriteLine((double)seven.Count() / 60000);
                s.WriteLine((double)eight.Count() / 60000);
                s.WriteLine((double)nine.Count() / 60000);
                s.Close();
                //========================================================================================================
                for (int i = 0; i < num_of_classes; i++)
                {
                    double[] mean = new double[num_of_features];
                    double[] variance = new double[num_of_features];
                    if (i == 0)
                    {
                        mean = GetMean(zero);
                        variance = Getvariance(zero, mean);
                    }
                    if (i == 1)
                    {
                        mean = GetMean(one);
                        variance = Getvariance(one, mean);
                    }
                    if (i == 2)
                    {
                        mean = GetMean(two);
                        variance = Getvariance(two, mean);
                    }
                    if (i == 3)
                    {
                        mean = GetMean(three);
                        variance = Getvariance(three, mean);
                    }
                    if (i == 4)
                    {
                        mean = GetMean(four);
                        variance = Getvariance(four, mean);
                    }
                    if (i == 5)
                    {
                        mean = GetMean(five);
                        variance = Getvariance(five, mean);
                    }
                    if (i == 6)
                    {
                        mean = GetMean(six);
                        variance = Getvariance(six, mean);
                    }
                    if (i == 7)
                    {
                        mean = GetMean(seven);
                        variance = Getvariance(seven, mean);
                    }
                    if (i == 8)
                    {
                        mean = GetMean(eight);
                        variance = Getvariance(eight, mean);
                    }
                    if (i == 9)
                    {
                        mean = GetMean(nine);
                        variance = Getvariance(nine, mean);
                    }
                    StreamWriter sw = new StreamWriter(f[i]);
                    for (int l = 0; l < num_of_features; l++)
                    {
                        sw.Write(mean[l] + " ");
                    }
                    sw.WriteLine();
                    for (int m = 0; m < num_of_features; m++) //28*28
                    {
                        sw.Write(variance[m] + " ");
                    }
                    sw.WriteLine();
                    sw.Close();
                }

                MessageBox.Show("Estimation finished");

            }
            else
                MessageBox.Show("Estimation already finished");
            //==============================================================================
        }
        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < num_of_classes; i++)
            {
                f[i] = new FileStream(i + ".txt", FileMode.OpenOrCreate, FileAccess.Read);

            }

            double[] Prior = new double[num_of_classes];
            fp = new FileStream("Prior.txt", FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader ss = new StreamReader(fp);

            for (int i = 0; i < num_of_classes; i++)
            {
                string str = ss.ReadLine();
                Prior[i] = double.Parse(str);
            }
            ss.Close();
           
            //======================================
            //mean
            double[,] Mean = new double[num_of_classes, num_of_features];
            //variance
            double[,] Variance = new double[num_of_classes, num_of_features];


            for (int i = 0; i < num_of_classes; i++)
            {
                StreamReader sr = new StreamReader(f[i]);
                string str = sr.ReadLine();
                string[] filed = str.Split(' '); // 784  of label i

                for (int j = 0; j < num_of_features; j++)
                    Mean[i, j] = double.Parse(filed[j]);


                //========================================get variance from file

                str = sr.ReadLine();
                filed = str.Split(' '); // 784  of label i

                for (int j = 0; j < num_of_features; j++)
                    Variance[i, j] = double.Parse(filed[j]);
                sr.Close();

            }
            int count = 0;
            try
            {
                count = int.Parse(textBox1.Text.ToString());
            }
            catch
            {          
                MessageBox.Show("Enter Number of classification !! ");
            }
            if (count > Form1._MinstTestingDatabase.m_pImagePatterns.Count())
                MessageBox.Show("error"+count + " is greater than Form1._MinstTestingDatabase.m_pImagePatterns.Count()");
            for (int j = 0; j < count; j++)
            {
                DataGridViewRow data = (DataGridViewRow)dataGridView1.Rows[j].Clone();

                data.Cells[0].Value = j+1;
                p = Form1._MinstTestingDatabase.m_pImagePatterns[j];
                double[] Likelihood = new double[num_of_classes];
                double[] Posterior = new double[num_of_classes];
                double Evidence=0;
                for(int i=0;i<10;i++)
                    Likelihood[i] = 1;
                for (int k = 0; k < 10; k++)
                {
                    for (int l = 0; l < num_of_features; l++) //784
                    {
                        int x;
                        if (p.pPattern[l] >= 8)  // threshold 
                            x = 0;
                        else
                            x = 255;
                        if (x != 0)
                        {
                            if (Variance[k, l] != 0)
                            {
                                Likelihood[k] *= (1 / Math.Sqrt(2 * Math.PI * Variance[k, l])) * (Math.Exp(-0.5 * (Math.Pow(x - Mean[k, l], 2) * (1 / Variance[k, l]))));
                            }
                        }

                    }
                }


                for (int m = 0; m < num_of_classes; m++)
                {
                    Evidence += (Likelihood[m] * Prior[m]);
                }
             for (int m = 0; m < num_of_classes; m++)
                {
                    Posterior[m] = (Likelihood[m] * Prior[m])/Evidence;
                          
                }
                //get max Posterior 
                double MaxgOfX = Posterior[0];
                int maxindex = 0;
                for (int i = 1; i < num_of_classes; i++)
                {
                    if (MaxgOfX < Posterior[i])

                    {
                        maxindex = i;
                        MaxgOfX = Posterior[i];
                    }
                }


                int label = int.Parse(p.nLabel.ToString());
                data.Cells[1].Value = label;
                data.Cells[2].Value = maxindex;
                dataGridView1.Rows.Add(data);
                //make  Confusin Matrix             
                 Confusin_Matrix[label, maxindex] += 1;
              
            }

           
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            Confusin_Matrix = new double[num_of_classes,num_of_classes];
        }
    }

}