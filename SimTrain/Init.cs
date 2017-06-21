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
            FillTaskArray();
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
            string str_type = "";
            Task tsk;
            for (i = 0; i <= 30; i++) { 
                type = RandNumber(1, 5);
                switch (type)
                {
                    case 1:
                        {
                            tsk= new Task(RandNumber(1, 100), RandNumber(50, 1200), 0, RandNumber(0, 2), GetRandomPrinter(type), type,0);
                            str_type = "матричный";
                            TaskArray.Add(tsk);
                            break;
                        }
                    case 2:
                        {
                            tsk = new Task(RandNumber(1, 100), RandNumber(50, 1200), RandNumber(0, 2), 0, GetRandomPrinter(type), type,0);
                            str_type = "струйный";
                            TaskArray.Add(tsk);
                            break;
                        }
                    case 3:
                        {
                            tsk = new Task(RandNumber(1, 100), RandNumber(50, 1200), RandNumber(0, 2), RandNumber(0, 2), GetRandomPrinter(type), type,0);
                            str_type = "лазерный";
                            TaskArray.Add(tsk);
                            break;
                        }
                    default:
                        {
                            tsk = new Task(RandNumber(1, 100), RandNumber(50, 1200), RandNumber(0, 2), RandNumber(0, 2), null, 0,0);
                            str_type = "любой";
                            TaskArray.Add(tsk);
                            break;
                        }
                }
                string s = "Печать " + Convert.ToString(tsk.Get_CountList()) + 
                    " листов, разрешение " + Convert.ToString(tsk.Get_Resolution()) +
                    ", цветная печать-" + (tsk.Get_ColorPrint() == 1 ? "Да" : "Нет") +
                    ", тип принтера "+str_type+", имя принтера -"+tsk.Get_PrintOn().Get_Name(); 
                f1.listTask.Items.Add(s);
            }
        }
        public Printer GetRandomPrinter(int type)
        {
            int cnt = this.f1.getCntPrn();
            int i = RandNumber(0, cnt);
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
                        if (pr.Get_Id() == i+cnt) return pr;
                        break;
                }
                case 3:
                    {
                        foreach (Printer pr in LaserPrinterArray)
                            if (pr.Get_Id() == i+cnt*2) return pr;
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