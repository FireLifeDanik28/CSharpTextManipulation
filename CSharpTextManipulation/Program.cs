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
            //zad 8
            //Generator akronimów
            Console.WriteLine("Proszę wpisać dowolny tekst");
            string zad8 = Console.ReadLine().ToString().Trim();
            string[] wordsZad8 = zad8.Split(' ');
            string zad8Res = String.Empty;
            for (int i = 0; i < wordsZad8.Length; i++)
            {
                zad8Res = zad8Res + wordsZad8[i][0];
            }
            Console.WriteLine(zad8Res);
            //zad 9
            //Wyciąganie domeny z e-maila
            Console.WriteLine("Proszę wpisać email");
            string zad9 = Console.ReadLine().ToString().Trim();
            for (int i = 0; i < zad9.Length; i++)
            {
                if (i == zad9.IndexOf("@"))
                {
                    Console.WriteLine(zad9.Substring(i+1));
                }
            }
            //zad 10
            Console.WriteLine("Proszę wpisać zdanie");
            string zad10 = Console.ReadLine().ToString().Trim();
            Console.WriteLine("Proszę wpisać słowa zakazane");
            string zad10SwearTableInput = Console.ReadLine().ToString().ToLower();
            string[] zad10SwearTable = zad10SwearTableInput.Split(' ');
            string[] zad10Table = zad10.Split(' ');
            string EndString = string.Empty;
            for (int i = 0; i < zad10Table.Length; i++)
            {
                for (int j = 0; j < zad10SwearTable.Length; j++)
                {
                    if (zad10Table[i] == zad10SwearTable[j])
                    {
                        string StarAmount = string.Empty;
                        for (int c = 0; c < zad10Table[i].Length; c++)
                        {
                            StarAmount = StarAmount + "*";
                        }
                        zad10Table[i] = zad10Table[i].Replace(zad10Table[i], StarAmount);
                    }
                }
            }
            EndString = string.Join(" ", zad10Table);
            Console.WriteLine(EndString);
            
            //zad 11
            
            Console.WriteLine("Proszę wpisać zdanie z cyframi");
            string zad11 = Console.ReadLine().ToString().Trim();
            string zad11SwearTableInput = "1 2 3 4 5 6 7 8 9 0";
            string[] zad11SwearTable = zad11SwearTableInput.Split(' ');
            string[] zad11Table = zad11.Split(' ');
            for (int i = 0; i < zad11Table.Length; i++)
            {
                for (int j = 0; j < zad11SwearTable.Length; j++)
                {
                    if (zad11Table[i] == zad11SwearTable[j])
                    {
                        string ReplaceWith = string.Empty;
                        switch(zad11Table[i])
                        {
                            case "1":
                                ReplaceWith = "jeden";
                            break;
                            case "2":
                                ReplaceWith = "dwa";
                            break;
                            case "3":
                                ReplaceWith = "trzy";
                            break;
                            case "4":
                                ReplaceWith = "czteru";
                            break;
                            case "5":
                                ReplaceWith = "piec";
                            break;
                            case "6":
                                ReplaceWith = "szesc";
                            break;
                            case "7":
                                ReplaceWith = "siedem";
                            break;
                            case "8":
                                ReplaceWith = "osiem";
                            break;
                            case "9":
                                ReplaceWith = "dziewiec";
                            break;
                            case "0":
                                ReplaceWith = "zero";
                            break;
                        }
                        zad11Table[i] = zad11Table[i].Replace(zad11Table[i], ReplaceWith);
                    }
                }
            }
        string EndString2 = string.Join(" ", zad11Table);
        Console.WriteLine(EndString2);
        //zad 12
        string ObamaIpsum = "If there's a senior citizen somewhere who can't pay for their prescription drugs, and has to choose between medicine and the rent, that makes my life poorer, even if it's not my grandparent. Not once in my conversations with him have I heard him talk about any ethnic group in derogatory terms, or treat whites with whom he interacted with anything but courtesy and respect. I reject the view of some in the West that a woman who chooses to cover her hair is somehow less equal, but I do believe that a woman who is denied an education is denied equality. \n\n God bless you.";
        Console.WriteLine("Proszę wpisać zdanie");
        string zad12 = Console.ReadLine().ToString().Trim();
            if (ObamaIpsum.Contains(zad12))
            {
                int index12 = ObamaIpsum.IndexOf(zad12);
                Console.WriteLine($"Found in index: {index12}");
            }
            else {
                Console.WriteLine("404 Not found");
            }
        //zad 13
        Console.WriteLine("Proszę wpisać imie i nazwisko (2 slowa tylko)");
        string zad13 = Console.ReadLine().ToString().Trim();
        string[] zad13Table = zad13.Split(' ');
        zad13Table[0].ToUpper().Substring(1).ToLower();
        zad13Table[1].ToUpper().Substring(1).ToLower();
        Console.WriteLine(zad13Table[0] + " " + zad13Table[1]);
        }
    }
}