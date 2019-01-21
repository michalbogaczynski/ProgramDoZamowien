using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kurs.BL
{
    public class KlientRepository
    {
        
        /// <summary>
        /// Pobieramy jednego klienta
        /// </summary>
        /// <param name="klientID"></param>
        /// <returns></returns>
        public Klient Pobierz(int klientID)
        {
            //Tworzymy instancję klasy klienta
            Klient klient = new Klient(klientID);

            //kod który pobiera określonego klienta

            // Tymczasowo zakodowane wartości, aby zwrócić klienta
            if (klientID == 1)
            {
                klient.Email = "marcin@dev-hobby.pl";
                klient.Imie = "Marcin";
                klient.Nazwisko = "Kowal";                
            }
            return klient;
        }

        /// <summary>
        /// Pobieramy wszystkich klientów
        /// </summary>
        /// <returns></returns>
        public List<Klient> Pobierz()
        {
            //kod który pobiera wszystkich klientów
            return new List<Klient>();
        }

        /// <summary>
        /// Zapisuje klienta
        /// </summary>
        /// <returns></returns>
        public bool Zapisz()
        {
            //kod który zapisuje zdefiniowanego kliena
            return true;
        }
    }
}
