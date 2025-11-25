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
            string zad2 = Console.ReadLine().ToString();
            Console.WriteLine(zad2.Trim());
            Console.WriteLine(zad2.Length);
            Console.WriteLine(zad2.Substring(0,1));
            Console.WriteLine(zad2.Substring(zad2.Length - 1, 1));
            
        }
    }
}
