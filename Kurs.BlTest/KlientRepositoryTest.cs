using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Kurs.BL;
using System.Collections.Generic;

namespace Kurs.BlTest
{
    [TestClass]
    public class KlientRepositoryTest
    {
        [TestMethod]
        public void PobierzKlientaTest()
        {
            // Arrange (przygotuj test)
            var klientRepository = new KlientRepository();
            var oczekiwana = new Klient(1)
            {
                Email = "marcin@dev-hobby.pl",
                Imie = "Marcin",
                Nazwisko = "Kowal"

        };
            
            // Act (działaj)
            var aktualna = klientRepository.Pobierz(1);


            // Assert (potwierdz test)
            // Assert.AreEqual(oczekiwana, aktualna);
            Assert.AreEqual(oczekiwana.KlientID, aktualna.KlientID);
            Assert.AreEqual(oczekiwana.Email, aktualna.Email);
            Assert.AreEqual(oczekiwana.Imie, aktualna.Imie);
            Assert.AreEqual(oczekiwana.Nazwisko, aktualna.Nazwisko);

        }

        [TestMethod]
        public void PobierzKlientaZAdresami()
        {
            // Arrange (przygotuj test)
            var klientRepository = new KlientRepository();
            var oczekiwana = new Klient(1)
            {
                Email = "marcin@dev-hobby.pl",
                Imie = "Marcin",
                Nazwisko = "Kowal",
                ListaAdresow = new List<Adres>()
                {
                    new Adres()
                    {
                        AdresTyp = 1,
                        Ulica = "Adama",
                        Miasto = "Opole",
                        Kraj = "Polska",
                        KodPocztowy = "11-100"
                    },
                         new Adres()
                    {
                        AdresTyp = 1,
                        Ulica = "Adama",
                        Miasto = "Opole",
                        Kraj = "Polska",
                        KodPocztowy = "11-100"
                    },
                }
            }

            // Act (działaj)

            // Assert (potwierdz test)
        }
    }
}
