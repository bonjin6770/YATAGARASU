using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YatagarasuLibrary
{
    public class TestStep
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public List<string> Detail { get; set; }
        public DateTime Created { get; set; }

        public override string ToString()
        {
            return this.Title;
        }
    }
}
