using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XamarinFromsApp
{
    public class ListCell : ViewCell
    {
        public ListCell()
        {
            var firstNameLabel = new Label()
            {
                FontSize = 22,
                FontAttributes = FontAttributes.Bold
            };
            firstNameLabel.SetBinding(Label.TextProperty, new Binding("FirstName"));

            var lastNameLabel = new Label()
            {
                FontSize = 22
            };
            lastNameLabel.SetBinding(Label.TextProperty, new Binding("LastName"));

            var emailLabel = new Label()
            {
                FontSize = 16
            };
            emailLabel.SetBinding(Label.TextProperty, new Binding("Email"));

            View = new StackLayout()
            {
                Children =
                {
                    new StackLayout()
                    {
                        Children = {firstNameLabel, lastNameLabel},
                        Orientation = StackOrientation.Horizontal
                    },
                    emailLabel
                },
                Orientation = StackOrientation.Vertical
            };

            View.SetBinding(View.BackgroundColorProperty, new Binding("Color"));
        }
    }
}
