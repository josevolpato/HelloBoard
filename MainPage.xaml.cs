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

// O modelo de item de Página em Branco está documentado em https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x416

namespace HelloBoard
{
    /// <summary>
    /// Uma página vazia que pode ser usada isoladamente ou navegada dentro de um Quadro.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void mfiClose_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Exit();
        }

        private void mfiNewBoard_Click(object sender, RoutedEventArgs e)
        {
            gdBoard.Children.Clear();
            gdBoard.ColumnDefinitions.Clear();
            for (int i = 0; i < 3; i++)
            {
                gdBoard.ColumnDefinitions.Add(new ColumnDefinition());
                Button b = new Button();
                b.Content = i.ToString();
                Grid.SetColumn(b, i);
                gdBoard.Children.Add(b);
            }

        }

        //Button btn = new Button();
        //btn.Content = "Item coluna 1";
        //spCol1.Children.Add(btn);
    }
}
