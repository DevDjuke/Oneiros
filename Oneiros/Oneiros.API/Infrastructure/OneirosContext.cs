using Microsoft.EntityFrameworkCore;
using Oneiros.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oneiros.API.Infrastructure
{
    public class OneirosContext : DbContext
    {
        public OneirosContext(DbContextOptions<OneirosContext> options) : base(options) { }

        #region Dbset
        public DbSet<Affinity> Affinities { get; set; }
        public DbSet<Amulet> Amulets { get; set; }
        public DbSet<BackGround> BackGround { get; set; }
        public DbSet<Focus> Focus { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<Klasse> Klasses { get; set; }
        public DbSet<Race> Races { get; set; }
        public DbSet<Campaign> Campaigns { get; set; }
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
