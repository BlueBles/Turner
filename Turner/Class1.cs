using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turner
{
    class Offuj
    {

        
            
         public string turnoff(int czas) //works perfectly D.H.
                {
                    czas *= 60; //minuty
                    string wylaczamy = "shutdown -s -t ";
                    wylaczamy = wylaczamy + czas;
                    string czasString = Convert.ToString(czas / 60); // dopis w minutach do informacji
                    string wiadomosc = "  -c \" bedziemy sie zamykac za ->  ";
                    wiadomosc = wiadomosc + (czasString);
                    wiadomosc = wiadomosc + (" minut \"");
                    wylaczamy = wylaczamy+(wiadomosc); // tekst komendy po dodaniu najwazniejszych informacji
                    string komenda = wylaczamy;

                    System.Diagnostics.Process cmd = new System.Diagnostics.Process();
                    cmd.StartInfo.FileName = "cmd.exe"; //nazwa apki
                    cmd.StartInfo.RedirectStandardInput = true; //przesylaj wejscie
                    cmd.StartInfo.RedirectStandardOutput = true; //przesylaj wyjscie
                    cmd.StartInfo.CreateNoWindow = true; //nie tworz okna
                    cmd.StartInfo.UseShellExecute = false;
                    cmd.Start(); //zacznij
                    cmd.StandardInput.WriteLine(komenda); //komenda zostaje przeslana i aktywowana
                    cmd.StandardInput.Flush();
                    cmd.StandardInput.Close();
                    cmd.WaitForExit();
                    Console.WriteLine(cmd.StandardOutput.ReadToEnd());
            return komenda;
        }
            
        

    }
}
