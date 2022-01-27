﻿using Microsoft.EntityFrameworkCore;
using Oneiros.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oneiros.Data
{
    internal class OneirosContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.\;Database=OneirosDB;Trusted_Connection=True;MultipleActiveResultSets=true");
        }

        #region Dbset
        public DbSet<Affinity> Affinities { get; set; }
        public DbSet<Amulet> Amulets { get; set; }
        public DbSet<BackGround> BackGround { get; set; }
        public DbSet<Focus> Focus { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<Klasse> Klasses { get; set; }
        public DbSet<Race> Races { get; set; }
        public DbSet<Roanoke> Roanokes { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<SubGroup> SubGroups { get; set; }

        public DbSet<Player> Players { get; set; }    

        public DbSet<PlayerAffinity> PlayerAffinities { get; set; }
        public DbSet<PlayerFocus> PlayerFocus { get; set; }
        public DbSet<PlayerItem> PlayerItems { get; set; }
        public DbSet<PlayerKlasse> PlayerKlasses { get; set; }
        public DbSet<PlayerRace> PlayerRaces { get; set; } 
        public DbSet<PlayerSkill> PlayerSkills { get; set; }
        public DbSet<PlayerSubGroup> PlayerSubGroups { get; set; }
        public DbSet<PlayerRoanoke> PlayerRoanokes { get; set; }

        #endregion


    }
}
