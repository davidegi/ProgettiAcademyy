namespace MarioTask.Services
{
    public interface IService<T>
    {
        IEnumerable<T> PrendiliTutti();
    }
}
