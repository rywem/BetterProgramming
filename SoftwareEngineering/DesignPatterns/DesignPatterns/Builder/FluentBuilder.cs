using System;
namespace DesignPatterns.Builder.Fluent
{
    /// <summary>
    /// Fluent builder
    /// </summary>
    public class Person
    {
        public string Name;
        public string Position;
        public override string ToString()
        {
            return $"{nameof(Name)}: {Name}, {nameof(Position)}: {Position}";
        }

        public class Builder : PersonJobBuilder<Builder> 
        {
            
        }


        public static Builder New => new Builder();
    }



    public abstract class PersonBuilder
    {
        protected Person person = new Person();

        public Person Build()
        {
            return person;    
        }
    }
    /// <summary>
    /// Recursive generics
    /// </summary>
    /// https://www.udemy.com/design-patterns-csharp-dotnet/learn/v4/t/lecture/8708948?start=400
    public class PersonInfoBuilder<SELF> : PersonBuilder where SELF : PersonInfoBuilder<SELF>
    {
        //protected Person person = new Person();
        public SELF Called(string name)
        {
            person.Name = name;
            return (SELF)this;
        }
    }

    public class PersonJobBuilder<SELF> : PersonInfoBuilder<PersonJobBuilder<SELF>>
        where SELF : PersonJobBuilder<SELF>
    {
        public SELF worksAsA(string position)
        {
            person.Position = position;
            return (SELF) this;
        }
    }

    public class FluentBuilder
    {
        public void Run()
        {
           
            var worker = Person.New.Called("John")
                  .worksAsA("Programmer")
                  .Build();
            var x = worker.GetType();
            Console.WriteLine($"{worker.ToString()},  of type:{worker.GetType().Name}");
            //builder.Called("ry").
        }
    }
}
