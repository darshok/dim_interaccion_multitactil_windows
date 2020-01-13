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
    public sealed partial class Ejercicio3 : Page
    {
        public Ejercicio3()
        {
            this.InitializeComponent();
        }
        private void Image_Opened(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            Image img = sender as Image;
            ScaleTransform.CenterX = img.ActualWidth / 2;
            ScaleTransform.CenterY = img.ActualHeight / 2;
            RotateTransform.CenterX = img.ActualWidth / 2;
            RotateTransform.CenterY = img.ActualHeight / 2;
        }

        private void imageView_ManipulationDelta(object sender, ManipulationDeltaRoutedEventArgs e)
        {
            this.RotateTransform.Angle += e.Delta.Rotation;
            this.ScaleTransform.ScaleX *= e.Delta.Scale;
            this.ScaleTransform.ScaleY *= e.Delta.Scale;
        }
    }
}
