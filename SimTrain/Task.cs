using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimTrain
{
   public class Task:TaskInfo
    {
        private int CountList;
        private int Resolution=-1;
        private int ColorPrint=0;
        private int InfinityPrint=0;
        private Printer PrintOn=null;
        private int PrintOnType=-1;
        private int Status=0;                           // 0 - новая
                                                        // # - в очереди
                                                        // -1 - ошибка - нет доступных принтеров
                                                        // 3 - завершена
        


        public Task( int cnt, int r, int color, int infinity, Printer pr, int PrinterType, int st)
        {
            CountList = cnt;
            Resolution = r;
            ColorPrint = color;
            InfinityPrint = infinity;
            PrintOn = pr;
            PrintOnType = PrinterType;
            Status = st;
        }

        public int Get_CountList() { return CountList; }                                                                               
        public int Get_Resolution() { return Resolution; }                                                                        
        public int Get_ColorPrint() { return ColorPrint; }                                                                
        public int Get_InfinityPrint() { return InfinityPrint; }                                                              
        public int Get_PrintOnType() { return PrintOnType; }          
  //      public int Get_ColorPrint() { return this.matrix_printer == 1 ? "Да" : "Нет"; }                          
  //      public string Get_print_on_lenta() { return this.print_on_lenta == 1 ? "Да" : "Нет"; }                         
  //      public string Get_printColor() { return this.printColor == 1 ? "Да" : "Нет"; }                                 
        public Printer Get_PrintOn() { return PrintOn; }
        public int Get_Status() { return Status; }
        //     public string Get_broken() { return this.broken == true ? "Да" : "Нет"; }                                     
    }
}
