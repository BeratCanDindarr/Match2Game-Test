using UnityEngine;
using VContainer;
using VContainer.Unity;

namespace Merge2D.Core
{
    public class GameLifeScope : LifetimeScope
    {
        [SerializeField] private Settings settings;
        protected override void Configure(IContainerBuilder builder)
        {
            base.Configure(builder);
            
            settings.InjectAllSettings(builder);
            InjectControllers(builder);
        }

        private void InjectControllers(IContainerBuilder builder)
        {
            builder.RegisterEntryPoint<ApplicationController>(Lifetime.Singleton);
        }
    }
}