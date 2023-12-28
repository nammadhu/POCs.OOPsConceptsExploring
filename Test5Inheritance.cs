using POCs.OOPsConcepTsExploring;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static POCs.OOPsConceptsExploring.ClassesAndStructs;

namespace POCs.OOPsConceptsExploring
    {
    internal partial class TestImplementations
        {
        #region Test5Inheritance
        public static void Test5Inheritance()
            {
            Console.WriteLine(nameof(Test5Inheritance));
            BaseClass b1 = new BaseClass();
            DerivedClass d1 = new DerivedClass();
            Console.WriteLine(d1.DerivedProperty1);
            b1 = d1;//when this happens DerivedProperty1 will not be accessible
            Console.WriteLine(d1.DerivedProperty1);
            Console.WriteLine();
            Console.ReadLine();
            }
        #endregion Test4Inheritance

     
        }
    }
