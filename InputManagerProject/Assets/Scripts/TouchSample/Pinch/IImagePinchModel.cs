namespace TouchSample.Pinch
{
    public delegate void ScaledHandler(float delta);

    public interface IImagePinchModel
    {
        event ScaledHandler Scaled;
    }
}