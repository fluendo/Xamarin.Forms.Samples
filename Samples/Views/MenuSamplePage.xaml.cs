using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Samples.Views
{
    public partial class MenuSamplePage : ContentPage
    {
        public MenuSamplePage()
        {
            InitializeComponent();
            menus.ItemsSource = new List<MenuItem> {
                new MenuItem {Text ="Menu 1", Selected=false},
                new MenuItem {Text ="Menu 2", Selected=true},
            };
            menus.ItemSelected += (o, e) =>
            {
                if (((MenuItem)e.SelectedItem).Text == "Menu 1")
                {
                    Navigation.PushAsync(new MenuSamplePage());
                }
                else
                {
                    Navigation.PopModalAsync();
                }
            };
        }
    }

    struct MenuItem
    {
        public string Text { get; set; }
        public bool Selected { get; set; }
    }
}
