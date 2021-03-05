using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1VP
{
    public partial class Form1 : Form
    {
        int N = 0, M = 0;
        int[,] arr;
        int[] arr2 = new int[25];
        public Form1()
        {
            InitializeComponent();
        }

        private void showArray(){
            string allNum = "";
            for (int j = 0; j < N; j++)
            {
                for (int i = 0; i < M; i++)
                {
                    allNum += arr[j, i].ToString() + " ";
                }
                allNum += "\n";
            }
            label2.Text = allNum;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Random rand = new Random(((int)DateTime.Now.Ticks));
            if (N > 0 && M > 0 && N < 5 && M < 5)
            {
                arr = new int[N, M];
                for (int i = 0; i < N; i++)
                {
                    for (int j = 0; j < M; j++)
                    {
                        arr[i, j] = rand.Next(0, 10);
                    }
                }
                showArray();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (N > 0 && M > 0)
            {
                this.label5.Text = $"{N} {M}";
            }
        }

        private void button3_Click(object sender, EventArgs e) { 
            int[] max = new int[N];
            string maxStr = "";
            int z = 0;
            for (int i = 0; i < N; i++)
                max[i] = 0;
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    if (max[z] < arr[i, j])
                    {
                        max[z] = arr[i, j];
                    }
                }
                z++;
            }
            for (int i = 0; i < N; i++)
            {
                {
                    maxStr += max[i].ToString() + " ";
                }
            }
            this.label3.Text = $"{maxStr}";
        }

     

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e) {
               MessageBox.Show("Мухомедзянов, Носков, Степанченко, ИП-917");
        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {
            M = Convert.ToInt32(textBox2.Text);
            if(M == 0)
            {
                MessageBox.Show("M != 0");
            }
            if(M > 4)
            {
                MessageBox.Show("M > 4");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            N = Convert.ToInt32(textBox1.Text);
            if (N == 0)
            {
                MessageBox.Show("N != 0");
            }
            if (N > 4)
            {
                MessageBox.Show("N > 4");
            }
        }
    }
}
