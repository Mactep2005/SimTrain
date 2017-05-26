using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimTrain
{
    public class MatrixPrinter:Printer
    {
        private int PrintOnLenta;

        public MatrixPrinter(int id, int lenta)   // Конструктор матричного принтера
        {
            this.Id = id;
            Name = "Принтер №" + Convert.ToString(Id)+ " матричный";
            PrintOnLenta =lenta;
        }

        public int Type()
        {
            return 1;
        }

    }

}