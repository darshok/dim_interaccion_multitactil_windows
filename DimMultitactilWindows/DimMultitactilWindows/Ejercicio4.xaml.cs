using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=234238

namespace DimMultitactilWindows
{
    /// <summary>
    /// Una página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class Ejercicio4 : Page
    {
        public Ejercicio4()
        {
            this.InitializeComponent();
        }

        private void ImagePoder_Opened(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            Image img = sender as Image;
            CompositeTransform.CenterX = img.ActualWidth / 2;
            CompositeTransform.CenterY = img.ActualHeight / 2;
            //RotateTransform.CenterX = img.ActualWidth / 2;
            //RotateTransform.CenterY = img.ActualHeight / 2;
        }

        private void imageViewPoder_ManipulationDelta(object sender, ManipulationDeltaRoutedEventArgs e)
        {
            FrameworkElement source = (FrameworkElement)e.OriginalSource;
            var ct = new CompositeTransform();
            ct.Rotation += e.Delta.Rotation;
            ct.ScaleX *= e.Delta.Scale;
            ct.ScaleY *= e.Delta.Scale;
            source.RenderTransform = ct;
        }
    }
}
