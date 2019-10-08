using System;

public class Off
{
    public OFF()
    {
        void turnoff()
        {
            std::cout << "Wprowadz czas w minutach po jakim chcesz zamknac system - > ";
            std::cin >> czas; //pobor czasu w sekundach
            czas *= 60; //minuty
            string wylaczamy = "shutdown -s -t ";
            string czasString = to_string(czas / 60); // dopis w minutach do informacji
            wylaczamy.append(czasString);
            string wiadomosc = "  -c \" bedziemy sie zamykac za ->  ";
            wiadomosc.append(czasString);
            wiadomosc.append(" minut \"");
            wylaczamy.append(wiadomosc); // tekst komendy po dodaniu najwazniejszych informacji
            cout << wylaczamy; // test i tresc komendy
            const char* komenda = wylaczamy.c_str(); //zamiana komendy na const char* typ wymagany przez system()
            system(komenda); //aktywacja komendy
        }
    }
}
