namespace Negocio.InterfacesRepositorio
{
    public interface IRepositorio<T> where T : class
    {
        void Add(T obj);
        void Remove(int id);
        void Update(T obj);
        IEnumerable<T> FindAll();
        T FindById(int id);
    }
}
