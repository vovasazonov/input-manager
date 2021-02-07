using Inputs;

namespace Scenes.Scripts.TouchSample.Swipe
{
    public delegate void MovedHandler(float deltaX, float deltaY);

    public interface ICameraModel
    {
        event MovedHandler Moved;
        
    }
}