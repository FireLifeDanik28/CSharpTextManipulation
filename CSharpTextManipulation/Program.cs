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
            Console.WriteLine("Chcesz wypisać (małymi/dużymi/tylko pierwsza duża)");
            //zad 1.1
            while (true)
            {
                string zad1choice = Console.ReadLine().ToString();
                if (zad1choice == "małymi" || zad1choice == "malymi")
                {
                    Console.WriteLine(zad1.ToLower());
                    break;
                }
                else if (zad1choice == "dużymi" || zad1choice == "duzymi")
                {
                    Console.WriteLine(zad1.ToUpper());
                    break;
                }
                //zad 1.2
                else if (zad1choice == "tylko pierwsza duża" || zad1choice == "tylko pierwsza duza")
                {
                    Console.WriteLine(zad1.Substring(0, 1).ToUpper() + zad1.Substring(1, zad1.Length - 1).ToLower());
                    break;
                }
                else
                    Console.WriteLine("możesz tylko napisać: małymi, malymi, dużymi, duzymi, tylko pierwsza duża, tylko pierwsza duza");
            }


        }
    }
}
