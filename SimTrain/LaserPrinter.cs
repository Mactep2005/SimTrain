using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimTrain
{
    public class LaserPrinter:Printer
    {
        private int CanInfinityPrint;

        public LaserPrinter(int id, int lenta)
        {
            this.Id = id;
            Name = "Принтер №" + Convert.ToString(Id)+ " лазерный";
            CanInfinityPrint =lenta;
        }

        public int Type()
        {
            return 3;
        }
    }
}