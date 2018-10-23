using Samples.Models;
using System;
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Samples.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MenuPage : ContentPage
    {
        MainPage RootPage { get => Application.Current.MainPage as MainPage; }

        List<HomeMenuItem> menuItems;

        public MenuPage()
        {
            InitializeComponent();

            menuItems = new List<HomeMenuItem>
            {
                new HomeMenuItem {PageType =typeof (TransparencyBug), Title="Transparency Bug" },
                new HomeMenuItem {PageType =typeof (TextDecoration), Title="Text decorations" },
                new HomeMenuItem {PageType =typeof (AcitivityIndicatorPage), Title="Activity indicator" },
                new HomeMenuItem {PageType =typeof (PageWithBackgroundImage), Title="Page with image" },
                new HomeMenuItem {PageType =typeof (MenuSamplePage), Title="Menu Page" },
                new HomeMenuItem {PageType =typeof (LabelsBugPage), Title="Labels Bug" },
                new HomeMenuItem {PageType =typeof (SliderPage), Title="Slider Page" },
            };

            ListViewMenu.ItemsSource = menuItems;

            ListViewMenu.SelectedItem = menuItems[0];
            ListViewMenu.ItemSelected += (sender, e) =>
           {
               if (e.SelectedItem == null)
                   return;
               RootPage.NavigateFromMenu((HomeMenuItem)e.SelectedItem);
           };
        }
    }
}