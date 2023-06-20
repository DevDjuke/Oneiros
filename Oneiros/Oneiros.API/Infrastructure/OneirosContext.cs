using Microsoft.EntityFrameworkCore;
using Oneiros.Domain.Model;
using Oneiros.Domain.Model.CharacterModel;
using Oneiros.Domain.Model.CharacterModel.NonPlayer;
using Oneiros.Domain.Model.CharacterModel.Player;
using Oneiros.Domain.Model.Generic;
using Oneiros.Domain.Model.Links;

namespace Oneiros.API.Infrastructure
{
    public class OneirosContext : DbContext
    {
        public OneirosContext(DbContextOptions<OneirosContext> options) : base(options) { }

        #region Dbset
        //Base
        public DbSet<Character> Characters { get; set; }
        public DbSet<NonPlayer> NPCs { get; set; }
        public DbSet<Player> Players { get; set; }
        public DbSet<Campaign> Campaigns { get; set; }
        public DbSet<Item> Items { get; set; }
        //NPC
        public DbSet<Preset> Presets { get; set; }
        public DbSet<Build> Builds { get; set; }
        //player
        public DbSet<Classe> Classes { get; set; }
        //Character
        public DbSet<Ability> Abilities { get; set; }
        public DbSet<BackGround> BackGrounds { get; set; }
        public DbSet<Feature> Features { get; set; }
        public DbSet<Language> Languages { get; set; }
        public DbSet<Race> Races { get; set; }
        public DbSet<Skill> Skills { get; set; }
        //Genertic
        public DbSet<Tag> Tags { get; set; }
        //Link
        public DbSet<CampaignCharacter> CampaignCharacters { get; set; }
        public DbSet<CharacterAbility> CharacterAbilities { get; set; }
        public DbSet<CharacterFeature> CharacterFeatures { get; set; }
        public DbSet<CharacterLanguage> CharacterLanguages { get; set; }
        public DbSet<CharacterSkill> CharacterSkills { get; set; }
        public DbSet<CharacterTag> CharacterTags { get; set; }
        public DbSet<RaceAbility> RaceAbilities { get; set; }
        public DbSet<RaceFeature> RaceFeatures { get; set; }
        public DbSet<PresetAbility> PresetAbilities { get; set; }
        public DbSet<PresetFeature> PresetFeatures { get; set; }
        public DbSet<PresetLanguage> PresetLanguages { get; set; }
        public DbSet<PresetSkill> PresetSkills { get; set; }
        public DbSet<NonPlayerBuild> NonPlayerBuilds { get; set; }
        #endregion
    }
}
