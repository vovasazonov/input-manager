using UnityEngine;

namespace Scenes.Scripts.TouchSample.Swipe
{
    public sealed class CameraView : MonoBehaviour, ICameraView
    {
        [SerializeField] private Camera _camera;
        [SerializeField] private float _moveSpeed = 0.01f;

        public void SetPositionFromDefault(float deltaX, float deltaY)
        {
            var currentCameraPosition = _camera.transform.position;
            var positionX = (currentCameraPosition.x + deltaX) * _moveSpeed;
            var positionY = (currentCameraPosition.y + deltaY) * _moveSpeed;
            _camera.transform.position = new Vector3(positionX, positionY, currentCameraPosition.z);
        }
    }
}