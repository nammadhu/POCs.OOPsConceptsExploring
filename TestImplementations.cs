using POCs.OOPsConcepTsExploring;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static POCs.OOPsConceptsExploring.ClassesAndStructs;

namespace POCs.OOPsConceptsExploring
    {
    internal class TestImplementations
        {
        #region Test6DeepCopyShallowCopy
        public static void Test6DeepCopyShallowCopy()
            {
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
            }
        #endregion Test6DeepCopyShallowCopy
        #region Test5Inheritance
        public static void Test5Inheritance()
            {
            BaseClass b1 = new BaseClass();
            DerivedClass d1 = new DerivedClass();
            Console.WriteLine(d1.DerivedProperty1);
            b1 = d1;//when this happens DerivedProperty1 will not be accessible
            Console.WriteLine(d1.DerivedProperty1);

            }
        #endregion Test4Inheritance

        #region Test4ReferenceTypeChanges
        public static void Test4ReferenceTypeChanges()
            {
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
            }
        #endregion Test4ReferenceTypeChanges

        #region Test3ConstructorCreationFlow
        public static void Test3ConstructorCreationFlow()
            {
            using (BaseClass b1 = new BaseClass())
                {
                Console.WriteLine(b1.MyString1);
                }
            }
        #endregion Test3ConstructorCreationFlow

        #region Test2SizeOf
        /// <summary>
        /// Test2SizeOf
        ///C# adatetypes and its sizes
        ///Type	Bytes	Range
        ///byte	1	0 to 255
        ///sbyte	1	-128 to 127
        ///short	2	-32,768 to 32,767
        ///ushort	2	0 to 65,535
        ///int	4	-2 billion to 2 billion
        ///uint	4	0 to 4 billion
        ///long	8	-9 quintillion to 9 quintillion
        ///ulong	8	0 to 18 quintillion
        ///float	4	7 significant digits1
        ///double	8	15 significant digits2
        ///object	4 byte address  All C# Objects
        ///char	2	Unicode characters
        ///string	4 byte address  Length up to 2 billion bytes3
        ///decimal	24	28 to 29 significant digits4
        ///bool	1	true, false5
        ///DateTime 	8 	0:00:00am 1/1/01 to 11:59:59pm 12/31/9999
        ///DateSpan    NA 	-10675199.02:48:05.4775808 to  10675199.02:48:05.47758076
        ///    bytes now working need to check TODO
        ///            PointStructure size is: 24 bytes
        /// </summary>
        public static void Test2SizeOf()
            {
            Console.WriteLine(nameof(Test2SizeOf));
            Console.WriteLine("sizeof can be used for predefined size only,so string ,class is not possible.Instead value types are allowed at runtime");
            Console.WriteLine($"Everything in c@ storage is minimum of {sizeof(byte)}bytes occupation & multiples of it");//1
            Console.WriteLine($"bool occupies {sizeof(bool)}bytes range {bool.TrueString} => {bool.FalseString}");//1
            char a0 = 'a';
            a0 = ',';
            Console.WriteLine($"char occupies {sizeof(char)}bytes  because stores as 16-bit Unicode range single character 'a'-'z'-'0'-'9'-','");//2
            Console.WriteLine($"short occupies {sizeof(short)}bytes range  {short.MinValue} => {short.MaxValue}");//4
            Console.WriteLine($"int occupies {sizeof(int)}bytes range  {int.MinValue} => {int.MaxValue} ");//4
            Console.WriteLine($"float occupies {sizeof(float)}bytes range  {float.MinValue} => {float.MaxValue} ");//4
            Console.WriteLine($"long occupies {sizeof(long)}bytes range   {long.MinValue}  =>  {long.MaxValue}  ");//8
            Console.WriteLine($"double occupies {sizeof(double)}bytes range   {double.MinValue}  =>  {double.MaxValue}  ");//8
            Console.WriteLine($"decimal occupies {sizeof(decimal)}bytes range   {decimal.MinValue}  =>  {decimal.MaxValue}  ");//16


            Console.WriteLine("{sizeof(string)} is not possible as 'string' does not have a predefined size,instead its address always stores as '4 byte address' and its content somewhere else based on its length");
            //'string' does not have a predefined size, therefore sizeof can only be used in an unsafe context

            string s1 = "s1234567";
            Console.WriteLine($"size of string s1 {s1} is itsLength*sizeofChar(2 byte):{s1.Length * sizeof(Char)}");

            Console.WriteLine("{sizeof(PointStructure)} bytes now working need to check TODO");
            int size = System.Runtime.InteropServices.Marshal.SizeOf(typeof(PointStructure));
            Console.WriteLine($"{nameof(PointStructure)} size is: {size} bytes");


            //BaseClass b = new BaseClass() { MyPropertyInt = 12 };
            //Console.WriteLine($"{nameof(b.MyPropertyInt)} size:{Marshal.SizeOf(b)}");
            Console.WriteLine();
            Console.ReadLine();
            }
        #endregion Test2SizeOf

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

        #region Test0MemoryStackAndHeap
        public static void Test0MemoryStackAndHeap()
            {
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
            }
        #endregion Test0MemoryStackAndHeap
        }
    }
