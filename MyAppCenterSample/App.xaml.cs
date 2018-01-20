using Xamarin.Forms;
using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;

namespace MyAppCenterSample
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MyAppCenterSamplePage();
        }

        protected override void OnStart()
        {
            
            AppCenter.Start("ios=fb702ddd-65c3-4143-91d2-ca94f215106d;" + "uwp={Your UWP App secret here};" +
                   "android={Your Android App secret here}",
                   typeof(Analytics), typeof(Crashes));
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
