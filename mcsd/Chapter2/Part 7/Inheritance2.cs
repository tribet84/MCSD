using System.Collections.Generic;
namespace Chapter2
{
    interface IRespository<T>
    {
        T FindById(int id);
        IEnumerable<T> All();
    }
}