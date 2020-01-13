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
            CompositeTransformPoder.CenterX = img.ActualWidth / 2;
            CompositeTransformPoder.CenterY = img.ActualHeight / 2;
        }

        private void imageViewPoder_ManipulationDelta(object sender, ManipulationDeltaRoutedEventArgs e)
        {
            FrameworkElement source = (FrameworkElement)e.OriginalSource;
            CompositeTransformPoder.Rotation += e.Delta.Rotation;
            CompositeTransformPoder.ScaleX *= e.Delta.Scale;
            CompositeTransformPoder.ScaleY *= e.Delta.Scale;
            CompositeTransformPoder.TranslateX += e.Delta.Translation.X;
            CompositeTransformPoder.TranslateY += e.Delta.Translation.Y;
            source.RenderTransform = CompositeTransformPoder;
        }

        private void ImageSabiduria_Opened(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            Image img = sender as Image;
            CompositeTransformSabiduria.CenterX = img.ActualWidth / 2;
            CompositeTransformSabiduria.CenterY = img.ActualHeight / 2;
        }

        private void imageViewSabiduria_ManipulationDelta(object sender, ManipulationDeltaRoutedEventArgs e)
        {
            FrameworkElement source = (FrameworkElement)e.OriginalSource;
            CompositeTransformSabiduria.Rotation += e.Delta.Rotation;
            CompositeTransformSabiduria.ScaleX *= e.Delta.Scale;
            CompositeTransformSabiduria.ScaleY *= e.Delta.Scale;
            CompositeTransformSabiduria.TranslateX += e.Delta.Translation.X;
            CompositeTransformSabiduria.TranslateY += e.Delta.Translation.Y;
            source.RenderTransform = CompositeTransformSabiduria;
        }

        private void ImageValor_Opened(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            Image img = sender as Image;
            CompositeTransformValor.CenterX = img.ActualWidth / 2;
            CompositeTransformValor.CenterY = img.ActualHeight / 2;
        }

        private void imageViewValor_ManipulationDelta(object sender, ManipulationDeltaRoutedEventArgs e)
        {
            FrameworkElement source = (FrameworkElement)e.OriginalSource;
            CompositeTransformValor.Rotation += e.Delta.Rotation;
            CompositeTransformValor.ScaleX *= e.Delta.Scale;
            CompositeTransformValor.ScaleY *= e.Delta.Scale;
            CompositeTransformValor.TranslateX += e.Delta.Translation.X;
            CompositeTransformValor.TranslateY += e.Delta.Translation.Y;
            source.RenderTransform = CompositeTransformValor;
        }
    }
}
