﻿using System.Collections.Generic;

namespace Kurs.BL
{
    public class AdresRepository
    {
        /// <summary>
        /// Pobieramy jeden adres.
        /// </summary>
        /// <param name="adresID"></param>
        /// <returns></returns>
        public Adres Pobierz(int adresID)
        {
            // Tworzymy instancję klasy Adres i przekazujemy żądany identyfikator
            Adres adres = new Adres(adresID);

            // Kod, który pobiera zdefiniowany adres

            //Tymczasowo zakodowane wartości do zwrócenia adresu
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
            // Kod, który pobiera zdefiniowany adresy dla klienta

            //Tymczasowo zakodowane wartości do zwrócenia, zestaw adresów
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
                Miasto = "Katowice",
                Kraj = "Polska",
                KodPocztowy = "44-400"
            };
            listaAdresow.Add(adres);

            return listaAdresow;
        }

        /// <summary>
        /// Zapisuje aktualny adres.
        /// </summary>
        /// <returns></returns>
        public bool Zapisz(Adres adres)
        {
            // Kod, który zapisuje zdefiniowany adres.

            return true;
        }
    }
}