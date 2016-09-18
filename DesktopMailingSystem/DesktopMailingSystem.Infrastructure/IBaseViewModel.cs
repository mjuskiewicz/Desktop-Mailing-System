namespace DesktopMailingSystem.Infrastructure
{
    public interface IBaseViewModel<T>
    {
        T Controller { get; }
    }
}
