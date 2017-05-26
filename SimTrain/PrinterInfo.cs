using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimTrain
{
    public interface PrinterInfo
    {
        int GetId();                                 // ID принтера
        string GetName();                            // Имя
        int Get_max_width();                          // Максимальная ширина листа
        int Get_max_height();                         // Максимальная высота листа
        int Get_max_resolution();                     // Максимальное разрешение печати
        int Get_speed_print();                        // Скорость мечати
        int Get_max_capacity();                       // Емкость лотка
        string Get_matrix_printer();                    // Признак матричного принтера
        string Get_print_on_lenta();                    // Возможность печатать на бесконечной ленте
        string Get_printColor();                          // Возможность цветной печати
        string Get_printLaser();                          // Признак лазерного принтера
        string Get_broken();                             // Признак поломки
    }
}