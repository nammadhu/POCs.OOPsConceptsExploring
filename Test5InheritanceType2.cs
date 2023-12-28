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
        #region Test5Inheritance
        class Animal
            {
            public void Eat()
                {
                Console.WriteLine("Animal is eating.");
                }
            }

        class Dog : Animal
            {
            public int Legs { get; set; } = 4;
            public void Bark()
                {
                Console.WriteLine("Dog is barking.");
                }
            }
        class Fish : Animal
            {
            public int Wings { get; set; } = 2;
            public void Swim()
                {
                Console.WriteLine("Fish is swimming.");
                }
            }
        public static void Test5InheritanceType2()
            {
            Console.WriteLine(nameof(Test5InheritanceType2));
            Dog myDog = new Dog(); // Creating an object of the derived class

            myDog.Legs = 3;
            Console.WriteLine("myDog has Legs");
            // Upcasting: Assigning the derived class object to the base class variable
            Animal myAnimal = myDog;
            Console.WriteLine("But myAnimal is not having Legs,bcz not all anilams have legs");
            var dd = myAnimal as Dog;
            Console.WriteLine(dd.Legs);
            // Now, myAnimal is of compile-time type Animal, but its runtime type is still Dog.

            myAnimal.Eat(); // Accessing the Eat() method from the base class
            //myAnimal.Bark(); // This line would result in a compile-time error because the compiler only knows about the methods of the base class.

            // You can, however, downcast explicitly to access the specific methods of the derived class:
            if (myAnimal is Dog)
                {
                Dog sameDog = (Dog)myAnimal;
                sameDog.Bark(); // Now you can access the Bark() method.
                }
            Console.WriteLine();
            Console.ReadLine();
            }
        #endregion Test4Inheritance


        }
    }
