using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace RecipesApp.DAL
{
    interface IDBRepository<T>
    {
        void Create(T input);
        void Update(T input);
        T Get(int id);
        List<T> GetAll();
        void Delete(int id);

    }
}
