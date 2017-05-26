﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimTrain
{
    public class Init
    {
        static public MatrixPrinter[] MatrixPrinterArray = new MatrixPrinter[10];
        static public InkjetPrinter[] InkjetPrinterArray = new InkjetPrinter[10];
        static public LaserPrinter[] LaserPrinterArray = new LaserPrinter[10];
        static public Queue[] QueueArray = new Queue[30];
     //   static public Task[] TaskArray = new Task[30];

        public List<Task> TaskArray = new List<Task>();
        public List<String> AllPrinters = new List<String>();
        int i;
        public Random rnd = new Random();

        public Init()
        {
            FillPrinterArray();
            FillTaskArray();
        }

        public void FillPrinterArray()
        {
            for (i = 0; i <= 9; i++)
            {
                MatrixPrinterArray[i] = new MatrixPrinter(i,rnd.Next(0, 2));
                AllPrinters.Add(MatrixPrinterArray[i].GetNamePrinter());
                InkjetPrinterArray[i] = new InkjetPrinter(i,rnd.Next(0, 2));
                AllPrinters.Add(InkjetPrinterArray[i].GetNamePrinter());
                LaserPrinterArray[i] = new LaserPrinter(i,rnd.Next(0, 2));
                AllPrinters.Add(LaserPrinterArray[i].GetNamePrinter());
            }
        }

        public void FillTaskArray()
        {
            int type = 0;
            Task tsk;
            for (i = 0; i <= 30; i++) { 
                type = rnd.Next(1, 4);
                switch (type)
                {
                    case 1:
                        {
                            tsk= new Task(rnd.Next(1, 1000), rnd.Next(50, 1200), 0, rnd.Next(0, 2), GetRandomPrinter(type), type);
                            TaskArray.Add(tsk);
                            break;
                        }
                    case 2:
                        {
                            tsk = new Task(rnd.Next(1, 1000), rnd.Next(50, 1200), rnd.Next(0, 2), 0, GetRandomPrinter(type), type);
                            TaskArray.Add(tsk);
                            break;
                        }
                    case 3:
                        {
                            tsk = new Task(rnd.Next(1, 1000), rnd.Next(50, 1200), rnd.Next(0, 2), rnd.Next(0, 2), GetRandomPrinter(type), type);
                            TaskArray.Add(tsk);
                            break;
                        }
                    default:
                        {
                            break;
                        }
                }
            }
        }
        public Printer GetRandomPrinter(int n)
        {
            int i = rnd.Next(0, 10);
            switch (n) {
                case 1:
                {
                    foreach (Printer pr in MatrixPrinterArray)
                        if (pr.GetId()== i) return pr;
                        break;
                }
                case 2:
                {
                    foreach (Printer pr in InkjetPrinterArray)
                        if (pr.GetId() == i) return pr;
                        break;
                }
                case 3:
                    {
                        foreach (Printer pr in LaserPrinterArray)
                            if (pr.GetId() == i) return pr;
                        break;
                    }
            }
   
            return null;
        }
    }
}