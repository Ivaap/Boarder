using Boarder.Loggers;
using Boarder.Models;
using System;

namespace Boarder
{
    class Program
    {
        static void Main(string[] args)
        {
            //var tomorrow = DateTime.Now.AddDays(1);
            //BoardItem task = new Task("Write unit tests", "Pesho", tomorrow);
            //BoardItem issue = new Issue("Review tests", "Someone must review Peter's tests.", tomorrow);

            //Console.WriteLine(task.ViewInfo());
            //Console.WriteLine(issue.ViewInfo());

            var tomorrow = DateTime.Now.AddDays(1);
            var task = new Task("Write unit tests", "Peter", tomorrow);
            var issue = new Issue("Review tests", "Someone must review Peter's tests.", tomorrow);
            Board.AddItem(task);
            Board.AddItem(issue);

            ConsoleLogger logger = new ConsoleLogger();
            Board.LogHistory(logger); // pass a ConsoleLogger type where an ILogger is expected:
        }
    }
}
