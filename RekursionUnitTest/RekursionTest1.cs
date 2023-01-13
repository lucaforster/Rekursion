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
        public void fakultaet_EingabeZahl_ErgebnissRichtig()
        {
            int ergebniss = Rekursion.fakultaet(6);

            Assert.AreEqual(720, ergebniss);
        }

        [Test]
        public void fakultaet_EingabeNegativeZahl_ErgebnissRichtig()
        {
            int ergebniss = Rekursion.fakultaet(-6);

            Assert.AreEqual(720, ergebniss);
        }

        [Test]
        public void fibunaccis_EingabeZahl_ErgebnisRichtig()
        {
            int ergebniss = Rekursion.fibunaccis(6);

            Assert.AreEqual(8, ergebniss);
        }

        [Test]
        public void fibunaccis_EingabeNegativZahl_ErgebnisNull()
        {
            int ergebniss = Rekursion.fibunaccis(-6);

            Assert.AreEqual(0, ergebniss);
        }
    }
}