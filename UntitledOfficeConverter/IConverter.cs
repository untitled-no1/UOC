using System;

namespace UntitledOfficeConverter
{
    public interface IConverter : IDisposable
    {
        void Convert(string path);
    }
}