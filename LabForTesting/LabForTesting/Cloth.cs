using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabForTesting
{
    public class Cloth
    {
        private int Amount;
        private double Price;
        public void Init(float P, int A)
        {
            Price = P;
            Amount = A;
            if (Amount <= 0) { throw new ArgumentOutOfRangeException(nameof(Amount)); }
            if (Price <= 0) { throw new ArgumentOutOfRangeException(nameof(Price)); }
        }

        public void Read()
        {
            Console.Write("\nВведите цену и количество: ");
            string s = "";
            s = Console.ReadLine();
            string[] s1 = s.Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
            Price = Convert.ToDouble(s1[0]);
            Amount = Convert.ToInt32(s1[1]);
        }
        public void Display()
        {
            Console.Write("Цена ткани: " + Price + "\nКоличество ткани: " + Amount + "\n");
        }
        public double Cost()
        {
            return Price * Amount;
        }

    }
}
