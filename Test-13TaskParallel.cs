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

        /*output as like below
09.00.40.462853 Task 2 starting
09.00.40.462819 Task 1 starting
09.00.40.465986 Task 3 starting
09.00.43.509571 Task 1 ending
09.00.43.509627 Task 2 ending
09.00.43.589465 Task 3 ending
Main method ending
         */
        public static void Test13TaskParallel()//Note method is async
            {
            Parallel.Invoke(() =>
            {
                Console.WriteLine(DateTime.Now.ToString("hh.mm.ss.ffffff") + " Task 1 starting");
                Thread.Sleep(TimeSpan.FromSeconds(3));
                // Task 1 logic
                Console.WriteLine(DateTime.Now.ToString("hh.mm.ss.ffffff") + " Task 1 ending");
            },
            () =>
            {
                Console.WriteLine(DateTime.Now.ToString("hh.mm.ss.ffffff") + " Task 2 starting");
                Thread.Sleep(TimeSpan.FromSeconds(3));
                // Task 2 logic
                Console.WriteLine(DateTime.Now.ToString("hh.mm.ss.ffffff") + " Task 2 ending");
            },
            () =>
            {
                Console.WriteLine(DateTime.Now.ToString("hh.mm.ss.ffffff") + " Task 3 starting");
                Thread.Sleep(TimeSpan.FromSeconds(3));
                // Task 2 logic
                Console.WriteLine(DateTime.Now.ToString("hh.mm.ss.ffffff") + " Task 3 ending");
            });

            Console.WriteLine("Main method ending");
            }
        }
    }
