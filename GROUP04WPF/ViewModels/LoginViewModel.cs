using GROUP04DataAccess.Repositories;
using GROUP04WPF.Helpers;
using GROUP04WPF.Views;
using System.ComponentModel;
using System.Security;
using System.Windows;
using System.Windows.Input;

namespace GROUP04WPF.ViewModels
{
    public class LoginViewModel : INotifyPropertyChanged
    {
        private string email;
        private string password;
        private readonly RelayCommand loginCommand;
        
        public string Email
        {
            get => email;
            set
            {
                email = value;
                OnPropertyChanged(nameof(Email));
                loginCommand.RaiseCanExecuteChanged(); // Cập nhật CanExecute
            }
        }        
        public string Password
        {
            get => password;
            set
            {
                password = value;
                OnPropertyChanged(nameof(Password));
                loginCommand.RaiseCanExecuteChanged(); // Cập nhật CanExecute
            }
        }        
        public ICommand LoginCommand { get => loginCommand; }
        public LoginViewModel()
        {
            loginCommand = new RelayCommand(Login, () => !string.IsNullOrEmpty(Email) && !string.IsNullOrEmpty(Password));
        }
        private void Login()
        {
            try
            {
                if (Email == "admin@FUMiniHotelSystem.com" && Password == "@@abc123@@")
                {
                    new AdminMainWindow().Show();
                    Application.Current.Windows[0].Close();
                }
                else
                {
                    var customer = CustomerRepository.Instance.GetAll().FirstOrDefault(c => c.EmailAddress == Email && c.Password == Password);
                    if (customer != null)
                    {
                        new CustomerMainWindow(customer).Show();
                        Application.Current.Windows[0].Close();
                    }
                    else
                    {
                        MessageBox.Show("Invalid credentials!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error during login: {ex.Message}");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}