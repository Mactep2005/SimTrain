﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimTrain
{
    public class Printer:PrinterInfo
    {
        protected int Id;                                 // ID принтера
        protected string Name;                            // Имя
        protected int max_width;                          // Максимальная ширина листа
        protected int max_height;                         // Максимальная высота листа
        protected int max_resolution;                     // Максимальное разрешение печати
        protected int speed_print;                        // Скорость мечати
        protected int max_capacity;                       // Емкость лотка
        protected int matrix_printer;                    // Признак матричного принтера
        protected int print_on_lenta;                    // Возможность печатать на бесконечной ленте
        protected int printColor;                          // Возможность цветной печати
        protected int printLaser;                          // Возможность бесконечного лотка
        protected bool broken;
        protected Random rnd=new Random();

        public Printer()
        {
            max_width = rnd.Next(10, 210);
            max_height = rnd.Next(10, 210);
            max_resolution = rnd.Next(50, 1200);
            speed_print = rnd.Next(1, 10);
            max_capacity = rnd.Next(1,600);

        }
        public int Get_Id() { return Id; }                                                                                // ID принтера
        public string Get_Type() { return this.Type() == 1 ? "Матричный" : (this.Type() == 2 ? "Струйный" : "Лазерный"); }
        public string Get_Name() { return Name; }                                                                        // Имя
        public int Get_max_width() { return max_width; }                                                                // Максимальная ширина листа
        public int Get_max_height() { return max_height; }                                                              // Максимальная высота листа
        public int Get_max_resolution() { return max_resolution; }                                                      // Максимальное разрешение печати
        public int Get_speed_print() { return speed_print; }                                                            // Скорость мечати
        public int Get_max_capacity() { return max_capacity; }                                                          // Емкость лотка
        public string Get_matrix_printer() { return this.matrix_printer == 1 ? "Да" : "Нет"; }                          // Признак матричного принтера
        public string Get_print_on_lenta() { return this.print_on_lenta == 1 ? "Да" : "Нет"; }                         // Возможность печатать на бесконечной ленте
        public string Get_printColor() { return this.printColor == 1 ? "Да" : "Нет"; }                                 // Возможность цветной печати
        public string Get_printLaser() { return this.printLaser == 1 ? "Да" : "Нет"; }                                   // Признак лазерного принтера
        public string Get_broken() { return this.broken == true ? "Да" : "Нет"; }                                     // Признак поломки

        public virtual int Type()
        {
            return 0;
        }

        public bool CanColorPrint()
        {
            return false;
        }
    }
}
