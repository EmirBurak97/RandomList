using RandomList.DataAccess.Concrete.EntityFramewoek;
using RandomList.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomList.DataAccess.Abstract
{
    public interface ILolDal : IEntityRepository<Lol>
    {
    }
}
