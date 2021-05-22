using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab9._2
{
    public partial class Form1 : Form
    {
        static List<Entities.CountryUnitary> ctrun_list;
        public Form1()
        {
            InitializeComponent();
            ctrun_list = new List<Entities.CountryUnitary>();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //this.listBox1.DataSource = "";
            Entities.CountryUnitary ctr = new Entities.CountryUnitary(this.textBox1.Text,this.textBox3.Text,this.textBox2.Text,this.textBox4.Text,this.textBox5.Text,(int)this.numericUpDown1.Value, (double)this.numericUpDown2.Value, (int)this.numericUpDown3.Value);
            ctrun_list.Add(ctr);
            this.listBox1.Items.Add(ctr);
            //this.listBox1.DataSource = ctrun_list;
            MessageBox.Show(String.Format("{0}",ctrun_list.Count));
            
        }
    }
}
