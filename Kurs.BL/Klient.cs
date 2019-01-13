namespace Kurs.BL
{
    public class Klient
    {
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

        public string ImieNazwiskoP
        {
            get
            {
                return Imie + "," + Nazwisko;
            }
        }
        
    }
}
