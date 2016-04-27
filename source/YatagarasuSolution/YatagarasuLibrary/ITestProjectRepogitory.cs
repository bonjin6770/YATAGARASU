using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YatagarasuLibrary
{
    public interface ITestProjectRepogitory
    {
        void Add(TestProject project);
        List<TestProject> SelectAll();
        TestProject SelectByName(string projectName);
        void Save(TestProject project);
    }
}
