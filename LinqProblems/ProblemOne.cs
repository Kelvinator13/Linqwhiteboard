using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqProblems
{
    class ProblemOne
    {
        List<string> words;
        public ProblemOne()
        {
            words = new List<string>() { "the", "bike", "this", "it", "tenth", "mathematics" };
        }

        public void Run()
        {
            var wordsthatcontainth = words.Where(w => w.Contains("th"));
        }


       
           
    }
  
}
