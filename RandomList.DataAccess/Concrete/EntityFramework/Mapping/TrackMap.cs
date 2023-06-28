using RandomList.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomList.DataAccess.Concrete.EntityFramework.Mapping
{
    public class TrackMap:EntityTypeConfiguration<Track>
    {
        public TrackMap()
        {
            ToTable(@"Tracks", @"dbo");
            HasKey(x => x.TrackId);

            Property(x => x.TrackId).HasColumnName("TrackId");
            Property(x=>x.TrackName).HasColumnName("TrackName");
        }
    }
}
