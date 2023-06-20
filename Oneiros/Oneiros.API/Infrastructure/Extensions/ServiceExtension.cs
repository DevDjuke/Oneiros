
using Oneiros.API.Infrastructure.Services;
using Oneiros.API.Infrastructure.Services.Base;

namespace Oneiros.API.Infrastructure.Extensions
{
    public static class ServiceExtension
    {
        public static void ConfigureServices(this IServiceCollection services)
        {
           services.AddTransient<ICampaignService, CampaignService>();
            services.AddTransient<ICharacterService, CharacterService>();
            services.AddTransient<IItemService, ItemService>();
            services.AddTransient<INonPlayerService, NonPlayerService>();
            services.AddTransient<IPlayerService, PlayerService>();
            services.AddTransient<IAbilityService, AbilityService>();
            services.AddTransient<IBackGroundService, BackGroundService>();
            services.AddTransient<IFeatureService, FeatureService>();
            services.AddTransient<ILanguageService, LanguageService>();
            services.AddTransient<IRaceService, RaceService>();
            services.AddTransient<ISkillService, SkillService>();
            services.AddTransient<IBuildService, BuildService>();
            services.AddTransient<IPresetService, PresetService>();
            services.AddTransient<IClasseService, ClasseService>();
            services.AddTransient<ITagService, TagService>();
            services.AddTransient<ICampaignCharacterService, CampaignCharacterService>();
            services.AddTransient<ICharacterAbilityService, CharacterAbilityService>();
            services.AddTransient<ICharacterFeatureService, CharacterFeatureService>();
            services.AddTransient<ICharacterLanguageService, CharacterLanguageService>();
            services.AddTransient<ICharacterSkillService, CharacterSkillService>();
            services.AddTransient<ICharacterTagService, CharacterTagService>();
            services.AddTransient<INonPlayerBuildService, NonPlayerBuildService>();
            services.AddTransient<IPresetAbilityService, PresetAbilityService>();
            services.AddTransient<IPresetFeatureService, PresetFeatureService>();
            services.AddTransient<IPresetLanguageService, PresetLanguageService>();
            services.AddTransient<IPresetSkillService, PresetSkillService>();
            services.AddTransient<IRaceAbilityService, RaceAbilityService>();
            services.AddTransient<IRaceFeatureService, RaceFeatureService>();
        }
    }
}