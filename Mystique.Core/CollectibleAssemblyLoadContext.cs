﻿using Mystique.Core.ViewModels;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.Loader;
using System.Linq;
using System;

namespace Mystique.Core
{
    public class CollectibleAssemblyLoadContext : AssemblyLoadContext
    {
        private Assembly _entryPoint = null;
        private string _pluginName = string.Empty;

        public CollectibleAssemblyLoadContext(string pluginName) : base(isCollectible: true)
        {
            _pluginName = pluginName;
        }

        public string PluginName
        {
            get
            {
                return _pluginName;
            }
        }

        public void SetEntryPoint(Assembly entryPoint)
        {
            _entryPoint = entryPoint;
        }

        public Assembly GetEntryPointAssembly()
        {
            return _entryPoint;
        }

        protected override Assembly Load(AssemblyName name)
        {
            return null;
        }
    }
}
