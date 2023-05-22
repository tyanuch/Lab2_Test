using System;
using Xunit;
using LabForTesting;
namespace Lab2Testing
{
    public class UnitTest1
    {
        [Fact]
        public void Test01() // �������� ������ ��� �������� ���� ���������� ������
        {
            Atelie A = new Atelie();
            A.Init(100, 2, 200, 4, 150, 5, 3, 7, 5, 2000);
            Assert.Equal(11950, A.CostWithDop());
        }
        [Fact]
        public void Test02() // ���� ����� ������ ���� ������ 0, �������� ����������, ���� ��� ������ 0
        {
            Atelie A = new Atelie();
            Assert.Throws<ArgumentOutOfRangeException>(() => A.Init(-100, 2, 200, 4, 150, 5, 3, 7, 5, 2000));
        }
        [Fact]
        public void Test03() // ���������� ����� ������ ���� ������ 0, �������� ����������, ���� ��� ������ 0
        {
            Atelie A = new Atelie();
            Assert.Throws<ArgumentOutOfRangeException>(() => A.Init(100, -2, 200, 4, 150, 5, 3, 7, 5, 2000));
        }
        [Fact]
        public void Test04() // ���� ����� ������ ���� ������ 0, �������� ����������, ���� ��� ����� 0
        {
            Atelie A = new Atelie();
            Assert.Throws<ArgumentOutOfRangeException>(() => A.Init(100, -2, 200, 4, 150, 5, 3, 7, 5, 2000));
        }
        [Fact]
        public void Test05() // ���������� ����� ������ ���� ������ 0, �������� ����������, ���� ��� ����� 0
        {
            Atelie A = new Atelie();
            Assert.Throws<ArgumentOutOfRangeException>(() => A.Init(100, 0, 200, 4, 150, 5, 3, 7, 5, 2000));
        }
        [Fact]
        public void Test06() // ��������� �������������� ����������� ������ ���� ������ 0, �������� ����������, ���� ��� ������ 0
        {
            Atelie A = new Atelie();
            Assert.Throws<ArgumentOutOfRangeException>(() => A.Init(100, 2, 200, 4, 150, 5, 3, 7, 5, -2000));
        }
        [Fact]
        public void Test07() // ��������� �������������� ����������� ������ ���� ������ 0, �������� ����������, ���� ��� ����� 0
        {
            Atelie A = new Atelie();
            A.Init(100, 2, 200, 4, 150, 5, 3, 7, 5, 0);
            Assert.Equal(0, A.GetCostDopI());
        }
        [Fact]
        public void Test08() // ���������� ����� ��� ������� ������� ������ ���� ������ 0, �������� ����������, ���� ��� ������ 0
        {
            Atelie A = new Atelie();
            Assert.Throws<ArgumentOutOfRangeException>(() => A.Init(100, 2, 200, 4, 150, 5, -3, 7, 5, 2000));
        }

        [Fact]
        public void Test09() // ���������� ����� ��� ������� ������� ������ ���� ������ 0, �������� ����������, ���� ��� ����� 0
        {
            Atelie A = new Atelie();
            Assert.Throws<ArgumentOutOfRangeException>(() => A.Init(100, 2, 200, 4, 150, 5, 3, 0, 5, 2000));
        }

        [Fact]
        public void Test10() // ���������� ����� ��� �������� ������� ������ ���� ������ 0, �������� ����������, ���� ��� ������ 0
        {
            Atelie A = new Atelie();
            Assert.Throws<ArgumentOutOfRangeException>(() => A.Init(100, 2, 200, 4, 150, 5, 3, 7, -5, 2000));
        }
    }
}