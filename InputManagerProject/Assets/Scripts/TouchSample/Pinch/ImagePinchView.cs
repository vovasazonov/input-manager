using UnityEngine;

namespace Scenes.Scripts.TouchSample.Pinch
{
    public sealed class ImagePinchView : MonoBehaviour, IImagePinchView
    {
        [SerializeField] private RectTransform _rectTransform;
        [SerializeField] private float _speedChange = 0.01f;
        private Vector3 _defaultScale;

        private void Awake()
        {
            _defaultScale = _rectTransform.localScale;
        }

        public void SetPinch(float value)
        {
            _rectTransform.localScale = new Vector3((_defaultScale.x + value) * _speedChange, (_defaultScale.y * value) * _speedChange, _defaultScale.z);
        }
    }
}