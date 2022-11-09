using System;
using System.Collections.Generic;
using System.Text;

namespace EniDemo.Service
{
    public enum DeviceOrientations
    {
        Undefined,
        Portrait,
        Landscape
    };

    public interface IDeviceOrientation
    {

        DeviceOrientations GetOrientation();
    }
}
