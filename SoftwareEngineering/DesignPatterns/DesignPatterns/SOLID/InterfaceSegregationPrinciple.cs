using System;
namespace DesignPatterns.SOLID
{
    public class InterfaceSegregationPrinciple
    {
        public class Document
        {
            
        }

        public interface IPrinter
        {
            void Print(Document d);
        }
        public interface IScanner
        {
            void Scan(Document d);
        }
        public interface IFaxer 
        {
            void Fax(Document d);
        }

        public interface IMultiFunctionDevice : IPrinter, IScanner 
        {
            
        }

        public class MultiFunctionMachine : IMultiFunctionDevice
        {
            private IPrinter printer;
            private IScanner scanner;

            public MultiFunctionMachine(IPrinter printer, IScanner scanner)
            {
                if (printer == null)
                    throw new ArgumentNullException(paramName: nameof(printer));
            }

            public void Print(Document d)
            {
                throw new NotImplementedException();
            }

            public void Scan(Document d)
            {
                throw new NotImplementedException();
            }
        }

        public class Photocopier : IPrinter, IScanner
        {
            public void Print(Document d)
            {
                throw new NotImplementedException();
            }

            public void Scan(Document d)
            {
                throw new NotImplementedException();
            }
        }

        public class OldFashionedPrinter
        {
            
        }
    }
}
