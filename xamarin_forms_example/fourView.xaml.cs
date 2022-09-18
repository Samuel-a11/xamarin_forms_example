using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace xamarin_forms_example
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class fourView : ContentPage
    {
        public fourView()
        {
            InitializeComponent();
            btnBack3.Clicked += onClick6;
        }

        private void onClick6(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            Navigation.PopAsync();
        }
    }
}