using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly:XamlCompilation(XamlCompilationOptions.Compile)]
namespace WebViewSample
{
    public class App : Application
    {
        public App()
        {
			var navPage = new NavigationPage { Title="Authorization" };
            navPage.PushAsync(new LoadingLabelXaml());
            MainPage = navPage;
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
