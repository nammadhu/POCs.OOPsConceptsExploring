﻿using System;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static System.Runtime.InteropServices.JavaScript.JSType;
using POCs.OOPsConcepTsExploring;
using POCs.OOPsConceptsExploring;
using System.Net;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using static POCs.OOPsConceptsExploring.TestImplementations;

namespace POCs.OOPsConcepTsExploring
    {
    internal class Program
        {
        static void Main(string[] args)
            {
            //Test0MemoryStackAndHeap();
            //Test1ValuetypeVsRefTypeTest();
            //Test2SizeOf();
            //Test3ConstructorCreationFlow();
            //Test4ReferenceTypeChanges();
            //Test5Inheritance();
            //Test5InheritanceType2();
            //Test6DeepCopyShallowCopy();
            //Test7EqualOperators();
            Test8InterfaceClass();

            //  b.NormalProperty2 = 1;

            // AbstractBaseClass a = new AbstractBaseClass();//1.not allowed to create abstract instance
            //  b.NormalProperty2 = 1;
            Console.ReadLine();
            }
      
        }


    }
