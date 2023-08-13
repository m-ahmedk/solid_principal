namespace SOLID.Repository.Interface
{
    public interface IInstanceFactory<T>
    {
        public T GetInstance(string token);
    }
}
