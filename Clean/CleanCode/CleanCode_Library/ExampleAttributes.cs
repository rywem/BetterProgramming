using System;

namespace CleanCode_Library
{

    [System.AttributeUsage(AttributeTargets.Property | AttributeTargets.Method | AttributeTargets.Class | AttributeTargets.Field)]
    public class ExampleAttributes : Attribute
    {
        public ExampleType ExampleType { get; set; }
        public ExampleAttributes(ExampleType typeOfExample)
        {
            this.ExampleType = typeOfExample;
        }
    }
}
