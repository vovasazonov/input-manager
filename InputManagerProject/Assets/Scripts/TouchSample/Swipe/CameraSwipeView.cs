using UnityEngine;

namespace Scenes.Scripts.TouchSample.Swipe
{
    public sealed class CameraSwipeView : MonoBehaviour, ICameraSwipeView
    {
        [SerializeField] private Camera _camera;
        [SerializeField] private float _speedChange = 0.01f;

        public void SetPositionFromDefault(float deltaX, float deltaY)
        {
            var currentCameraPosition = _camera.transform.position;
            var positionX = (currentCameraPosition.x + deltaX) * _speedChange;
            var positionY = (currentCameraPosition.y + deltaY) * _speedChange;
            _camera.transform.position = new Vector3(positionX, positionY, currentCameraPosition.z);
        }
    }
}