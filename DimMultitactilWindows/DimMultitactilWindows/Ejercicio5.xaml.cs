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
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;

// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=234238

namespace DimMultitactilWindows
{
    /// <summary>
    /// Una página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class Ejercicio5 : Page
    {
        
        CompositeTransform compositeTransform = new CompositeTransform();
        List<Image> balls = new List<Image>();
        public Ejercicio5()
        {
            this.InitializeComponent();
        }

        private void grid_DoubleTapped(object sender, DoubleTappedRoutedEventArgs e)
        {
            double x = e.GetPosition(innerGrid).X;
            double y = e.GetPosition(innerGrid).Y;

            Image ball = new Image();
            ball.Width = 70;
            ball.Height = 70;
            compositeTransform.TranslateX = x - grid.ActualWidth / 2;
            compositeTransform.TranslateY = y - grid.ActualHeight / 2;
            ball.RenderTransform = compositeTransform;
            BitmapImage bitmapImage = new BitmapImage(new Uri("ms-appx:///Assets/ball.png"));
            ball.Source = bitmapImage;

            ball.ManipulationMode = ManipulationModes.All;
            ball.ManipulationDelta += Image_ManipulationDelta;

            balls.Add(ball);
            innerGrid.Children.Add(ball);
        }

        private void Image_ManipulationDelta(object sender, ManipulationDeltaRoutedEventArgs e)
        {
            Image source = sender as Image;

            compositeTransform.CenterX = source.ActualWidth / 2;
            compositeTransform.CenterY = source.ActualHeight / 2;
            compositeTransform.Rotation += e.Delta.Rotation;
            compositeTransform.ScaleX *= e.Delta.Scale;
            compositeTransform.ScaleY *= e.Delta.Scale;
            compositeTransform.TranslateX += e.Delta.Translation.X;
            compositeTransform.TranslateY += e.Delta.Translation.Y;

            source.RenderTransform = compositeTransform;
        }
    }
}
