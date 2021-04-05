using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms.Internals;

namespace Dependency.Services
{
    public interface IOrientationService
    {
        DeviceOrientation GetOrientation();
    }
}
