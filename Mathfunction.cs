using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleTest
{
    public class Mathfunction: IArith
    {
        public int Add(int a,int b)
        {
            return a + b;
        }
    }
}
