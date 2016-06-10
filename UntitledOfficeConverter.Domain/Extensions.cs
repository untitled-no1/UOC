using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UntitledOfficeConverter.Domain
{
    public static class Extensions
    {
        private static IEnumerable<string> wordExtensions;
        public static IEnumerable<string> WordExtensions => wordExtensions ??
                                                            (wordExtensions =
                                                                new List<string>
                                                                {
                                                                    ".doc",
                                                                    ".docx",
                                                                    ".docm",
                                                                    ".dot",
                                                                    ".dotm",
                                                                    ".dotx",
                                                                    ".html",
                                                                    ".odt",
                                                                    ".rtf",
                                                                    ".txt",
                                                                    ".wps",
                                                                    ".xps"
                                                                });

        private static IEnumerable<string> excelExtensions;
        public static IEnumerable<string> ExcelExtensions => excelExtensions ??
                                                            (excelExtensions =
                                                                new List<string>
                                                                {
                                                                    ".csv",
                                                                    ".ods",
                                                                    ".xls",
                                                                    ".xlsb",
                                                                    ".xlsm",
                                                                    ".xlsx",
                                                                    ".xlt",
                                                                    ".xltm",
                                                                    ".xltx",
                                                                    ".xltw"
                                                                });

        private static IEnumerable<string> powerPointExtensions;
        public static IEnumerable<string> PowerPointExtensions => powerPointExtensions ??
                                                            (powerPointExtensions =
                                                                new List<string>
                                                                {
                                                                    ".odp",
                                                                    ".pot",
                                                                    ".potm",
                                                                    ".potx",
                                                                    ".ppa",
                                                                    ".ppam",
                                                                    ".pps",
                                                                    ".ppsm",
                                                                    ".ppsx",
                                                                    ".ppt",
                                                                    ".pptm",
                                                                    ".pptx"
                                                                });
    }
}
