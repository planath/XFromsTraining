using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using XamarinFromsApp.Model;

namespace XamarinFromsApp
{
    class PersonPage : ContentPage
    {
        //public PersonPage()
        //{
        //    SetBinding(ContentPage.TitleProperty, "FirstName");

        //    BackgroundColor = Color.White;
        //    Title = "Keine Wahl";
        //    Content = new Label
        //    {
        //        Text = "Bitte wähle einen Entrag",
        //        HorizontalTextAlignment = TextAlignment.Center,
        //        HorizontalOptions = LayoutOptions.FillAndExpand,
        //        TextColor = Color.Teal
        //    };
        //}

        public PersonPage()
        {
            BackgroundColor = Color.Silver;
            this.SetBinding(ContentPage.TitleProperty, "Name");

            var titleLabel = new Label
            {
                FontSize = 28,
                FontAttributes = FontAttributes.Bold
            };
            titleLabel.SetBinding(Label.TextProperty, "Name");

            var firstNameLabel = new Label();
            firstNameLabel.SetBinding(Label.TextProperty, "FirstName");

            var lastNameLabel = new Label();
            lastNameLabel.SetBinding(Label.TextProperty, "LastName");

            var emailLabel = new Label();
            emailLabel.SetBinding(Label.TextProperty, "Email");

            Content = new ScrollView
            {
                Content = new StackLayout
                {
                    Padding = new Thickness(10, Device.OnPlatform(20, 0, 0), 10, 0),
                    Spacing = 10,
                    Children = { titleLabel, firstNameLabel, lastNameLabel, emailLabel}
                }
            };

        }
    }
}
