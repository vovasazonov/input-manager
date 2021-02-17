namespace UI
{
    public delegate void UpdatedHandler();

    public interface ISelectable
    {
        event UpdatedHandler Updated;
    }
}