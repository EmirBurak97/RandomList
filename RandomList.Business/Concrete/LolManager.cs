using Ninject.Infrastructure.Language;
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
    public class LolManager : ILolService
    {
        private ILolDal _lolDal;

        public LolManager(ILolDal lolDal)
        {
            _lolDal = lolDal;
        }

        public void Add(Lol lol)
        {
            _lolDal.Add(lol);
        }

        public void AddUnique(Lol lol)
        {
            using(ListsContext context = new ListsContext()) 
            {
                var nameControl = context.Lol.Any(x => x.CharacterName == lol.CharacterName);
                if (nameControl==false)
                {
                    _lolDal.Add(lol);
                }
            }
        }

        public void Delete(Lol lol)
        {
            _lolDal.Delete(lol);
        }

        public List<Lol> GetAll()
        {
            return _lolDal.GetAll();
        }
    }
}
