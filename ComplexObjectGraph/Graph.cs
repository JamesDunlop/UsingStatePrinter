using System.Collections.Generic;

namespace ComplexObjectGraph
{
    public class Policy
    {
        IList<Traveller> Travellers { get; set; }

        IList<Dependent> Dependents { get; set; }
    }

    public class Traveller
    {
    }

    public class Dependent
    {
    }

}
