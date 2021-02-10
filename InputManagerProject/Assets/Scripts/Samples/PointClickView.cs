using Inputs;
using UnityEngine;

namespace Samples
{
    public sealed class PointClickView : MonoBehaviour, IPointClickView
    {
        [SerializeField] private RectTransform _pointRectTransform;

        public void SetPosition(IVector2 position)
        {
            var pointPosition = _pointRectTransform.position;
            _pointRectTransform.position = new Vector3(position.X, position.Y, pointPosition.z);
        }
    }
}