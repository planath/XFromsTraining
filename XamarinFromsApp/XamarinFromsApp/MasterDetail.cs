using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using XamarinFromsApp.Model;

namespace XamarinFromsApp
{
    class MasterDetail : MasterDetailPage
    {
        public MasterDetail()
        {
            var listView = new ListView();
            listView.ItemsSource = Person.GetPeople(10);
            listView.ItemSelected += ListView_ItemSelected;

            Master = new ContentPage
            {
                Title = "Kontakte",
                Content = listView
            };

            Detail = new AbsoluteLayout
            {
                Content = new Label()
                {
                    Text = "<- Wähle einen Eintrag aus dem versteckten menü."
                }
            };

        }

        private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem != null)
            {
                Detail = new PersonPage();
                Detail.BindingContext = e.SelectedItem;
                IsPresented = false;
            }
        }
    }
}
