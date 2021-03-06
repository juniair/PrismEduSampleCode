﻿using Microsoft.Practices.Unity;
using Prism.Unity;
using CollectionSampleApp.Views;
using System.Windows;

namespace CollectionSampleApp
{
    class Bootstrapper : UnityBootstrapper
    {
        protected override DependencyObject CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }

        protected override void InitializeShell()
        {
            Application.Current.MainWindow.Show();
        }
    }
}
