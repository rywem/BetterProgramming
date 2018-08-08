using System;
using System.Collections.Generic;

namespace DesignPatterns.SOLID
{

    public enum Color
    {
        Red, Green, Blue
    }

    public enum Size
    {
        Small, Medium, Large, Huge
    }

    public class Product
    {
        public string Name;
        public Color Color;
        public Size Size;

        public Product(string name, Color color, Size size)
        {
            if(name == null)
            {
                throw new ArgumentException("name");
            }
            Name = name;
            Color = color;
            Size = size;
        }
    }

    public class ProductFilter
    {
        public IEnumerable<Product> FilterBySize(IEnumerable<Product> products, Size size)
        {
            foreach (var item in products)
            {
                if(item.Size == size)
                {
                    yield return item;
                }
            }
        }
        public IEnumerable<Product> FilterByColor(IEnumerable<Product> products, Color color)
        {
            foreach (var item in products)
            {
                if (item.Color == color)
                {
                    yield return item;
                }
            }
        }
    }
    public interface ISpecification<T>
    {
        bool IsSatisfied(T t);
    }

    public interface IFilter<T>
    {
        IEnumerable<T> Filter(IEnumerable<T> items, ISpecification<T> spec);   
    }
    public class ColorSpecification : ISpecification<Product>
    {
        private Color color;
        public ColorSpecification(Color color)
        {
            this.color = color;
        }
        public bool IsSatisfied(Product t)
        {
            return t.Color == color;
        }
    }

    public class BetterFilter : IFilter<Product>
    {
        public IEnumerable<Product> Filter(IEnumerable<Product> items, ISpecification<Product> spec)
        {
            foreach(var i in items)
            {
                if (spec.IsSatisfied(i))
                    yield return i;
            }
        }
    }

    public class Runner
    {
        public void Run()
        {
            var apple = new Product("Apple", Color.Green, Size.Small);
            var tree = new Product("Tree", Color.Green, Size.Large);
            var house = new Product("House", Color.Blue, Size.Large);

            Product[] products = { apple, tree, house };

            var productFilter = new ProductFilter();
            Console.WriteLine("Green (old): ");

            foreach (var p in productFilter.FilterByColor(products, Color.Green))
            {
               // Console.WriteLine($" - {p.Name} is green");
            }

            var betterFilter = new BetterFilter();
            Console.WriteLine("Green products (new): ");
            foreach (var p in betterFilter.Filter(products, new ColorSpecification(Color.Green)))
            {
                Console.WriteLine($" - {p.Name} is green");
            }
        }
    }
}
