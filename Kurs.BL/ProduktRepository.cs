using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kurs.BL
{
    public class ProduktRepository
    {
        /// <summary>
        /// Pobieramy jedne produkt
        /// </summary>
        /// <param name="produktID"></param>
        /// <returns></returns>
        public Produkt Pobierz(int produktID)
        {
            // Tworzenie instancji produktu
            Produkt produkt = new Produkt(produktID);

            //kod który pobiera określony produkt

            // tymczasowo zakodowane wartości, aby zwrócić produkt
            if (produktID == 5)
            {
                produkt.NazwaProduktu = "Klocki";
                produkt.Opis = "Klocki dla dzieci";
                produkt.AktualnaCena = 89.99M;
            }
            return produkt;
        }

        /// <summary>
        /// Pobieramy wszystkich klientów
        /// </summary>
        /// <returns></returns>
        public List<Produkt> Pobierz()
        {
            //kod który pobiera wszystkich klientów
            return new List<Produkt>();
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
    }
}
