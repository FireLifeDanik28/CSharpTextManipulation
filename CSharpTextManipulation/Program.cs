using System.ComponentModel.DataAnnotations;

namespace CSharpTextManipulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //zadanie 1
            //Zamiana wielkości liter
            Console.WriteLine("Proszę wpisać zdanie");
            string zad1 = Console.ReadLine().ToString();
            Console.WriteLine(zad1.Length);
            Console.WriteLine("Chcesz wypisać (małymi: 1/dużymi: 2/tylko pierwsza duża: 3)");
            //zad 1.1
            while (true)
            {
                string zad1choice = Console.ReadLine().ToString();
                if (zad1choice == "małymi" || zad1choice == "malymi" || zad1choice == "1")
                {
                    Console.WriteLine(zad1.ToLower());
                    break;
                }
                else if (zad1choice == "dużymi" || zad1choice == "duzymi" || zad1choice == "2")
                {
                    Console.WriteLine(zad1.ToUpper());
                    break;
                }
                //zad 1.2
                else if (zad1choice == "tylko pierwsza duża" || zad1choice == "tylko pierwsza duza" || zad1choice == "3")
                {
                    Console.WriteLine(zad1.Substring(0, 1).ToUpper() + zad1.Substring(1, zad1.Length - 1).ToLower());
                    break;
                }
                else
                    Console.WriteLine("możesz tylko napisać: małymi, malymi, dużymi, duzymi, tylko pierwsza duża, tylko pierwsza duza, 1, 2, 3");
            }
            //zad 2
            //Długość tekstu i pierwsza/ostatnia litera
            Console.WriteLine("Proszę wpisać dowolny tekst");
            string zad2 = Console.ReadLine().ToString().Trim();
            Console.WriteLine(zad2);
            Console.WriteLine(zad2.Length);
            Console.WriteLine(zad2.Substring(0,1));
            Console.WriteLine(zad2.Substring(zad2.Length - 1, 1));
            //zad 3
            //Zadanie 3: Liczenie wystąpień znaku
            Console.WriteLine("Proszę wpisać dowolny tekst");
            string zad3 = Console.ReadLine().ToString();
            Console.WriteLine("Proszę wpisać dowolną litere do wyszukiwania");
            char zad3letter = Console.ReadKey().KeyChar;
            int zad3occurences = 0;
            for (int i = 0; i < zad3.Length; i++) {
                if (zad3letter == zad3[i])
                {
                    zad3occurences++;
                }
            }
            Console.WriteLine("");
            Console.WriteLine($"Litera {zad3letter} występuje w {zad3} {zad3occurences} razy");
            //zad 4
            //Zamiana spacji na podkreślniki
            Console.WriteLine("Proszę wpisać zdanie");
            string zad4 = Console.ReadLine().ToString();
            //zad 4.2
            Console.WriteLine("Proszę wpisać stary znak do zamiany");
            string zad4oldchar = Console.ReadLine().ToString();
            //zad 4.1
            Console.WriteLine("Proszę wpisać nowy znak do zamiany");
            string zad4newchar = Console.ReadLine().ToString();
            zad4 = zad4.Replace(zad4oldchar, zad4newchar);
            Console.WriteLine(zad4);
            //zad 5
            Console.WriteLine("Proszę wpisać dowolny tekst");
            string zad5 = Console.ReadLine().ToString();
            char[] cArray = zad5.ToCharArray();
            string revZad5 = String.Empty;
            for (int i = 0; i < zad5.Length; i++)
            {
                revZad5 = revZad5 + cArray[zad5.Length - 1 - i];
            }
            Console.WriteLine(revZad5);
            //zad 6
            //czy to palindrom?
            //literalnie ABSOLUtNiE TO SAMO co było w repo Csharp w 11 zadaniu LMFAO.
            Console.WriteLine("Proszę wpisać dowolny tekst, lub palindrom");
            //zad 6.1 oraz 6.2
            string zad6 = Console.ReadLine().ToString().ToLower().Replace(" ", "");
            int halfZad6Length = zad6.Length / 2;
            bool isPalindrome = true;

            for (int i = 0; i < halfZad6Length; i++)
            {
                if (zad6[i] != zad6[zad6.Length - 1 - i])
                {
                    isPalindrome = false;
                    break;
                }
            }
            if (isPalindrome == false)
            {
                Console.WriteLine("Nie jest palindromem");
            }
            else
            {
                Console.WriteLine("Jest palindromem");
            }
            //zad 7
            //Licznik słów
            Console.WriteLine("Proszę wpisać dowolny tekst");
            string zad7 = Console.ReadLine().ToString().Trim();
            string[] words = zad7.Split(' ');
            Console.WriteLine($"Ilość słów: {words.Length}");

        }
    }
}
