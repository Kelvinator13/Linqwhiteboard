using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            ProblemOne problemOne = new ProblemOne();
            ProblemTwo problemTwo = new ProblemTwo();
            ProblemThree problemThree = new ProblemThree();
            ProblemFour problemFour = new ProblemFour();
            problemOne.wordscontainingth();
            Console.WriteLine();
           // problemTwo.RemoveDup();
            Console.WriteLine();
            problemThree.Average();
            Console.WriteLine();
            problemFour.NumberofLetters();
            Console.ReadLine();
        }
    }
}
