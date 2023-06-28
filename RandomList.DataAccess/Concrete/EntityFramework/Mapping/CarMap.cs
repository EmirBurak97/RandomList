using RandomList.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomList.DataAccess.Concrete.EntityFramework.Mapping
{
    public class CarMap:EntityTypeConfiguration<Car>
    {        
        public CarMap()
        {
            ToTable(@"Cars", @"dbo");
            HasKey(x => x.CarId);

            Property(x => x.CarId).HasColumnName("CarId");
            Property(x => x.CarName).HasColumnName("CarName");
        }
    }
}
