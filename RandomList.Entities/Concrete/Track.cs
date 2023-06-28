using RandomList.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomList.Entities.Concrete
{
    public class Track:IEntity
    {
        public int TrackId { get; set; }
        public string TrackName { get; set; }
    }
}
