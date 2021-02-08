namespace TouchSample.Swipe
{
    public delegate void DisplaceHandler(float displaceX, float displaceY);

    public interface ICameraSwipeModel
    {
        event DisplaceHandler Displaced;
    }
}