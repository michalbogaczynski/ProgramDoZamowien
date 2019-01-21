using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kurs.BL
{
    public class Zamowienie
    {
        public Zamowienie()
        {

        }
        public Zamowienie(int zamowienieID)
        {
            ZamowienieID = zamowienieID;
        }
        public int ZamowienieID { get; private set; }
        public DateTimeOffset? DataZamowienia { get; set; }


        //Metody
        /// <summary>
        /// Sprawdza dane zamówienia
        /// </summary>
        /// <returns></returns>
        public bool Waliduj()
        {
            var poprawne = true;

            if (DataZamowienia == null)
                poprawne = false;

            return poprawne;

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
        /// <summary>
        /// Pobieramy jedno zamowienie
        /// </summary>
        /// <param name="zamowienieID"></param>
        /// <returns></returns>
        public Zamowienie Pobierz(int zamowienieID)
        {
            //kod który pobiera określony produkt
            return new Zamowienie();
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


    }
}
