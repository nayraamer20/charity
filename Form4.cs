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
    public partial class Form4 : Form
    {
        String fname;
        String lname;
        String pass;

        string ordb = "Data Source=ORCL;User Id=scott;Password=tiger";
        OracleConnection conn;

        public Form4(String fname,String lname,String password)
        {
            this.fname = fname;
            this.lname = lname;
            this.pass = password;

            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            this.Size = new Size(414, 736);

            button1.Size = new Size(25, 25);
            button1.Location = new Point(379, 9);

            button3.Size = new Size(25, 25);
            button3.Location = new Point(9, 9);

            label1.Location = new Point(70, 135);
            label1.Size = new Size(335, 36);

            label3.Location = new Point(12, 183);
            label3.Size = new Size(104, 19);

            label2.Location = new Point(12, 330);
            label2.Size = new Size(95, 19);

            label4.Location = new Point(12, 401);
            label4.Size = new Size(67, 19);

           

            label9.Location = new Point(12, 473);
            label9.Size = new Size(46, 19);

            label10.Location = new Point(12, 473);
            label10.Size = new Size(37, 19);

            label6.Location = new Point(12, 259);
            label6.Size = new Size(100, 19);

            label8.Location = new Point(12, 547);
            label8.Size = new Size(37, 19);

            textBox1.Location = new Point(16, 205);
            textBox1.Size = new Size(360,27);

            textBox2.Location = new Point(16, 352);
            textBox2.Size = new Size(360, 27);
            textBox2.UseSystemPasswordChar = true;

            textBox3.Location = new Point(16, 423);
            textBox3.Size = new Size(360, 27);

           

            textBox6.Location = new Point(16, 495);
            textBox6.Size = new Size(360, 27);

            textBox5.Location = new Point(16, 281);
            textBox5.Size = new Size(360, 27);

            textBox7.Location = new Point(16, 569);
            textBox7.Size = new Size(360, 27);

           

            pictureBox1.Location = new Point(352,358);
            pictureBox1.Size = new Size(21, 14);

        


            conn = new OracleConnection(ordb);

            OracleCommand c = new OracleCommand();
            c.Connection = conn;
            conn.Open();

            c.CommandText = "e_profile";
            c.CommandType = CommandType.StoredProcedure;
            String first = this.fname;
            String last = this.lname;
            String PP = this.pass;
          
           

            c.Parameters.Add("f_name", first); //input
            c.Parameters.Add("l_name", last); //input

            c.Parameters.Add("sssn", OracleDbType.Int32, ParameterDirection.Output);
          // c.Parameters.Add("sstreet", OracleDbType.Int32, ParameterDirection.Output);
           // c.Parameters.Add("ccity", OracleDbType.Int32, ParameterDirection.Output);
            c.Parameters.Add("aage", OracleDbType.Int32, ParameterDirection.Output);
         // c.Parameters.Add("ppass",OracleDbType.Varchar2,ParameterDirection.Output);
            c.Parameters.Add("pphone", OracleDbType.Int32, ParameterDirection.Output);
           
           
            c.ExecuteNonQuery();

         // String password = c.Parameters["ppass"].Value.ToString();

            textBox1.Text = fname ;
            textBox5.Text = lname ;
            textBox2.Text = pass;
            textBox7.Text = c.Parameters["sssn"].Value.ToString();
          //  textBox4.Text = c.Parameters["sstreet"].Value.ToString();
           // textBox8.Text = c.Parameters["ccity"].Value.ToString();
            //  textBox2.Text = password;
            
            textBox6.Text = c.Parameters["aage"].Value.ToString();
            textBox3.Text = c.Parameters["pphone"].Value.ToString();
     
          
           


        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            textBox2.UseSystemPasswordChar = false;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            main_menu f7 = new main_menu();

            f7.ShowDialog();
            this.Close();
        }
    }
}
