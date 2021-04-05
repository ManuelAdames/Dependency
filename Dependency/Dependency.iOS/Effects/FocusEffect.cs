using Foundation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UIKit;
using Xamarin.Forms.Platform.iOS;
using Dependency.iOS.Effects;
using Xamarin.Forms;
using System.ComponentModel;

[assembly: ResolutionGroupName("ManuelAdames")]
[assembly: ExportEffect(typeof(IosFocusEffect), "FocusEffect")]
namespace Dependency.iOS.Effects
{
    public class IosFocusEffect : PlatformEffect
    {
        UIColor backgroundColor;

        protected override void OnAttached()
        {
            try
            {
                Control.BackgroundColor = backgroundColor = UIColor.FromRGB(204, 153, 255);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Cannot set property on attached control. Error: ", ex.Message);
            }
        }

        protected override void OnDetached()
        {
        }

        protected override void OnElementPropertyChanged(PropertyChangedEventArgs args)
        {
            base.OnElementPropertyChanged(args);

            try
            {
                if (args.PropertyName == "IsFocused")
                {
                    if (Control.BackgroundColor == backgroundColor)
                    {
                        Control.BackgroundColor = UIColor.White;
                    }
                    else
                    {
                        Control.BackgroundColor = backgroundColor;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Cannot set property on attached control. Error: ", ex.Message);
            }
        }
    }
}