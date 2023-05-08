using System.Text;

namespace utauPlugin.Test
{
    public class OutputUstTest
    {
        UtauPlugin utauPlugin;
        
        [SetUp]
        public void Setup()
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            utauPlugin = new UtauPlugin();
        }

        [Test]
        public void testv119()
        {
            utauPlugin.FilePath = "inputData/test119.tmp";
            utauPlugin.Input();
            utauPlugin.FilePath = "outputData/out119.tmp";
            utauPlugin.Output();
        }

        [Test]
        public void testv119Insert()
        {
            utauPlugin.FilePath = "inputData/test119.tmp";
            utauPlugin.Input();
            for (int i = 0; i < utauPlugin.note.Count; i++)
            {
                utauPlugin.note[i].SetNum("INSERT");
            }
            utauPlugin.FilePath = "outputData/out119Insert.tmp";
            utauPlugin.Output();
        }

        [Test]
        public void testv119_SetLength()
        {
            utauPlugin.FilePath = "inputData/test119.tmp";
            utauPlugin.Input();
            utauPlugin.note[2].SetLength(120);
            utauPlugin.FilePath = "outputData/out119_Length.tmp";
            utauPlugin.Output();
        }

        [Test]
        public void testv119_SetDirect()
        {
            utauPlugin.FilePath = "inputData/test119.tmp";
            utauPlugin.Input();
            utauPlugin.note[2].SetDirect(false);
            utauPlugin.FilePath = "outputData/out119_Direct.tmp";
            utauPlugin.Output();
        }
        /*
        [Test]
        public void InitOriginalEntryOutputTest()
        {
            utauPlugin = new UtauPlugin();
            utauPlugin.FilePath = "inputData\\originalEntry.tmp";
            utauPlugin.InitOriginalEntry("myEntry", "ccc");
            utauPlugin.InitOriginalEntry("myEntry2", "");
            utauPlugin.Input();
            utauPlugin.FilePath = "outputData\\original.tmp";
            utauPlugin.note[1].SetOriginalEntry("myEntry", "ddd");
            utauPlugin.Output();
        }*/
        /*
        [Test]
        public void InitOriginalEntryInsertTest()
        {
            utauPlugin = new UtauPlugin();
            utauPlugin.FilePath = "inputData\\originalEntry.tmp";
            utauPlugin.InitOriginalEntry("myEntry", "ccc");
            utauPlugin.InitOriginalEntry("myEntry2", "");
            utauPlugin.Input();
            utauPlugin.FilePath = "outputData\\originalInsert.tmp";
            for (int i = 0; i < utauPlugin.note.Count; i++)
            {
                utauPlugin.note[i].SetNum("INSERT");
            }
            utauPlugin.Output();
        }*/
        /*
        [Test]
        public void testNoBody()
        {
            utauPlugin.FilePath = "inputData\\nobody.tmp";
            utauPlugin.Input();
            utauPlugin.FilePath = "outputData\\nobody.tmp";
            utauPlugin.Output();
        }*/
    }
}
