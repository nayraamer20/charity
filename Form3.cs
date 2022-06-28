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
    public partial class Form3 : Form
    {
        string ordb = "Data Source=ORCL;User Id=scott;Password=tiger";
        OracleConnection conn;
        OracleDataAdapter ad;
        DataSet ds;
        public Form3()
        {
            InitializeComponent();
           
        }

        private void Form3_Load(object sender, EventArgs e)
        {

            this.Size = new Size(414, 736);
            button3.Size = new Size(25, 25);
            button3.Location = new Point(9, 9);

            button1.Size = new Size(25, 25);
            button1.Location = new Point(379, 9);

            dataGridView1.Location = new Point(12, 207);
            dataGridView1.Size = new Size(393, 517);

           button2.Location = new Point(192, 162);
           button2.Size = new Size(213, 39);

            label1.Location = new Point(46, 158);
            label1.Size = new Size(67, 18);

            textBox1.Location = new Point(49, 179);
          textBox1.Size = new Size(100, 23);


        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
           
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            conn.Open();
            string cm = "select * from donation where :vid = v_id";

            ad = new OracleDataAdapter(cm, ordb);
            ad.SelectCommand.Parameters.Add("id", textBox1.Text);

            ds = new DataSet();
            ad.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];




        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
