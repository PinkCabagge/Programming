using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab9_1
{
    class ourForm: System.Windows.Forms.Form
    {
        static List<Entities.CountryUnitary> ctr_list;
        Label lb = new Label();
        DataGridView dgv = new DataGridView();
        public ourForm()
        {
            this.Width = 700;
            this.Height = 500;
            this.dgv.Width = 600;
            this.dgv.Height = 400;
            this.dgv.Top = 30;//чем больше число, тем ниже элемент установлен
            this.dgv.Left = 10;//выравние по горизонтали 
            this.lb.Text = "Список унитарных государств:";
            this.lb.Top = 10;
            this.lb.Left = 10;
            this.lb.Width = 300;
            ctr_list = new List<Entities.CountryUnitary>();
            Entities.CountryUnitary ctr1 = new Entities.CountryUnitary("Испания", "Мадрид", "Филипп VI", "Испанский язык", "Евро", 47431256, 505990, 1479);
            Entities.CountryUnitary ctr2 = new Entities.CountryUnitary("Китайская Народная Республика", "Пекин", "Си Цзиньпин", "Китайский язык", "Китайский юань", 1404328000, 9596961, 1949);
            Entities.CountryUnitary ctr3 = new Entities.CountryUnitary("Великобритания", "Лондон", "Елизавета II", "Английский язык", "Фунт стерлигов", 66273, 243809, 1707);
            ctr_list.Add(ctr1);
            ctr_list.Add(ctr2);
            ctr_list.Add(ctr3);
            this.dgv.DataSource = ctr_list;//привязка списка со странами к datagridview
            this.Controls.Add(this.dgv);// добавление элемента на форму
            this.Controls.Add(this.lb);



        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            
            ourForm fr1 = new ourForm();
            fr1.ShowDialog();
            Console.ReadLine();
        }
    }
}
