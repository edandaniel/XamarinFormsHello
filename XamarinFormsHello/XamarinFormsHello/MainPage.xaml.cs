using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XamarinFormsHello
{
	public partial class MainPage : ContentPage
	{
        public MainPage()
		{
			InitializeComponent();
		}

        private void ClicarNomeBotao(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTexto.Text))
            {
                DisplayAlert("Hey"
                    , "write your name in the box below", "OK");
                txtTexto.Focus();
            }
            else
                DisplayAlert("Hey Hey Hey"
                    , string.Format("Hello, {0}, be welcomed", txtTexto.Text)
                    , "OK");

        }

        private void btnHome_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new HomePage());
        }

        void btnConfig_Clicked(object sender, EventArgs args)
        {
            Navigation.PushAsync(new ConfigPage());
        }

        void btnConteudo_Clicked(object sender, EventArgs args)
        {
            Navigation.PushAsync(new CoursePage());
        }

        private void btnDataBinding_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new DataBindingPage());
        }
    }
}
