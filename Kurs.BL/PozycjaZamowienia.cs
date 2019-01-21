using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kurs.BL
{
    public class PozycjaZamowienia
    {
        public PozycjaZamowienia()
        {

        }
        public PozycjaZamowienia(int pozycjaZamowienieID)
        {
            PozycjaZamowieniaID = pozycjaZamowienieID;
        }

        public int PozycjaZamowieniaID { get; private set; }
        public int Ilosc { get; set; }
        public int ProduktID { get; set; }
        public Decimal? CenaZakupu { get; set; }

        //Metody
        /// <summary>
        /// Sprawdza dane pozycji zamówienia
        /// </summary>
        /// <returns></returns>
        public bool Waliduj()
        {
            var poprawne = true;

            if (Ilosc <= 0)
                poprawne = false;
            if (ProduktID <= 0)
                poprawne = false;
            if (CenaZakupu == 0)
                poprawne = false;

            return poprawne;

        }
        /// <summary>
        /// Zapisuje element zamówienia
        /// </summary>
        /// <returns></returns>
        public bool Zapisz()
        {
            //kod który zapisuje zdefiniowane pozycje zamówienia
            return true;
        }
        /// <summary>
        /// Pobieramy jeden element zamówienia
        /// </summary>
        /// <param name="pozycjaZamowienieID"></param>
        /// <returns></returns>
        public PozycjaZamowienia Pobierz(int pozycjaZamowienieID)
        {
            //kod który pobiera określony produkt
            return new PozycjaZamowienia();
        }




    }
}
