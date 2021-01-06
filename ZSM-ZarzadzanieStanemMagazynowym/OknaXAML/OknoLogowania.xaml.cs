using System.Windows;
using ZSM_ZarzadzanieStanemMagazynowym.Serwer;

namespace ZSM_ZarzadzanieStanemMagazynowym
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class OknoLogowania : Window
    {
        public OknoLogowania()
        {
            InitializeComponent();
        }

        private void ButtonLogin_Click(object sender, RoutedEventArgs e)
        {
            Uzytkownik uzytkownik = SerwerLogowanie.Zaloguj(textBoxLogin.Text, passwordBoxPassword.Password);
            if (uzytkownik != null)
            {
                MessageBox.Show("Zalogowano");
            }
            else
            {
                MessageBox.Show("Błędny login, lub hasło");
            }
        }
    }
}
