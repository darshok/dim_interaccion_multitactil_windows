﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.ApplicationModel.Activation;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0xc0a

namespace DimMultitactilWindows
{
    /// <summary>
    /// Página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void NavView_Loaded(object sender, RoutedEventArgs e)
        {
            ContentFrame.Navigate(typeof(Ejercicio1));
            NavView.Header = "Ejercicio 1";
        }

        private void NavView_SelectionChanged(NavigationView sender, NavigationViewSelectionChangedEventArgs args)
        {
            NavigationViewItem item = args.SelectedItem as NavigationViewItem;

            switch (item.Tag.ToString())
            {
                case "ej1":
                    ContentFrame.Navigate(typeof(Ejercicio1));
                    NavView.Header = "Ejercicio 1";
                    break;
                case "ej2":
                    ContentFrame.Navigate(typeof(Ejercicio2));
                    NavView.Header = "Ejercicio 2";
                    break;
                case "ej3":
                    ContentFrame.Navigate(typeof(Ejercicio3));
                    NavView.Header = "Ejercicio 3";
                    break;
                case "ej4":
                    ContentFrame.Navigate(typeof(Ejercicio4));
                    NavView.Header = "Ejercicio 4";
                    break;
                case "ej5":
                    ContentFrame.Navigate(typeof(Ejercicio5));
                    NavView.Header = "Ejercicio 5";
                    break;
            }
        }
    }
}
