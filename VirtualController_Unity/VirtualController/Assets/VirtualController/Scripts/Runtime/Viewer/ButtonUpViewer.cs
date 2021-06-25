using UnityEngine;

namespace VirtualController
{
    public class ButtonUpViewer : BaseButtonViewer
    {
        #region Exposed

        [Header("Button up viewer")]
        [SerializeField]
        protected Color _defaultColor = Color.white;
            
        #endregion


        #region Main
            
        public override void OnEventRaised()
        {
            _buttonGraphics.color = _defaultColor;
        }

        #endregion


        #region Unity API

        private void Awake() 
        {
            _buttonGraphics.color = _defaultColor;    
        }

        #endregion
    }
}
