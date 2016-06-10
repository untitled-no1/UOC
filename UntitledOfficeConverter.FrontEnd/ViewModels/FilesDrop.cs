using System.ComponentModel;
using System.Windows;
using UntitledOfficeConverter.FrontEnd.Util;

namespace UntitledOfficeConverter.FrontEnd.ViewModels
{
    public class FilesDrop : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public void ImagePanel_OnDrop(object sender, DragEventArgs e)
        {
            if (!e.Data.GetDataPresent(DataFormats.FileDrop)) return;
            // Note that you can have more than one file.
            var files = (string[])e.Data.GetData(DataFormats.FileDrop);

            RemoteOperations.ConvertFiles(files);
        }

        
    }
}