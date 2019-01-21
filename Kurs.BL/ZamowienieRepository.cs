using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kurs.BL
{
    public class ZamowienieRepository
    {
        
        /// <summary>
        /// Pobieramy jedno zamowienie
        /// </summary>
        /// <param name="zamowienieID"></param>
        /// <returns></returns>
        public Zamowienie Pobierz(int zamowienieID)
        {

            Zamowienie zamowienie = new Zamowienie(zamowienieID);
            //kod który pobiera określony produkt
            //tymczasowo zakodowane wartości zamówienia
            if (zamowienieID == 10)
            {
                zamowienie.DataZamowienia = new DateTimeOffset(2018, 4, 20, 11, 00, 00, new TimeSpan(7, 0, 0));
            }
            return zamowienie;
        }

        /// <summary>
        /// Pobieramy wszystkie zamówienia
        /// </summary>
        /// <returns></returns>
        public List<Zamowienie> Pobierz()
        {
            //kod który pobiera wszystkie zamowienia
            return new List<Zamowienie>();
        }


        /// <summary>
        /// Zapisuje zamówienie
        /// </summary>
        /// <returns></returns>
        public bool Zapisz()
        {
            //kod który zapisuje zdefiniowane zamówienie
            return true;
        }

    }
}
