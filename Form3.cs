using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1_day
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void заданиеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.ShowDialog();
        }

        private void заданиеToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.ShowDialog();
        }

        private void заданиеToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Form3 frm = new Form3();
            frm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double x = double.Parse(textBox1.Text); // Пример значения x
                double epsilon = 0.001; // Порог точности

                double sum = 0;
                int n = 1;
                double term = CalculateSeries(x, n);
                double prevTerm;

                // Суммируем члены ряда до тех пор, пока разница между последовательными членами не станет меньше epsilon
                do
                {
                    sum += term;
                    n++;
                    prevTerm = term;
                    term = CalculateSeries(x, n);
                } while (Math.Abs(term - prevTerm) >= epsilon);
                label1.Text = sum.ToString();
            }
            catch(Exception ex) { MessageBox.Show(ex.Message); }
        }
        // Функция для вычисления определенного члена ряда по его номеру n
        static double CalculateSeries(double x, int n)
        {
            return Math.Pow(-1, n-1) * Math.Pow(x, 2 * n - 1) / (2 * n - 1);
        }
    }
}
