using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimTrain
{
    public partial class Form1 : Form
    {
        Init ttt = new Init();
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach(Printer pr in ttt.AllPrinters)
            listBox1.Items.Add(pr.Get_Name()+" ширина "+pr.Get_max_width()+" ВЫСОТА "+ pr.Get_max_height()) ;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (PrinterInfo pri in ttt.AllPrinters)
                if (pri.Get_Name() == listBox1.SelectedItem.ToString())
                {
                    label2.Text = "Тип: " + pri.Get_Type();
                    label3.Text = "Имя: " + pri.Get_Name();
                    label4.Text = "Макс.шир.листа: " + pri.Get_max_width().ToString();
                    label5.Text = "Макс.выс.листа: " + pri.Get_max_height().ToString();
                    label6.Text = "Макс.Разрешение: " + pri.Get_max_resolution().ToString();
                    label7.Text = "Скорость печати: " + pri.Get_speed_print().ToString();
                    label8.Text = "Емкость лотка: " + pri.Get_max_capacity().ToString();
                    label9.Text = "Бесконечн.Лента: " + pri.Get_print_on_lenta();
                    label10.Text = "Печать текста: " + pri.Get_matrix_printer();
                    label11.Text = "Цветная печать: " + pri.Get_printColor();
                    label12.Text = "Поломка: " + pri.Get_broken();
                }
        }
    }
}
