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
    public class MusicManager : IMusicService
    {
        private IMusicDal _musicDal;
        public MusicManager(IMusicDal musicDal)
        {
            _musicDal = musicDal;
        }

        public void Add(Music music)
        {
            _musicDal.Add(music);
        }

        public void AddUnique(Music music)
        {
            using (ListsContext context = new ListsContext())
            {
                var nameControl = context.Music.Any(x => x.MusicName == music.MusicName);
                if (nameControl==false)
                {
                    _musicDal.Add(music);
                }

            } 
        }

        public void Delete(Music music)
        {
            _musicDal.Delete(music);
        }

        public List<Music> GetAll()
        {
            return _musicDal.GetAll();
        }
    }
}
