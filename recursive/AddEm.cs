using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursiveFib
{
    public static class AddEm
    {
        public static ulong NewNum { get; set; }
        public static void NumbersToAdd(ulong num1, ulong num2)
        { 
            NewNum = num1 + num2;
            if (NewNum > ulong.MaxValue / 2)
            {
                return;
            }
            NumbersToAdd(num2, NewNum);
            return ;
        }
    }
}
