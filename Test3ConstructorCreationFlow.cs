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
            using (BaseClass b1 = new BaseClass())
                {
                Console.WriteLine(b1.MyString1);
                }
            Console.WriteLine();
            Console.ReadLine();
            }
        #endregion Test3ConstructorCreationFlow
        }
    }
