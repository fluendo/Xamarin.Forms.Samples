using System;
using Gtk;
using Xamarin.Forms;
using Xamarin.Forms.Platform.GTK;
using Xamarin.Forms.Platform.GTK.Helpers;

namespace Samples
{
    public static class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            GtkThemes.Init();
            Gtk.Application.Init();
            Forms.Init();
            var app = new App();
            var window = new FormsWindow();
            window.LoadApplication(app);
            window.SetApplicationTitle("XAMLator Sample App");
            window.Show();
            Gtk.Application.Run();
        }
    }

}
