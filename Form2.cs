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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void заданиеToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Form3 frm = new Form3();
            frm.ShowDialog();

        }

        private void заданиеToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.ShowDialog();
        }

        private void заданиеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.ShowDialog();
        }
        static double CalculateFormula(double a, double b)
        {
            // Вычисляем значения синуса и косинуса
            double sina = Math.Sin(a);
            

            // Вычисляем числитель и знаменатель формулы
            double numerator = Math.Pow(sina, 2) + Math.Pow(b, 3);
            double denominator = Math.Sqrt(1 + (b / (a + Math.Cos(Math.PI + Math.Pow(b, 2)))));

            // Вычисляем и возвращаем результат арктангенса от всей функции
            return Math.Atan(numerator / denominator);
        }

    }
}
