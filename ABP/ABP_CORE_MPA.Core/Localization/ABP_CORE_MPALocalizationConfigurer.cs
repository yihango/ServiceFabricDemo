using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace ABP_CORE_MPA.Localization
{
    public static class ABP_CORE_MPALocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(ABP_CORE_MPAConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(ABP_CORE_MPALocalizationConfigurer).GetAssembly(),
                        "ABP_CORE_MPA.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
