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
            CanPrintColor =color;
        }

        public int Type()
        {
            return 2;
        }
     
    }
}