using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hypechat.BusinessLayer
{
    public class FizzBuzzer
    {
        public List<string> FizzBuzz(int max = 100)
        {
            var ret = new List<string>();

            for (var i = 1; i <= max; i++)
            {
                if (i % 15 == 0) ret.Add("Fizz Buzz");
                else if (i % 3 == 0) ret.Add("Fizz");
                else if (i % 5 == 0) ret.Add("Buzz");
                else ret.Add(i.ToString());
            }

            return ret;
        }
    }
}
