using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Core;
using Microsoft.Office.Interop.PowerPoint;

namespace UntitledOfficeConverter
{
    public class PowerPointConverter : IConverter
    {
        private Application PowerPointApp { get; set; }
        private Presentation PowerPointDocument { get; set; }
        public PowerPointConverter()
        {
            PowerPointApp = new Application();
        }

        public void Convert(string path)
        {
            string exportPath = path + ".pdf";
            PowerPointDocument = PowerPointApp.Presentations.Open(@path, MsoTriState.msoCTrue, MsoTriState.msoFalse, MsoTriState.msoFalse);
            PowerPointDocument.ExportAsFixedFormat(@exportPath, PpFixedFormatType.ppFixedFormatTypePDF);
        }

        public void Dispose()
        {
            PowerPointDocument?.Close();
            PowerPointApp?.Quit();

            if (PowerPointApp != null)
                while (Marshal.ReleaseComObject(PowerPointApp) != 0) { }
            if (PowerPointDocument != null)
                while (Marshal.ReleaseComObject(PowerPointDocument) != 0) { }

            PowerPointApp = null;
            PowerPointDocument = null;


            GC.Collect();
            GC.WaitForPendingFinalizers();
        }

    }
}
