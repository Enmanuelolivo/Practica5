using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;
using Practica5.Services;
using Xamarin.Forms.Internals;

namespace Practica5.ViewModels
{
    public class DevicePageViewModel
    {
        public ICommand GetOrientationCommand { get; set; }
        public DevicePageViewModel()
        {
            GetOrientationCommand = new Command(() =>
            {
                IDeviceOrientationService service = DependencyService.Get<IDeviceOrientationService>();
                DeviceOrientation orientation = service.GetOrientation();

                App.Current.MainPage.DisplayAlert("Orientacion", orientation.ToString(), "ok");
            });

        }


    }
}
