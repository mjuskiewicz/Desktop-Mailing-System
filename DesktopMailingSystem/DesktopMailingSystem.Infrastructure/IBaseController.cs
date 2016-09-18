namespace DesktopMailingSystem.Infrastructure
{
    public interface IBaseController<T>
    {
        T ViewModel { get; set; }
    }
}
