using System.Windows;
using System.Windows.Controls;

namespace WpfWebStyle
{
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent(); 
            Tracing.Enable();
        }

        private void Quit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        //private void Test1(object sender, System.Windows.Input.MouseButtonEventArgs e) ok mousedoubleclick
        //{
          
        //}


        //private void Btn_Gotfocus(object sender, RoutedEventArgs e)
        //{
        //    frame1.NavigationService.Navigate(new Page1());
        //}



        //private void Test1(object sender, RoutedEventArgs e) loaded
        //{
        //    MessageBox.Show("Menu item clicked");
        //}

        //private void Test1(object sender, DependencyPropertyChangedEventArgs e) Ismousecapturechanged
        //{
        //    MessageBox.Show("Menu item clicked");
        //}

        //private void Test1(object sender, DependencyPropertyChangedEventArgs e) Isenablechanged
        //{
        //    MessageBox.Show("Menu item clicked");
        //}

        //private void Test1(object sender, System.EventArgs e) Item initialized
        //{
        //    MessageBox.Show("Menu item clicked");
        //}

    }
}
