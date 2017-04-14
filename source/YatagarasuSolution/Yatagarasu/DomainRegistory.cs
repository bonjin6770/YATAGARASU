using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yatagarasu
{
    static class DomainRegistory
    {
        public static CommandList CommandList { get; private set; }

        public static bool IsNullCommandList()
        {
            return CommandList == null;
        }
        public static void LoadCommandList()
        {
            DomainRegistory.CommandList = CommandList.Load();
        }

        public static void SaveCommandList()
        {
            DomainRegistory.CommandList.Save();
        }
    }
}
