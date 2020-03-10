using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqProblems
{
    class ProblemFour
    {
        string wordTest = "Terrill";
        public void NumberofLetters()
        { 
           var letterNumbers = string.Join("", wordTest.OrderBy(t => t).Distinct().Select(x => $"{x}{wordTest.Count(y => y == x)
            foreach(var 1 in letterNumbers)
            {
                Console.WriteLine(1 + " ");
            }
        }
    }
}