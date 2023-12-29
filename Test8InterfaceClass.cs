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
        public static void Test8InterfaceClass()
            {
            Console.WriteLine(nameof(Test8InterfaceClass));
            SimpleClass4 s = new SimpleClass4();
            Console.WriteLine("s.Test2Method()");
            s.Test2Method();
            Console.WriteLine();
            //s.Test1Method();//not allowed but below is allowed as it exists in interface level with default logic
            IClassesAndStructs i1 = new SimpleClass4();
            Console.WriteLine("i1.Test1Method()");
            i1.Test1Method();
            Console.WriteLine();
            Console.WriteLine("i1.Test2Method()");
            i1.Test2Method();
            Console.WriteLine();
            Console.WriteLine("i1.Test3Method()");
            i1.Test3Method();
            Console.WriteLine();
            Console.WriteLine("s.Test3Method();");
            s.Test3Method();
            Console.WriteLine();

            Console.ReadLine();
            }
        public interface IClassesAndStructs
            {
            public int MyProperty { get; set; }

            public void Test1Method()
                {
                Console.WriteLine($"{nameof(Test1Method)} with default logic in interface itself");
                }

            public void Test2Method();
            public void Test3Method()
                {
                Console.WriteLine($"{nameof(Test3Method)} with default logic in interface itself");
                }
            }
        public class SimpleClass4 : IClassesAndStructs
            {
            public int MyProperty { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

            public void Test2Method()
                {

                Console.WriteLine("bbb");
                }
            public void Test3Method()
                {
                Console.WriteLine($"{nameof(Test3Method)} from {nameof(SimpleClass4)}");
                }
            }
        
        }
    }
