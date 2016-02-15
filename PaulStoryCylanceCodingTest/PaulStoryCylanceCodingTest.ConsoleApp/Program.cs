using System;
using PaulStoryCylanceCodingTest.Data;

namespace PaulStoryCylanceCodingTest.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            InitializeDatabase();

        }

        private static void InitializeDatabase()
        {
            try
            {
                Console.WriteLine("Initializing Database...");

                DataContext context = new DataContext();
                context.Database.Initialize(true);

                Console.WriteLine("Done...");
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(string.Format("ERROR MESS: {0}", ex.Message));
                Console.ReadLine();
            }
        }
    }
}
