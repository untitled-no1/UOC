using UntitledOfficeConverter.FrontEnd.ViewModels;

namespace UntitledOfficeConverter.FrontEnd.Util
{
    public static class ViewModelLocator
    {
        private static FilesDrop fileDrop;
        public static FilesDrop FileDrop => fileDrop ?? (fileDrop = new FilesDrop());
    }
}