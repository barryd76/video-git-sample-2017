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

namespace LambdaAnatomy
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            ClickMeButton.Click += 
                ( s,  e) =>
                {
                    MessageBox.Show("Hello World");
                };

            /*ClickMeButton.Click += 
                ( s, e) => MessageBox.Show("Hello World");*/

        }

       /* private void ClickMeButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Hello World");
        }*/


        /* private void ClickMeButton_Click(object sender, RoutedEventArgs e)
         {
             MessageBox.Show("Hello World");
         }*/

        // 1: Named delegate
        /*private void ClickMeButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Hello World");
        }*/


        // 2: Anonymouse delegate
        /* ClickMeButton.Click += 
                 delegate (object sender, RoutedEventArgs e)
                 {
                     MessageBox.Show("Hello World");
                 };*/

        // 3 To turn above into a lambda expression
        // remove delegate and add goto operator =>
        /*(object sender, RoutedEventArgs e) =>
                {
                    MessageBox.Show("Hello World");
                };*/

        // Can remove object and RoutedEventArgs , parameter typed inference
    }


}
