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
        #region Test6DeepCopyShallowCopy
        public static void Test6DeepCopyShallowCopy()
            {
            Console.WriteLine(nameof(Test6DeepCopyShallowCopy));
            Console.WriteLine("Step1:ShallowCopy");
            DerivedClass d1 = new DerivedClass();
            d1.MyString = "n1";
            Console.WriteLine();
            Console.WriteLine($"d1.MyString:{d1.MyString},d1.SimpleClass1.SimpleClassString:{d1.SimpleClass1.SimpleClassString}");
            Console.WriteLine("Doing ShallowCopy by var d2 = (DerivedClass)d1.ShallowCopy()");
            var d2 = (DerivedClass)d1.ShallowCopy(); //or d1.ShallowCopy() as DerivedClass
            Console.WriteLine($"d1.MyString:{d1.MyString},d1.SimpleClass1.SimpleClassString:{d1.SimpleClass1.SimpleClassString}");
            Console.WriteLine($"d2.MyString:{d2.MyString},d2.SimpleClass1.SimpleClassString:{d2.SimpleClass1.SimpleClassString}");

            d2.MyString = "n2";
            d2.SimpleClass1.SimpleClassString = "new string2222";
            Console.WriteLine();
            Console.WriteLine("Assigned d2.MyString = \"new string2\" & d2.SimpleClass1.SimpleClassString = \"new string2222\" then as below");
            Console.WriteLine($"d1.MyString:{d1.MyString},d1.SimpleClass1.SimpleClassString:{d1.SimpleClass1.SimpleClassString}");
            Console.WriteLine($"d2.MyString:{d2.MyString},d2.SimpleClass1.SimpleClassString:{d2.SimpleClass1.SimpleClassString}");

            Console.WriteLine();
            Console.WriteLine("On Shallow copy,there are 2 different types behaviour for value & reference type");
            Console.WriteLine("Value type:creates new copy & no reference back");
            Console.WriteLine("ReferenceType:Retains same reference,any changes to any ref will reflect to all");
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Step2:DeepCopy");
            Console.WriteLine("Since in deepcopy reference types are not created new object so had to do those reference additionally");
            Console.WriteLine("Doing ShallowCopy by var d3 = (DerivedClass)d1.ShallowCopy()");
            var d3 = (DerivedClass)d1.DeepCopy();
            Console.WriteLine($"d1.MyString:{d1.MyString},d1.SimpleClass1.SimpleClassString:{d1.SimpleClass1.SimpleClassString}");
            Console.WriteLine($"d3.MyString:{d3.MyString},d3.SimpleClass1.SimpleClassString:{d3.SimpleClass1.SimpleClassString}");

            d3.MyString = "n3";
            d3.SimpleClass1.SimpleClassString = "new string333";
            Console.WriteLine();
            Console.WriteLine("Assigned d3.MyString = \"new string3\" & d3.SimpleClass1.SimpleClassString = \"new string333\" then as below");
            Console.WriteLine($"d1.MyString:{d1.MyString},d1.SimpleClass1.SimpleClassString:{d1.SimpleClass1.SimpleClassString}");
            Console.WriteLine($"d3.MyString:{d3.MyString},d3.SimpleClass1.SimpleClassString:{d3.SimpleClass1.SimpleClassString}");

            Console.WriteLine();
            Console.WriteLine("Conclusion Deep copy expected to create all new references & total new");
            Console.WriteLine("Other ways are by CLone, Serialization...");
            Console.WriteLine();
            Console.WriteLine();
            Console.ReadLine();
            }
        #endregion Test6DeepCopyShallowCopy
        }
    }
