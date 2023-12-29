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
        public static void Test9BoxingUnBoxing()
            {
            int num = 23;         // value type is int and assigned value 23
            //num=23 craeted in stack
            Object Obj = num;    // Boxing
            //Obj created in Heap 
            int i = (int)Obj;    // Unboxing
            //Cast it additionally & then creates object in STACK
            }
         }
    }
