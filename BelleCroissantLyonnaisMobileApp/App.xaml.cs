using BelleCroissantLyonnaisMobileApp.Views;

namespace BelleCroissantLyonnaisMobileApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new RegistrationScreen());
        }
    }
}
