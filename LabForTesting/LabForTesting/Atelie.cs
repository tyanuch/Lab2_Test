using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabForTesting
{
    public class Atelie
    {
        private String name;
        private Cloth i1 = new Cloth();
        private Cloth i2 = new Cloth();
        private Cloth i3 = new Cloth();
        private int AmountI1, AmountI2, AmountI3, CostDopI;
        public void Init(float P1, int A1, float P2, int A2, float P3, int A3, int AI1, int AI2, int AI3, int C)
        {
            i1.Init(P1, A1);
            i2.Init(P2, A2);
            i3.Init(P3, A3);
            AmountI1 = AI1;
            AmountI2 = AI2;
            AmountI3 = AI3;
            CostDopI = C;
            if (CostDopI < 0) { throw new ArgumentOutOfRangeException(nameof(CostDopI)); }
            if (AmountI1 <= 0) { throw new ArgumentOutOfRangeException(nameof(AmountI1)); }
            if (AmountI2 <= 0) { throw new ArgumentOutOfRangeException(nameof(AmountI2)); }
            if (AmountI3 <= 0) { throw new ArgumentOutOfRangeException(nameof(AmountI3)); }
        }
        public int GetCostDopI()
        {
            return CostDopI;
        }
        public void Read()
        {
            i1.Read();
            Console.Write("Введите количество изделий: ");
            AmountI1 = Convert.ToInt32(Console.ReadLine());
            i2.Read();
            Console.Write("Введите количество изделий: ");
            AmountI2 = Convert.ToInt32(Console.ReadLine());
            i3.Read();
            Console.Write("Введите количество изделий: ");
            AmountI3 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите цену дополнительных аксессуаров: ");
            CostDopI = Convert.ToInt32(Console.ReadLine());
        }
        public void Display()
        {
            Console.Write("Имя продукта: " + name + "\nИзделие 1: ");
            i1.Display();
            Console.Write("Цена первого изделия: " + i1.Cost() + "\n");
            Console.Write("Количество изделий: " + AmountI1);
            Console.Write("\n\nИзделие 2: ");
            i2.Display();
            Console.Write("Цена второго изделия: " + i2.Cost() + "\n");
            Console.Write("Количество изделий: " + AmountI2);
            Console.Write("\n\nИзделие 3: ");
            i3.Display();
            Console.Write("Цена третьего изделия: " + i3.Cost() + "\n");
            Console.Write("Количество изделий: " + AmountI3);
            Console.Write("\n\nСтоимость дополнительных аксессуаров: " + CostDopI + "\n");
        }
        public void Name()
        {
            name = Console.ReadLine();
        }
        public double CostWithDop()
        {
            return i1.Cost() * AmountI1 + i2.Cost() * AmountI2 + i3.Cost() * AmountI3 + CostDopI;
        }
        public Cloth Expensive()
        {
            double a = i1.Cost();
            double b = i2.Cost();
            double c = i3.Cost();
            if (a >= b && a >= c) { return i1; }
            else if (b >= a && b >= c) { return i2; }
            else return i3;
        }
    }
}
