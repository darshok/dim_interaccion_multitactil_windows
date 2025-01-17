﻿using System;
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
    public sealed partial class Ejercicio2 : Page
    {
        public Ejercicio2()
        {
            this.InitializeComponent();
        }

        private void imageView_Tapped(object sender, TappedRoutedEventArgs e)
        {
            double x = e.GetPosition(imageView).X;
            double y = e.GetPosition(imageView).Y;
            listView.Items.Add("Se ha pulsado en la posicion x: " + x + ", y la posicion y: " + y);
            imageView.Opacity -= 0.1;
        }

        private void imageView_DoubleTapped(object sender, DoubleTappedRoutedEventArgs e)
        {
            imageView.Opacity = 1.0;
        }

        private void imageView_Holding(object sender, HoldingRoutedEventArgs e)
        {
            listView.Items.Clear();
        }
    }
}
