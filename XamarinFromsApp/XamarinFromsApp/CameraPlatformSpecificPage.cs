using Xamarin.Forms;

namespace XamarinFromsApp
{
    public class CameraPlatformSpecificPage : ContentPage
    {
        public CameraPlatformSpecificPage()
        {
            var theButton = new Button
            {
                Text = "take a pic"
            };
            theButton.Clicked += (sender, args) =>
            {
                var picTaker = DependencyService.Get<IPictureTaker>();
                picTaker.SnapPic();
            };

            var theImage = new Image
            {
                HorizontalOptions = LayoutOptions.FillAndExpand,
                VerticalOptions = LayoutOptions.FillAndExpand
            };

            MessagingCenter.Subscribe<IPictureTaker, string>(this, "pictureTaken",
                (sender, arg) =>
                {
                    theImage.Source = ImageSource.FromFile(arg);
                });

            Content = new StackLayout
            {
                Spacing = 10,
                Children = {theButton, theImage}
            };
        }
    }
}