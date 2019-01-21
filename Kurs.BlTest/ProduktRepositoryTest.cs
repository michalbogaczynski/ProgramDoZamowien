using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Kurs.BL;

namespace Kurs.BlTest
{
    [TestClass]
    public class ProduktRepositoryTest
    {
        [TestMethod]
        public void PobierzProduktTest()
        {
            // Arrange (przygotuj test)
            var produktRepository = new ProduktRepository();
            var oczekiwane = new Produkt(5)
            {
                NazwaProduktu = "Klocki",
                Opis = "Klocki dla dzieci",
                AktualnaCena = 89.99M
            };

            // Act (działaj)
            var aktualne = produktRepository.Pobierz(5);



            // Assert (potwierdz test)
            Assert.AreEqual(oczekiwane.ProduktID, aktualne.ProduktID);
            Assert.AreEqual(oczekiwane.NazwaProduktu, aktualne.NazwaProduktu);
            Assert.AreEqual(oczekiwane.Opis, aktualne.Opis);
            Assert.AreEqual(oczekiwane.AktualnaCena, aktualne.AktualnaCena);
        }
    }
}
