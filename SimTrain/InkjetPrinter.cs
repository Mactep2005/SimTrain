using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimTrain
{
    public class InkjetPrinter : Printer
    {
        private int CanPrintColor;

        public InkjetPrinter(int id, int color)
        {
            this.Id = id;
            Name = "Принтер №" + Convert.ToString(Id)+ " струйный";
            printColor = color;
            CanPrintColor =color;
            print_on_lenta = 0;
        }

        public override int Type()
        {
            return 2;
        }
     
    }
}