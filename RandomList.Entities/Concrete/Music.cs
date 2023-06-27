using RandomList.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomList.Entities.Concrete
{
    public class Music:IEntity
    {
        public int MusicId { get; set; }
        public string MusicName { get; set; }
    }
}
