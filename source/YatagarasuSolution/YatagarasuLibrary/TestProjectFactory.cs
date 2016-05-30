using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YatagarasuLibrary
{
    public class TestProjectFactory
    {
        public TestProject CreateNew(string name)
        {
            return new TestProject
            {
                Name = name,
                Id = Guid.NewGuid(),
                Created = DateTime.Now,
                List = new List<TestCase>()
            };
        }
    }
}
