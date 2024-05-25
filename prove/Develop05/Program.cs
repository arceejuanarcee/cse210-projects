// A feature was added where when a user achieves all the goals listed, he or she will receive a badge. A user can receive a badge upto 10 levels.

using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        GoalManager manager = new GoalManager();
        manager.Start();
    }
}
