using YamlDotNet.Core;
using YamlDotNet.Core.Events;
using YamlDotNet.Serialization;
using YamlDotNet.Serialization.EventEmitters;
using YamlDotNet.Serialization.NamingConventions;

//reference: https://github.com/stakira/OpenUtau/blob/master/OpenUtau.Core/Util/Yaml.cs

namespace utauPlugin {
    public static class Yaml {
        public static ISerializer DefaultSerializer = new SerializerBuilder()
            .WithNamingConvention(UnderscoredNamingConvention.Instance)
            .ConfigureDefaultValuesHandling(DefaultValuesHandling.OmitNull)
            .DisableAliases()
            .WithQuotingNecessaryStrings()
            .Build();

        public static IDeserializer DefaultDeserializer = new DeserializerBuilder()
            .WithNamingConvention(UnderscoredNamingConvention.Instance)
            .IgnoreUnmatchedProperties()
            .Build();
    }
}