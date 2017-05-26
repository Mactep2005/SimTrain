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
            printLaser = 1;
            printColor = 0;
            CanInfinityPrint =lenta;
        }

        public override int Type()
        {
            return 3;
        }
    }
}