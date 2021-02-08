using UnityEngine;

namespace TouchSample.Swipe
{
    public sealed class CameraSwipeView : MonoBehaviour, ICameraSwipeView
    {
        [SerializeField] private Camera _camera;

        public void DisplaceCamera(float displaceX, float displaceY)
        {
            var cameraTransform = _camera.transform;
            var currentCameraPosition = cameraTransform.position;
            var positionX = currentCameraPosition.x + displaceX;
            var positionY = currentCameraPosition.y + displaceY;
            cameraTransform.position = new Vector3(positionX, positionY, currentCameraPosition.z);
        }
    }
}