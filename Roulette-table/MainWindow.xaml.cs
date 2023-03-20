using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Roulette_table
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {


            InitializeComponent();
            CreateAndShowMainWindow();
           
        }
        private void CreateAndShowMainWindow()
        {
            // Create the application's main window
            Window mainWindow = Application.Current.MainWindow;

            // Create a canvas sized to fill the window
            Canvas myCanvas = new Canvas();

            int number = 5;
            int width = 100;
            int height = 10;
            int top = 20;
            int left = 20;

            for (int i = 0; i < number; i++)
            {
                // Create the rectangle
                Rectangle rec = new Rectangle()
                {
                    Width = width,
                    Height = height,
                    Fill = Brushes.Green,
                    Stroke = Brushes.Red,
                    StrokeThickness = 2,
                };

                // Add to a canvas for example
                myCanvas.Children.Add(rec);
                Canvas.SetTop(rec, top);
                Canvas.SetLeft(rec, left);
            }

            mainWindow.Content = myCanvas;
            mainWindow.Title = "Canvas Sample";
            mainWindow.Show();




        }

    }
}
