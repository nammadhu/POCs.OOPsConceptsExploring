using POCs.OOPsConcepTsExploring;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static POCs.OOPsConceptsExploring.ClassesAndStructs;

namespace POCs.OOPsConceptsExploring
    {
    public enum Direction
        {
        East = 1,
        West = 2,
        North = 3,
        South = 4
        };
    public class SimpleSmallClass3
        {
        public int P1 { get; set; }
        public int P2 { get; set; }
        public override bool Equals(object obj)
            {
            // If the passed object is null, return False
            if (obj == null)
                {
                return false;
                }
            // If the passed object is not Customer Type, return False
            if (!(obj is SimpleSmallClass3))
                {
                return false;
                }
            return (this.P1 == ((SimpleSmallClass3)obj).P1)
                && (this.P2 == ((SimpleSmallClass3)obj).P2);
            }

        //This is not necessary always but its good to have implemented GetHashCode()
        //Overriding the GetHashCode method
        //GetHashCode method generates hashcode for the current object
        //public override int GetHashCode()
        //    {
        //    //Performing BIT wise OR Operation on the generated hashcode values
        //    //If the corresponding bits are different, it gives 1.
        //    //If the corresponding bits are the same, it gives 0.
        //    return P1.GetHashCode() ^ P2.GetHashCode() ;
        //    }
        }
    public class SimpleClass2
        {
        public int SimpleClassInt { get; set; } = 3;

        public string? SimpleClassString { get; set; } = "default Madhu";
        public SimpleSmallClass3 SimpleSmallClass3333 { get; set; }
        public override bool Equals(object obj)
            {
            // If the passed object is null, return False
            if (obj == null)
                {
                return false;
                }
            // If the passed object is not Customer Type, return False
            if (!(obj is SimpleClass2))
                {
                return false;
                }
            return (this.SimpleClassInt == ((SimpleClass2)obj).SimpleClassInt)
                && (this.SimpleClassString == ((SimpleClass2)obj).SimpleClassString)
                && this.SimpleSmallClass3333.Equals(((SimpleClass2)obj).SimpleSmallClass3333);
            }

        //This is not necessary always but its good to have implemented GetHashCode()
        //Overriding the GetHashCode method
        //GetHashCode method generates hashcode for the current object
        //public override int GetHashCode()
        //    {
        //    //Performing BIT wise OR Operation on the generated hashcode values
        //    //If the corresponding bits are different, it gives 1.
        //    //If the corresponding bits are the same, it gives 0.
        //    return SimpleClassInt.GetHashCode() ^ SimpleClassInt.GetHashCode() ^ SimpleSmallClass3333.GetHashCode();
        //    }
        }
    internal partial class TestImplementations
        {
        #region Test7EqualOperators
        public static void Test7EqualOperators()
            {

            Console.WriteLine(nameof(Test7EqualOperators));
            Console.WriteLine("== checks for value & Equal() checks for reference by default if not overridden");

            Console.WriteLine("Step1:Value type comparison");
            int Number1 = 10;
            int Number2 = 10;
            Console.WriteLine($"Number1 == Number2: {Number1 == Number2}");
            Console.WriteLine($"Number1.Equals(Number2): {Number1.Equals(Number2)}");
            Console.ReadKey();

            Console.WriteLine("Step2:Enum type comparison");
            Direction direction1 = Direction.East;
            Direction direction2 = Direction.East;
            Console.WriteLine(direction1 == direction2);
            Console.WriteLine(direction1.Equals(direction2));
            Console.ReadKey();


            Console.WriteLine("Step3.1:Reference type comparison of assigned object");
            SimpleClass C1 = new SimpleClass();
            C1.SimpleClassInt = 5;
            C1.SimpleClassString = "Rout";
            SimpleClass C2 = C1;
            Console.WriteLine("Assigned C2=C1 ");
            Console.WriteLine($"C1 == C2: {C1 == C2}");
            Console.WriteLine($"C1.Equals(C2): {C1.Equals(C2)}");
            Console.ReadKey();
            Console.WriteLine();

            Console.WriteLine("Step3.2:Reference type comparison of assigned object");
            Console.WriteLine("Creating new object c3 with same value of 5 & Rout");
            SimpleClass C3 = new SimpleClass();
            C3.SimpleClassInt = 5;
            C3.SimpleClassString = "Rout";
            Console.WriteLine($"C1 == C3: {C1 == C3}");
            Console.WriteLine($"C1.Equals(C3): {C1.Equals(C3)}");

            Console.WriteLine("Step3.3:Reference type comparison with EQUAL overridden");
            Console.WriteLine("Creating new object c3 with same value of 5 & Rout");
            SimpleClass2 C22 = new SimpleClass2();
            C22.SimpleClassInt = 5;
            C22.SimpleClassString = "Rout";
            C22.SimpleSmallClass3333 = new SimpleSmallClass3() {P1=5,P2=8 };
            var C33 = C22;
            Console.WriteLine($"C22 == C33: {C22 == C33}");
            Console.WriteLine($"C22.Equals(C33): {C22.Equals(C33)}");

            Console.ReadLine();
            Console.WriteLine();
            }
        #endregion Test7EqualOperators
        }
    }
