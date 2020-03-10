using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqProblems
{
    class ProblemTwo
    {
        public ProblemTwo()
        {
            List<string> names = new List<string>() { "Mike", "Brad", "Nevin", "Ian", "Mike" };
            
                var name = names.OrderBy(a => new string(a.ToCharArray())).Distinct();
                foreach (var n in name)
                {
                    Console.WriteLine(n);
                }
        } 
    }          
}

   
