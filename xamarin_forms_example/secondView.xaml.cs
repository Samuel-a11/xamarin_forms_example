using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace xamarin_forms_example
{
    public partial class Page1 : ContentPage
    {
        public Page1(string para)
        {
            InitializeComponent();
            mylabel.Text = para;
            btnBack.Clicked += onClick2;
            btnNext.Clicked += onClick3;
        }

        private void onClick2(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            Navigation.PopAsync();
        }

        private void onClick3(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            Navigation.PushAsync(new thirdView(), false);
        }
    }
}