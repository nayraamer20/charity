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
    public partial class Form5 : Form
    {
        string ordb = "Data Source=ORCL;User Id=scott;Password=tiger";
        OracleConnection conn;
        OracleDataAdapter adapter;
        OracleCommandBuilder builder;
        DataSet ds;
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            this.Size = new Size(414, 736);

            button7.Size = new Size(25, 25);
            button7.Location = new Point(9, 9);

            button1.Location = new Point(379, 9);
            button1.Size = new Size(25, 25);

            button2.Location = new Point(9,157);
            button2.Size = new Size(105, 39);

            button3.Location = new Point(142, 157);
            button3.Size = new Size(118, 39);

            button4.Location = new Point(284, 157);
            button4.Size = new Size(121, 39);

            comboBox1.Location = new Point(9, 199);
            comboBox1.Size = new Size(105, 27);

            comboBox2.Location = new Point(142, 199);
            comboBox2.Size = new Size(118, 27);

            comboBox3.Location = new Point(284, 199);
            comboBox3.Size = new Size(121, 27);

            label3.Location = new Point(12,270);
            label3.Size = new Size(140, 19);

            type_text.Location = new Point(16, 292);
            type_text.Size = new Size(136, 27);

            dataGridView1.Location = new Point(16, 325);
            dataGridView1.Size = new Size(386, 195);

            button5.Location = new Point(222, 288);
            button5.Size = new Size(180, 31);

            button6.Location = new Point(161, 523);
            button6.Size = new Size(88, 31);


        }

        private void button2_Click(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            conn.Open();

            cmd.CommandText = "all_donators";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("cfname", OracleDbType.RefCursor,ParameterDirection.Output);
            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read()) {
                comboBox1.Items.Add(dr[0]);
            }
            dr.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            conn.Open();

            cmd.CommandText = "all_employees";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("cfname", OracleDbType.RefCursor, ParameterDirection.Output);
            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBox2.Items.Add(dr[0]);
            }
            dr.Close();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            conn.Open();

            cmd.CommandText = "all_volunteers";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("cfname", OracleDbType.RefCursor, ParameterDirection.Output);
            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBox3.Items.Add(dr[0]);
            }
            dr.Close();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            String type = type_text.Text;

            string constr = "Data Source=orcl; User Id=scott;Password=tiger;";

            string cmdstr = "";
          
            if (type_text.Text == "clothes")
            {
                cmdstr = "select * from donation where typee = 'clothes'";
            }
            else if (type_text.Text == "money")
            {
                cmdstr = "select * from donation where typee = 'money'";
            }

            else if (type_text.Text == "books") {
                cmdstr = "select * from donation where typee = 'books'";
            }

            adapter = new OracleDataAdapter(cmdstr,constr);
            ds = new DataSet();
            adapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void button6_Click(object sender, EventArgs e)
        {
            builder = new OracleCommandBuilder(adapter);
            adapter.Update(ds.Tables[0]);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            main_menu f7 = new main_menu();

            f7.ShowDialog();
            this.Close();
        }
    }
}
