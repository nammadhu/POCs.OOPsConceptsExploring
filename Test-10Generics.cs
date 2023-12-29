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
        //step1
        public class GenericClass<T>
            {
            private T genericField;

            public GenericClass(T value)
                {
                genericField = value;
                }

            public T GetValue()
                {
                return genericField;
                }
            }


        public static void Test10Generics()
            {
            Console.WriteLine("Step1 GenericClass");
            GenericClass<int> intObj = new GenericClass<int>(42);
            Console.WriteLine(intObj.GetValue()); // Output: 42
            GenericClass<string> stringObj = new GenericClass<string>("Hello, Generics!");
            Console.WriteLine(stringObj.GetValue()); // Output: Hello, Generics!

            Console.WriteLine("Step2 GenericMethods");
            GenericMethods genericMethods = new GenericMethods();
            Console.WriteLine(genericMethods.Max(3, 7));               // Output: 7
            Console.WriteLine(genericMethods.Max("apple", "orange"));  // Output: orange

            Console.WriteLine("Step2 Interface");
            IGenericInterface<int> intInterfaceObj = new GenericInterfaceClass<int>(123);
            Console.WriteLine(intInterfaceObj.GetValue()); // Output: 123

            IGenericInterface<string> stringInterfaceObj = new GenericInterfaceClass<string>("Generic Interface");
            Console.WriteLine(stringInterfaceObj.GetValue()); // Output: Generic Interface

            }
        //step2
        public class GenericMethods
            {
            public T Max<T>(T first, T second) where T : IComparable<T>
                {
                return first.CompareTo(second) > 0 ? first : second;
                }
            }

        //step3 IGenericInterface
        public interface IGenericInterface<T>
            {
            T GetValue();
            }

        public class GenericInterfaceClass<T> : IGenericInterface<T>
            {
            private T value;

            public GenericInterfaceClass(T val)
                {
                value = val;
                }

            public T GetValue()
                {
                return value;
                }
            }

        }
    }
