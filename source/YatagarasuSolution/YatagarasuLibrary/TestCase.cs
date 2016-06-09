using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YatagarasuLibrary
{
    public class TestCase
    {
        public string Title { get; set; }
        public string Details { get; set; }
        public Guid Id { get; set; }
        public List<TestStep> List { get; set; }
        public DateTime Created { get; set; }

        public void AddStep(string title, List<string> detail)
        {
            var guid = Guid.NewGuid();
            var newStep = new TestStep { Id = guid, Title = title, Detail = detail, Created = DateTime.Now };
            List.Add(newStep);
        }

        public override string ToString()
        {
            return this.Title;
        }
    }
}
