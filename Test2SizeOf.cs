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
        }
    }
