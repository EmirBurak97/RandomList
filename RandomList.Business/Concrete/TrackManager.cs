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
    public class TrackManager : ITrackService
    {
        private ITrackDal _trackDal;

        public TrackManager(ITrackDal trackDal) 
        {
            _trackDal = trackDal;
        }
        public void Add(Track track)
        {
            _trackDal.Add(track);
        }

        public void AddUnique(Track track)
        {
            using(ListsContext context = new ListsContext()) 
            {
                var nameControl = context.Tracks.Any(p => p.TrackName == track.TrackName);
                if (nameControl==false) 
                {
                    _trackDal.Add(track);
                }
            }
        }

        public void Delete(Track track)
        {
            _trackDal.Delete(track);
        }

        public List<Track> GetAll()
        {
            return _trackDal.GetAll();
        }
    }
}
