using System.IO;
using System.Globalization;

using utauPlugin.Util;

namespace utauPlugin.Runtime
{
    public enum RuntimeType{
        OpenUtau,
        Utau
    }

    public class Runtime : SingletonBase<Runtime>
    {
        public RuntimeType runtimeType;
        public IPathManager pathManager => GetPathManager(runtimeType);

        public Runtime()
        {
            runtimeType = GetRuntimeType();
        }

        //Uses the existance of prefs.json to detect runtime type
        public static RuntimeType GetRuntimeType()
        {
            if(File.Exists("../../prefs.json")){
                return RuntimeType.OpenUtau;
            }
            return RuntimeType.Utau;
        }
        
        public static IPathManager GetPathManager(RuntimeType runtimeType)
        {
            switch (runtimeType)
            {
                case RuntimeType.OpenUtau:
                    return OpenUtau.OpenUtauPathManager.Inst;
                case RuntimeType.Utau:
                    return Utau.UtauPathManager.Inst;
                default:
                    return null;
            }
        }

        public CultureInfo GetCultureInfo()
        {
            if(runtimeType==RuntimeType.OpenUtau){
                string language = OpenUtau.Preferences.Default.Language;
                if(!string.IsNullOrEmpty(language)){
                    return new CultureInfo(language);
                }
            }
            return CultureInfo.CurrentCulture;
        }
    }
}