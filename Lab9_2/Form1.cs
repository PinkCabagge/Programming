using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab9_2
{
    
    public partial class Form1 : Form
    {
        
        static int row_index = 0;
        public Form1()
        {
            InitializeComponent();
            
            this.dataGridView1.Columns.Add("Name", "Название страны");
            this.dataGridView1.Columns.Add("Capital", "Столица");
            this.dataGridView1.Columns.Add("Ruler", "Правитель");
            this.dataGridView1.Columns.Add("language", "Язык страны");
            this.dataGridView1.Columns.Add("Money", "Денежная единица");
            this.dataGridView1.Columns.Add("Population", "Население");
            this.dataGridView1.Columns.Add("Territory", "Территория");
            this.dataGridView1.Columns.Add("Year", "Год основания");
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Entities.CountryUnitary ctr = new Entities.CountryUnitary(this.textBox1.Text, this.textBox2.Text, this.textBox3.Text, this.textBox4.Text,this.comboBox1.Text, (int)this.numericUpDown1.Value, (double)this.numericUpDown2.Value, (int)this.numericUpDown3.Value);
           
            this.dataGridView1.Rows.Add();
            this.dataGridView1["Name", row_index].Value = ctr.Name;
            this.dataGridView1["Capital", row_index].Value = ctr.Capital;
            this.dataGridView1["Ruler", row_index].Value = ctr.Ruler;
            this.dataGridView1["language", row_index].Value = ctr.Language;
            this.dataGridView1["Money", row_index].Value = ctr.Moneyunit;
            this.dataGridView1["Population", row_index].Value = ctr.Population;
            this.dataGridView1["Territory", row_index].Value = ctr.Territory;
            this.dataGridView1["Year", row_index].Value = ctr.Yearoffoundation;
            row_index++;

        }
    }
}
