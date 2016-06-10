using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UntitledOfficeConverter;
using UntitledOfficeConverter.Domain;

namespace OfficeConverter.BLL
{
    public static class BusinessLayerTunnel
    {
        private static ConverterFactory converterFactory;

        private static ConverterFactory ConverterFactory => converterFactory ?? (converterFactory = new ConverterFactory());

        public static void ValidateAndProcess(object obj)
        {
            ResultSet rs = obj as ResultSet;
            if(rs == null)
                return;
            Converters prog = Converters.Invalid;
            string extension = Path.GetExtension(rs.Path);
            if (Extensions.WordExtensions.Contains(extension))
            {
                prog = Converters.Word;
            } else if (Extensions.ExcelExtensions.Contains(extension))
            {
                prog = Converters.Excel;
            } else if (Extensions.PowerPointExtensions.Contains(extension))
            {
                prog = Converters.PowerPoint;
            }
            else
            {
                Console.WriteLine("Input Not Valid");
                rs.Result = 1;
                rs.handle.Set(); // signal we're done
                return;
            }
            using (IConverter converter = ConverterFactory.CreateConverter(prog))
            {
                converter.Convert(rs.Path);
            }
            rs.Result = 0;
            rs.handle.Set(); // signal we're done
        }
    }
}
