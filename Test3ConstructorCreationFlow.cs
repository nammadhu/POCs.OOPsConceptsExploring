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

        #region Test3ConstructorCreationFlow
        public static void Test3ConstructorCreationFlow()
            {
            Console.WriteLine();
            Console.WriteLine(nameof(Test3ConstructorCreationFlow));
            Console.WriteLine();
            Console.WriteLine("Without any parameters,default constructor invocation");
            BaseClass b1 = new BaseClass();
            Console.WriteLine();

            Console.WriteLine();
            Console.WriteLine("With parameters constructor int(derived(a)-base(a) contructor)");
            BaseClass b2 = new BaseClass(5);
            Console.WriteLine();

            Console.WriteLine();
            Console.WriteLine("With parameters constructor string(derived(a)-base(a)-default empty contructor)");
            BaseClass b3 = new BaseClass("b3string");
            Console.WriteLine();

            Console.WriteLine();
            Console.WriteLine("With parameters constructor float(derived(a)-default empty contructor)");
            Console.WriteLine("Still this calls baseclass constructor via this default constructor()");
            BaseClass b4 = new BaseClass(5.8f);//without f it gets confused with double for int cast
            Console.WriteLine();

            //using (BaseClass b1 = new BaseClass(5))
            //    {
            //    Console.WriteLine(b1.MyString1);
            //    }
            Console.WriteLine();
            Console.ReadLine();
            }
        #endregion Test3ConstructorCreationFlow
        }
    }
