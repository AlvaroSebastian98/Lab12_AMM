using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Trigger
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            Item1.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new Data());

            };
            Item2.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new Event());
            };

            Item4.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new Property());

            };
            Item5.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new Style());

            };

            Item6.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new MultiTrigger());

            };

        }

    }
}
