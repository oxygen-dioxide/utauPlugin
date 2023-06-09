using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Newtonsoft.Json;

using utauPlugin.Util;

namespace utauPlugin.Runtime.OpenUtau
{
    public static class Preferences {
        public static SerializablePreferences Default;
        public const string PrefsFilePath = "../../prefs.json";

        static Preferences() {
            Load();
        }

        public static void Load() {
            try {
                if (File.Exists(PrefsFilePath)) {
                    Default = JsonConvert.DeserializeObject<SerializablePreferences>(
                        File.ReadAllText(PrefsFilePath, Encoding.UTF8));
                } else {
                    Default = new SerializablePreferences();
                }
            } catch (Exception e) {
                //Log.Error(e, "Failed to load prefs.");
                Default = new SerializablePreferences();
            }
        }
    }

    [Serializable]
    public class SerializablePreferences {
        public const int MidiWidth = 1024;
        public const int MidiHeight = 768;
        public int MainWidth = 1024;
        public int MainHeight = 768;
        public bool MainMaximized;
        public bool MidiMaximized;
        public int UndoLimit = 100;
        public List<string> SingerSearchPaths = new List<string>();
        public string PlaybackDevice = string.Empty;
        public int PlaybackDeviceNumber;
        public int? PlaybackDeviceIndex;
        public bool ShowPrefs = true;
        public bool ShowTips = true;
        public int Theme;
        public bool PreRender = true;
        public int NumRenderThreads = 2;
        public string OnnxRunner = string.Empty;
        public int OnnxGpu = 0;
        public string Language = string.Empty;
        public string SortingOrder = string.Empty;
        public List<string> RecentFiles = new List<string>();
        public string SkipUpdate = string.Empty;
        public string AdditionalSingerPath = string.Empty;
        public bool InstallToAdditionalSingersPath = true;
        public bool PreferCommaSeparator = false;
        public bool ResamplerLogging = false;
        public List<string> RecentSingers = new List<string>();
        public Dictionary<string, string> SingerPhonemizers = new Dictionary<string, string>();
        public List<string> RecentPhonemizers = new List<string>();
        public bool PreferPortAudio = false;
        public double PlayPosMarkerMargin = 0.9;
        public int LockStartTime = 0;
        public int PlaybackAutoScroll = 1;
        public bool ReverseLogOrder = true;
        public bool ShowPortrait = true;
        public bool ShowGhostNotes = true;
        public Dictionary<string, string> DefaultResamplers = new Dictionary<string, string>();
        public Dictionary<string, string> DefaultWavtools = new Dictionary<string, string>();
        public string LyricHelper = string.Empty;
        public bool LyricsHelperBrackets = false;
        public int OtoEditor = 0;
        public string VLabelerPath = string.Empty;
    }

    public class OpenUtauPathManager : SingletonBase<OpenUtauPathManager>, IPathManager{
        public string SingersPath() {
            if(Preferences.Default.InstallToAdditionalSingersPath 
                && !string.IsNullOrEmpty(Preferences.Default.AdditionalSingerPath))
            {
                return Preferences.Default.AdditionalSingerPath;
            }
            return Path.GetDirectoryName("../../Singers");
        }

        public string[] SingersPaths() {
            if(string.IsNullOrEmpty(Preferences.Default.AdditionalSingerPath)){
                return new string[] {Path.GetDirectoryName("../../Singers")};
            }
            if(Preferences.Default.InstallToAdditionalSingersPath){
                return new string[] {
                    Preferences.Default.AdditionalSingerPath, 
                    Path.GetDirectoryName("../../Singers")};
            }else{
                return new string[] {
                    Path.GetDirectoryName("../../Singers"),
                    Preferences.Default.AdditionalSingerPath};
            }
        }

        public string ResamplersPath() {
            return Path.GetDirectoryName("../../Resamplers");
        }

        public string WavtoolsPath() {
            return Path.GetDirectoryName("../../Wavtools");
        }

        public string PluginsPath() {
            return Path.GetDirectoryName("..");
        }
    }
}