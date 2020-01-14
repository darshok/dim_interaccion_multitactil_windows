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
        public Ejercicio5()
        {
            this.InitializeComponent();
        }

        private void grid_DoubleTapped(object sender, DoubleTappedRoutedEventArgs e) //poner fondo en el grid
        {
            double x = e.GetPosition(grid).X;
            double y = e.GetPosition(grid).Y;

            Image ball = new Image();
            ball.Width = 200;
            ball.Height = 200;
            CompositeTransform compositeTransform = new CompositeTransform();
            compositeTransform.TranslateX = x;
            compositeTransform.TranslateY = y;
            ball.RenderTransform = compositeTransform;
            BitmapImage bitmapImage = new BitmapImage(new Uri("/Assets/ball.png", UriKind.Relative));
            ball.Source = bitmapImage;
        }
    }
}
