using System;
using ComplexObjectGraph;
using StatePrinter;

namespace Runner
{
    class Program
    {
        static readonly Stateprinter printer = new Stateprinter();

        static void Main(string[] args)
        {
            var policy = new Policy
            {
                PolicyId = 4,
                CountryOfResidence = new Country
                {
                    CountryId = 16,
                    Name = "UK",
                    Code = "GBR"
                },
                PolicyNumber = "QA1200798",
                DepartureDate = new DateTime(2014, 11, 4),
                ReturnDate = new DateTime(2014, 11, 12),
                Travellers = new []
                {
                    new Traveller
                    {
                        TravellerId = 37,
                        FirstName = "John",
                        LastName = "Riley",
                        DateOfBirth = new DateTime(1984, 2, 5)
                    },
                    new Traveller
                    {
                        TravellerId = 38,
                        FirstName = "Julie",
                        LastName = "Riley",
                        DateOfBirth = new DateTime(1986, 8, 1)
                    }
                },
                Dependents = null
            };

            var printedPolicy = printer.PrintObject(policy);

            Console.ReadKey();
        }
    }
}
