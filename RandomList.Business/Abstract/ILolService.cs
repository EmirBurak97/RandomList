using RandomList.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomList.Business.Abstract
{
    public interface ILolService
    {
        void Add(Lol lol);
        void Delete(Lol lol);
        List<Lol> GetAll();
    }
}
