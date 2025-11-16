using UnityEngine;
using VContainer;

namespace Merge2D.Core
{
    [CreateAssetMenu(menuName = MenuConst.CoreSettings + nameof(Settings), fileName = nameof(Settings))]
    public class Settings : ScriptableObject
    {
      public ScriptableObject[] allSettings;


      public void InjectAllSettings(IContainerBuilder builder)
      {
          foreach (var setting in allSettings)
          {
              builder.RegisterInstance(setting).AsSelf();
          }
      }
    }
}
