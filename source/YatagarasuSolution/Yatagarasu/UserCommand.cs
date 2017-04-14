using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yatagarasu
{
    [System.Runtime.Serialization.DataContract]
    class UserCommand
    {
        [System.Runtime.Serialization.DataMember()]
        public string Name { get; set; }

        [System.Runtime.Serialization.DataMember()]
        public string Command { get; set; }

        [System.Runtime.Serialization.DataMember()]
        public string Arguments { get; set; }

        [System.Runtime.Serialization.DataMember()]
        public string WorkingDirectory { get; set; }

        public void Execute()
        {
            var info = new ProcessStartInfo();
            if (!String.IsNullOrWhiteSpace(WorkingDirectory))
            {
                info.WorkingDirectory = WorkingDirectory;
            }
            info.FileName = Command;
            info.Arguments = Arguments;

            Process.Start(info);
        }
    }
}
