using Lista.Views;

namespace Lista
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            UserAppTheme = AppTheme.Light;

            MainPage = new StartPage();
        }
    }
}
