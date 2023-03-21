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
using System.Diagnostics;
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
            mainWindow.Background = new SolidColorBrush(Colors.Black);

            // Create a canvas sized to fill the window
            Grid grid = new()
            {
                Width = 650,
                Height = 250,

                ShowGridLines = true,
                HorizontalAlignment = HorizontalAlignment.Stretch,
                VerticalAlignment = VerticalAlignment.Stretch,
                Background = new SolidColorBrush(Colors.Black),
            };
           

            ColumnDefinition colDef1 = new ColumnDefinition();
            ColumnDefinition colDef2 = new ColumnDefinition();
            ColumnDefinition colDef3 = new ColumnDefinition();
            ColumnDefinition colDef4 = new ColumnDefinition();
            ColumnDefinition colDef5 = new ColumnDefinition();
            ColumnDefinition colDef6 = new ColumnDefinition();
            ColumnDefinition colDef7 = new ColumnDefinition();
            ColumnDefinition colDef8 = new ColumnDefinition();
            ColumnDefinition colDef9 = new();
            ColumnDefinition colDef10 = new ColumnDefinition();
            ColumnDefinition colDef11= new ColumnDefinition();
            ColumnDefinition colDef12 = new ColumnDefinition();
            ColumnDefinition colDef13 = new ColumnDefinition();
            ColumnDefinition colDef14 = new ColumnDefinition();


            grid.ColumnDefinitions.Add(colDef1);
            grid.ColumnDefinitions.Add(colDef2);
            grid.ColumnDefinitions.Add(colDef3);
            grid.ColumnDefinitions.Add(colDef4);
            grid.ColumnDefinitions.Add(colDef5);
            grid.ColumnDefinitions.Add(colDef6);
            grid.ColumnDefinitions.Add(colDef7);
            grid.ColumnDefinitions.Add(colDef8);
            grid.ColumnDefinitions.Add(colDef9);
            grid.ColumnDefinitions.Add(colDef10);
            grid.ColumnDefinitions.Add(colDef11); 
            grid.ColumnDefinitions.Add(colDef12);
            grid.ColumnDefinitions.Add(colDef13);
            grid.ColumnDefinitions.Add(colDef14);




            RowDefinition rowDef1 = new RowDefinition();
            RowDefinition rowDef2 = new RowDefinition();
            RowDefinition rowDef3 = new RowDefinition();

            grid.RowDefinitions.Add(rowDef1);
            grid.RowDefinitions.Add(rowDef2);
            grid.RowDefinitions.Add(rowDef3);

        
            int number = 12;

            //tavaliselt ei hard codeiks array'd
            //praegu numbrid ei muutu
            int[,] roulette_numbers = { { 3, 6, 9, 12, 15, 18, 21, 24, 27, 30, 33, 36 }, { 2, 5, 8, 11, 14, 17, 20, 23, 26, 29, 32, 35 }, { 1, 4, 7, 10, 13, 16, 19, 22, 25, 28, 31, 34 } };





            for (int i = 0; i < number; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    int num = roulette_numbers[j, i];

                    //kontrollib kas jääb 1-10 19-28 vahemikku
                    if (num <= 10 || num >= 19 && num <= 28)
                    {
                        if (num % 2 == 0)
                        {
                            TextBox textBox = new TextBox()
                            {
                                Text = roulette_numbers[j, i].ToString(),
                                IsReadOnly = true,
                                Background = new SolidColorBrush(Colors.Black),
                                Foreground = new SolidColorBrush(Colors.White),
                                HorizontalContentAlignment = HorizontalAlignment.Center,
                                VerticalContentAlignment = VerticalAlignment.Center,
                                FontSize = 20,
                                Margin = new Thickness(2),
                            };
                            //odd red -- even black
                            Grid.SetColumn(textBox, i+1);
                            Grid.SetRow(textBox, j);
                            grid.Children.Add(textBox);

                        }
                        else if (num % 2 == 1)
                        {
                            TextBox textBox = new TextBox()
                            {
                                Text = roulette_numbers[j, i].ToString(),
                                IsReadOnly = true,
                                Background = new SolidColorBrush(Colors.Red),
                                Foreground = new SolidColorBrush(Colors.Black),
                                HorizontalContentAlignment = HorizontalAlignment.Center,
                                VerticalContentAlignment = VerticalAlignment.Center,
                                FontSize = 20,
                                Margin = new Thickness(2),


                            };
                            Grid.SetColumn(textBox, i+1);
                            Grid.SetRow(textBox, j);
                            grid.Children.Add(textBox);
                        }


                       

                    }
                    //kontrollib kas jääb 11-18 ja 29-36 vahele
                    else if (num <= 18 && num >= 11 || num >= 29 && num <= 36)
                    {
                        if (num % 2  == 1)
                        {
                            TextBox textBox = new TextBox()
                            {
                                Text = roulette_numbers[j, i].ToString(),
                                IsReadOnly = true,
                                Background = new SolidColorBrush(Colors.Black),
                                Foreground = new SolidColorBrush(Colors.White),
                                HorizontalContentAlignment = HorizontalAlignment.Center,
                                VerticalContentAlignment = VerticalAlignment.Center,
                                FontSize = 20,
                                Margin = new Thickness(2),


                            };

                            Grid.SetColumn(textBox, i + 1);
                            Grid.SetRow(textBox, j);
                            grid.Children.Add(textBox);
                        }
                        else if(num% 2 == 0)
                        {
                            TextBox textBox = new TextBox()
                            {
                                Text = roulette_numbers[j, i].ToString(),
                                IsReadOnly = true,
                                Background = new SolidColorBrush(Colors.Red),
                                Foreground = new SolidColorBrush(Colors.Black),
                                HorizontalContentAlignment = HorizontalAlignment.Center,
                                VerticalContentAlignment = VerticalAlignment.Center,
                                FontSize = 20,
                                Margin = new Thickness(2),


                            };

                            Grid.SetColumn(textBox, i + 1);
                            Grid.SetRow(textBox, j);
                            grid.Children.Add(textBox);
                        }
                      
                    }




                }
            }
            for (int i = 0; i < 3; i++)
            {
                TextBox textBox1 = new TextBox()
                {
                    Text = "2 to 1",
                    Background = new SolidColorBrush(Colors.Black),
                    Foreground = new SolidColorBrush(Colors.White),
                    HorizontalContentAlignment = HorizontalAlignment.Center,
                    VerticalContentAlignment = VerticalAlignment.Center,
                    LayoutTransform = new RotateTransform(-90),
                    Margin = new Thickness(5,0,0,0),
                    IsReadOnly = true,
                };
            

                Grid.SetColumn(textBox1, 13);

                Grid.SetRow(textBox1, 0+i);
                grid.Children.Add(textBox1);

            }



            mainWindow.Content = grid;
            mainWindow.Title = "test";
            mainWindow.Show();




        }

       


    }
}
