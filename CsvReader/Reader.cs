using System;
using System.Collections.Generic;
using System.Text;

namespace CsvReader
{
    class Reader
    {
        private string csvFilePath;

        public Reader(string csvfilepath)
        {
            this.csvFilePath = csvfilepath;
        }

        public Country[] ReadFirstNCountries(int nCountries)
        {
            Country[] countries = new Country[nCountries];
            return countries;
        }

        public Country ReadCountryFromCsvLine(string csvline)
        {
            string[] parts = csvline.Split(',');

            string name = parts[0];
            string code = parts[1];
            string region = parts[2];
            int population = int.Parse(parts[3]);

            return new Country(name, code, region, population);
        }
    }
}
