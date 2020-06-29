using SimpleInjector;
using Xamarin.Forms;


namespace beispiel
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());

            if (!DesignMode.IsDesignModeEnabled)
            {
                var mainPage = new MainPage();
                var navigationPage = new NavigationPage(mainPage);

                Services.RegisterInstance(navigationPage.Navigation);
                

                
            }
        }

        public static Container Services { get; } = new Container();
        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
