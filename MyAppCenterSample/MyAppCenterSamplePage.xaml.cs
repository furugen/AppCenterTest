using System.Collections.Generic;
using Microsoft.AppCenter.Analytics;
using Xamarin.Forms;

namespace MyAppCenterSample
{
    public partial class MyAppCenterSamplePage : ContentPage
    {
        public MyAppCenterSamplePage()
        {
            InitializeComponent();
        }

         void Button1_Clicked(object sender, System.EventArgs e)
        {
            Analytics.TrackEvent("Navigation", new System.Collections.Generic.Dictionary<string, string>{
                {"MyAppCenterSamplePage", "SecondPage"}
        });

        }

         void Button2_Clicked(object sender, System.EventArgs e)
        {
            Analytics.TrackEvent("Navigation", new Dictionary<string, string>{
                {"MyAppCenterSamplePage", "ThirdPage"}
        });

        }
    }
}
