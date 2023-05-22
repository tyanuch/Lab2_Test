using LabForTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabForTesting
{
    class Program
    {
        static void Main(string[] args)
        {
            Atelie y = new Atelie();
            Console.Write("Изделие: ");
            y.Name();
            y.Init((float)200.2, 12, (float)443.5, 43, 312, 21, 22, 33, 11, 1815);
            y.Display();
            y.Read();
            y.Display();
            Cloth p = y.Expensive();
            Console.Write("\nИтоговая цена всего: " + y.CostWithDop() + "\nСамая дорогая одежда:\n");
            p.Display();
        }
    }
}

