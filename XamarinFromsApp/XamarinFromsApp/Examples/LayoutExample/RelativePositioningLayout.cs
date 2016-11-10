using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XamarinFromsApp
{
    class RelativePositioningLayout : ContentPage
    {
        public RelativePositioningLayout()
        {
            var layout = new RelativeLayout();

            var label1 = new Label { Text = "This is a line of text" };
            var label2 = new Label { Text = "This is second line of text" };
            var label3 = new Label { Text = "This is the third line" };

            layout.Children.Add(label1, Constraint.Constant(0),
                Constraint.RelativeToParent(p => (p.Height / 2) - (label1.Height / 2)));
            layout.Children.Add(label2,
                Constraint.RelativeToView(label1, (parent, otherView) => otherView.X + otherView.Width),
                Constraint.RelativeToView(label1, (parent, otherView) => otherView.Y - otherView.Height));
            layout.Children.Add(label3, 
                Constraint.RelativeToView(label2, (parent, otherView) => otherView.X + otherView.Width - label3.Width), 
                Constraint.RelativeToView(label1, (parent, otherView) => otherView.Y));

            // recalculate layout to make constraints work properly
            label3.SizeChanged += (sender, args) => layout.ForceLayout();

            Content = layout;
        }
    }
}
