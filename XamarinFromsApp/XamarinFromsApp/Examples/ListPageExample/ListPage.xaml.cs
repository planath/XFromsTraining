using System.Diagnostics;
using System.Linq;

using Xamarin.Forms;
using XamarinFromsApp.Model;

namespace XamarinFromsApp
{
    public partial class ListPage : ContentPage
    {
        public ListPage()
        {
            InitializeComponent();
            
            var listView = new ListView();
            listView.ItemsSource = Person.GetPeople();
            listView.ItemTemplate = new DataTemplate(typeof(ListCell));
        

            listView.ItemSelected += (sender, args) =>
            {
                if(args.SelectedItem != null)
                    Debug.WriteLine("Selected: " + args.SelectedItem);

                listView.SelectedItem = null;
            };

            Padding = new Thickness(0, Device.OnPlatform(20, 0, 0), 0, 0);
            Content = listView;
        }
    }
}
