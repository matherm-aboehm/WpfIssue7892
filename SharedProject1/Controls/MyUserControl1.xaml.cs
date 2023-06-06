using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Windows.Controls;
//using Windows.Foundation;
//using Windows.Foundation.Collections;
//using Windows.UI.Xaml;
//using Windows.UI.Xaml.Controls;
//using Windows.UI.Xaml.Controls.Primitives;
//using Windows.UI.Xaml.Data;
//using Windows.UI.Xaml.Input;
//using Windows.UI.Xaml.Media;
//using Windows.UI.Xaml.Navigation;

// Die Elementvorlage "Benutzersteuerelement" wird unter https://go.microsoft.com/fwlink/?LinkId=234236 dokumentiert.

namespace SharedProject1.Controls
{
    public sealed partial class MyUserControl1 : UserControl
    {
        public MyUserControl1()
        {
            this.InitializeComponent();
        }

        private void Image_ImageFailed(object sender, System.Windows.ExceptionRoutedEventArgs e)
        {
            throw e.ErrorException;
        }
    }
}
