using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using UntitledOfficeConverter.FrontEnd.Util;

namespace UntitledOfficeConverter.FrontEnd.Views
{
    /// <summary>
    /// Interaction logic for FilesDrop.xaml
    /// </summary>
    public partial class FilesDrop : UserControl
    {
        public FilesDrop()
        {
            InitializeComponent();
            
        }


        private void ImagePanel_OnDrop(object sender, DragEventArgs e)
        {
            ViewModelLocator.FileDrop.ImagePanel_OnDrop(sender, e);
        }
    }
}
