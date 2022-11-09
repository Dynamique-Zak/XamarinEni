using EniDemo.DAO;
using EniDemo.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EniDemo
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PageDemoNatif : ContentPage
    {
        public PageDemoNatif()
        {
            InitializeComponent();

            // Singleton pour récupérer l'implémentation natif de notre service multi-plateform
            IDeviceOrientation deviceOrientation = DependencyService.Get<IDeviceOrientation>();

            LabelOrientation.Text = (deviceOrientation.GetOrientation() == DeviceOrientations.Landscape) ? "On est Lanscape" : "On est portait";
        }
    }
}