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

        #region Test1ValuetypeVsRefTypeTest
        public static void Test1ValuetypeVsRefTypeTest()
            {
            Console.WriteLine($"{nameof(Test1ValuetypeVsRefTypeTest)}");
            Console.WriteLine($"Step1:ValueType");
            int a1 = 10;
            Console.WriteLine($"Calling {nameof(ChangeValue)} with {nameof(a1)}:{a1}");
            static void ChangeValue(int x)
                {
                Console.WriteLine($"{nameof(ChangeValue)}: Before {x}");
                x = 200;
                Console.WriteLine($"{nameof(ChangeValue)}: After {x}");
                }
            ChangeValue(a1);
            Console.WriteLine($"result={a1}");
            Console.WriteLine();
            Console.WriteLine($"Step2:ReferenceType");
            BaseClass b = new BaseClass();
            b.MyPropertyInt = 100;
            static void ChangeReferenceType(BaseClass std2)
                {
                Console.WriteLine($"{nameof(ChangeReferenceType)}: Before {std2.MyPropertyInt}");
                std2.MyPropertyInt = 200;//no need to return & assign back to main object
                Console.WriteLine($"{nameof(ChangeReferenceType)}: After {std2.MyPropertyInt}");
                }
            Console.WriteLine($"Calling {nameof(ChangeReferenceType)} with {nameof(b.MyPropertyInt)}:{b.MyPropertyInt}");
            ChangeReferenceType(b);//no need to get return result & assign back to main object
            Console.WriteLine($"result={b.MyPropertyInt}");
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine();
            Console.ReadLine();
            }
        #endregion Test1ValuetypeVsRefTypeTest
}
    }
