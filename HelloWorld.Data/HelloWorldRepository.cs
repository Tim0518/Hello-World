using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld.Data
{
    public class HelloWorldRepository : IRepository
    {
        public string get()
        {
            return "Hello World";
        }
    }
}
