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
    public partial class CoursePage : TabbedPage
    {
        public CoursePage ()
        {
            InitializeComponent();
        }
    }
}