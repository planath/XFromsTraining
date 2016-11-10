using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using XamarinFromsApp.Model;

namespace XamarinFromsApp
{
    class HomePage : ContentPage
    {
        public HomePage()
        {
            var button1 = new Button
            {
                Text = "Color Picker",
                BackgroundColor = Color.Silver
            };
            button1.Clicked += (object sender, EventArgs e) =>
            {
                Navigation.PushAsync(new ColorPickerPage());
            };

            var button2 = new Button
            {
                Text = "Master Detail",
                BackgroundColor = Color.Silver
            };
            button2.Clicked += (object sender, EventArgs e) =>
            {
                Navigation.PushAsync(new MasterDetail());
            };

            var button3 = new Button
            {
                Text = "Tab page",
                BackgroundColor = Color.Silver
            };
            button3.Clicked += (object sender, EventArgs e) =>
            {
                var tabPage = new TabbedPage();
                tabPage.Title = "Courses";
                foreach (var person in Person.GetPeople(3))
                {
                    var onPage = new PersonPage();
                    onPage.BindingContext = person;
                    tabPage.Children.Add(onPage);
                }
                Navigation.PushAsync(tabPage);
            };

            var button4 = new Button
            {
                Text = "Carousel page",
                BackgroundColor = Color.Silver
            };
            button4.Clicked += (object sender, EventArgs e) =>
            {
                var carouselPage = new CarouselPage();
                carouselPage.Title = "Courses";
                foreach (var person in Person.GetPeople(3))
                {
                    var onPage = new PersonPage();
                    onPage.BindingContext = person;
                    carouselPage.Children.Add(onPage);
                }
                Navigation.PushAsync(carouselPage);
            };

            Content = new ScrollView
            {
                Padding = new Thickness(10, Device.OnPlatform(20, 0, 0), 10, 0),
                Content = new StackLayout
                {
                    Spacing = 10,
                    Children = {
                        button1, button2, button3, button4
                    }
                }
            };
        }
        
    }
}
