using System;
using System.IO;
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

namespace STFastDesktop
{
    /// <summary>
    /// Lógica de interacción para Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Executed(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            main.Show();
            this.Close();
        }

        private void Login_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            if (userLogin_textBox.Text != "" && passwLogin_textBox.Password != "")
            {
                e.CanExecute = true;
            }
            else e.CanExecute = false;
        }

        private void CerrarLogin_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            this.Close();
        }

        //MOVER VENTANA LOGIN
        private  void StackPanel_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            base.OnMouseLeftButtonDown(e);
            this.DragMove();
        }

     
        //MARCA DE AGUA LOGIN-TEXTBOX
        private void UserTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (userLogin_textBox.Text == "")
            {
                ImageBrush textImageBrush = new ImageBrush();
                textImageBrush.ImageSource =new BitmapImage(new Uri("pack://application:,,,/Resources/userMaterial.png", UriKind.RelativeOrAbsolute));
                textImageBrush.AlignmentX = AlignmentX.Left;
                textImageBrush.Stretch = Stretch.None;
                userLogin_textBox.Background = textImageBrush;
            }
            else userLogin_textBox.Background = null;
        }

        private void PasswPasswordBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void PasswLogin_textBox_PasswordChanged(object sender, RoutedEventArgs e)
        {
            if (passwLogin_textBox.Password == "")
            {
                ImageBrush textImageBrush = new ImageBrush();
                textImageBrush.ImageSource = new BitmapImage(new Uri("pack://application:,,,/Resources/passMaterial.png", UriKind.RelativeOrAbsolute));
                textImageBrush.AlignmentX = AlignmentX.Left;
                textImageBrush.Stretch = Stretch.None;
                passwLogin_textBox.Background = textImageBrush;
            }
            else passwLogin_textBox.Background = null;
        }


    }
}
