using System;
using System.Collections.Generic;
using System.Linq;

namespace DesignPatterns.SOLID
{
    public enum Relationship
    {
        Parent, Child, Sibling
    }

    public class Person
    {
        public string Name;
        //public DateTime DateOfBirth;
    }
    public interface IRelationshipBrowser
    {
        IEnumerable<Person> FindAllChildrenOf(string name);
    }

    //low level
    public class Relationships : IRelationshipBrowser
    {
        private List<Tuple<Person, Relationship, Person>> relations = new List<Tuple<Person, Relationship, Person>>();

        public void AddParentAndChild(Person parent, Person child)
        {
            relations.Add(Tuple.Create<Person, Relationship, Person>(parent, Relationship.Parent, child));
            relations.Add(Tuple.Create<Person, Relationship, Person>(child, Relationship.Child, parent));
        }

        public IEnumerable<Person> FindAllChildrenOf(string name)
        {
            return relations.Where(x => x.Item1.Name == name && x.Item2 == Relationship.Parent)
                            .Select(r => r.Item3);
        }

        public List<Tuple<Person, Relationship, Person>> Relations => relations;
    }

    public class DRunner
    {

        public DRunner(IRelationshipBrowser browser)
        {
            foreach (var p in browser.FindAllChildrenOf("John"))
                Console.WriteLine($"John has a child named {p.Name}");

        }
        public static void Run()
        {
            var parent = new Person { Name = "John" };
            var child1 = new Person { Name = "Chris" };
            var child2 = new Person { Name = "Mary" };

            var relationships = new Relationships();
            relationships.AddParentAndChild(parent, child1);
            relationships.AddParentAndChild(parent, child2);

            new DRunner(relationships);
        }
    }
}
