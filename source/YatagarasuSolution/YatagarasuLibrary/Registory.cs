using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YatagarasuLibrary
{
    public static class Registory
    {
        public static TestProjectFactory TestProjectFactory { get; set; }
        public static ITestProjectRepogitory TestProjectRepogitory { get; set; }
    }
}
