using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using wonders;

namespace sharp_21_10_2022_namespase
{
    internal class All_wanders
    {
        private readonly First_Wonders C1 = new First_Wonders();
        private readonly Second_Wonders C2 = new Second_Wonders();
        private readonly Third_Wonders C3 = new Third_Wonders();
        private readonly Fourth_Wonders C4 = new Fourth_Wonders();
        private readonly Fifth_Wonders C5 = new Fifth_Wonders();
        private readonly Sixth_Wonders C6 = new Sixth_Wonders();
        private readonly Seventh_Wonders C7 = new Seventh_Wonders();
        public void Print_All_Wounders()
        {
            C1.Print();
            C2.Print();
            C3.Print(); 
            C4.Print();
            C5.Print();
            C6.Print();
            C7.Print();
        }

    }
}
