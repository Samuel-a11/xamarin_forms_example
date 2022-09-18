using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace xamarin_forms_example
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            btnBuy.Clicked += onClick;
        }

        private void onClick(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            label1.Text = "Se ha hecho un clic en el botón";
            Navigation.PushAsync(new Page1("Se ha hecho un clic en el botón"));
            Console.WriteLine("Se ha hecho un clic en el botón");
        }
    }
}
