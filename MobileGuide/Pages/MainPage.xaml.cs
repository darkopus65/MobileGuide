using System;
using Xamarin.Forms;
using PropertyChanged;
using MobileGuide.Pages;

namespace MobileGuide
{ 
    public partial class MainPage : ContentPage
    {
        private static MainViewModel VM = new MainViewModel();

        public MainPage()
        {
            InitializeComponent();
        }

        async void Attractions(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AttractionsPage());
        }

        void Vision(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }

    [AddINotifyPropertyChangedInterface]
    public class MainViewModel
    {

    }
}