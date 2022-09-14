using System;


    namespace uppgift2_13
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vill du ge ut lönerna till lönetagarna?");
            Console.ReadLine();

            Console.WriteLine("Ja? Lägg ihop teras löner.");
            Console.ReadLine();

            Console.WriteLine("Hur mycket lön har ska Thomas få?");
            string strThomaslöntext = Console.ReadLine();
            int Thomaslön = int.Parse(strThomaslöntext);

            Console.WriteLine("Hur mycket lön ska Jacob få?");
            string strJacobslöntext = Console.ReadLine();
            int Jacobslön = int.Parse(strJacobslöntext);

            Console.WriteLine("hur mycket lön ska David få?");
            string strDavidslöntext = Console.ReadLine();
            int Davidslön = int.Parse(strDavidslöntext);

            int summan;

            summan = Thomaslön + Jacobslön + Davidslön;
            Console.WriteLine("Deras löner sammanlagt blir " + summan); 


        }
    }
}

