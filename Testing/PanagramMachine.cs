using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing
{
    class PanagramMachine
    {
        public void Main(String[] args)
        {
            string s = Console.ReadLine();
            bool newS = s.ToLower().Where(c => Char.IsLetter(c)).GroupBy(c => c).Count() == 26;
            if (newS)
            {
                Console.WriteLine(("pangram"));
            }
            else
            {
                Console.WriteLine("not pangram");
            }
        }
    }
}
