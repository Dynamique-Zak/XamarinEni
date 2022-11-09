using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using EniDemo.Droid;
using EniDemo.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

[assembly: Xamarin.Forms.Dependency(typeof(AndroidDeviceOrientation))]
namespace EniDemo.Droid
{
    public class AndroidDeviceOrientation : IDeviceOrientation
    {
        public DeviceOrientations GetOrientation()
        {
            // Récupérer l'ecran du telephone
            IWindowManager windowManager = Android.App.Application.Context.GetSystemService(Context.WindowService)
    .JavaCast<IWindowManager>();

            // Récupérer l'orientation du telephone
            var rotation = windowManager.DefaultDisplay.Rotation;

            // Landscape
            bool isLandscape = (rotation == SurfaceOrientation.Rotation90 || rotation ==  SurfaceOrientation.Rotation270);


            return isLandscape ? DeviceOrientations.Landscape : DeviceOrientations.Portrait;
        }
    }
}