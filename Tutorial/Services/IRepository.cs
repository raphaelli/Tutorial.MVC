using System.Collections.Generic;

namespace Tutorial.Services
{
    public interface IRepository<T> where T:class
    {
        IEnumerable<T> GetAll();
    }
}
