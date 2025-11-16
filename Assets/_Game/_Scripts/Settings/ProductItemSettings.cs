using UnityEngine;

namespace Merge2D.Settings
{
    [CreateAssetMenu(menuName = MenuConst.ItemSettings+ nameof(ProductItemSettings), fileName = nameof(ProductItemSettings))]
    public class ProductItemSettings : ScriptableObject
    {
        public string ProductName;
    }
}