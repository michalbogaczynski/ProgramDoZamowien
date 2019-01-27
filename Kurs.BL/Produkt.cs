using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kurs.BL
{
    public class Produkt
    {
        public Produkt()
        {

        }

        public Produkt(int produktID)
        {
            ProduktID = produktID;
        }

        public int ProduktID { get; private set; }
        public Decimal? AktualnaCena { get; set; }
        public string Opis { get; set; }
        public string NazwaProduktu { get; set; }


        //Metody
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
            //kod który zapisuje zdefiniowany produkt
            return true;
        }
        /// <summary>
        /// Pobieramy jedne produkt
        /// </summary>
        /// <param name="produktID"></param>
        /// <returns></returns>
        public Produkt Pobierz(int produktID)
        {
            //kod który pobiera określony produkt
            return new Produkt();
        }

        /// <summary>
        /// Pobieramy wszystkie produkty
        /// </summary>
        /// <returns></returns>
        public List<Produkt> Pobierz()
        {
            //kod który pobiera wszystkich klientów
            return new List<Produkt>();
        }

    }
}
