﻿using System.Collections.Generic;

namespace Kurs.BL
{
    public class Klient
    {
        public Klient()
        {

        }

        public Klient(int klientId)
        {
            KlientId = klientId;
        }

        // Właściwości

        public static int Licznik { get; set; }

        private string _nazwisko;
        public string Nazwisko
        {
            get
            { 
                // tutaj możemy dodać dowlony kod
                return _nazwisko;
            }
            set
            {
                // tutaj możemy dodać dowlony kod
                _nazwisko = value;
            }
        }

        public string Imie { get; set; }

        public string Email { get; set; }

        public int KlientId { get; private set; }
        

        public string ImieNazwisko
        {
            get
            {
                string imieNazwisko = Imie;

                if (!string.IsNullOrWhiteSpace(Nazwisko))
                {
                    if (!string.IsNullOrWhiteSpace(imieNazwisko))
                    {
                        imieNazwisko += ", ";
                    }
                    imieNazwisko += Nazwisko;
                }

                return imieNazwisko;
            }
        }

        // Metody

        public bool Waliduj()
        {
            var poprawne = true;

            if (string.IsNullOrWhiteSpace(Nazwisko))
                poprawne = false;
            if (string.IsNullOrWhiteSpace(Email))
                poprawne = false;

            return poprawne;

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
        /// <summary>
        /// Pobieramy jednego klienta
        /// </summary>
        /// <param name="klientID"></param>
        /// <returns></returns>
        public Klient Pobierz(int klientID)
        {
            //kod który pobiera określonego klienta
            return new Klient();
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
    }
}
