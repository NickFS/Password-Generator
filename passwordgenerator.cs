using System;


namespace PasswordGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();
            for (var i = 0; i < 10; i++)
                Console.Write((char) random.Next(97, 122));

           Console.WriteLine();

           

       }
    }
}