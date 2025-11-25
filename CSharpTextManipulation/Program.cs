namespace CSharpTextManipulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //zadanie 1
            //Zamiana wielkości liter
            Console.WriteLine("Proszę wpisać zdanie");
            string zad1 = Console.ReadLine();
            Console.WriteLine(zad1.Length);
            Console.WriteLine(zad1.ToUpper());
            Console.WriteLine(zad1.ToLower());
            

        }
    }
}
