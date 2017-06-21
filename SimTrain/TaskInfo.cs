using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimTrain
{
    public interface TaskInfo
    {
        int Get_CountList();
        int Get_Resolution() ;
        int Get_ColorPrint() ;
        int Get_InfinityPrint() ;
        string Get_PrintOn ();
        int Get_PrintOnType ();
        int Get_Status();
    }
}