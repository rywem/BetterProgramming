using System;
using System.Collections.Generic;

namespace CleanCode_Library.Principles
{

    /// <summary>
    /// Chapter 2 recommends using meaningful, "intention revealing" names.
    /// </summary>
    [ExampleAttributes(ExampleType.DoThis)]
    public class NamingGood : NamingBase
    {
        public int elapsedTimeInDays
        {
            get
            {
                return base.someVariableForSavingDays;
            }
            set
            {
                base.someVariableForSavingDays = value;
            }
        }
        public NamingGood()
        {
        }


        public List<int[]> GetFlaggedCells()
        {
            return SomeMethodForMakingAList();
        }
    }

    [ExampleAttributes(ExampleType.AvoidThis)]
    public class NamingBad : NamingBase
    {
        public int d
        {
            get
            {
                return base.someVariableForSavingDays;
            }
            set
            {
                base.someVariableForSavingDays = value;
            }
        }  

        public List<int[]> TheList()
        {
            return SomeMethodForMakingAList();
        }
    }


    public class NamingBase
    {
        public int someVariableForSavingDays { get; set; }


        public List<int[]> SomeMethodForMakingAList()
        {
            return new List<int[]>();
        }
        
    } 
}
