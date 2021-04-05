using Foundation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UIKit;
using Dependency.iOS.Renderers;
using Dependency.Controls;
using Xamarin.Forms.Platform.iOS;
using Xamarin.Forms;

[assembly: ExportRenderer(typeof(MyEntry), typeof(MyEntryRenderer))]
namespace Dependency.iOS.Renderers
{
    public class MyEntryRenderer : EntryRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            if (e.NewElement != null)
            {
                Control.BackgroundColor = UIColor.FromRGB(204, 153, 255);
                Control.BorderStyle = UITextBorderStyle.Line;
            }
        }
    }
}