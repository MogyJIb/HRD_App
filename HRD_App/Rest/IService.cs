using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRD_App.Rest
{
    public interface IService<T>
    {
        Task<List<T>> GetAll(bool deleted);
        Task<T> Get(int id);
        Task Update(int id, T item);
        Task<T> Add(T item);
        Task<T> Delete(int id);
    }
}
