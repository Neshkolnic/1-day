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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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

        private void заданиеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.ShowDialog();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            double x, y, z;
            x = double.Parse(textBox1.Text);
            y = double.Parse(textBox2.Text);    
            z = double.Parse(textBox3.Text);

            textBox4.Text = SolvingProblem(x, y, z).ToString();

    

        }

        static double SolvingProblem(double x, double y, double z)
        {
            x = 4000;
            y = -0.875;
            z = -0.000475;

            double cosineX = Math.Cos(x);
            double cosineY = Math.Cos(y);
            double sineY = Math.Sin(y);

            double part1 = Math.Abs(cosineX - cosineY);
            double part2 = 1 + 2 * Math.Pow(sineY, 2);
            double part3 = 1 + z + (Math.Pow(z, 2) / 2) + (Math.Pow(z, 3) / 3) + (Math.Pow(z, 4) / 4);

            return Math.Pow(part1, part2) * part3;
        }

    }
}
