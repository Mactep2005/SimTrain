using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimTrain
{
    public class Queue
    {
        private int id;
        private Printer Printer;
        private string Name;

        public Queue(Printer pr, string name)
        {
            Printer=pr;
            Name = name;
            id++;
        }

        public int GetPaperCount() //количество страниц для печати
        {
            return 0;
        }

        public int GetError()
        {
            return 0;
        }
    }
}
