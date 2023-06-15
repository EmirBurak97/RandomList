using RandomList.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomList.DataAccess.Concrete.EntityFramework.Mapping
{
    public class ValoMap:EntityTypeConfiguration<Valo>
    {
        public ValoMap() 
        {
            ToTable(@"Valorant", @"dbo");
            HasKey(x => x.ValoId);

            Property(x => x.ValoId).HasColumnName("ValoId");
            Property(x=>x.ValoName).HasColumnName("ValoName");
        }
    }
}
