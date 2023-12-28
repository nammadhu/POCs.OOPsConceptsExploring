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
        

        #region Test4ReferenceTypeChanges
        public static void Test4ReferenceTypeChanges()
            {
            Console.WriteLine(nameof(Test4ReferenceTypeChanges));
            BaseClass b1 = new BaseClass();
            DerivedClass d1 = new DerivedClass();
            Console.WriteLine("d1.DerivedProperty1:" + d1.DerivedProperty1);
            b1 = d1;//when this happens DerivedProperty1 will not be accessible
            Console.WriteLine("d1.DerivedProperty1:" + d1.DerivedProperty1);

            Console.WriteLine();
            Console.WriteLine("Reference type proeprty changes(derived to base class assigned): b1=d1; then");
            Console.WriteLine("Before");
            Console.WriteLine("b1.AbstractProperty1:" + b1.AbstractProperty1);
            Console.WriteLine("d1.AbstractProperty1:" + d1.AbstractProperty1);
            b1.AbstractProperty1 = "new1";
            Console.WriteLine("b1.AbstractProperty1 = \"new1\" Assigned then");
            Console.WriteLine("b1.AbstractProperty1:" + b1.AbstractProperty1);
            Console.WriteLine("d1.AbstractProperty1:" + d1.AbstractProperty1);
            Console.WriteLine();

            Console.WriteLine("Reference type proeprty changes(derived to derived same class assigned): d1=d2; then");
            var d2 = d1;
            Console.WriteLine("since d2=d1,so both all same");
            Console.WriteLine("d2.DerivedProperty1:" + d2.DerivedProperty1);
            Console.WriteLine("d1.DerivedProperty1:" + d1.DerivedProperty1);
            Console.WriteLine("Assigning d2.DerivedProperty1 = \"New2\"");
            d2.DerivedProperty1 = "New2";
            Console.WriteLine("d2.DerivedProperty1:" + d2.DerivedProperty1);
            Console.WriteLine("d1.DerivedProperty1:" + d1.DerivedProperty1);
            Console.WriteLine();
            Console.WriteLine("Assigning d1.DerivedProperty1 = \"New11\"");
            d1.DerivedProperty1 = "New11";
            Console.WriteLine("d2.DerivedProperty1:" + d2.DerivedProperty1);
            Console.WriteLine("d1.DerivedProperty1:" + d1.DerivedProperty1);
            Console.WriteLine();
            var d3 = d2;
            var d4 = d3;
            var d5 = d4;
            Console.WriteLine("d3=d2;d4=d3;d5=d4;");
            Console.WriteLine("Assigning d5.DerivedProperty1 = \"New55\"");
            d5.DerivedProperty1 = "New55";
            Console.WriteLine("d1.DerivedProperty1:" + d1.DerivedProperty1);
            Console.WriteLine("d2.DerivedProperty1:" + d2.DerivedProperty1);
            Console.WriteLine("d3.DerivedProperty1:" + d3.DerivedProperty1);
            Console.WriteLine("d4.DerivedProperty1:" + d4.DerivedProperty1);
            Console.WriteLine("d5.DerivedProperty1:" + d5.DerivedProperty1);

            Console.WriteLine();
            Console.WriteLine($"{nameof(ChangeReferenceType)} and changing to \"New54321\"");
            static void ChangeReferenceType(DerivedClass std2)
                {
                Console.WriteLine($"{nameof(ChangeReferenceType)}: Before {std2.DerivedProperty1}");
                std2.DerivedProperty1 = "New54321";//no need to return & assign back to main object
                Console.WriteLine($"{nameof(ChangeReferenceType)}: After {std2.DerivedProperty1}");
                }
            ChangeReferenceType(d3);
            Console.WriteLine("d1.DerivedProperty1:" + d1.DerivedProperty1);
            Console.WriteLine("d2.DerivedProperty1:" + d2.DerivedProperty1);
            Console.WriteLine("d3.DerivedProperty1:" + d3.DerivedProperty1);
            Console.WriteLine("d4.DerivedProperty1:" + d4.DerivedProperty1);
            Console.WriteLine("d5.DerivedProperty1:" + d5.DerivedProperty1);

            Console.WriteLine();
            Console.WriteLine("Conclusion Any change to reference anywhere it reflects back to all");
            Console.WriteLine();
            Console.WriteLine("More info below");
            Test1ValuetypeVsRefTypeTest();
            Console.WriteLine();
            Console.WriteLine();
            //Console.ReadLine();
            }
        #endregion Test4ReferenceTypeChanges
        }
    }
