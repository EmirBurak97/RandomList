using RandomList.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomList.DataAccess.Concrete.EntityFramework.Mapping
{
    public class MusicMap:EntityTypeConfiguration<Music>
    {
        public MusicMap() 
        {
            ToTable(@"Music", @"dbo");
            HasKey(x => x.MusicId);

            Property(x=> x.MusicId).HasColumnName("MusicId");
            Property(x => x.MusicName).HasColumnName("MusicName");
        }
    }
}
