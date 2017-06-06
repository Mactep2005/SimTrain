using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimTrain
{
    public class Init
    {
        Form1 f1;
        static public MatrixPrinter[] MatrixPrinterArray = new MatrixPrinter[10];
        static public InkjetPrinter[] InkjetPrinterArray = new InkjetPrinter[10];
        static public LaserPrinter[] LaserPrinterArray = new LaserPrinter[10];
        static public Queue[] QueueArray = new Queue[30];
        //   static public Task[] TaskArray = new Task[30];

           public List<Task> TaskArray = new List<Task>();
        public List<Printer> AllPrinters = new List<Printer>();
        int i;

        public Init(Form1 f)
        {
            this.f1 = f;
            FillPrinterArray();
        //    FillTaskArray();
        }

        public void FillPrinterArray()
        {
            int cnt = this.f1.getCntPrn();
            for (i = 0; i <cnt; i++)
            {
                MatrixPrinterArray[i] = new MatrixPrinter(i, RandNumber(0, 2));   
                InkjetPrinterArray[i] = new InkjetPrinter(i+cnt, RandNumber(0, 2));
                LaserPrinterArray[i] = new LaserPrinter(i+cnt*2, RandNumber(0, 2));
            }
            for (int i = 0; i < cnt ; i++) AllPrinters.Add(MatrixPrinterArray[i]);
            for (int i = 0; i < cnt; i++) AllPrinters.Add(InkjetPrinterArray[i]);
            for (int i = 0; i < cnt; i++) AllPrinters.Add(LaserPrinterArray[i]);
        }

        public void FillTaskArray()
        {
            int type = 0;
            Task tsk;
            for (i = 0; i <= 30; i++) { 
                type = RandNumber(1, 4);
                switch (type)
                {
                    case 1:
                        {
                            tsk= new Task(RandNumber(1, 1000), RandNumber(50, 1200), 0, RandNumber(0, 2), GetRandomPrinter(type), type);
                            TaskArray.Add(tsk);
                            break;
                        }
                    case 2:
                        {
                            tsk = new Task(RandNumber(1, 1000), RandNumber(50, 1200), RandNumber(0, 2), 0, GetRandomPrinter(type), type);
                            TaskArray.Add(tsk);
                            break;
                        }
                    case 3:
                        {
                            tsk = new Task(RandNumber(1, 1000), RandNumber(50, 1200), RandNumber(0, 2), RandNumber(0, 2), GetRandomPrinter(type), type);
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
        public Printer GetRandomPrinter(int type)
        {
            int i = RandNumber(0, 10);
            switch (type) {
                case 1:
                {
                    foreach (Printer pr in MatrixPrinterArray)
                        if (pr.Get_Id()== i) return pr;
                        break;
                }
                case 2:
                {
                    foreach (Printer pr in InkjetPrinterArray)
                        if (pr.Get_Id() == i) return pr;
                        break;
                }
                case 3:
                    {
                        foreach (Printer pr in LaserPrinterArray)
                            if (pr.Get_Id() == i) return pr;
                        break;
                    }
            }
            return null;
        }
        public static int RandNumber(int Low, int High)
        {
            Random rndNum = new Random(int.Parse(Guid.NewGuid().ToString().Substring(0, 8), System.Globalization.NumberStyles.HexNumber));

            int rnd = rndNum.Next(Low, High);

            return rnd;
        }
    }
}