using RandomList.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomList.DataAccess.Concrete.EntityFramework.Mapping
{
    public class LolMap : EntityTypeConfiguration<Lol>
    {
        public LolMap() 
        {
            ToTable(@"Lol", @"dbo");
            HasKey(x => x.LolId);

            Property(x => x.LolId).HasColumnName("LolId");
            Property(x => x.CharacterName).HasColumnName("CharacterName");
        }
    }
}
