using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinFormsHello.App_Code;

namespace XamarinFormsHello
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class DataBindingPage : ContentPage
	{
		public DataBindingPage ()
		{
            InitializeComponent();

            Student student = new Student() {
                Id =Guid.NewGuid(),
                Name = "John Silva",
                Email = "JohnOfSilva@mail.com"
            };

            Professor professor = new Professor()
            {
                Name = "Michael Jackson",
                Course = "Dancing"
            };

            panelStudent.BindingContext = student;
            panelProfessor.BindingContext = professor;
		}
	}
}