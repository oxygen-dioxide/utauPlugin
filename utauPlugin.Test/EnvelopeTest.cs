namespace utauPlugin.Test
{
    public class EnvelopeTest
    {
        [SetUp]
        public void Setup()
        {
            
        }

        [Test]
        public void SetEnvInit()
        {
            Note.Envelope env = new Note.Envelope("0,5,30,1,2,3,4");
            Assert.AreEqual(0.0f, env.GetP()[0]);
            Assert.AreEqual(5.0f, env.GetP()[1]);
            Assert.AreEqual(30.0f, env.GetP()[2]);
            Assert.AreEqual(1, env.GetV()[0]);
            Assert.AreEqual(2, env.GetV()[1]);
            Assert.AreEqual(3, env.GetV()[2]);
            Assert.AreEqual(4, env.GetV()[3]);
            Assert.AreEqual("0,5,30,1,2,3,4", env.Get());
        }
        [Test]
        public void SetEnv()
        {
            Note.Envelope env = new Note.Envelope();
            env.Set("0,5,30,1,2,3,4");
            Assert.AreEqual(0.0f, env.GetP()[0]);
            Assert.AreEqual(5.0f, env.GetP()[1]);
            Assert.AreEqual(30.0f, env.GetP()[2]);
            Assert.AreEqual(1, env.GetV()[0]);
            Assert.AreEqual(2, env.GetV()[1]);
            Assert.AreEqual(3, env.GetV()[2]);
            Assert.AreEqual(4, env.GetV()[3]);
        }
        [Test]
        public void SetEnv2()
        {
            Note.Envelope env = new Note.Envelope();
            env.Set("0,0");
            Assert.AreEqual(0.0f, env.GetP()[0]);
            Assert.AreEqual(0.0f, env.GetP()[1]);
            Assert.AreEqual(0.0f, env.GetP()[2]);
            Assert.AreEqual(100, env.GetV()[0]);
            Assert.AreEqual(100, env.GetV()[1]);
            Assert.AreEqual(100, env.GetV()[2]);
            Assert.AreEqual(100, env.GetV()[3]);
        }
        [Test]
        public void SetEnv8()
        {
            Note.Envelope env = new Note.Envelope();
            env.Set("0,5,30,1,2,3,4,%,15");
            Assert.AreEqual(0.0f, env.GetP()[0]);
            Assert.AreEqual(5.0f, env.GetP()[1]);
            Assert.AreEqual(30.0f, env.GetP()[2]);
            Assert.AreEqual(15.0f, env.GetP()[3]);
            Assert.AreEqual(1, env.GetV()[0]);
            Assert.AreEqual(2, env.GetV()[1]);
            Assert.AreEqual(3, env.GetV()[2]);
            Assert.AreEqual(4, env.GetV()[3]);
            Assert.AreEqual("0,5,30,1,2,3,4,%,15", env.Get());
        }
        [Test]
        public void SetEnv10()
        {
            Note.Envelope env = new Note.Envelope();
            env.Set("0,5,30,1,2,3,4,%,15,7.1,5");
            Assert.AreEqual(0.0f, env.GetP()[0]);
            Assert.AreEqual(5.0f, env.GetP()[1]);
            Assert.AreEqual(30.0f, env.GetP()[2]);
            Assert.AreEqual(15.0f, env.GetP()[3]);
            Assert.AreEqual(7.1f, env.GetP()[4]);
            Assert.AreEqual(1, env.GetV()[0]);
            Assert.AreEqual(2, env.GetV()[1]);
            Assert.AreEqual(3, env.GetV()[2]);
            Assert.AreEqual(4, env.GetV()[3]);
            Assert.AreEqual(5, env.GetV()[4]);
            Assert.AreEqual("0,5,30,1,2,3,4,%,15,7.1,5", env.Get());
        }
        [Test]
        public void SetEnvPInt()
        {
            Note.Envelope env = new Note.Envelope();
            env.Set("0,0");
            env.SetP(5, 1);
            Assert.AreEqual(5.0f, env.GetP()[1]);
        }
        [Test]
        public void SetEnvPFloat()
        {
            Note.Envelope env = new Note.Envelope();
            env.Set("0,0");
            env.SetP(5.0f, 1);
            Assert.AreEqual(5.0f, env.GetP()[1]);
        }
        [Test]
        public void SetEnvPStr()
        {
            Note.Envelope env = new Note.Envelope();
            env.Set("0,0");
            env.SetP("5", 1);
            Assert.AreEqual(5.0f, env.GetP()[1]);
        }
        [Test]
        public void SetEnvVInt()
        {
            Note.Envelope env = new Note.Envelope();
            env.Set("0,0");
            env.SetV(5, 1);
            Assert.AreEqual(5.0f, env.GetV()[1]);
        }
        [Test]
        public void SetEnvVStr()
        {
            Note.Envelope env = new Note.Envelope();
            env.Set("0,0");
            env.SetV("5", 1);
            Assert.AreEqual(5.0f, env.GetV()[1]);
        }
        [Test]
        public void SetEnvRe8()
        {
            Note.Envelope env = new Note.Envelope();
            env.Set("0,0");
            env.Set("0,5,30,1,2,3,4,%,15");
            Assert.AreEqual(0.0f, env.GetP()[0]);
            Assert.AreEqual(5.0f, env.GetP()[1]);
            Assert.AreEqual(30.0f, env.GetP()[2]);
            Assert.AreEqual(15.0f, env.GetP()[3]);
            Assert.AreEqual(1, env.GetV()[0]);
            Assert.AreEqual(2, env.GetV()[1]);
            Assert.AreEqual(3, env.GetV()[2]);
            Assert.AreEqual(4, env.GetV()[3]);
            Assert.AreEqual("0,5,30,1,2,3,4,%,15", env.Get());
        }
    }
}
