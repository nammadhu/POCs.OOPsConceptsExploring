using System;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static System.Runtime.InteropServices.JavaScript.JSType;
using POCs.OOPsConcepTsExploring;
using POCs.OOPsConceptsExploring;
using System.Net;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using static POCs.OOPsConceptsExploring.TestImplementations;

namespace POCs.OOPsConcepTsExploring
    {
    internal partial class TestImplementations
        {
        /* How threads get changed ,
Main-Thread 1
MethodAsync starts on Thread 1
MethodAsync ends on Thread 5
Main-Thread 5

MethodSync starts on Thread 5
MethodSync ends on Thread 5
Main-Thread 5
         * */
        static int tid;
        public static void ThreadChanges()
            {
            if (tid != System.Threading.Thread.CurrentThread.ManagedThreadId)
                {
                Console.WriteLine($"Main-Thread changed to {System.Threading.Thread.CurrentThread.ManagedThreadId}");
                tid = System.Threading.Thread.CurrentThread.ManagedThreadId;
                }
            }
        public static async Task Test14TaskMultiThreading()
            {
            tid = System.Threading.Thread.CurrentThread.ManagedThreadId;
            Console.WriteLine($"Main-Thread {System.Threading.Thread.CurrentThread.ManagedThreadId}");

            Thread thread1 = new Thread(DoWork);
            Console.WriteLine("t1 created");
            ThreadChanges();
            Thread thread2 = new Thread(DoWork);
            Console.WriteLine("t2 created");
            ThreadChanges();

            thread1.Start();
            Console.WriteLine("t1 started");
            ThreadChanges();
            thread2.Start();
            Console.WriteLine("t2 started");
            ThreadChanges();

            // Main thread can also do some work
            Console.WriteLine("loop entering");
            for (int i = 0; i < 5; i++)
                {
                ThreadChanges();
                Console.WriteLine($"Main thread: {i} & going to sleep 100");
                Thread.Sleep(100);
                ThreadChanges();
                }
            Console.WriteLine("loop done");
            Console.ReadLine();
            }

        static void DoWork()
            {
            ThreadChanges();
            for (int i = 0; i < 5; i++)
                {
                Console.WriteLine($"Worker thread: {i} & going to sleep");
                ThreadChanges();
                Thread.Sleep(100);
                ThreadChanges();
                }
            ThreadChanges();
            }
        }


    }
