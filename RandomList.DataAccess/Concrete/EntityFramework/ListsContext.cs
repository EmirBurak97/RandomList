﻿using RandomList.DataAccess.Concrete.EntityFramework.Mapping;
using RandomList.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomList.DataAccess.Concrete.EntityFramewoek
{
    public class ListsContext : DbContext
    {
        public DbSet<Lol> Lol { get; set; }

        public DbSet<Valo> Valo { get; set; }

        public DbSet<Music> Music { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new LolMap());
            modelBuilder.Configurations.Add(new ValoMap());
            modelBuilder.Configurations.Add(new MusicMap());
        }
    }
}
