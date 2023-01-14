using NUnit.Framework;
using Rekursion_solution;

namespace RekursionUnitTest
{
    public class RekursionenTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void fakultaet_6_720()
        {
            int ergebniss = Rekursion.fakultaet(6);

            Assert.AreEqual(720, ergebniss);
        }

        [Test]
        public void fakultaet_EingabeNegativeZahl_1()
        {
            int ergebniss = Rekursion.fakultaet(-6);

            Assert.AreEqual(1, ergebniss);
        }

        [Test]
        public void fibonacci_6_8()
        {
            int ergebniss = Rekursion.fibonacci(6);

            Assert.AreEqual(8, ergebniss);
        }

        [Test]
        public void fibunaccis_EingabeNegativZahl_1()
        {
            int ergebniss = Rekursion.fibonacci(-6);

            Assert.AreEqual(1, ergebniss);
        }
    }
}