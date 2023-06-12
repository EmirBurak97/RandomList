using RandomList.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomList.Entities.Concrete
{
    public class Lol:IEntity
    {
        public int LolId { get; set; }
        public string CharacterName { get; set; }
    }
}
