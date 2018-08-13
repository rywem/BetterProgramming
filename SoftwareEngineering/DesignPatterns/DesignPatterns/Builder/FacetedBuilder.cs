using System;
namespace DesignPatterns.Builder.Faceted
{

    public class Person
    {
        //address
        public string StreetAddress, PostCode, City;

        //employment 
        public string CompanyName, Position;
        public int AnnualIncome;

        public override string ToString()
        {
            return $"{nameof(StreetAddress)}: {StreetAddress}, {nameof(PostCode)}:  {PostCode}, {nameof(City)}: {City}, {nameof(CompanyName)}: {CompanyName}, {nameof(Position)}: {Position}, {nameof(AnnualIncome)}: {AnnualIncome}";
        }
    }

    public class PersonBuilder // facade
    {
        
    }
    public class FacetedBuilder
    {
        public void Run()
        {
            
        }
    }
}
