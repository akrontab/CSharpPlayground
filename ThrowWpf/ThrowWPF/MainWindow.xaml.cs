using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Effects;

namespace ThrowWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            txtBlk.BorderThickness = new Thickness(2);
            txtBlk.HorizontalScrollBarVisibility = ScrollBarVisibility.Auto;
        }

        private void btnThrow_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                JustThrow();
            }
            catch (Exception ex)
            {
                txtBlk.Text = ex.StackTrace;
            }
        }

        private void SomeBuggyCode()
        {
            throw new Exception("This is my Exception");


        }

        private void JustThrow()
        {
            try
            {
                SomeBuggyCode();
            }
            catch
            {
                throw;
            }
        }

        private void btnThrowEx_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                ThrowEx();
            }
            catch (Exception ex)
            {
                txtBlk.Text = ex.StackTrace;
            }
        }

        private void ThrowEx()
        {
            try
            {
                SomeBuggyCode();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
