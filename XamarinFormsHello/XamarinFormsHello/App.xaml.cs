using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation (XamlCompilationOptions.Compile)]
namespace XamarinFormsHello
{
	public partial class App : Application
	{
        public static MyConfiguration ConfigVM { get; set; }
		public App ()
		{
			InitializeComponent();
            if (ConfigVM == null) ConfigVM = new MyConfiguration();
			MainPage = new NavigationPage( new MainPage());
		}

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
