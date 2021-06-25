using UnityEngine;
using UnityEngine.UI;

namespace VirtualController
{
    public class SingleAxisViewer : BaseSingleAxisControlListener
    {
        #region Exposed

        [Header("Viewer")]
        [SerializeField]
        private Image _controllerGraphic;
        [SerializeField]
        private Color _baseColor = Color.white;
        [SerializeField]
        private Color _maxValueColor = Color.white;

        #endregion


        #region Unity API

        private void Update() 
        {
            _controllerGraphic.color = Color.Lerp(_baseColor, _maxValueColor, _axisValue);
        }
            
        #endregion
    }
}
