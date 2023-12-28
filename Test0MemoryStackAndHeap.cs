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
        #region Test0MemoryStackAndHeap
        public static void Test0MemoryStackAndHeap()
            {
            Console.WriteLine();
            Console.WriteLine(nameof(Test0MemoryStackAndHeap));
            int x = 5; // x is a local variable and is stored on the stack

            // y is a reference to an object and is stored on the stack
            // the object itself is stored on the heap
            string y = new string("hello");

            // z is a reference to the same object as y
            // both y and z are stored on the stack, but the object is only stored once on the heap
            string z = y;

            // the object referenced by y and z is no longer needed, so the garbage collector will deallocate the memory on the heap
            y = null;
            z = null;
            Console.WriteLine($"To understand {nameof(Test0MemoryStackAndHeap)} check the code");
            Console.WriteLine();
            Console.ReadLine();
            }
        #endregion Test0MemoryStackAndHeap
        }
    }
