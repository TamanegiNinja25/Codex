using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreadingApplication
{
    public class ThreadClass
    {
        public static void Thread1()
        {
            for (int loopCount = 0; loopCount <= 2; loopCount++)
            {
                Thread thread = Thread.CurrentThread;
                Console.WriteLine("Name of Thread: " + Thread.CurrentThread.Name + " Process = " + loopCount);
                Thread.Sleep(500);
            }
        }
        public static void Thread2()
        {
            for (int loopCount = 0; loopCount <= 6; loopCount++)
            {
                Thread thread = Thread.CurrentThread;
                Console.WriteLine("Name of Thread: " + Thread.CurrentThread.Name + " Process = " + loopCount);
                Thread.Sleep(1500);
            }
        }
    }
}
