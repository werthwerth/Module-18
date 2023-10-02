using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_18
{
    abstract class Command
    {
        public abstract void Run(string url, string path = "");
    }
}
