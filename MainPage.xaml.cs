using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI;
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
            SetBoardColumnNumber(3);
        }

        private void Slider_ValueChanged(object sender, RangeBaseValueChangedEventArgs e)
        {
            SetBoardColumnNumber((int) e.NewValue);
        }

        private void SetBoardColumnNumber(int number)
        {
            gdBoard.Children.Clear();
            gdBoard.ColumnDefinitions.Clear();
            Color[] colors =
            {
                Colors.BlueViolet,
                Colors.Green,
                Colors.Gray,
                Colors.Orange,
                Colors.Red,
                Colors.Yellow,
                Colors.Turquoise
            };
            for (int i = 0; i < number; i++)
            {
                ColumnDefinition cd = new ColumnDefinition();
                gdBoard.ColumnDefinitions.Add(cd);

                StackPanel sp = new StackPanel();
                Grid.SetColumn(sp, i);
                sp.Background = new SolidColorBrush(colors[i]);

                Button b1 = new Button();
                b1.HorizontalAlignment = HorizontalAlignment.Stretch;
                b1.Content = i.ToString();

                Button b2 = new Button();
                b2.HorizontalAlignment = HorizontalAlignment.Stretch;
                b2.Content = i.ToString();

                sp.Children.Add(b1);
                sp.Children.Add(b2);
                gdBoard.Children.Add(sp);
            }
        }
    }
}
