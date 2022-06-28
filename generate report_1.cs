using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.Shared;
namespace WindowsFormsApp2
{
    public partial class generate_report_1 : Form
    {
        CrystalReport1 cr;
        CrystalReport2 rr;
        public generate_report_1()
        {
            InitializeComponent();
        }

        private void generate_report_1_Load(object sender, EventArgs e)
        {

            cr = new CrystalReport1();
            foreach (ParameterDiscreteValue v in cr.ParameterFields[0].DefaultValues)
                comboBox1.Items.Add(v.Value);

            // load needy people ssn 
            rr = new CrystalReport2();
            foreach (ParameterDiscreteValue v in rr.ParameterFields[0].DefaultValues)
                comboBox2.Items.Add(v.Value);

         

        }

        private void button1_Click(object sender, EventArgs e)
        {
            cr.SetParameterValue(0, comboBox1.Text);
            crystalReportViewer1.ReportSource = cr;
                }

        private void button2_Click(object sender, EventArgs e)
        {
            rr.SetParameterValue(0, comboBox2.Text);
            crystalReportViewer2.ReportSource = rr;
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}

