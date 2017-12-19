using ICT13580032A2.Helpers;
using Xamarin.Forms;

namespace ICT13580032A2
{
    public partial class App : Application
    {
        public static dbHelper dbHelper {get;set;}
        public App(string dbPath)
        {
            InitializeComponent();

            dbHelper = new dbHelper(dbPath);

            MainPage = new NavigationPage(new MainPage());
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
