using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Windows.Input;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServusAppNet8.MVVM.Models;

namespace ServusAppNet8.MVVM.ViewModels
{
    internal class UserViewModel : INotifyPropertyChanged
    {
        //var declaration
        private string _username;
        private string _password;
        private List<User> _users = new List<User>();
        public ICommand LoginButton => new Command(Login);
        public ICommand RegisterButton => new Command(Register);

        

        public string Username
        {
            get => _username;
            set
            {
                _username = value;
                OnPropertyChanged(nameof(Username));
            }
        }

        public string Password
        {
            get => _password;
            set
            {
                _password = value;
                OnPropertyChanged(nameof(Password));
            }
        }

        private void Login()
        {
            if (_users.Any(u => u.Username == Username && u.Password == Password))
            {
                App.Current.MainPage.DisplayAlert("Login","Login Successful","OK");
            }
            else
            {
                App.Current.MainPage.DisplayAlert("Login", "Login Unsuccessful\nInvalid Username or Password", "OK");
            }
        }
        private void Register()
        {
            if (!string.IsNullOrEmpty(Username) && !string.IsNullOrEmpty(Password))
            {
                // Check if username already exists
                if (_users.Any(u => u.Username == Username || u.Password == Password))
                {
                    App.Current.MainPage.DisplayAlert("Register", "Account Already Exists", "OK");
                }
                else
                {
                    _users.Add(new User { Username = Username, Password = Password });
                    App.Current.MainPage.DisplayAlert("Register", "Account Registered", "OK");
                }


            }
            else
            {
                App.Current.MainPage.DisplayAlert("Register", "Please Enter All Fields", "OK");
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
