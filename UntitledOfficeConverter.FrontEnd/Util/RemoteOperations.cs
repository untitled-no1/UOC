using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OfficeConverter.BLL;
using UntitledOfficeConverter.Domain;

namespace UntitledOfficeConverter.FrontEnd.Util
{
    internal static class RemoteOperations
    {
        public static void ConvertFiles(string[] files)
        {
            int proc = Environment.ProcessorCount;
            ThreadPool.SetMaxThreads(proc, proc);
            foreach (var s in files)
            {
                var res = new ResultSet(s);
                ThreadPool.QueueUserWorkItem(BusinessLayerTunnel.ValidateAndProcess, res);

            }
        }
    }

    
}
