using RandomList.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomList.Entities.Concrete
{
    public class Valo:IEntity
    {
        public int ValoId { get; set; }
        public string ValoName { get; set; }
    }
}
