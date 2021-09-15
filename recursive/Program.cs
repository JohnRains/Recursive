using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursiveFib
{
    class Program
    {
        static void Main(string[] args)
        {
            var start = DateTime.Now;
            AddEm.NumbersToAdd(0, 1);
            Console.WriteLine($"Value = {AddEm.NewNum} in {(DateTime.Now - start).TotalMilliseconds} milliseconds\nEnter to close");
            Console.ReadLine();
        }

    }


}
