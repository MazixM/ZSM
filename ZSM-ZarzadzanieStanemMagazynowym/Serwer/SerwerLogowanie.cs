using System;
using System.Collections.Generic;
using System.Text;

namespace ZSM_ZarzadzanieStanemMagazynowym.Serwer
{
    public class SerwerLogowanie
    {
        /// <summary>
        /// Logowanie do systemu
        /// </summary>
        /// <param name="login">Login użytkownika</param>
        /// <param name="haslo">Hasło użytkownika</param>
        /// <returns>Dane użytkownika, lub null, gdy dane były błędne</returns>
        public static Uzytkownik Zaloguj(string login, string haslo)
        {
            Uzytkownik uzytkownik = null;
            //TODO - Odpytanie serwera
            if (login == "Admin" && haslo == "Admin")
            {
                uzytkownik = new Uzytkownik();
                uzytkownik.Id = 1;
                uzytkownik.Login = login;
                uzytkownik.Imie = "Admin";
                uzytkownik.Nazwisko = "Admin";
                List<Uprawnienie> uprawnienia = new List<Uprawnienie>();
                Uprawnienie uprawnienieAdmin = new Uprawnienie
                {
                    Id = 1,
                    Nazwa = "Super Administrator",
                    Opis = "Dostęp do wszystkich funkcji systemu"
                };
                uprawnienia.Add(uprawnienieAdmin);
            }

            return uzytkownik;
        }
    }
}
