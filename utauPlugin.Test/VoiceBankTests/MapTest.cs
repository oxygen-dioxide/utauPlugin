using System.Text;
using utauPlugin.UtauVoiceBank;

namespace utauPlugin.Test.VoiceBankTests
{
    public class MapTest
    {
        [SetUp]
        public void SetUp()
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
        }

        [Test]
        public void InputPrefixMapTest()
        {
            VoiceBank vb = new VoiceBank("VoiceBankData/testDir");
            vb.InputPrefixMap();
            Assert.IsTrue(vb.prefixMap["B3"].Su == "B3");
            Assert.IsTrue(vb.prefixMap["A#3"].Su == "");
        }

        [Test]
        public void InputPrefixMapsAllTest()
        {
            VoiceBank vb = new VoiceBank("VoiceBankData/testDir");
            vb.InputPrefixMapsAll();
            Assert.IsTrue(vb.prefixMaps[""]["B3"].Su == "B3");
            Assert.IsTrue(vb.prefixMaps[""]["A#3"].Su == "");
            Assert.IsTrue(vb.prefixMaps["あ"]["A#3"].Su == "G#3");

        }
    }
}