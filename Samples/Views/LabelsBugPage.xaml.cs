using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Samples.Views
{
    public partial class LabelsBugPage : ContentPage
    {
        public LabelsBugPage()
        {
            InitializeComponent();
            Task.Run(async () =>
           {
               await Task.Delay(5000);
               label2.Text = "Paella is from Murcia";
           });
        }
    }
}
