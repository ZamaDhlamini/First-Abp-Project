using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace NewAbpProject.Localization
{
    public static class NewAbpProjectLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(NewAbpProjectConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(NewAbpProjectLocalizationConfigurer).GetAssembly(),
                        "NewAbpProject.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
