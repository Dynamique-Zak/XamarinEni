﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EniDemo
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new PageDemo();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
