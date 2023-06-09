using System.IO;

using utauPlugin.Util;

namespace utauPlugin.Runtime.Utau
{
    public class UtauPathManager : SingletonBase<UtauPathManager>, IPathManager{
        public string SingersPath() {
            //TODO: additionalSingerPath
            return Path.GetDirectoryName("../../voice");
        }

        public string[] SingersPaths() {
            return new string[] {SingersPath()};
        }

        public string ResamplersPath() {
            return Path.GetDirectoryName("../..");
        }

        public string WavtoolsPath() {
            return Path.GetDirectoryName("../..");
        }

        public string PluginsPath() {
            return Path.GetDirectoryName("..");
        }
    }
}