using EniDemo.DAO;
using System;
using System.Collections.Generic;
using System.Text;

namespace EniDemo.Service
{
    public class ServiceManager
    {
        static List<ServiceBase> Services = new List<ServiceBase>();

        public static T GetServiceByClass<T>() where T : new()
        {
            // Je vais voir si la DAO à déjà été instancié
            foreach (ServiceBase service in Services)
            {
                if (service.GetType() == typeof(T))
                {
                    return (T)Convert.ChangeType(service, typeof(T));
                }
            }

            T newService = new T();
            ServiceBase ServiceInstance = newService as ServiceBase;
            Services.Add(ServiceInstance);

            return newService;
        }
    }
}
