using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Word;

namespace UntitledOfficeConverter
{
    public class WordConverter : IConverter
    {
        private Application WordApp { get; set; }
        private Document WordDocument { get; set; }
        public WordConverter()
        {
            WordApp = new Application();
        }

        public void Convert(string path)
        {
            string exportPath = path + ".pdf";
            WordDocument = WordApp.Documents.Open(@path);
            WordDocument.ExportAsFixedFormat(@exportPath, WdExportFormat.wdExportFormatPDF);
        }

        public void Dispose()
        {
            WordDocument?.Close(WdSaveOptions.wdDoNotSaveChanges, WdOriginalFormat.wdOriginalDocumentFormat, false);
            WordApp?.Quit();
        }

    }
}
