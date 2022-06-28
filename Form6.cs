using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            this.Size = new Size(414, 736);

            button3.Location = new Point(379, 9);
            button3.Size = new Size(25, 25);

            button6.Location = new Point(9, 353);
            button6.Size = new Size(396, 31);

            button1.Location = new Point(9, 438);
            button1.Size = new Size(396, 31);

            button2.Location = new Point(9, 518);
            button2.Size = new Size(396, 31);

            button4.Location = new Point(9, 596);
            button4.Size = new Size(396, 31);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();

            f1.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();

            f2.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5();

            f5.ShowDialog();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();

            f3.ShowDialog();
            this.Close();
        }

    }

}
