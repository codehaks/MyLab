using System;

namespace MyLab
{
    class Program
    {
        public delegate void Notify(string message);

        static void Main(string[] args)
        {
            Notify notifier = (m) => { Console.WriteLine(m); };
            notifier += (m) => { Console.WriteLine(" Message : " + m); };

            WorkStarted(notifier);
            WorkFinished(notifier);

        }

        static public void WorkStarted(Notify notify)
        {
            notify("started");
        }

        static public void WorkFinished(Notify notify)
        {
            notify("Finished");
        }
    }
}
