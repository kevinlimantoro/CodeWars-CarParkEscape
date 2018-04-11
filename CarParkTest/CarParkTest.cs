using NUnit.Framework;

namespace CodeWars
{
    [TestFixture]
    class KataTestClass
    {
        [TestCase]
        public void BasicTest1()
        {
            Kata kata = new Kata();
            int[,] carpark = new int[,] { { 1, 0, 0, 0, 2 },
                                          { 0, 0, 0, 0, 0 } };
            string[] result = new string[] { "L4", "D1", "R4" };
            Assert.AreEqual(result, kata.Escape(carpark));
        }

        [TestCase]
        public void BasicTest2()
        {
            Kata kata = new Kata();
            int[,] carpark = new int[,] { { 2, 0, 0, 1, 0 },
                                          { 0, 0, 0, 1, 0 },
                                          { 0, 0, 0, 0, 0 } };
            string[] result = new string[] { "R3", "D2", "R1" };
            Assert.AreEqual(result, kata.Escape(carpark));
        }

        [TestCase]
        public void BasicTest3()
        {
            Kata kata = new Kata();
            int[,] carpark = new int[,] { { 0, 2, 0, 0, 1 },
                                          { 0, 0, 0, 0, 1 },
                                          { 0, 0, 0, 0, 1 },
                                          { 0, 0, 0, 0, 0 } };
            string[] result = new string[] { "R3", "D3" };
            Assert.AreEqual(result, kata.Escape(carpark));
        }

        [TestCase]
        public void BasicTest4()
        {
            Kata kata = new Kata();
            int[,] carpark = new int[,] { { 1, 0, 0, 0, 2 },
                                          { 0, 0, 0, 0, 1 },
                                          { 1, 0, 0, 0, 0 },
                                          { 0, 0, 0, 0, 0 } };
            string[] result = new string[] { "L4", "D1", "R4", "D1", "L4", "D1", "R4" };
            Assert.AreEqual(result, kata.Escape(carpark));
        }

        [TestCase]
        public void BasicTest5()
        {
            Kata kata = new Kata();
            int[,] carpark = new int[,] { { 0, 0, 0, 0, 2 } };
            string[] result = new string[] { };
            Assert.AreEqual(result, kata.Escape(carpark));
        }

    }
}