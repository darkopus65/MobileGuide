using System;
using System.Collections.Generic;
using MobileGuide.ViewModel;
using Xamarin.Forms;

namespace MobileGuide.Pages
{
    public partial class AttractionsPage : ContentPage
    {
        private static AttractionsViewModel VM = new AttractionsViewModel();
        public AttractionsPage()
        {
            InitializeComponent();
            BindingContext = VM;
        }
    }
}