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
        private Task tsk;
        private 

        public Queue(Task task)
        {
            tsk = task;
        }

        public int AddTask(Task task, Form1 init) // добавить задание в очередь
        {
            Printer = task.Get_PrintOn();
            if (Printer != null)
            {
                return Print(task, Printer);

            }
            else
            {
                Printer = init.ttt.GetRandomPrinter(task.Get_PrintOnType());
                return Printer == null?  -1:  Print(task,);
            } 
        }

        public int Print(Task task, Printer prn) //количество страниц для печати
        {
           
            return 0;
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
