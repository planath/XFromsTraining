using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace XamarinFromsApp
{
    public partial class ColorPickerPage : ContentPage
    {
        public ColorPickerPage()
        {
            InitializeComponent();
        }

        void OnColorSliderChange(Object sender, EventArgs e)
        {
            var red = SliderRed.Value;
            var blue = SliderBlue.Value;
            var green = SliderGreen.Value;

            BoxView.Color = Color.FromRgb(red, green, blue);
        }
    }
}
