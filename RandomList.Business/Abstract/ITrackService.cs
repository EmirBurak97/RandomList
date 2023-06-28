using RandomList.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomList.Business.Abstract
{
    public interface ITrackService
    {
        void Add(Track track);
        void Delete(Track track);
        void AddUnique(Track track);
        List<Track> GetAll();
    }
}
