using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimTrain
{
   public class Task
    {
        private int CountList;
        private int Resolution=-1;
        private int ColorPrint=0;
        private int InfinityPrint=0;
        private Printer PrintOn=null;
        private int PrintOnType=-1;

        public Task( int cnt, int r, int color, int infinity, Printer pr, int PrinterType)
        {
            CountList = cnt;
            Resolution = r;
            ColorPrint = color;
            InfinityPrint = infinity;
            PrintOn = pr;
            PrintOnType = PrinterType;
        }
    }
}
