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
        public static async Task Test12TaskAsyncAwaitsWithThreadDifferences()
            {
            Console.WriteLine($"Main-Thread {System.Threading.Thread.CurrentThread.ManagedThreadId}");

            // Asynchronous method call
            await MethodAsync();

            Console.WriteLine($"Main-Thread {System.Threading.Thread.CurrentThread.ManagedThreadId}");
            Console.WriteLine();
            MethodSync();
            Console.WriteLine($"Main-Thread {System.Threading.Thread.CurrentThread.ManagedThreadId}");
            }

        static async Task MethodAsync()
            {
            Console.WriteLine($"MethodAsync starts on Thread {System.Threading.Thread.CurrentThread.ManagedThreadId}");

            // Simulate asynchronous work (non-blocking)
            await Task.Delay(2000);

            Console.WriteLine($"MethodAsync ends on Thread {System.Threading.Thread.CurrentThread.ManagedThreadId}");
            }
        static void MethodSync()
            {
            Console.WriteLine($"MethodSync starts on Thread {System.Threading.Thread.CurrentThread.ManagedThreadId}");

            // Simulate asynchronous work (non-blocking)
            Task.Delay(2000);

            Console.WriteLine($"MethodSync ends on Thread {System.Threading.Thread.CurrentThread.ManagedThreadId}");
            }
        }


    }
