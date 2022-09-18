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
    public partial class thirdView : ContentPage
    {
        public thirdView()
        {
            InitializeComponent();
            btnBack2.Clicked += onClick4;
            btnNext2.Clicked += onClick5;
        }

        private void onClick4(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            Navigation.PopAsync();
        }

        private void onClick5(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            Navigation.PushAsync(new fourView(), false);
        }
    }
}