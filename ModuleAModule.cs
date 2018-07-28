using Prism.Modularity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prism.Unity.Regions;
using Prism.Unity;
using Microsoft.Practices.Unity;
using Prism.Regions;

namespace ModuleA
{
    public class ModuleAModule : IModule
    {
        IUnityContainer _container;
        IRegionManager _regionmanager;
        public void Initialize()
        {
            this._regionmanager.RegisterViewWithRegion("Toolbarview", typeof(Toolbarview));
            this._regionmanager.RegisterViewWithRegion("Toolbarview", typeof(Toolbarview));
            this._regionmanager.RegisterViewWithRegion("Toolbarview", typeof(Toolbarview));
            this._regionmanager.RegisterViewWithRegion("ContentView", typeof(ContentView));
        }
        public ModuleAModule(IUnityContainer container, IRegionManager regionmanager )
        {
            this._container = container;
            this._regionmanager = regionmanager;
        }
    }
}
