using System;
using Xunit;
using LabForTesting;
namespace Lab2Testing
{
    public class UnitTest1
    {
        [Fact]
        public void Test01() // ѕроверка работы при передачи всех корректных данных
        {
            Atelie A = new Atelie();
            A.Init(100, 2, 200, 4, 150, 5, 3, 7, 5, 2000);
            Assert.Equal(11950, A.CostWithDop());
        }
        [Fact]
        public void Test02() // ÷ена ткани должна быть больше 0, проверка исключени€, если она меньше 0
        {
            Atelie A = new Atelie();
            Assert.Throws<ArgumentOutOfRangeException>(() => A.Init(-100, 2, 200, 4, 150, 5, 3, 7, 5, 2000));
        }
        [Fact]
        public void Test03() //  оличество ткани должно быть больше 0, проверка исключени€, если оно меньше 0
        {
            Atelie A = new Atelie();
            Assert.Throws<ArgumentOutOfRangeException>(() => A.Init(100, -2, 200, 4, 150, 5, 3, 7, 5, 2000));
        }
        [Fact]
        public void Test04() // ÷ена ткани должна быть больше 0, проверка исключени€, если она равна 0
        {
            Atelie A = new Atelie();
            Assert.Throws<ArgumentOutOfRangeException>(() => A.Init(100, -2, 200, 4, 150, 5, 3, 7, 5, 2000));
        }
        [Fact]
        public void Test05() //  оличество ткани должно быть больше 0, проверка исключени€, если оно равно 0
        {
            Atelie A = new Atelie();
            Assert.Throws<ArgumentOutOfRangeException>(() => A.Init(100, 0, 200, 4, 150, 5, 3, 7, 5, 2000));
        }
        [Fact]
        public void Test06() // —тоимость дополнительных аксессуаров должна быть больше 0, проверка исключени€, если она меньше 0
        {
            Atelie A = new Atelie();
            Assert.Throws<ArgumentOutOfRangeException>(() => A.Init(100, 2, 200, 4, 150, 5, 3, 7, 5, -2000));
        }
        [Fact]
        public void Test07() // —тоимость дополнительных аксессуаров должна быть больше 0, проверка исключени€, если она равна 0
        {
            Atelie A = new Atelie();
            A.Init(100, 2, 200, 4, 150, 5, 3, 7, 5, 0);
            Assert.Equal(0, A.GetCostDopI());
        }
        [Fact]
        public void Test08() //  оличество ткани дл€ первого издели€ должно быть больше 0, проверка исключени€, если оно меньше 0
        {
            Atelie A = new Atelie();
            Assert.Throws<ArgumentOutOfRangeException>(() => A.Init(100, 2, 200, 4, 150, 5, -3, 7, 5, 2000));
        }

        [Fact]
        public void Test09() //  оличество ткани дл€ второго издели€ должно быть больше 0, проверка исключени€, если оно равно 0
        {
            Atelie A = new Atelie();
            Assert.Throws<ArgumentOutOfRangeException>(() => A.Init(100, 2, 200, 4, 150, 5, 3, 0, 5, 2000));
        }

        [Fact]
        public void Test10() //  оличество ткани дл€ третьего издели€ должно быть больше 0, проверка исключени€, если оно меньше 0
        {
            Atelie A = new Atelie();
            Assert.Throws<ArgumentOutOfRangeException>(() => A.Init(100, 2, 200, 4, 150, 5, 3, 7, -5, 2000));
        }
    }
}