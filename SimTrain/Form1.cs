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
        public Init ttt ;
        public Form1()
        {
            InitializeComponent();
        }

             
        private void button3_Click(object sender, EventArgs e)
        {
            ttt = new Init(this);
            ListViewItem item1;
            ImageList imageListLarge = new ImageList();
            imageListLarge.ImageSize = new Size(90, 65);
      //      listPrinters.LargeImageList = imageListLarge;
      //      this.listPrinters.View = View.Details;
            foreach (PrinterInfo pr in ttt.AllPrinters)
            {
                item1 = new ListViewItem();
                item1.Text = pr.Get_Name();
                if (pr.Get_Type() == "Матричный") item1.ImageIndex = 0;
                if (pr.Get_Type() == "Струйный") item1.ImageIndex = 1; 
                if (pr.Get_Type() == "Лазерный") item1.ImageIndex = 2;
                listPrinters.Items.Add(item1);
            }

            button3.Enabled = false;
            label14.Text="Создано "+Convert.ToString(cntPrn.Value)+" притеров и "+Convert.ToString(cntTask.Value)+" случайных заданий";
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }
        public int getCntPrn()
        {
            return (int)cntPrn.Value; 
        }

        private void listPrinters_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (PrinterInfo pri in ttt.AllPrinters)
                if (pri.Get_Id() == listPrinters.FocusedItem.Index)
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

        private void Go_Click(object sender, EventArgs e)
        {
            foreach(Task tsk in ttt.TaskArray)
            {
                switch (tsk.Get_Status())
                {
                    case 0:
                        {
                            Queue qu = new Queue();
                            tsk.Set_Status = qu.AddTask(tsk, this) ;
                            break;
                        }
                    default:
                        {

                        }
                }
            }
        }
    }
}
