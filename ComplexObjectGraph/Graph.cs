using System;
using System.Collections.Generic;

namespace ComplexObjectGraph
{
    public class Policy
    {
        public long PolicyId { get; set; }

        public string PolicyNumber { get; set; }

        public DateTime DepartureDate { get; set; }

        public DateTime ReturnDate { get; set; }

        public Country CountryOfResidence { get; set; }

        public IList<Traveller> Travellers { get; set; }

        public IList<Dependent> Dependents { get; set; }
    }

    public class Country
    {
        public long CountryId { get; set; }

        public string Name { get; set; }

        public string Code { get; set; }
    }

    public class Traveller
    {
        public long TravellerId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime DateOfBirth { get; set; }

    }

    public class Dependent
    {
        public long DependentId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime DateOfBirth { get; set; }

    }

}
