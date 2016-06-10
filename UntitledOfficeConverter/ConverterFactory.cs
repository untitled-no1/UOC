using Microsoft.Office.Interop.PowerPoint;
using UntitledOfficeConverter.Domain;

namespace UntitledOfficeConverter
{
    public class ConverterFactory
    {
        public IConverter CreateConverter(Converters prog)
        {
            switch (prog)
            {
                case Converters.Word: { return new WordConverter();}
                case Converters.Excel: { return new ExcelConverter();}
                case Converters.PowerPoint: { return new PowerPointConverter();}
                default:
                {
                    return null;
                }
            }
        }
    }
}