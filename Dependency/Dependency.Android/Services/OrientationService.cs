using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Dependency.Internals;
using Dependency.Services;
using Xamarin.Forms;

namespace Dependency.Droid.Services
{
    public class OrientationService : IOrientationService
    {
        public Orientation GetOrientation()
        {
            IWindowManager windowManager = Android.App.Application.Context.GetSystemService(Context.WindowService).JavaCast<IWindowManager>();

            SurfaceOrientation orientation = windowManager.DefaultDisplay.Rotation;
            bool isLandscape = orientation == SurfaceOrientation.Rotation90 ||
                orientation == SurfaceOrientation.Rotation270;
            return isLandscape ? Orientation.Landscape : Orientation.Portrait;
        }
    }
}