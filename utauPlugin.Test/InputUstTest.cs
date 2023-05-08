using System.Text;

namespace utauPlugin.Test
{
    public class InputUstTest
    {
        UtauPlugin utauPlugin;

        [SetUp]
        public void SetUp()
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            utauPlugin = new UtauPlugin();
            utauPlugin.FilePath = "inputData/test119.tmp";
            utauPlugin.Input();
        }

        [Test]
        public void SetUstVersion()
        {
            utauPlugin.Version = "3.0";
            Assert.AreEqual("3.0", utauPlugin.Version);
        }

        [Test]
        public void SetUstVoiceDir()
        {
            utauPlugin.VoiceDir = "C:\\Program Files (x86)\\UTAU\\voice\\utau";
            Assert.AreEqual("C:\\Program Files (x86)\\UTAU\\voice\\utau", utauPlugin.VoiceDir);
        }

        [Test]
        public void TestUstVersion()
        {
            Assert.AreEqual("1.19", utauPlugin.Version);
        }
        
        [Test]
        public void TestUstVersionV120()
        {
            utauPlugin = new UtauPlugin();
            utauPlugin.FilePath = "inputData/test120.tmp";
            utauPlugin.Input();
            Assert.AreEqual("1.20", utauPlugin.Version);
        }

        [Test]
        public void TestTempo()
        {
            Assert.AreEqual(150.0f, utauPlugin.Tempo);
        }

        [Test]
        public void TestNotePrev()
        {
            Assert.AreEqual("PREV", utauPlugin.note[0].GetNum());
            Assert.AreEqual(480, utauPlugin.note[0].GetLength());
            Assert.AreEqual("あ", utauPlugin.note[0].GetLyric());
            Assert.AreEqual(60, utauPlugin.note[0].GetNoteNum());
            Assert.AreEqual(100, utauPlugin.note[0].GetIntensity());
            Assert.AreEqual(0, utauPlugin.note[0].GetMod());
            Assert.AreEqual(0.0f, utauPlugin.note[0].GetPbStart());
            Assert.AreEqual(97, utauPlugin.note[0].GetPitches().Count);
            Assert.AreEqual(0, utauPlugin.note[0].GetPitches()[utauPlugin.note[0].GetPitches().Count - 1]);
            Assert.AreEqual(0.0f, utauPlugin.note[0].GetAtPre());
            Assert.AreEqual(0.0f, utauPlugin.note[0].GetAtOve());
            Assert.AreEqual(0.0f, utauPlugin.note[0].GetAtStp());
            Assert.AreEqual("あ.wav", utauPlugin.note[0].GetAtFileName());
            Assert.AreEqual("あ", utauPlugin.note[0].GetAtAlias());
        }
    }
}
