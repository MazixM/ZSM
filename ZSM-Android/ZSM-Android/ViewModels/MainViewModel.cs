using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ZSM_Android.ViewModel
{
    class MainViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private bool isBusy = false;
        private string adresIp;
        private string port;
        private string login;
        private string password;
        private string displayMessage;

        public MainViewModel()
        {
            ConnectCommand = new Command(async () => await ConnectToServer(), () => !IsBusy);
        }

        public bool IsBusy
        {
            get => isBusy;
            set
            {
                isBusy = value;
                OnPropertyChanged();
                ConnectCommand.ChangeCanExecute();
            }
        }
        public string Login
        {
            get => login;
            set
            {
                login = value;
                OnPropertyChanged();
            }

        }
        public string Password
        {
            get => password;
            set
            {
                password = value;
                OnPropertyChanged();
            }
        }
        public string Port
        {
            get => port;
            set
            {
                port = value;
                OnPropertyChanged();
            }
        }
        public string DisplayMessage
        {
            get => displayMessage; private set
            {
                displayMessage = value;
                OnPropertyChanged();
            }
        }
        public string AdresIp
        {
            get => adresIp;
            set
            {
                adresIp = value;
                OnPropertyChanged();
            }
        }
        public Command ConnectCommand { get; }

        async Task ConnectToServer()
        {
            //TODO Connection to server
            IsBusy = true;
            await Task.Delay(2000);
            IsBusy = false;
            await Application.Current.MainPage.DisplayAlert("Połączenie", "Nie udało się połączyć z serwerem", "OK");

        }
        void OnPropertyChanged([CallerMemberName] string name = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
