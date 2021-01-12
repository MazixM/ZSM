using Xamarin.Forms;
using ZSM_Android.ViewModel;

namespace ZSM_Android
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new MainViewModel();
        }
    }
}
