using GROUP04WPF.ViewModels;
using System.Windows;
using System.Windows.Controls;

namespace GROUP04WPF.Views
{
    public partial class LoginView : Window
    {
        public LoginView()
        {
            InitializeComponent();
            DataContext = new LoginViewModel();
            passwordBox.PasswordChanged += (s, e) =>
            {
                ((LoginViewModel)DataContext).Password = passwordBox.Password;
                System.Diagnostics.Debug.WriteLine($"Password updated: {passwordBox.Password}");
            };
        }

        private void TogglePasswordButton_Click(object sender, RoutedEventArgs e)
        {
            if (passwordBox.Visibility == Visibility.Visible)
            {
                // Chuyển sang chế độ hiển thị password
                passwordTextBox.Text = passwordBox.Password;
                passwordTextBox.Visibility = Visibility.Visible;
                passwordBox.Visibility = Visibility.Collapsed;
                togglePasswordButton.Content = "🙈"; // Đổi icon sang ẩn
            }
            else
            {
                // Chuyển về chế độ ẩn password
                passwordBox.Password = passwordTextBox.Text;
                passwordTextBox.Visibility = Visibility.Collapsed;
                passwordBox.Visibility = Visibility.Visible;
                togglePasswordButton.Content = "👁"; // Đổi icon sang hiện
            }
        }
        private void btnExit_Click(object sender, RoutedEventArgs e)
        {            
            this.Close();
        }
    }
}