using RandomList.DataAccess.Abstract;
using RandomList.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomList.DataAccess.Concrete.EntityFramewoek
{
    public class EfLolDal : EfRepositoryBase<Lol, ListsContext>, ILolDal
    {

    }
}
