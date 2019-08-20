using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Task1.Task1 t1 = new Task1.Task1();
            t1.Execute();

            Task2.Task2 t2 = new Task2.Task2();
            t2.Execute();
        }
    }
}
