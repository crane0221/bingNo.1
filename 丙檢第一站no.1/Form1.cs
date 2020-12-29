using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace _106031
{
    public partial class Form1 : Form
    {              
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int m0, m1, m2, m3;
            string m4 = "";
            StreamReader file = new StreamReader(@"C:\Users\user\Desktop\丙檢題本\1060301.sm");
            m0 = int.Parse(file.ReadLine());
            m1 = m0;
            for (int i = 0;i <= 9;i++)
            {
                m2 = m1 / 10;
                m3 = m1 % 10;
                string a;
                a = m3.ToString();
                m4 = m4 + a;
                if (m2 == 0)
                    break;
                m1 = m2;
            }
            string b;
            b = m0.ToString();
            if (m4 == b)
            {
                textBox1.Text = "第一題結果:" + "\r\n" + m4 + "是迴文";
            }
            else
            {
                textBox1.Text = "第一題結果:" + "\r\n" + m4 + "不是迴文";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int m0;
            string m1;
            string m2 = "";
            StreamReader file = new StreamReader(@"C:\Users\user\Desktop\丙檢題本\1060302.sm");
            m0 = int.Parse(file.ReadLine());
            for (int i = 1;i <= m0;i++)
            {
                for (int j = 1;j <= i;j++)
                {
                m1 = m0.ToString();
                m2 = m2 + j;
                }
                m2 = m2 + "\r\n";
            }
            textBox2.Text = "第二題結果:" + "\r\n" + m2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int m0;
            int m1 = 0;
            StreamReader file = new StreamReader(@"C:\Users\user\Desktop\丙檢題本\1060303.sm");
            m0 = int.Parse(file.ReadLine());
            for (int i = 1;i <= m0;i++)
            {
                m1 = m0 % i;
                if (m1 == 0)
                    m1 = m1 + 1;
            }
            if (m1 == 2)
            {
                textBox3.Text = "第三題結果:" + "\r\n" + m0 + "是質數";
            }
            else
            {
                textBox3.Text = "第三題結果:" + "\r\n" + m0 + "不是質數";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string[] h = new string[3];
            float[] h1 = new float[3];
            string[] w = new string[3];
            float[] w1 = new float[3];
            float[] bmi = new float[3];
            float sbmi = 0;
            string a;
            string[] b;
            int sbmi1 = 0;
            StreamReader file = new StreamReader(@"C:\Users\user\Desktop\丙檢題本\1060304.sm");            
            for (int i = 0;i <= 2;i++)
            {
                a = file.ReadLine();
                System.Console.WriteLine(a);
                b = a.Split(',');                
   
                h[i] = b[0];
                w[i] = b[1];
                h1[i] = int.Parse(h[i]);
                w1[i] = int.Parse(w[i]);
                bmi[i] = w1[i] / ((h1[i] / 100) * (h1[i] / 100));

                sbmi = bmi[0];
                if (sbmi > bmi[i])
                    sbmi = bmi[i];               
            }
            
            if (sbmi < 20 || sbmi > 25)
            {
                sbmi1 = (int)sbmi + 1;
                textBox4.Text = "第四題結果:" + "\r\n" + "最小bmi值=" + sbmi1 + "不正常";
            }
            else
            {
                textBox4.Text = "第四題結果:" + "\r\n" + "最小bmi值=" + sbmi1 + "正常";
            }                  
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string z;
            string[] y;
            string[,] a = new string[2,2];
            int[,] a1 = new int[2,2];
            string[,] b = new string[2,2];
            int[,] b1 = new int[2,2];
            int[,] c = new int[2,2];
            StreamReader file = new StreamReader(@"C:\Users\user\Desktop\丙檢題本\1060305.sm");
            z = file.ReadLine();            
            y = z.Split(',');
            a[0,0] = y[0];
            b[0,0] = y[1];
            a1[0,0] = int.Parse(a[0,0]);
            b1[0,0] = int.Parse(b[0,0]);
            z = file.ReadLine();
            y = z.Split(',');
            a[0, 1] = y[0];
            b[0, 1] = y[1];
            a1[0, 1] = int.Parse(a[0, 1]);
            b1[0, 1] = int.Parse(b[0, 1]);
            z = file.ReadLine();
            y = z.Split(',');
            a[1, 0] = y[0];
            b[1, 0] = y[1];
            a1[1, 0] = int.Parse(a[1, 0]);
            b1[1, 0] = int.Parse(b[1, 0]);
            z = file.ReadLine();
            y = z.Split(',');
            a[1,1] = y[0];
            b[1, 1] = y[1];
            a1[1, 1] = int.Parse(a[1, 1]);
            b1[1, 1] = int.Parse(b[1, 1]);

            c[0, 0] = a1[0, 0] + a1[1, 0];
            c[0, 1] = a1[0, 1] + a1[1, 1];
            c[1, 0] = b1[0, 0] + b1[1, 0];
            c[1, 1] = b1[0, 1] + b1[1, 1];
            textBox5.Text = "第五題結果:\r\n" + "[" + c[0,0] + "     " + c[1,0] + "]" + "\r\n" + "[" + c[0,1] + " " + c[1,1] + "]";
        }
    }
}
