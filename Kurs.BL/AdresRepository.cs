using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kurs.BL
{
    public class AdresRepository
    {

        /// <summary>
        /// Pobieramy jeden adres
        /// </summary>
        /// <param name="adresID"></param>
        /// <returns></returns>
        public Adres Pobierz(int adresID)
        {
            Adres adres = new Adres(adresID);

            if (adresID == 1)
            {
                adres.AdresTyp = 1;
                adres.Ulica = "Gościnna";
                adres.Miasto = "Katowice";
                adres.Kraj = "Polska";
                adres.KodPocztowy = "40-467";
            }
            return adres;
        }

        /// <summary>
        /// Pobieramy wszystkie zdefiniowane adresy dla klienta o przekazanym klientId
        /// </summary>
        /// <param name="klientID"></param>
        /// <returns></returns>
        public IEnumerable<Adres> PobierzPoKlientID(int klientID)
        {
            var listaAdresow = new List<Adres>();

            Adres adres = new Adres(1)
            {
                AdresTyp = 1,
                Ulica = "Adama",
                Miasto = "Opole",
                Kraj = "Polska",
                KodPocztowy = "11-100"

            };
            listaAdresow.Add(adres);

            adres = new Adres(2)
            {
                AdresTyp = 3,
                Ulica = "Miła",
                Miasto = "Katocie",
                Kraj = "Polska",
                KodPocztowy = "44-400"

            };
            listaAdresow.Add(adres);

            return listaAdresow;
        }

        /// <summary>
        /// Zapisuje aktualny adres
        /// </summary>
        /// <param name="adres"></param>
        /// <returns></returns>
        public bool Zapisz(Adres adres)
        {
            return true;
        }
    }
}
