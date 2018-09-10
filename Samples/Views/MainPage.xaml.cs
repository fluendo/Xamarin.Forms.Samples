using System;
using System.Collections.Generic;
using Samples.Models;
using Xamarin.Forms;

namespace Samples.Views
{
    public partial class MainPage : MasterDetailPage
    {
        public MainPage()
        {
            InitializeComponent();
            Master = new MenuPage();
            Detail = new ContentPage();
        }

        public void NavigateFromMenu(HomeMenuItem homeMenuItem)
        {
            Detail = (Page)Activator.CreateInstance(homeMenuItem.PageType);
        }
    }
}
