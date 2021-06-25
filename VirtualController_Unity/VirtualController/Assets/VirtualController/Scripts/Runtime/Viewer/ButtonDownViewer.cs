using UnityEngine;

namespace VirtualController
{
    public class ButtonDownViewer : BaseButtonViewer
    {
        #region Exposed

        [Header("Button down viewer")]    
        [SerializeField]
        private Color _color = Color.white;

        #endregion
        

        #region Main
            
        public override void OnEventRaised()
        {
            _buttonGraphics.color = _color;
        }

        #endregion
    }
}
