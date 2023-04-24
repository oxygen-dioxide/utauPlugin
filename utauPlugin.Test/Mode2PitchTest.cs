namespace utauPlugin.Test
{
    public class Mode2PitchTest
    {
        [SetUp]
        public void SetUp()
        {

        }

        [Test]
        public void SetMode2PitchPbsSemiColon()
        {
            Note.Mode2Pitch mode2Pitch = new Note.Mode2Pitch();
            mode2Pitch.SetPbs("50;30");
            Assert.AreEqual(50.0f, mode2Pitch.GetPbsTime());
            Assert.AreEqual(30.0f, mode2Pitch.GetPbsHeight());
            Assert.AreEqual("50;30", mode2Pitch.GetPbs());
        }
        [Test]
        public void SetMode2PitchPbsComma()
        {
            Note.Mode2Pitch mode2Pitch = new Note.Mode2Pitch();
            mode2Pitch.SetPbs("50,30");
            Assert.AreEqual(50.0f, mode2Pitch.GetPbsTime());
            Assert.AreEqual(30.0f, mode2Pitch.GetPbsHeight());
            Assert.AreEqual("50;30", mode2Pitch.GetPbs());
        }
        [Test]
        public void SetMode2PitchPbs()
        {
            Note.Mode2Pitch mode2Pitch = new Note.Mode2Pitch();
            mode2Pitch.SetPbs("50");
            Assert.AreEqual(50.0f, mode2Pitch.GetPbsTime());
            Assert.AreEqual(0.0f, mode2Pitch.GetPbsHeight());
            Assert.AreEqual("50", mode2Pitch.GetPbs());
        }
        [Test]
        public void SetMode2PitchPbw()
        {
            Note.Mode2Pitch mode2Pitch = new Note.Mode2Pitch();
            mode2Pitch.SetPbw("50");
            Assert.AreEqual(50f, mode2Pitch.GetPbw()[0]);
        }
        [Test]
        public void SetMode2PitchPbwStr()
        {
            Note.Mode2Pitch mode2Pitch = new Note.Mode2Pitch();
            mode2Pitch.SetPbw("50,30,20");
            Assert.AreEqual(50f, mode2Pitch.GetPbw()[0]);
            Assert.AreEqual(30f, mode2Pitch.GetPbw()[1]);
            Assert.AreEqual(20f, mode2Pitch.GetPbw()[2]);
            Assert.AreEqual(3, mode2Pitch.GetPbw().Count);
        }
        [Test]
        public void ChangeMode2PitchPbwStr()
        {
            Note.Mode2Pitch mode2Pitch = new Note.Mode2Pitch();
            mode2Pitch.SetPbw("50,30,20");
            mode2Pitch.SetPbw("40", 1);
            Assert.AreEqual(50f, mode2Pitch.GetPbw()[0]);
            Assert.AreEqual(40f, mode2Pitch.GetPbw()[1]);
            Assert.AreEqual(20f, mode2Pitch.GetPbw()[2]);
            Assert.AreEqual(3, mode2Pitch.GetPbw().Count);
        }
        [Test]
        public void ChangeMode2PitchPbwInt()
        {
            Note.Mode2Pitch mode2Pitch = new Note.Mode2Pitch();
            mode2Pitch.SetPbw("50,30,20");
            mode2Pitch.SetPbw(40, 1);
            Assert.AreEqual(50f, mode2Pitch.GetPbw()[0]);
            Assert.AreEqual(40f, mode2Pitch.GetPbw()[1]);
            Assert.AreEqual(20f, mode2Pitch.GetPbw()[2]);
            Assert.AreEqual(3, mode2Pitch.GetPbw().Count);
        }
        [Test]
        public void ChangeMode2PitchPbwList()
        {
            Note.Mode2Pitch mode2Pitch = new Note.Mode2Pitch();
            mode2Pitch.SetPbw("50,30,20");
            mode2Pitch.SetPbw(new List<float> { 15f, 25f });
            Assert.AreEqual(15f, mode2Pitch.GetPbw()[0]);
            Assert.AreEqual(25f, mode2Pitch.GetPbw()[1]);
            Assert.AreEqual(2, mode2Pitch.GetPbw().Count);
        }
        [Test]
        public void SetMode2PitchPby()
        {
            Note.Mode2Pitch mode2Pitch = new Note.Mode2Pitch();
            mode2Pitch.SetPby("50");
            Assert.AreEqual(50f, mode2Pitch.GetPby()[0]);
        }
        [Test]
        public void SetMode2PitchPbyStr()
        {
            Note.Mode2Pitch mode2Pitch = new Note.Mode2Pitch();
            mode2Pitch.SetPby("50,30,20");
            Assert.AreEqual(50f, mode2Pitch.GetPby()[0]);
            Assert.AreEqual(30f, mode2Pitch.GetPby()[1]);
            Assert.AreEqual(20f, mode2Pitch.GetPby()[2]);
            Assert.AreEqual(3, mode2Pitch.GetPby().Count);
        }
        [Test]
        public void ChangeMode2PitchPbyStr()
        {
            Note.Mode2Pitch mode2Pitch = new Note.Mode2Pitch();
            mode2Pitch.SetPby("50,30,20");
            mode2Pitch.SetPby("40", 1);
            Assert.AreEqual(50f, mode2Pitch.GetPby()[0]);
            Assert.AreEqual(40f, mode2Pitch.GetPby()[1]);
            Assert.AreEqual(20f, mode2Pitch.GetPby()[2]);
            Assert.AreEqual(3, mode2Pitch.GetPby().Count);
        }
        [Test]
        public void ChangeMode2PitchPbyInt()
        {
            Note.Mode2Pitch mode2Pitch = new Note.Mode2Pitch();
            mode2Pitch.SetPby("50,30,20");
            mode2Pitch.SetPby(40, 1);
            Assert.AreEqual(50f, mode2Pitch.GetPby()[0]);
            Assert.AreEqual(40f, mode2Pitch.GetPby()[1]);
            Assert.AreEqual(20f, mode2Pitch.GetPby()[2]);
            Assert.AreEqual(3, mode2Pitch.GetPby().Count);
        }
        [Test]
        public void ChangeMode2PitchPbyList()
        {
            Note.Mode2Pitch mode2Pitch = new Note.Mode2Pitch();
            mode2Pitch.SetPby("50,30,20");
            mode2Pitch.SetPby(new List<float> { 15, 25, 40, 50 });
            Assert.AreEqual(15f, mode2Pitch.GetPby()[0]);
            Assert.AreEqual(25f, mode2Pitch.GetPby()[1]);
            Assert.AreEqual(4, mode2Pitch.GetPby().Count);
        }
        [Test]
        public void ChangeMode2PitchPbyList2()
        {
            Note.Mode2Pitch mode2Pitch = new Note.Mode2Pitch();
            mode2Pitch.SetPby("50,30,20");
            List<float> pby = new List<float> { 15, 25, -40, 50 };
            mode2Pitch.SetPby(pby);
            Assert.AreEqual(4, pby.Count);
            Assert.AreEqual(15f, mode2Pitch.GetPby()[0]);
            Assert.AreEqual(25f, mode2Pitch.GetPby()[1]);
            Assert.AreEqual(4, mode2Pitch.GetPby().Count);
        }
        [Test]
        public void ChangeMode2PitchPbyList3()
        {
            Note.Mode2Pitch mode2Pitch = new Note.Mode2Pitch();
            mode2Pitch.SetPby("50,30,20");
            List<float> pby = mode2Pitch.GetPby();
            mode2Pitch.SetPby(pby);
            Assert.AreEqual(3, pby.Count);
            Assert.AreEqual(50f, mode2Pitch.GetPby()[0]);
            Assert.AreEqual(30f, mode2Pitch.GetPby()[1]);
            Assert.AreEqual(3, mode2Pitch.GetPby().Count);
        }
        [Test]
        public void SetMode2PitchPbm()
        {
            Note.Mode2Pitch mode2Pitch = new Note.Mode2Pitch();
            mode2Pitch.SetPbm("r");
            Assert.AreEqual("r", mode2Pitch.GetPbm()[0]);
        }
        [Test]
        public void SetMode2PitchPbmStr()
        {
            Note.Mode2Pitch mode2Pitch = new Note.Mode2Pitch();
            mode2Pitch.SetPbm("r,,s");
            Assert.AreEqual("r", mode2Pitch.GetPbm()[0]);
            Assert.AreEqual("", mode2Pitch.GetPbm()[1]);
            Assert.AreEqual("s", mode2Pitch.GetPbm()[2]);
            Assert.AreEqual(3, mode2Pitch.GetPbm().Count);
        }
        [Test]
        public void SetMode2PitchPbmList()
        {
            Note.Mode2Pitch mode2Pitch = new Note.Mode2Pitch();
            mode2Pitch.SetPbm("r,,s");
            mode2Pitch.SetPbm(new List<string> { "", "j" });
            Assert.AreEqual("", mode2Pitch.GetPbm()[0]);
            Assert.AreEqual("j", mode2Pitch.GetPbm()[1]);
            Assert.AreEqual(2, mode2Pitch.GetPbm().Count);
        }
    }
}
