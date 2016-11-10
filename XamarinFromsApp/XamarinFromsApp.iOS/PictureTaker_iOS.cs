using System;
using Xamarin.Forms;
using Xamarin.Media;

[assembly: Dependency(typeof(XamarinFromsApp.iOS.PictureTaker_iOS))]
namespace XamarinFromsApp.iOS
{
    class PictureTaker_iOS : IPictureTaker
    {
        public async void SnapPic()
        {
            var picker = new MediaPicker();
            var mediaFile = await picker.PickPhotoAsync();
            System.Diagnostics.Debug.WriteLine(mediaFile.Path);

            MessagingCenter.Send<IPictureTaker, string>(this, "pictureTaken", mediaFile.Path);
        }
    }
}