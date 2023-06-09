using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace utauPlugin.Runtime
{
    public interface IPathManager
    {
        
        //Get the default path to install singers
        string SingersPath();
        //Get all paths to find singers
        string[] SingersPaths();
        string ResamplersPath();
        string WavtoolsPath();
        string PluginsPath();
    }
}