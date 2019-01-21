using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Kurs.BL;

namespace Kurs.BlTest
{
    [TestClass]
    public class KlientTest
    {
        [TestMethod]
        public void ImieNazwiskoTest()
        {
            // Arrange (przygotuj test)
            Klient klient = new Klient();
            klient.Imie = "Robert";
            klient.Nazwisko = "Kowal";

            string oczekiwana = "Robert, Kowal";

            // Act (działaj)
            string aktualna = klient.ImieNazwisko;

            // Assert (potwierdz test)
            Assert.AreEqual(oczekiwana, aktualna);

        }


        [TestMethod]
        public void ImieNazwiskoImiePusteTest()
        {
            // Arrange (przygotuj test)
            Klient klient = new Klient();            
            klient.Nazwisko = "Kowal";

            string oczekiwana = "Kowal";

            // Act (działaj)
            string aktualna = klient.ImieNazwisko;

            // Assert (potwierdz test)
            Assert.AreEqual(oczekiwana, aktualna);

        }

        [TestMethod]
        public void ImieNazwiskoNazwiskoPusteTest()
        {
            // Arrange (przygotuj test)
            Klient klient = new Klient();
            klient.Imie = "Robert";


            string oczekiwana = "Robert";

            // Act (działaj)
            string aktualna = klient.ImieNazwisko;

            // Assert (potwierdz test)
            Assert.AreEqual(oczekiwana, aktualna);

        }
            [TestMethod]
        public void StaticTest()
        {
            // Arrange (przygotuj test)

            var kln1 = new Klient();
            kln1.Imie = "Jacek";
            Klient.Licznik += 1;

            var kln2 = new Klient();
            kln2.Imie = "Maciek";
            Klient.Licznik += 1;

            var kln3 = new Klient();
            kln3.Imie = "Irek";
            Klient.Licznik += 1;

            // Act (działaj)


            // Assert (potwierdz test)
            Assert.AreEqual(3, Klient.Licznik);



        }


        [TestMethod]
        public void ZwalidujTest()
        {
            // Arrange (przygotuj test)
            var klient = new Klient();
            klient.Nazwisko = "Kowal";
            klient.Email = "marcin@dev-hobby.pl";
            var oczekiwana = true;


            // Act (działaj)
            var aktualna = klient.Waliduj();

            // Assert (potwierdz test)
            Assert.AreEqual(oczekiwana, aktualna);
        }

        [TestMethod]
        public void ZwalidujBrakNazwiskaTest()
        {
            // Arrange (przygotuj test)
            var klient = new Klient();            
            klient.Email = "marcin@dev-hobby.pl";
            var oczekiwana = false;


            // Act (działaj)
            var aktualna = klient.Waliduj();

            // Assert (potwierdz test)
            Assert.AreEqual(oczekiwana, aktualna);
        }

        [TestMethod]
        public void ZwalidujEmailTest()
        {
            // Arrange (przygotuj test)
            var klient = new Klient();
            klient.Nazwisko = "Kowal";
            var oczekiwana = false;


            // Act (działaj)
            var aktualna = klient.Waliduj();

            // Assert (potwierdz test)
            Assert.AreEqual(oczekiwana, aktualna);
        }
    }
}
