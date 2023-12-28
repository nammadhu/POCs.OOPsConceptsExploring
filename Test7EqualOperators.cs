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
    internal partial class TestImplementations
        {
        #region Test7EqualOperators
        public static void Test7EqualOperators()
            {

            Console.WriteLine(nameof(Test7EqualOperators));

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
            C1.SimpleClassInt= 5;
            C1.SimpleClassString= "Rout";
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
            
            Console.ReadLine();
            Console.WriteLine();
            }
    #endregion Test7EqualOperators
    }
    }
