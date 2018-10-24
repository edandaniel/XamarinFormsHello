using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinFormsHello
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class HomePage : ContentPage
	{
		public HomePage ()
		{
			InitializeComponent ();

            Button btnBack = new Button() { Text = "Back"};
            btnBack.Clicked += async(sender,evrs)=> {
                await Navigation.PopAsync();
            };
            rootLayout.Children.Add(btnBack);
		}

        void OnAlterarIntensidadeSlider(Object sender, EventArgs e)
        {
            var vermelho = sliderVermelho.Value;
            var verde = sliderVerde.Value;
            var azul = sliderAzul.Value;

            boxviewCor.Color = Color.FromRgb(vermelho, verde, azul);
        }
    }
}