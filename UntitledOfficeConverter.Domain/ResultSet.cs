using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace UntitledOfficeConverter.Domain
{
    public class ResultSet
    {
        public EventWaitHandle handle = new ManualResetEvent(false);
        public string Path { get; set; }
        // 0 = OK, 1 = fail, -1 = init
        public int Result { get; set; } = -1;

        public ResultSet(string path)
        {
            this.Path = path;

        }

    }
}
