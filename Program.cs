using System;
using System.Drawing;
using System.Runtime.InteropServices;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace POCs.OOPsConcepTsExploring
    {
    internal class Program
        {
        static void Main(string[] args)
            {
            //Test1ValuetypeVsRefTypeTest();
            Test2SizeOf();
            //  b.NormalProperty2 = 1;

            // AbstractBaseClass a = new AbstractBaseClass();//1.not allowed to create abstract instance
            //  b.NormalProperty2 = 1;
            Console.ReadLine();
            }

        #region Test2SizeOf
        /// <summary>
        /// Test2SizeOf
        ///sizeof can be used for predefined size only,so string ,class is not possible.Instead value types are allowed at runtime
        ///byte occupies 1 bytes
        ///bool occupies 1 bytes range True => False
        ///char occupies 2 bytes range single character 'a'-'z'-'0'-'9'-','
        ///short occupies 2 bytes range  -32768 => 32767
        ///int occupies 4 bytes range  -2147483648 => 2147483647
        ///float occupies 4 bytes range  -3.4028235E+38 => 3.4028235E+38
        ///long occupies 8 bytes range   -9223372036854775808  =>  9223372036854775807
        ///double occupies 8 bytes range   -1.7976931348623157E+308  =>  1.7976931348623157E+308
        ///decimal occupies 16 bytes range   -79228162514264337593543950335  =>  79228162514264337593543950335
        ///{ sizeof(string)} is not possible as 'string' does not have a predefined size
        ///            {sizeof(PointStructure)
        ///        }
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

        }

    public class BaseClass : AbstractBaseClass
        {

        public int MyPropertyInt { get; set; }
        private string stringField = "From Base class private stringField";//encapsulation
        private string stringFieldOther = "From Base class private stringFieldOther";//encapsulation

        public string MyStringOnlyGet { get { return stringField; } }//NO SETTING,only get 
        public string MyStringOnlyGetOther { get { return stringFieldOther; } }//NO SETTING,only get 
        public string MyStringMixed { get { return stringField; } set { stringFieldOther = value; } }//read from one,write to other
        public string MyString { get { return stringField; } set { stringField = value; } }
        //if above scenario then can directly use as below
        public string? MyStringProperty { get; set; }



        public string? NormalProperty1 { get { return stringField; } set { } }//this hiding baseclass property

        //below also hiding baseclass property but using that property with local customization
        public string? NormalProperty2 { get { return base.NormalProperty1; } set { base.NormalProperty1 = value + NormalProperty1 + base.MyString1; } }


        //public string? AbstractProperty1 { get; set; }//this is allowed but class expects must implemnt abstract method so below
        public override string? AbstractProperty1 { get; set; }
        public override string? AbstractProperty2 { get; set; }

        }

    public abstract class AbstractBaseClass
        {
        private string stringField = "From Abstract class private stringField";//encapsulation
        private string stringFieldOther = "From Abstract class private stringFieldOther";//encapsulation

        public string MyString1 { get { return stringField; } set { stringField = value; } }

        public string? NormalProperty1 { get; set; }
        public string? NormalProperty2 { get; set; }
        public abstract string? AbstractProperty1 { get; set; }
        public abstract string? AbstractProperty2 { get; set; }
        }

    public struct PointStructure
        {
        public PointStructure(byte tag, double x, double y) => (Tag, X, Y) = (tag, x, y);

        public byte Tag { get; }
        public double X { get; }
        public double Y { get; }
        }
    }
