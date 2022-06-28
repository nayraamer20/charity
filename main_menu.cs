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
    public partial class main_menu : Form
    {
        public main_menu()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            this.Size = new Size(414, 736);
            // menuStrip1.Location = new Point(0, 200);

            button3.Location = new Point(379, 30);
            button3.Size = new Size(25, 25);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void loginToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();

            f1.ShowDialog();
            this.Close();
        }

        private void signInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();

            f2.ShowDialog();
            this.Close();
        }

        private void charityInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5();

            f5.ShowDialog();
            this.Close();
        }

        private void volunteerInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();

            f3.ShowDialog();
            this.Close();
        }

        private void report1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            generate_report_1 one = new generate_report_1();
            one.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }

}
