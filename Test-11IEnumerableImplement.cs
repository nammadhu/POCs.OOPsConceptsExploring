using POCs.OOPsConcepTsExploring;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static POCs.OOPsConceptsExploring.ClassesAndStructs;

namespace POCs.OOPsConceptsExploring
    {
    internal partial class TestImplementations
        {

        public class MyCollection0
            {

            private List<int> elements = new List<int>();
            }
        public class MyCollection : IEnumerable<int>
            {

            private List<int> elements = new List<int>();

            // Add elements to the collection
            public void Add(int item)
                {
                elements.Add(item);
                }


            //IEnumerable implementation required method1 MUST
            public IEnumerator<int> GetEnumerator()
                {
                return elements.GetEnumerator();
                }

            //IEnumerable implementation required method2 MUST
            IEnumerator IEnumerable.GetEnumerator()
                {
                return GetEnumerator();
                }
            }

        public static void Test11IEnumerableImplement()
            {
            Console.WriteLine(nameof(Test11IEnumerableImplement));
            Console.WriteLine("Check the code to understand flow");
            //MyCollection0 my0 = new MyCollection0();
            //my0.Add()//this is not possible because not having Ienumerable or add implementions
            MyCollection myCollection = new MyCollection();
            myCollection.Add(1);
            myCollection.Add(2);
            myCollection.Add(3);
            //myCollection.Remove();//this is not implemented so wont workout
            // Iterate over the collection using foreach
            foreach (var item in myCollection)//to do foreach enumeration it needs ienumerable implementation
                {
                Console.WriteLine(item);
                }
            }

        }
    }
