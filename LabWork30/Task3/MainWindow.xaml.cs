﻿using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Task3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void SizeRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;
            TextBox.FontSize = Convert.ToInt32(radioButton.Content);
        }

        private void LeftAlign_Checked(object sender, RoutedEventArgs e)
            => TextBox.TextAlignment = TextAlignment.Left;

        private void RightAlign_Checked(object sender, RoutedEventArgs e)
            => TextBox.TextAlignment = TextAlignment.Right;

        private void CenterAlign_Checked(object sender, RoutedEventArgs e)
            => TextBox.TextAlignment = TextAlignment.Center;
    }
}