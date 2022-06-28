using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        string ordb = "Data Source=ORCL;User Id=scott;Password=tiger";
        OracleConnection conn;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
            this.Size = new Size(414, 736);

            button1.Size = new Size(25, 25);
            button1.Location = new Point(379, 9);

            button3.Size = new Size(25, 25);
            button3.Location = new Point(9, 9);

            panel1.Size = new Size(392, 197);
            panel1.Location = new Point(12, 444);



            label1.Location = new Point(80, 5);
            label1.Size = new Size(290, 36);



            label3.Location = new Point(14, 66);
            label3.Size = new Size(100, 19);

            label6.Location = new Point(14, 134);
            label6.Size = new Size(95, 19);

            textBox1.Location = new Point(18, 88);
            textBox1.Size = new Size(350, 27);


            pass_text.Location = new Point(18, 156);
            pass_text.Size = new Size(350, 27);


            button2.Location = new Point(156, 648);
            button2.Size = new Size(99, 39);

            label11.Location = new Point(100, 690);
            label11.Size = new Size(167, 19);

            label12.Location = new Point(256, 690);
            label12.Size = new Size(66, 19);

            label2.Location = new Point(120, 319);
            label2.Size = new Size(199, 34);

            label4.Location = new Point(60, 353);
            label4.Size = new Size(340, 34);

            label5.Location = new Point(55, 387);
            label5.Size = new Size(347, 34);



        }






        private void Form1_Click(object sender, EventArgs e) => Size = new Size(414, 736);

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
          
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

       

        private void label12_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();

            f2.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            string fullname = textBox1.Text;
            string[] name = fullname.Split(' ');
            string pass = pass_text.Text;

            Form4 f4 = new Form4(name[0].ToString(),name[1].ToString(),pass.ToString());

            f4.ShowDialog();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            main_menu f7 = new main_menu();

            f7.ShowDialog();
            this.Close();
        }
    }
}
