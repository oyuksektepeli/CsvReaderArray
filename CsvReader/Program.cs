using System;

namespace CsvReader
{
    class Program
    {
        static void Main(string[] args)
        {
            string filepath = @"C:\Repos\CsvReader\CountryPopulations.csv";

            Reader csvreader = new Reader(filepath);

            Country[] countries = csvreader.ReadFirstNCountries(10);

            foreach(Country country in countries)
            {
                Console.WriteLine($"{country.Population}: {country.Name}");
            }
        }
    }
}
