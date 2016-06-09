using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YatagarasuLibrary
{
    public class TestProject
    {
        public List<TestCase> List { get; set; }
        public string Name { get; set; }
        public Guid Id { get; set; }
        public DateTime Created { get; set; }

        public TestCase AddTestCase(string title, string details)
        {
            var id = Guid.NewGuid();
            var a = new TestCase { Id = id, Title = title, Details = details };
            a.List = new List<TestStep>();
            List.Add(a);
            return a;
        }

        public bool HasTestCase(Guid id)
        {
            foreach (var c in List)
            {
                if (c.Id == id) { return true; }
            }
            return false;
        }

        public TestCase SelectTestCase(Guid id)
        {
            foreach (var c in List)
            {
                if (c.Id == id) { return c; }
            }
            throw new IndexOutOfRangeException("テストケースが見つかりません");
        }

        public bool HasTestStep(Guid id)
        {
            foreach (var c in List)
            {
                if (c.HasTestStep(id)) { return true; }
            }
            return false;
        }


        public TestStep SelectTestStep(Guid id)
        {
            foreach (var c in List)
            {
                if (!c.HasTestStep(id)) { continue; }

                return c.SelectTestStep(id);
            }
            throw new IndexOutOfRangeException("テストステップが見つかりません");
        }

        public override string ToString()
        {
            return this.Name;
        }
    }
}
