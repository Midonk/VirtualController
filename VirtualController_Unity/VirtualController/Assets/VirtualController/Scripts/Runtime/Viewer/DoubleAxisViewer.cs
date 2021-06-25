using UnityEngine;

namespace VirtualController
{
    public class DoubleAxisViewer : BaseDoubleAxisControlListener
    {
        #region Exposed

        [Header("Viewer")]
        [SerializeField]
        private RectTransform _graphicTransform;
        [SerializeField, Range(0, 1)]
        private float _maxDisplacement;
            
        #endregion


        #region Unity API

        private void Awake() 
        {
            _defaultGraphicPosition = _graphicTransform.position;
        }

        protected virtual void Update() 
        {
            var moveVector = new Vector3(_xAxisValue, _yAxisValue, 0) * _maxDisplacement * _graphicTransform.rect.size.magnitude;
            _graphicTransform.position = _defaultGraphicPosition + moveVector;
        }
        
        #endregion


        #region Private Fields
            
        private Vector3 _defaultGraphicPosition;

        #endregion
    }
}