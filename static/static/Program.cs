using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @static
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution.Foo1();

            var sol = new Solution();
            sol.Foo2();
            
        }

        public class Solution
        {
            public static void Foo1() 
            {
                Console.WriteLine("Hell");
            }

            public void Foo2() { }
        }
    }
}
