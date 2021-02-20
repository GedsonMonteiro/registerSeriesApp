using System.Collections.Generic;

namespace DIO.Series.Interfaces
{
    public interface IRepository<T>
    {
        List<T> list();
        T returnToId(int id);        
        void insert(T entidade);        
        void delete(int id);        
        void update(int id, T entidade);
        int nextId();
    }
}