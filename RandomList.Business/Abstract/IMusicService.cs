using RandomList.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomList.Business.Abstract
{
    public interface IMusicService
    {
        List<Music> GetAll();
        void Add(Music music);
        void Delete(Music music);
        void AddUnique(Music music);
    }
}
