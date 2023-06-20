using Microsoft.Extensions.DependencyInjection;
using Oneiros.API.Repositories;
using Oneiros.API.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oneiros.API.Infrastructure.Extensions
{
    public static class RepositoryExtension
    {
        public static void ConfigureRepositories(this IServiceCollection services)
        {
            services.AddTransient<ICampaignRepository, CampaignRepository>();
            services.AddTransient<ICharacterRepository, CharacterRepository>();
            services.AddTransient<IItemRepository, ItemRepository>();
            services.AddTransient<INonPlayerRepository, NonPlayerRepository>();
            services.AddTransient<IPlayerRepository, PlayerRepository>();
            services.AddTransient<IAbilityRepository, AbilityRepository>();
            services.AddTransient<IBackGroundRepository, BackGroundRepository>();
            services.AddTransient<IFeatureRepository, FeatureRepository>();
            services.AddTransient<ILanguageRepository, LanguageRepository>();
            services.AddTransient<IRaceRepository, RaceRepository>();
            services.AddTransient<ISkillRepository, SkillRepository>();
            services.AddTransient<IBuildRepository, BuildRepository>();
            services.AddTransient<IPresetRepository, PresetRepository>();
            services.AddTransient<IClasseRepository, ClasseRepository>();
            services.AddTransient<ITagRepository, TagRepository>();
            services.AddTransient<ICampaignCharacterRepository, CampaignCharacterRepository>();
            services.AddTransient<ICharacterAbilityRepository, CharacterAbilityRepository>();
            services.AddTransient<ICharacterFeatureRepository, CharacterFeatureRepository>();
            services.AddTransient<ICharacterLanguageRepository, CharacterLanguageRepository>();
            services.AddTransient<ICharacterSkillRepository, CharacterSkillRepository>();
            services.AddTransient<ICharacterTagRepository, CharacterTagRepository>();
            services.AddTransient<INonPlayerBuildRepository, NonPlayerBuildRepository>();
            services.AddTransient<IPresetAbilityRepository, PresetAbilityRepository>();
            services.AddTransient<IPresetFeatureRepository, PresetFeatureRepository>();
            services.AddTransient<IPresetLanguageRepository, PresetLanguageRepository>();
            services.AddTransient<IPresetSkillRepository, PresetSkillRepository>();
            services.AddTransient<IRaceAbilityRepository, RaceAbilityRepository>();
            services.AddTransient<IRaceFeatureRepository, RaceFeatureRepository>();
        }
    }
}