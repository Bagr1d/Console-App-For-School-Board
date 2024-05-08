using System;
using System.IO;
namespace Projekt_pp
{
    class Program
    {
        public static string path()
        {
            return Convert.ToString(Environment.GetFolderPath(Environment.SpecialFolder.Desktop));
        }
        public static void wybórOpcje(int o)
        {
          switch(o)
          {
                case 1:
                    Console.Clear();
                    Start();
                    break;
                case 2:
                    Environment.Exit(0);
                    break;               
          }
        }
        public static void Opcje()
        {
            Console.Write("\n1. Wyczyść i zacznij od nowa\n2. Zakończ\n");
            bool stan = true;
            while(stan)
            {
                try
                {
                    int opcje = Convert.ToInt32(Console.ReadLine());
                    if (opcje > 2) Console.WriteLine("Podano złą wartość.Spróbuj ponownie: ");
                    else
                    {
                        wybórOpcje(opcje);
                        stan = false;
                    }
                }
                catch
                {
                    Console.Write("Podano złą wartość.Spróbuj ponownie: ");
                }
            }         
            Console.ReadLine();
        }
        public static void Nauczyciele(int m)
        {
            string nauczyciel =File.ReadAllText($@"{path()}\Projekt-dane\sn{m}.txt");
            Console.Write("\nLista nauczycieli:\n" + nauczyciel);
            Opcje();
            Console.ReadLine();
        }
        public static void Wykładowcy(int w)
        {
            string wykładowca = File.ReadAllText($@"{path()}\Projekt-dane\wn{w}.txt");
            Console.Write("\nLista wykładowców:\n" + wykładowca);
            Opcje();
            Console.ReadLine();
        }
        public static void średnie(int s)
        {
            string lista = File.ReadAllText($@"{path()}\Projekt-dane\s.średnia{s}.txt");
            Console.Write("\nLista uczniów:\n\n" + lista + "\n\nWybierz ucznia: ");
            bool stan = true;
            while(stan)
            {
                try
                {
                    int u = Convert.ToInt32(Console.ReadLine());
                    if (u > 10) Console.Write("Nie znaleziono ucznia o podanym numerze. Spróbuj ponownie: ");
                    else
                    {
                        Uczniowie(u);
                        stan = false;
                    }
                }
                catch
                {
                    Console.Write("Podano złą wartość. Spróbuj ponownie: ");
                }
            }         
            Console.ReadLine();          
        }
        public static void Uczelnie(int w)
        {
            string lista = File.ReadAllText($@"{path()}\Projekt-dane\s.wyższa{w}.txt");
            Console.Write("\nLista studentów:\n\n" + lista + "\n\nWybierz studenta: ");
            bool stan = true;
            while(stan)
            {
                try
                {
                    int s = Convert.ToInt32(Console.ReadLine());
                    if (s > 10) Console.Write("Nie znaleziono studenta o podanym numerze. Spróbuj ponownie: ");
                    else
                    {
                        Studenci(s);
                        stan = false;
                    }
                }
                catch
                {
                    Console.Write("Podano złą wartość. Spróbuj ponownie: ");
                }
            }         
        }
        public static void Studenci(int s)
        {
            string student = File.ReadAllText($@"{path()}\Projekt-dane\student{s}.txt");
            Console.WriteLine($"\nInformacje o studencie numer {s}\n\n" + student);
            Opcje();           
            Console.ReadLine();
        }
        public static void Uczniowie(int u)
        {
            string uczeń = File.ReadAllText($@"{path()}\Projekt-dane\uczeń{u}.txt");
            Console.WriteLine($"\nInformacje o uczniu numer {u}\n\n" + uczeń);
            Opcje();
            Console.ReadLine();
        }
        public static void szkołyŚrednie()
        {
            Console.Write("\nSzkoły Średnie\n\nPodaj numer szkoły: ");
            bool stan = true;
            while(stan)
            {
                try
                {
                    int n = Convert.ToInt32(Console.ReadLine());
                    if (n > 5) Console.Write("Nie znaleziono szkoły o podanym numerze. Spróbuj ponownie: ");
                    else
                    {
                        Console.Write($"\nWybrano szkołę numer {n}.\n");
                        wybórPozŚr(n);
                        stan = false;
                    }
                }
                catch
                {
                    Console.Write("Podano złą wartość. Spróbuj ponownie: ");
                }
            }          
        }
        public static void wybórUni(int x, int n)
        {
            switch(x)
            {
                case 1:
                    Wykładowcy(n);                   
                    break;
                case 2:
                    Uczelnie(n);                  
                    break;
                case 3:
                    Opcje();
                    break;
            }
        }
        public static void wybórŚr(int x, int n)
        {
            switch (x)
            {
                case 1:
                    Nauczyciele(n);                   
                    break;
                case 2:
                    średnie(n);                    
                    break;
                case 3:
                    Opcje();
                    break;
            }
        }
        public static void wybórPozUni(int n)
        {
            Console.Write("Wybierz pozycję:\n1. Lista wykładowców.\n2. Lista studentów.\n3. Opcje\n");
            bool stan = true;
            while(stan)
            {
                try
                {
                    int x = int.Parse(Console.ReadLine());
                    if(x > 3) Console.Write("Podano złą wartość. Spróbuj ponownie: ");
                    else
                    {
                        wybórUni(x,n);
                        stan = false;
                    }
                }
                catch
                {
                    Console.Write("Podano złą wartość. Spróbuj ponownie: ");
                }
            }
        }
        public static void wybórPozŚr(int n)
        {
            Console.Write("Wybierz pozycję:\n1. Lista nauczycieli.\n2. Lista uczniów.\n3. Opcje\n");
            bool stan = true;
            while(stan)
            {
                try
                {
                    int x = Convert.ToInt32(Console.ReadLine());              
                    if (x > 3) Console.Write("Podano złą wartość. Spróbuj ponownie: ");                  
                    else
                    {
                        wybórŚr(x,n);
                        stan = false;
                    }
                }
                catch
                {
                    Console.Write("Podano złą wartość. Spróbuj ponownie: ");
                }
            }          
        }
        public static void szkołyWyższe()
        {
            Console.Write("\nSzkoły Wyższe\n\nPodaj numer uczelni: ");
            bool stan = true;
            while(stan)
            {
                try
                {
                    int n = Convert.ToInt32(Console.ReadLine());
                    if (n > 5) Console.Write("Nie znaleziono uczelni o podanym numerze. Spróbuj ponownie: ");
                    else
                    {
                        Console.Write($"\nWybrano Uczelnię numer {n}.\n");
                        wybórPozUni(n);
                        stan = false;
                    }
                }
                catch
                {
                    Console.Write("Podano złą wartość. Spróbuj ponownie: ");
                }
            }                  
        }
        public static void Start()
        {
            Console.Write("~~~Kuratorium Oświaty~~~~\n");
            string czas = DateTime.Now.ToString("HH:mm:ss");
            string data = DateTime.Now.ToShortDateString();
            Console.WriteLine(data);
            Console.WriteLine(czas);
            Console.Write("\nWybierz rodzaj placówki:\n1. Szkoła Średnia\n2. Szkoła Wyższa\n3. Opcje\n");
            bool stan = true;
            while(stan)
            {
                try
                {
                    int num = Convert.ToInt32(Console.ReadLine());                    
                    switch (num)
                    {
                        case 1:
                            szkołyŚrednie();
                            stan = false;
                            break;
                        case 2:
                            szkołyWyższe();
                            stan = false;
                            break;
                        case 3:
                            Opcje();
                            stan = false;
                            break;
                        default:
                            Console.Write("Podano złą wartość. Spróbuj ponownie: ");                           
                            break;
                    }
                }
                catch
                {
                    Console.Write("Podano złą wartość. Spróbuj ponownie: ");
                }
            }
        }       
        static void Main(string[] args)
        {
            Start();           
        }
    }
}
