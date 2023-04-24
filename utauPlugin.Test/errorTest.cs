using System.Text;

namespace utauPlugin.Test
{
    public class ErrorTest
    {
        UtauPlugin utauPlugin;
        [SetUp]
        public void Setup()
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            utauPlugin = new UtauPlugin();
        }

        [Test]
        public void testMode2AddPitch()
        {
            utauPlugin.FilePath = "inputData\\test119.tmp";
            utauPlugin.Input();
            Note note = utauPlugin.note[2];
            List<float> pbw = note.GetPbw();
            List<float> pby = note.GetPby();
            List<string> pbm = note.GetPbm();
            Assert.AreEqual(4, pbw.Count);

            float ave = pbw[0] / 2;
            float nextY = pby[0];
            pbw.Insert(0, ave);
            pby.Insert(0, note.GetPbsHeight());
            pbm.Insert(0, "");
            pbw.Insert(1, 0);
            pby.Insert(1, nextY);
            pbm.Insert(1, "");
            pbw[2] = ave;
            note.SetPbw(pbw);
            note.SetPby(pby);
            note.SetPbm(pbm);
            //Assert.IsTrue(pby[0] == -20f);
            //Assert.IsTrue(pby[1] == 0f);
            //Assert.IsTrue(pby[2] == -10.7f);
            //Assert.IsTrue(pby[3] == 0f);
            //Assert.IsTrue(4 == pby.Count);
            Assert.AreEqual(6, pbw.Count);
            utauPlugin.FilePath = "outputData\\Mode2AddPitch.tmp";
            Directory.CreateDirectory("outputData");
            utauPlugin.Output();
        }
    }
}