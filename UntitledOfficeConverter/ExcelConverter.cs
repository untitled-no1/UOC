using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Excel;

namespace UntitledOfficeConverter
{
    public class ExcelConverter : IConverter
    {
        private Application ExcelApp { get; set; }
        private Workbook ExcelDocument { get; set; }
        public ExcelConverter()
        {
            ExcelApp = new Application();
        }

        public void Convert(string path)
        {
            string exportPath = path + ".pdf";
            ExcelDocument = ExcelApp.Workbooks.Open(@path);
            ExcelDocument.ExportAsFixedFormat(XlFixedFormatType.xlTypePDF, @exportPath);
        }

        public void Dispose()
        {
            ExcelDocument?.Close(false, "", false);
            ExcelApp?.Quit();

            if(ExcelApp != null)
                while (Marshal.ReleaseComObject(ExcelApp) != 0) { }
            if(ExcelDocument != null)
                while (Marshal.ReleaseComObject(ExcelDocument) != 0) { }

            ExcelApp = null;
            ExcelDocument = null;
            

            GC.Collect();
            GC.WaitForPendingFinalizers();
        }

    }
}
