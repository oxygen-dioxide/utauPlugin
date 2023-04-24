namespace utauPlugin.Test
{
    public class NoteNumTest
    {
        [SetUp]
        public void SetUp()
        {

        }
        [Test]
        public void SetNoteNumInit()
        {
            Note.NoteNum noteNum = new Note.NoteNum();
            Assert.AreEqual(60, noteNum.Get());
            Assert.AreEqual("C4", noteNum.GetName());
            Assert.AreEqual("C", noteNum.GetKey());
        }
        [Test]
        public void SetNoteNumInitStr()
        {
            Note.NoteNum noteNum = new Note.NoteNum("59");
            Assert.AreEqual(59, noteNum.Get());
            Assert.AreEqual("B3", noteNum.GetName());
            Assert.AreEqual("B", noteNum.GetKey());
        }
        [Test]
        public void SetNoteNumInitInt()
        {
            Note.NoteNum noteNum = new Note.NoteNum("71");
            Assert.AreEqual(71, noteNum.Get());
            Assert.AreEqual("B4", noteNum.GetName());
            Assert.AreEqual("B", noteNum.GetKey());
        }
        [Test]
        public void SetNoteNumStr()
        {
            Note.NoteNum noteNum = new Note.NoteNum();
            noteNum.Set("72");
            Assert.AreEqual(72, noteNum.Get());
            Assert.AreEqual("C5", noteNum.GetName());
            Assert.AreEqual("C", noteNum.GetKey());
        }
        [Test]
        public void SetNoteNumInt()
        {
            Note.NoteNum noteNum = new Note.NoteNum();
            noteNum.Set(61);
            Assert.AreEqual(61, noteNum.Get());
            Assert.AreEqual("C#4", noteNum.GetName());
            Assert.AreEqual("C#", noteNum.GetKey());
        }
    }
}
