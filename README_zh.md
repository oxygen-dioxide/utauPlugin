# utauPlugin
用于开发UTAU插件的 C# .net 类库

本仓库将delta-kimigatame开发的[utauPlugin](https://github.com/delta-kimigatame/utauPlugin)迁移到.net Core，并进行现代化改造。

## 下载与安装
本仓库目前处于测试阶段，可能存在较多的bug。可通过nuget安装utauPlugin库：[Nuget Gallery](https://www.nuget.org/packages/utauPlugin)

## 使用方法
示例：将所有音符升高一个半音
```
using utauPlugin;

namespace sample1
{
    class Program
    {
        static void Main(string[] args)
        {
            UtauPlugin utauPlugin = new UtauPlugin(args[0]);
            utauPlugin.Input();
            foreach(Note note in utauPlugin.note)
            {
                note.SetNoteNum(note.GetNoteNum() + 1);
            }
            utauPlugin.Output();
        }
    }
}
```

## 相关链接
[UTAU官网](http://utau2008.web.fc2.com/)
[UTAU插件协议](https://www20.atwiki.jp/utaou/pages/64.html)
