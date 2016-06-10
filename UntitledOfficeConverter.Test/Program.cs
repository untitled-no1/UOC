using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UntitledOfficeConverter.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"D:\VisualStudioProjects\UntitledOfficeConverter\TestFiles\sven.docx";
            using (var wrd = new WordConverter())
            {
                wrd.Convert(path);
            }
            path = @"D:\VisualStudioProjects\UntitledOfficeConverter\TestFiles\a.pptx";
            using (var wrd = new PowerPointConverter())
            {
                wrd.Convert(path);
            }

            path = @"D:\VisualStudioProjects\UntitledOfficeConverter\TestFiles\hist.xlsx";
            using (var wrd = new ExcelConverter())
            {
                wrd.Convert(path);
            }
        }
    }
}
