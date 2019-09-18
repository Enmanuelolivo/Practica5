using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using UIKit;
using Practica5.Services;
using Xamarin.Forms.Internals;
using Practica5.iOS.Services;
using Xamarin.Forms;

[assembly: Dependency(typeof(DeviceOrientationiOS))]
namespace Practica5.iOS.Services
{
    public class DeviceOrientationiOS : IDeviceOrientationService
    {
        public DeviceOrientation GetOrientation()
        {
            UIInterfaceOrientation orientation = UIApplication.SharedApplication.StatusBarOrientation;
            bool isPortrait = orientation == UIInterfaceOrientation.Portrait ||
            orientation == UIInterfaceOrientation.PortraitUpsideDown;
            return isPortrait ? DeviceOrientation.Portrait : DeviceOrientation.Landscape;
        }
    }
}