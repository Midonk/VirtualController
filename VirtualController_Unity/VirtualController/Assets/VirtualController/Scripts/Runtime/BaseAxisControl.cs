using UnityEngine;
using ScriptableObjectArchitecture;

namespace VirtualController
{
    public class BaseAxisControl : MonoBehaviour
    {
        #region Exposed

        [Header("Config")]
        [SerializeField]
        private string _axis;
        [SerializeField]
        private BoolVariable isRaw;

        [Header("Variables")]
        [SerializeField]
        private FloatVariable _axisValue;

        #endregion


        #region Unity API
            
        private void Update() 
        {
            _axisValue.Value = isRaw ? Input.GetAxisRaw(_axis) : Input.GetAxis(_axis);
        }

        #endregion
    }
}