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
    public partial class Form2 : Form
    {

        string ordb = "Data Source=ORCL;User Id=scott;Password=tiger";
        OracleConnection conn;
      
        public Form2()
        {
            InitializeComponent();
           

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();

            this.Size = new Size(414, 736);

            button1.Size = new Size(25, 25);
            button1.Location = new Point(379, 9);

            button3.Size = new Size(25, 25);
            button3.Location = new Point(9, 9);

            panel1.Size = new Size(392, 492);
           panel1.Location = new Point(12, 141);



            label1.Location = new Point(75, 5);
            label1.Size = new Size(305, 36);

            comboBox1.Location = new Point(142, 44);
            comboBox1.Size = new Size(155, 26);

            comboBox2.Location = new Point(213, 94);
            comboBox2.Size = new Size(155, 26);

            label13.Location = new Point(145, 100);
            label13.Size = new Size(73, 19);

            label2.Location = new Point(85, 51);
            label2.Size = new Size(51, 19);

            radioButton2.Location = new Point(142, 76);
            radioButton2.Size = new Size(84, 21);

            radioButton1.Location = new Point(232, 76);
            radioButton1.Size = new Size(65, 21);

            textBox1.Location = new Point(18, 123);
            textBox1.Size = new Size(350, 27);

            textBox2.Location = new Point(18,184);
            textBox2.Size = new Size(350, 27);

            textBox3.Location = new Point(18, 247);
            textBox3.Size = new Size(350, 27);

            textBox4.Location = new Point(18, 306);
            textBox4.Size = new Size(350, 27);

            textBox5.Location = new Point(18, 359);
            textBox5.Size = new Size(350, 27);

            textBox6.Location = new Point(18, 411);
            textBox6.Size = new Size(350, 27);

            textBox7.Location = new Point(18, 465);
            textBox7.Size = new Size(350, 27);

            label3.Location = new Point(14, 101);
            label3.Size = new Size(100, 19);

            label4.Location = new Point(14, 162);
            label4.Size = new Size(67, 19);

            label5.Location = new Point(14, 225);
            label5.Size = new Size(82, 19);

            label6.Location = new Point(14, 284);
            label6.Size = new Size(95, 19);

            label7.Location = new Point(14, 337);
            label7.Size = new Size(173, 19);

            label9.Location = new Point(14, 389);
            label9.Size = new Size(46, 19);

            label8.Location = new Point(14, 443);
            label8.Size = new Size(37, 19);

            label10.Location = new Point(14, 389);
            label10.Size = new Size(46, 19);


            label10.Visible = false;

            button2.Location = new Point(156, 648);
            button2.Size = new Size(99, 39);

            label11.Location = new Point(100, 690);
            label11.Size = new Size(167, 19);

            label12.Location = new Point(256, 690);
            label12.Size = new Size(66, 19);


            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select NAME_S from BRANCHES";
            cmd.CommandType = CommandType.Text;

            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBox2.Items.Add(dr[0]);
            }
            dr.Close();

          


        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();

            f1.ShowDialog();
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() == "Volunteer")
            {
                label8.Visible = true;
                label8.Text = "ID";
                textBox7.Visible = true;
                label10.Visible = false;
                label9.Visible = true;

                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;

                cmd.CommandText = "SELECT COUNT(*) FROM VOLUNTEER";
                double count =Convert.ToDouble( cmd.ExecuteScalar());
                count++;
                textBox7.Text = count.ToString();

            }

            else if (comboBox1.SelectedItem.ToString() == "Donator")
            {
                label8.Visible = false;
                textBox7.Visible = false;

                label10.Visible = true;
                label9.Visible = false;
            }
            else {
                label8.Visible = true;
                textBox7.Visible = true;
                label10.Visible = false;
                label9.Visible = true;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();

            f1.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

          

           


            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;

            

            string alladdress = textBox3.Text;
            string[] address = alladdress.Split(' ');

            string fullname = textBox1.Text;
            string[] name = fullname.Split(' ');
            string SEX = "";
            


            if (comboBox1.SelectedItem.ToString() == "Volunteer")
            {
                if (radioButton1.Checked == true)
                {
                    SEX = "M";
                }
                else if (radioButton2.Checked == true)
                {
                    SEX = "F";
                }
               

                cmd.CommandText = "insert into VOLUNTEER values (:SEX,:ID,:FNAME,:LNAME,:STREET,:CITY,:AGE,:C_NAME,:PHONE,:PASSWORD)";
                cmd.CommandType = CommandType.Text;

                cmd.Parameters.Add("SEX", SEX.ToString());
                cmd.Parameters.Add("ID", textBox7.Text);
                cmd.Parameters.Add("FNAME",name[0].ToString());
                cmd.Parameters.Add("LNAME", name[1].ToString());
                cmd.Parameters.Add("STREET", address[0].ToString());
                cmd.Parameters.Add("CITY", address[1].ToString());
                cmd.Parameters.Add("AGE", textBox6.Text);
                cmd.Parameters.Add("C_NAME", comboBox2.SelectedItem.ToString());
                cmd.Parameters.Add("PHONE",textBox2.Text);
                cmd.Parameters.Add("PASSWORD",textBox4.Text);
               
                
               

                int r = cmd.ExecuteNonQuery();
                if (r != -1)
                {
                    MessageBox.Show("New volunteer added");
                }

              

            }

            else if (comboBox1.SelectedItem.ToString() == "Donator")
            {
                if (radioButton1.Checked == true)
                {
                    SEX = "M";
                }
                else if (radioButton2.Checked == true)
                {
                    SEX = "F";
                }

                cmd.CommandText = "insert into DONATOR values (:STREET,:CITY,:SSN,:FNAME,:LNAME,:PHONE,:PASSWORD,:C_NAME,:SEX)";
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add("STREET", address[0].ToString());
                cmd.Parameters.Add("CITY", address[1].ToString());
                cmd.Parameters.Add("SSN", textBox6.Text);

                cmd.Parameters.Add("FNAME", name[0].ToString());
                cmd.Parameters.Add("LNAME", name[1].ToString());
                cmd.Parameters.Add("PHONE", textBox2.Text);
               
             
                
                cmd.Parameters.Add("PASSWORD", textBox4.Text);
                cmd.Parameters.Add("C_NAME", comboBox2.SelectedItem.ToString());
                cmd.Parameters.Add("SEX", SEX.ToString());


                int r = cmd.ExecuteNonQuery();
                if (r != -1)
                {
                    MessageBox.Show("New donator added");
                }

              
            }
            else if(comboBox1.SelectedItem.ToString() == "Charity Employee")
            {
                if (radioButton1.Checked == true)
                {
                    SEX = "M";
                }
                else if (radioButton2.Checked == true)
                {
                    SEX = "F";
                }

                cmd.CommandText = "insert into EMPLOYEES values (:SEX,:FNAME,:LNAME,:STREET,:CITY,:AGE,:C_NAME,:SSN,:PASSWORD,:PHONE)";

                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add("SEX", SEX.ToString());
                cmd.Parameters.Add("FNAME", name[0].ToString());
                cmd.Parameters.Add("LNAME", name[1].ToString());
                cmd.Parameters.Add("STREET", address[0].ToString());
                cmd.Parameters.Add("CITY", address[1].ToString());
                cmd.Parameters.Add("AGE", textBox6.Text);
                cmd.Parameters.Add("C_NAME", comboBox2.SelectedItem.ToString());
                cmd.Parameters.Add("SSN", textBox7.Text);

                cmd.Parameters.Add("PASSWORD", textBox4.Text);


                cmd.Parameters.Add("PHONE", textBox2.Text);
                
              
                


                int r = cmd.ExecuteNonQuery();
                if (r != -1)
                {
                    MessageBox.Show("New employee added");
                }

              
            }
           

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            main_menu f7 = new main_menu();

            f7.ShowDialog();
            this.Close();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
