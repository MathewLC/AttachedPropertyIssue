using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AttachedPropertiesIssue
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            var properties1 = StackLayoutProperties.GetStackLayoutCollection(StackLayout1); //this should return only StackLayout1 property
            var properties2 = StackLayoutProperties.GetStackLayoutCollection(StackLayout2); //this should return only StackLayout2 property

            var str = "";
            int count = 0;
            foreach (var prop in properties1)
            {
                str += $"{count} properties1: {prop.ExampleProperty1} \n";
                count++;
            }

            foreach (var prop in properties2)
            {
                str += $"{count} properties2: {prop.ExampleProperty1} \n";
                count++;
            }

            await DisplayAlert("Title", str, "OK");

        }
    }
}
