using System.Collections;
using UnityEngine;

namespace UI.Screens.AlertPopup.Animation
{
    public class UIAlertPopupAnimation : MonoBehaviour
    {
        #region Variables

        public float growSpeed;

        private Transform _transform;

        #endregion Variables
        
        
        #region Animation

        public void AnimateIn()
        {
            _transform = transform;
            _transform.localScale = Vector3.zero;

            StartCoroutine(nameof(AnimateTick));
        }

        private void OnDisable()
        {
            StopCoroutine(nameof(AnimateTick));
        }
        
        private IEnumerator AnimateTick()
        {
            while (_transform.localScale.x < 0.95f)
            {
                _transform.localScale = Vector3.Lerp(
                    _transform.localScale, 
                    Vector3.one, 
                    Time.unscaledDeltaTime * growSpeed);
                yield return null;
            }
            _transform.localScale = Vector3.one;
        }
        
        #endregion Animation
    }
}