using System;
using System.Collections.Generic;
using System.Linq;

namespace Kurs.BL
{
    public class Produkt
    {
        #region konstruktory
        public Produkt()
        {
        }

        public Produkt(int produktID)
        {
            ProduktID = produktID;
        }
        #endregion

        #region właściwości
        public int ProduktID { get; private set; }
        public Decimal? AktualnaCena { get; set; }
        public string Opis { get; set; }
        public string NazwaProduktu { get; set; }
        #endregion

        #region metody
        /// <summary>
        /// Sprawdza dane produktu
        /// </summary>
        /// <returns></returns>
        public bool Waliduj()
        {
            var poprawne = true;

            if (string.IsNullOrWhiteSpace(NazwaProduktu))
                poprawne = false;
            if (AktualnaCena == null)
                poprawne = false;

            return poprawne;
        }

        /// <summary>
        /// Zapisuje produkt
        /// </summary>
        /// <returns></returns>
        public bool Zapisz()
        {
            // kod, który zapisuje zdefiniowany produkt
            return true;
        }

        /// <summary>
        /// Pobieramy jedne produkt
        /// </summary>
        /// <param name="produktId"></param>
        /// <returns></returns>
        public Produkt Pobierz(int produktID)
        {
            //Kod który pobiera określony produkt
            return new Produkt();
        }

        /// <summary>
        /// Pobieramy wszystkie produkty
        /// </summary>
        /// <returns></returns>
        public List<Produkt> Pobierz()
        {
            //Kod który pobiera wszystkich klientów
            return new List<Produkt>();
        }
        #endregion
    }
}