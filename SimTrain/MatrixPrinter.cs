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

            print_on_lenta = lenta;
            printColor = 0;
            matrix_printer = 1;
            this.Id = id;
            Name = "Принтер №" + Convert.ToString(Id)+ " матричный";
            PrintOnLenta =lenta;
        }

        public override int Type()
        {
            return 1;
        }

    }

}