using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterfaceImplementationLister;

namespace WorkspaceCsharp
{
    internal class Workspace : IExerciseInterface
    {
        public void Execute()
        {
            int totalHours = 15;

            if (totalHours % 15 == 0 && totalHours <= 90 && totalHours >= 30)
                Console.WriteLine(totalHours / 15);

            Console.WriteLine(-1);
        }
    }
}
