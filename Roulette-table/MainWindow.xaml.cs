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
            // Create the application's main window and change its background to black
            Window mainWindow = Application.Current.MainWindow;
            mainWindow.Background = new SolidColorBrush(Colors.Black);

            // Create a Stretched grid
            Grid grid = new()
            {
              
                ShowGridLines = false,
                HorizontalAlignment = HorizontalAlignment.Stretch,
                VerticalAlignment = VerticalAlignment.Stretch,
                Background = new SolidColorBrush(Colors.Black),
            };
           

            //Create required columns
            ColumnDefinition colDef1 = new ColumnDefinition();
            ColumnDefinition colDef2 = new ColumnDefinition();
            ColumnDefinition colDef3 = new ColumnDefinition();
            ColumnDefinition colDef4 = new ColumnDefinition();
            ColumnDefinition colDef5 = new ColumnDefinition();
            ColumnDefinition colDef6 = new ColumnDefinition();
            ColumnDefinition colDef7 = new ColumnDefinition();
            ColumnDefinition colDef8 = new ColumnDefinition();
            ColumnDefinition colDef9 = new ColumnDefinition();
            ColumnDefinition colDef10 = new ColumnDefinition();
            ColumnDefinition colDef11= new ColumnDefinition();
            ColumnDefinition colDef12 = new ColumnDefinition();
            ColumnDefinition colDef13 = new ColumnDefinition();
            ColumnDefinition colDef14 = new ColumnDefinition();

            //add columns to grid
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



            //Create rows
            RowDefinition rowDef1 = new RowDefinition();
            RowDefinition rowDef2 = new RowDefinition();
            RowDefinition rowDef3 = new RowDefinition();
            RowDefinition rowDef4 = new RowDefinition();
            RowDefinition rowDef5 = new RowDefinition();
            
            //Add rows to grid
            grid.RowDefinitions.Add(rowDef1);
            grid.RowDefinitions.Add(rowDef2);
            grid.RowDefinitions.Add(rowDef3);
            grid.RowDefinitions.Add(rowDef4);
            grid.RowDefinitions.Add(rowDef5);


            //Static roulette table numbers
            int[,] roulette_numbers = { { 3, 6, 9, 12, 15, 18, 21, 24, 27, 30, 33, 36 }, { 2, 5, 8, 11, 14, 17, 20, 23, 26, 29, 32, 35 }, { 1, 4, 7, 10, 13, 16, 19, 22, 25, 28, 31, 34 } };


            int buttonRows = 12;



            for (int i = 0; i < buttonRows; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    int num = roulette_numbers[j, i];

                    //Checks if number is between 1-10 and 19-28
                    //odd == red even == black

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
                    //check if number is between 11-28 and 29-36 
                    else if (num <= 18 && num >= 11 || num >= 29 && num <= 36)
                    {
                        //odd == black even == red
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
                TextBox textBox = new TextBox()
                {
                    Text = "2 to 1",
                    Background = new SolidColorBrush(Colors.Black),
                    Foreground = new SolidColorBrush(Colors.White),
                    HorizontalContentAlignment = HorizontalAlignment.Center,
                    VerticalContentAlignment = VerticalAlignment.Center,
                    LayoutTransform = new RotateTransform(-90),
                    FontSize=20,
                    Margin = new Thickness(5,0,0,0),
                    IsReadOnly = true,
                };
            

                Grid.SetColumn(textBox, 13);

                Grid.SetRow(textBox, 0+i);
                grid.Children.Add(textBox);

            }




            



            
               TextBox textBox1 = new TextBox()
               {
                    Text = "1st 12",
                    Background = new SolidColorBrush(Colors.Black),
                    Foreground = new SolidColorBrush(Colors.White),
                    HorizontalContentAlignment = HorizontalAlignment.Center,
                    VerticalContentAlignment = VerticalAlignment.Center,
                    FontSize = 20,
                    IsReadOnly = true,
                   Margin = new Thickness(3, 8, 3, 3),
               };


                Grid.SetColumn(textBox1, 1);
                Grid.SetRow(textBox1, 3);
                Grid.SetColumnSpan(textBox1, 4);

            TextBox textBox2 = new TextBox()
            {
                Text = "2nd 12",
                Background = new SolidColorBrush(Colors.Black),
                Foreground = new SolidColorBrush(Colors.White),
                HorizontalContentAlignment = HorizontalAlignment.Center,
                VerticalContentAlignment = VerticalAlignment.Center,
                FontSize = 20,
                IsReadOnly = true,
                Margin = new Thickness(3, 8, 3, 3),

            };


            Grid.SetColumn(textBox2, 5);
            Grid.SetRow(textBox2, 3);
            Grid.SetColumnSpan(textBox2, 4);


            TextBox textBox3 = new TextBox()
            {
                Text = "3rd 12",
                Background = new SolidColorBrush(Colors.Black),
                Foreground = new SolidColorBrush(Colors.White),
                HorizontalContentAlignment = HorizontalAlignment.Center,
                VerticalContentAlignment = VerticalAlignment.Center,
                FontSize = 20,
                IsReadOnly = true,
                Margin = new Thickness(3, 8, 3, 3),

            };


            Grid.SetColumn(textBox3, 9);
            Grid.SetRow(textBox3, 3);
            Grid.SetColumnSpan(textBox3, 4);





            grid.Children.Add(textBox1);
            grid.Children.Add(textBox2);
            grid.Children.Add(textBox3);



            for (int i = 0; i < 12; i+=2)
            {

                TextBox textBox = new TextBox()
                {
                    Background = new SolidColorBrush(Colors.Black),
                    Foreground = new SolidColorBrush(Colors.White),
                    HorizontalContentAlignment = HorizontalAlignment.Center,
                    VerticalContentAlignment = VerticalAlignment.Center,
                    FontSize = 20,
                    IsReadOnly = true,
                    Margin = new Thickness(2),
                };


                switch (i)
                {
                    case 0:
                        textBox.Text = "1st to 18";
                        break;

                    case 2:
                        textBox.Text = "Even";
                        break;
                    case 4:
                        textBox.Background = new SolidColorBrush(Colors.Red);
                        break;
                    case 8:
                        textBox.Text = "Odd";
                        break;
                    case 10:
                        textBox.Text = "19 to 36";
                        break;
                    default:
                        break;
                }
                Grid.SetColumn(textBox,i+1);
                Grid.SetRow(textBox, 4);
                Grid.SetColumnSpan(textBox, 2);
                

                grid.Children.Add(textBox);

            }





            TextBox textBox4 = new TextBox()
            {
                Text = "0",
                Background = new SolidColorBrush(Colors.Green),
                Foreground = new SolidColorBrush(Colors.White),
                HorizontalContentAlignment = HorizontalAlignment.Center,
                VerticalContentAlignment = VerticalAlignment.Center,
                FontSize = 20,
                IsReadOnly = true,
                Margin = new Thickness(3),


            };
            Grid.SetColumn(textBox4, 0);
            Grid.SetRow(textBox4, 0);
            Grid.SetRowSpan(textBox4, 3);

            grid.Children.Add(textBox4);


            mainWindow.Content = grid;
            mainWindow.Title = "test";
            mainWindow.Show();






        }

       


    }
}
