using Merge2D.Settings;
using UnityEngine;
using VContainer.Unity;

namespace Merge2D
{
    public class ApplicationController :IInitializable
    {
        #region Injection

        private readonly ProductItemSettings _productSettings;

        public ApplicationController(ProductItemSettings productSettings)
        {
            _productSettings = productSettings;
        }

        #endregion
        //Todo<BeratCan> All Game in first started here !!!!
        public void Initialize()
        {
            Debug.Log("First implementation : " +  _productSettings.ProductName);
        }
    }
}