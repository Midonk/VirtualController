using UnityEngine;
using UnityEngine.UI;

namespace VirtualController
{
    public class DPadViewer : DoubleAxisViewer
    {
        #region Exposed
            
        [Header("DPad")]
        [SerializeField]
        private Image _controllerGraphic;
        [SerializeField]
        private Color _defaultColor = Color.white;
        [SerializeField]
        private Color _activeColor = Color.white;

        #endregion


        #region Unity API
            
        protected override void Update() 
        {
            var isInactive = Mathf.Approximately(_xAxisValue, 0) && Mathf.Approximately(_yAxisValue, 0);
            _controllerGraphic.color = isInactive ? _defaultColor : _activeColor;

            base.Update();            
        }

        #endregion
    }
}