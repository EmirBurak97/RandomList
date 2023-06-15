using RandomList.Business.Abstract;
using RandomList.DataAccess.Abstract;
using RandomList.DataAccess.Concrete.EntityFramewoek;
using RandomList.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomList.Business.Concrete
{
    public class ValoManager : IValoService
    {
        private IValoDal _valoDal;
        public ValoManager(IValoDal valoDal)
        {
              _valoDal = valoDal;
        }

        public void Add(Valo valo)
        {
            _valoDal.Add(valo);
        }

        public void AddUnique(Valo valo)
        {
            using (ListsContext context = new ListsContext())
            {
                var nameControl = context.Valo.Any(x => x.ValoName == valo.ValoName);
                if (nameControl == false)
                {
                    _valoDal.Add(valo);
                }
            }
        }

        public void Delete(Valo valo)
        {
            _valoDal.Delete(valo);
        }

        public List<Valo> GetAll()
        {
            return _valoDal.GetAll();
        }
    }
}
