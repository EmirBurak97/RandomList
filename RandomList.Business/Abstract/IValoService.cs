using RandomList.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomList.Business.Abstract
{
    public interface IValoService
    {
        void Add(Valo valo);
        void AddUnique(Valo valo);
        void Delete(Valo valo);
        List<Valo> GetAll();
    }
}
