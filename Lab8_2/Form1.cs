using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab8_2
{
    
    public partial class Form1 : Form
    {
        

        static List<Entities.FederationSubject<int>> subjects = new List<Entities.FederationSubject<int>>();
        public Form1()
        {
            InitializeComponent();
            Entities.FederationSubject<int> altairegion = new Entities.FederationSubject<int>(22, "Барнаул", "Алтайский край", 30, 300, 10);
            Entities.FederationSubject<int> altairepublic = new Entities.FederationSubject<int>(04, "Горно-Алтайск", "Республика Алтай", 450, 200, 20);

            subjects.Add(altairegion);
            subjects.Add(altairepublic);

            this.button1.PerformClick();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = String.Format("{0}", subjects[0].Budget);
            this.textBox2.Text = String.Format("{0}", subjects[1].Budget);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double amount = Convert.ToDouble(this.textBox3.Text);
            
            Entities.Migration<int, int> mgr1 = new Entities.Migration<int, int>()
            {
                Id = 39,
                Amount = amount,
                FromFederationSubject = subjects[this.comboBox1.SelectedIndex],
                InFederationSubject = subjects[this.comboBox2.SelectedIndex]
            };
            mgr1.Perform();
            this.button1.PerformClick();
        }

        
    }
}
