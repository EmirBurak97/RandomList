using RandomList.DataAccess.Abstract;
using RandomList.DataAccess.Concrete.EntityFramewoek;
using RandomList.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomList.DataAccess.Concrete.EntityFramework
{
    public class EfValoDal:EfRepositoryBase<Valo,ListsContext>,IValoDal
    {
    }
}
