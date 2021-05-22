using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;


namespace Lab9._1
{
    class НашаФорма : System.Windows.Forms.Form
    {
        System.Windows.Forms.Button кнопка1 = new
       System.Windows.Forms.Button();
        System.Windows.Forms.TextBox текстовое_поле1 = new
       System.Windows.Forms.TextBox();
        public НашаФорма()
        {
            this.кнопка1.Left = 10;
            this.кнопка1.Top = 10;
            this.кнопка1.Text = "Старт";
            this.кнопка1.MouseClick += кнопка1_MouseClick;
            this.кнопка1.AutoSize = true;
            System.Drawing.Font шрифт = new System.Drawing.Font("Arial", 22);
            this.кнопка1.Font = шрифт;
            this.текстовое_поле1.Top = this.кнопка1.Top;
            this.текстовое_поле1.Left = this.кнопка1.Left +
           this.кнопка1.Width + 10;
            this.текстовое_поле1.Font = шрифт;
            this.Controls.Add(this.кнопка1);
            this.Controls.Add(this.текстовое_поле1);
        }
        void кнопка1_MouseClick(object sender,
       System.Windows.Forms.MouseEventArgs e)
        {
            this.текстовое_поле1.Text = "Привет";
        }
    }
        class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.ReadLine();
        }
    }
}
