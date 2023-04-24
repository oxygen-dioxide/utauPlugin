namespace utauPlugin.Test
{
    public class NoteTest
    {
        Note note;

        [SetUp]
        public void SetUp()
        { 
            note = new Note(); 
        }

        [Test]
        public void NoteInit()
        {
            Assert.AreEqual(note.GetNum(), "");
            Assert.AreEqual(note.GetLength(), 480);
            Assert.AreEqual(note.GetLyric(), "");
            Assert.AreEqual(note.GetNoteNum(), 60);
        }
        [Test]
        public void SetNum()
        {
            note.SetNum("PREV");
            Assert.AreEqual(note.GetNum(), "PREV");
            note.SetNum("NEXT");
            Assert.AreEqual(note.GetNum(), "NEXT");
            note.SetNum("INSERT");
            Assert.AreEqual(note.GetNum(), "INSERT");
            note.SetNum("DELETE");
            Assert.AreEqual(note.GetNum(), "DELETE");
            note.SetNum("0000");
            Assert.AreEqual(note.GetNum(), "0000");
        }
        [Test]
        public void SetLengthStr()
        {
            note.InitLength("480");
            Assert.AreEqual(note.GetLength(), 480);
            Assert.IsFalse(note.LengthIsChanged());
            note.SetLength("240");
            Assert.AreEqual(note.GetLength(), 240);
            Assert.IsTrue(note.LengthIsChanged());
        }
        [Test]
        public void SetLengthInt()
        {
            note.InitLength(480);
            Assert.AreEqual(note.GetLength(), 480);
            Assert.IsFalse(note.LengthIsChanged());
            note.SetLength(240);
            Assert.AreEqual(note.GetLength(), 240);
            Assert.IsTrue(note.LengthIsChanged());
        }
        [Test]
        public void SetLyric()
        {
            note.InitLyric("い");
            Assert.AreEqual(note.GetLyric(), "い");
            Assert.IsFalse(note.LyricIsChanged());
            note.SetLyric("あ");
            Assert.AreEqual(note.GetLyric(), "あ");
            Assert.IsTrue(note.LyricIsChanged());
        }
        [Test]
        public void SetNoteNumStr()
        {
            note.InitNoteNum("61");
            Assert.AreEqual(note.GetNoteNum(), 61);
            Assert.AreEqual(note.GetNoteNumName(), "C#4");
            Assert.AreEqual(note.GetKey(), "C#");
            Assert.IsFalse(note.NoteNumIsChanged());
            note.SetNoteNum("62");
            Assert.AreEqual(note.GetNoteNum(), 62);
            Assert.AreEqual(note.GetNoteNumName(), "D4");
            Assert.AreEqual(note.GetKey(), "D");
            Assert.IsTrue(note.NoteNumIsChanged());
        }
        [Test]
        public void SetNoteNumInt()
        {
            note.InitNoteNum(61);
            Assert.AreEqual(note.GetNoteNum(), 61);
            Assert.AreEqual(note.GetNoteNumName(), "C#4");
            Assert.AreEqual(note.GetKey(), "C#");
            Assert.IsFalse(note.NoteNumIsChanged());
            note.SetNoteNum(62);
            Assert.AreEqual(note.GetNoteNum(), 62);
            Assert.AreEqual(note.GetNoteNumName(), "D4");
            Assert.AreEqual(note.GetKey(), "D");
            Assert.IsTrue(note.NoteNumIsChanged());
        }
        [Test]
        public void SetTempoStr()
        {
            note.InitTempo("120.0");
            Assert.AreEqual(note.GetTempo(), 120.0f);
            Assert.IsFalse(note.TempoIsChanged());
            note.SetTempo("121");
            Assert.AreEqual(note.GetTempo(), 121.0f);
            Assert.IsTrue(note.TempoIsChanged());
        }
        [Test]
        public void SetTempoInt()
        {
            note.InitTempo(120);
            Assert.AreEqual(note.GetTempo(), 120.0f);
            Assert.IsFalse(note.TempoIsChanged());
            note.SetTempo(121);
            Assert.AreEqual(note.GetTempo(), 121.0f);
            Assert.IsTrue(note.TempoIsChanged());
        }
        [Test]
        public void SetTempoFloat()
        {
            note.InitTempo(120.0f);
            Assert.AreEqual(note.GetTempo(), 120.0f);
            Assert.IsFalse(note.TempoIsChanged());
            note.SetTempo(121.0f);
            Assert.AreEqual(note.GetTempo(), 121.0f);
            Assert.IsTrue(note.TempoIsChanged());
        }
        [Test]
        public void SetPreStr()
        {
            note.InitPre("120.0");
            Assert.AreEqual(note.GetPre(), 120.0f);
            Assert.IsFalse(note.PreIsChanged());
            Assert.IsTrue(note.PreHasValue());
            note.SetPre("121");
            Assert.AreEqual(note.GetPre(), 121.0f);
            Assert.IsTrue(note.PreIsChanged());
            Assert.IsTrue(note.PreHasValue());
        }
        [Test]
        public void SetPreStrNone()
        {
            note.InitPre("");
            Assert.AreEqual(note.GetPre(), 0.0f);
            Assert.IsFalse(note.PreIsChanged());
            Assert.IsFalse(note.PreHasValue());
            note.SetPre("5");
            Assert.AreEqual(note.GetPre(), 5.0f);
            Assert.IsTrue(note.PreIsChanged());
            Assert.IsTrue(note.PreHasValue());
        }
        [Test]
        public void SetPreInt()
        {
            note.InitPre(120);
            Assert.AreEqual(note.GetPre(), 120.0f);
            Assert.IsFalse(note.PreIsChanged());
            Assert.IsTrue(note.PreHasValue());
            note.SetPre(121);
            Assert.AreEqual(note.GetPre(), 121.0f);
            Assert.IsTrue(note.PreIsChanged());
            Assert.IsTrue(note.PreHasValue());
        }
        [Test]
        public void SetPreFloat()
        {
            note.InitPre(120.0f);
            Assert.AreEqual(note.GetPre(), 120.0f);
            Assert.IsFalse(note.PreIsChanged());
            Assert.IsTrue(note.PreHasValue());
            note.SetPre(121.0f);
            Assert.AreEqual(note.GetPre(), 121.0f);
            Assert.IsTrue(note.PreIsChanged());
            Assert.IsTrue(note.PreHasValue());
        }


        [Test]
        public void SetAtPreStr()
        {
            note.InitAtPre("120.0");
            Assert.AreEqual(note.GetAtPre(), 120.0f);
            Assert.IsFalse(note.AtPreIsChanged());
            note.SetAtPre("121");
            Assert.AreEqual(note.GetAtPre(), 121.0f);
            Assert.IsTrue(note.AtPreIsChanged());
        }
        [Test]
        public void SetAtPreInt()
        {
            note.InitAtPre(120);
            Assert.AreEqual(note.GetAtPre(), 120.0f);
            Assert.IsFalse(note.AtPreIsChanged());
            note.SetAtPre(121);
            Assert.AreEqual(note.GetAtPre(), 121.0f);
            Assert.IsTrue(note.AtPreIsChanged());
        }
        [Test]
        public void SetAtPreFloat()
        {
            note.InitAtPre(120.0f);
            Assert.AreEqual(note.GetAtPre(), 120.0f);
            Assert.IsFalse(note.AtPreIsChanged());
            note.SetAtPre(121.0f);
            Assert.AreEqual(note.GetAtPre(), 121.0f);
            Assert.IsTrue(note.AtPreIsChanged());
        }


        [Test]
        public void SetAtFileName()
        {
            note.InitAtFileName("い");
            Assert.AreEqual(note.GetAtFileName(), "い");
            Assert.IsFalse(note.AtFileNameIsChanged());
            note.SetAtFileName("あ");
            Assert.AreEqual(note.GetAtFileName(), "あ");
            Assert.IsTrue(note.AtFileNameIsChanged());
        }


        [Test]
        public void SetAtAlias()
        {
            note.InitAtAlias("い");
            Assert.AreEqual(note.GetAtAlias(), "い");
            Assert.IsFalse(note.AtAliasIsChanged());
            note.SetAtAlias("あ");
            Assert.AreEqual(note.GetAtAlias(), "あ");
            Assert.IsTrue(note.AtAliasIsChanged());
        }

        [Test]
        public void SetOveStr()
        {
            note.InitOve("120.0");
            Assert.AreEqual(note.GetOve(), 120.0f);
            Assert.IsFalse(note.OveIsChanged());
            note.SetOve("121");
            Assert.AreEqual(note.GetOve(), 121.0f);
            Assert.IsTrue(note.OveIsChanged());
        }
        [Test]
        public void SetOveInt()
        {
            note.InitOve(120);
            Assert.AreEqual(note.GetOve(), 120.0f);
            Assert.IsFalse(note.OveIsChanged());
            note.SetOve(121);
            Assert.AreEqual(note.GetOve(), 121.0f);
            Assert.IsTrue(note.OveIsChanged());
        }
        [Test]
        public void SetOveFloat()
        {
            note.InitOve(120.0f);
            Assert.AreEqual(note.GetOve(), 120.0f);
            Assert.IsFalse(note.OveIsChanged());
            note.SetOve(121.0f);
            Assert.AreEqual(note.GetOve(), 121.0f);
            Assert.IsTrue(note.OveIsChanged());
        }


        [Test]
        public void SetAtOveStr()
        {
            note.InitAtOve("120.0");
            Assert.AreEqual(note.GetAtOve(), 120.0f);
            Assert.IsFalse(note.AtOveIsChanged());
            note.SetAtOve("121");
            Assert.AreEqual(note.GetAtOve(), 121.0f);
            Assert.IsTrue(note.AtOveIsChanged());
        }
        [Test]
        public void SetAtOveInt()
        {
            note.InitAtOve(120);
            Assert.AreEqual(note.GetAtOve(), 120.0f);
            Assert.IsFalse(note.AtOveIsChanged());
            note.SetAtOve(121);
            Assert.AreEqual(note.GetAtOve(), 121.0f);
            Assert.IsTrue(note.AtOveIsChanged());
        }
        [Test]
        public void SetAtOveFloat()
        {
            note.InitAtOve(120.0f);
            Assert.AreEqual(note.GetAtOve(), 120.0f);
            Assert.IsFalse(note.AtOveIsChanged());
            note.SetAtOve(121.0f);
            Assert.AreEqual(note.GetAtOve(), 121.0f);
            Assert.IsTrue(note.AtOveIsChanged());
        }


        [Test]
        public void SetStpStr()
        {
            note.InitStp("120.0");
            Assert.AreEqual(note.GetStp(), 120.0f);
            Assert.IsFalse(note.StpIsChanged());
            note.SetStp("121");
            Assert.AreEqual(note.GetStp(), 121.0f);
            Assert.IsTrue(note.StpIsChanged());
        }
        [Test]
        public void SetStpInt()
        {
            note.InitStp(120);
            Assert.AreEqual(note.GetStp(), 120.0f);
            Assert.IsFalse(note.StpIsChanged());
            note.SetStp(121);
            Assert.AreEqual(note.GetStp(), 121.0f);
            Assert.IsTrue(note.StpIsChanged());
        }
        [Test]
        public void SetStpFloat()
        {
            note.InitStp(120.0f);
            Assert.AreEqual(note.GetStp(), 120.0f);
            Assert.IsFalse(note.StpIsChanged());
            note.SetStp(121.0f);
            Assert.AreEqual(note.GetStp(), 121.0f);
            Assert.IsTrue(note.StpIsChanged());
        }


        [Test]
        public void SetAtStpStr()
        {
            note.InitAtStp("120.0");
            Assert.AreEqual(note.GetAtStp(), 120.0f);
            Assert.IsFalse(note.AtStpIsChanged());
            note.SetAtStp("121");
            Assert.AreEqual(note.GetAtStp(), 121.0f);
            Assert.IsTrue(note.AtStpIsChanged());
        }
        [Test]
        public void SetAtStpInt()
        {
            note.InitAtStp(120);
            Assert.AreEqual(note.GetAtStp(), 120.0f);
            Assert.IsFalse(note.AtStpIsChanged());
            note.SetAtStp(121);
            Assert.AreEqual(note.GetAtStp(), 121.0f);
            Assert.IsTrue(note.AtStpIsChanged());
        }
        [Test]
        public void SetAtStpFloat()
        {
            note.InitAtStp(120.0f);
            Assert.AreEqual(note.GetAtStp(), 120.0f);
            Assert.IsFalse(note.AtStpIsChanged());
            note.SetAtStp(121.0f);
            Assert.AreEqual(note.GetAtStp(), 121.0f);
            Assert.IsTrue(note.AtStpIsChanged());
        }


        [Test]
        public void SetVelocityStr()
        {
            note.InitVelocity("480");
            Assert.AreEqual(note.GetVelocity(), 480);
            Assert.IsFalse(note.VelocityIsChanged());
            note.SetVelocity("240");
            Assert.AreEqual(note.GetVelocity(), 240);
            Assert.IsTrue(note.VelocityIsChanged());
        }
        [Test]
        public void SetVelocityInt()
        {
            note.InitVelocity(480);
            Assert.AreEqual(note.GetVelocity(), 480);
            Assert.IsFalse(note.VelocityIsChanged());
            note.SetVelocity(240);
            Assert.AreEqual(note.GetVelocity(), 240);
            Assert.IsTrue(note.VelocityIsChanged());
        }


        [Test]
        public void SetIntensityStr()
        {
            note.InitIntensity("480");
            Assert.AreEqual(note.GetIntensity(), 480);
            Assert.IsFalse(note.IntensityIsChanged());
            note.SetIntensity("240");
            Assert.AreEqual(note.GetIntensity(), 240);
            Assert.IsTrue(note.IntensityIsChanged());
        }
        [Test]
        public void SetIntensityInt()
        {
            note.InitIntensity(480);
            Assert.AreEqual(note.GetIntensity(), 480);
            Assert.IsFalse(note.IntensityIsChanged());
            note.SetIntensity(240);
            Assert.AreEqual(note.GetIntensity(), 240);
            Assert.IsTrue(note.IntensityIsChanged());
        }


        [Test]
        public void SetModStr()
        {
            note.InitMod("480");
            Assert.AreEqual(note.GetMod(), 480);
            Assert.IsFalse(note.ModIsChanged());
            note.SetMod("240");
            Assert.AreEqual(note.GetMod(), 240);
            Assert.IsTrue(note.ModIsChanged());
        }
        [Test]
        public void SetModInt()
        {
            note.InitMod(480);
            Assert.AreEqual(note.GetMod(), 480);
            Assert.IsFalse(note.ModIsChanged());
            note.SetMod(240);
            Assert.AreEqual(note.GetMod(), 240);
            Assert.IsTrue(note.ModIsChanged());
        }
        [Test]
        public void SetFlags()
        {
            note.InitFlags("い");
            Assert.AreEqual(note.GetFlags(), "い");
            Assert.IsFalse(note.FlagsIsChanged());
            note.SetFlags("あ");
            Assert.AreEqual(note.GetFlags(), "あ");
            Assert.IsTrue(note.FlagsIsChanged());
        }

        [Test]
        public void SetPitches()
        {
            note.InitPitches("0,1,2,3,4,5");
            Assert.AreEqual(0, note.GetPitches()[0]);
            Assert.AreEqual(1, note.GetPitches()[1]);
            Assert.AreEqual(2, note.GetPitches()[2]);
            Assert.AreEqual(3, note.GetPitches()[3]);
            Assert.AreEqual(4, note.GetPitches()[4]);
            Assert.AreEqual(5, note.GetPitches()[5]);
            Assert.AreEqual(6, note.GetPitches().Count);
            Assert.IsFalse(note.PitchesIsChanged());
            note.SetPitches("6,7,8,9,10");
            Assert.AreEqual(6, note.GetPitches()[0]);
            Assert.AreEqual(7, note.GetPitches()[1]);
            Assert.AreEqual(8, note.GetPitches()[2]);
            Assert.AreEqual(9, note.GetPitches()[3]);
            Assert.AreEqual(10, note.GetPitches()[4]);
            Assert.AreEqual(5, note.GetPitches().Count);
            Assert.IsTrue(note.PitchesIsChanged());
        }
        [Test]
        public void SetPbStartStr()
        {
            note.InitPbStart("120.0");
            Assert.AreEqual(note.GetPbStart(), 120.0f);
            Assert.IsFalse(note.PbStartIsChanged());
            note.SetPbStart("121");
            Assert.AreEqual(note.GetPbStart(), 121.0f);
            Assert.IsTrue(note.PbStartIsChanged());
        }
        [Test]
        public void SetPbStartInt()
        {
            note.InitPbStart(120);
            Assert.AreEqual(note.GetPbStart(), 120.0f);
            Assert.IsFalse(note.PbStartIsChanged());
            note.SetPbStart(121);
            Assert.AreEqual(note.GetPbStart(), 121.0f);
            Assert.IsTrue(note.PbStartIsChanged());
        }
        [Test]
        public void SetPbStartFloat()
        {
            note.InitPbStart(120.0f);
            Assert.AreEqual(note.GetPbStart(), 120.0f);
            Assert.IsFalse(note.PbStartIsChanged());
            note.SetPbStart(121.0f);
            Assert.AreEqual(note.GetPbStart(), 121.0f);
            Assert.IsTrue(note.PbStartIsChanged());
        }




        [Test]
        public void SetPbs()
        {
            note.InitMode2Pitch();
            note.InitPbs("10;20");
            Assert.AreEqual(note.GetPbs(), "10;20");
            Assert.AreEqual(note.GetPbsTime(), 10);
            Assert.AreEqual(note.GetPbsHeight(), 20);
            Assert.IsFalse(note.PbsIsChanged());
            note.SetPbs("30;50");
            Assert.AreEqual(note.GetPbs(), "30;50");
            Assert.AreEqual(note.GetPbsTime(), 30);
            Assert.AreEqual(note.GetPbsHeight(), 50);
            Assert.IsTrue(note.PbsIsChanged());
        }
        [Test]
        public void SetPbw()
        {
            note.InitMode2Pitch();
            note.InitPbw("0,1,2");
            Assert.AreEqual(note.GetPbw()[0], 0);
            Assert.AreEqual(note.GetPbw()[1], 1);
            Assert.AreEqual(note.GetPbw()[2], 2);
            Assert.AreEqual(note.GetPbw().Count, 3);
            Assert.IsFalse(note.PbwIsChanged());
            note.SetPbw("2,3");
            Assert.AreEqual(note.GetPbw()[0], 2);
            Assert.AreEqual(note.GetPbw()[1], 3);
            Assert.AreEqual(note.GetPbw().Count, 2);
            Assert.IsTrue(note.PbwIsChanged());
        }
        [Test]
        public void SetPby()
        {
            note.InitMode2Pitch();
            note.InitPby("0,1,2,");
            Assert.AreEqual(note.GetPby()[0], 0);
            Assert.AreEqual(note.GetPby()[1], 1);
            Assert.AreEqual(note.GetPby()[2], 2);
            Assert.AreEqual(note.GetPby()[3], 0);
            Assert.AreEqual(note.GetPby().Count, 4);
            Assert.IsFalse(note.PbyIsChanged());
            note.SetPby("2,3");
            Assert.AreEqual(note.GetPby()[0], 2);
            Assert.AreEqual(note.GetPby()[1], 3);
            Assert.AreEqual(note.GetPby().Count, 2);
            Assert.IsTrue(note.PbyIsChanged());
        }
        [Test]
        public void SetPbm()
        {
            note.InitMode2Pitch();
            note.InitPbm(",r,j");
            Assert.AreEqual(note.GetPbm()[0], "");
            Assert.AreEqual(note.GetPbm()[1], "r");
            Assert.AreEqual(note.GetPbm()[2], "j");
            Assert.AreEqual(note.GetPbm().Count, 3);
            Assert.IsFalse(note.PbmIsChanged());
            note.SetPbm("s,j");
            Assert.AreEqual(note.GetPbm()[0], "s");
            Assert.AreEqual(note.GetPbm()[1], "j");
            Assert.AreEqual(note.GetPbm().Count, 2);
            Assert.IsTrue(note.PbmIsChanged());
        }
        [Test]
        public void SetEnvelope()
        {
            note.InitEnvelope();
            note.SetEnvelope("0,5,30,100,100,100,100");
            Assert.AreEqual(note.GetEnvelope(), "0,5,30,100,100,100,100");
            Assert.AreEqual(note.envelope.GetP(1), 5.0f);
        }
        [Test]
        public void SetVibrato()
        {
            note.InitVibrato();
            note.SetVibrato("0,1,2,30,30,30,30");
            Assert.AreEqual(note.GetVibrato(), "0,1,2,30,30,30,30,0");
            Assert.AreEqual(note.vibrato.Depth, 2);
        }
        [Test]
        public void SetLabel()
        {
            note.InitLabel("い");
            Assert.AreEqual(note.GetLabel(), "い");
            Assert.IsFalse(note.LabelIsChanged());
            note.SetLabel("あ");
            Assert.AreEqual(note.GetLabel(), "あ");
            Assert.IsTrue(note.LabelIsChanged());
        }


        [Test]
        public void SetDirectStr()
        {
            note.InitDirect("true");
            Assert.IsTrue(note.GetDirect());
            Assert.IsFalse(note.DirectIsChanged());
            note.SetDirect("false");
            Assert.IsFalse(note.GetDirect());
            Assert.IsTrue(note.DirectIsChanged());
            note.SetDirect("True");
            Assert.IsTrue(note.GetDirect());
            Assert.IsTrue(note.DirectIsChanged());
        }
        [Test]
        public void SetDirect()
        {
            note.InitDirect(true);
            Assert.IsTrue(note.GetDirect());
            Assert.IsFalse(note.DirectIsChanged());
            note.SetDirect(false);
            Assert.IsFalse(note.GetDirect());
            Assert.IsTrue(note.DirectIsChanged());
        }
        [Test]
        public void SetRegion()
        {
            note.InitRegion("い");
            Assert.AreEqual(note.GetRegion(), "い");
            Assert.IsFalse(note.RegionIsChanged());
            note.SetRegion("あ");
            Assert.AreEqual(note.GetRegion(), "あ");
            Assert.IsTrue(note.RegionIsChanged());
        }


        [Test]
        public void SetRegionEnd()
        {
            note.InitRegionEnd("い");
            Assert.AreEqual(note.GetRegionEnd(), "い");
            Assert.IsFalse(note.RegionEndIsChanged());
            note.SetRegionEnd("あ");
            Assert.AreEqual(note.GetRegionEnd(), "あ");
            Assert.IsTrue(note.RegionEndIsChanged());
        }
        [Test]
        public void NoInitSetPreStr()
        {
            note.SetPre("120.0");
            Assert.AreEqual(note.GetPre(), 120.0f);
            Assert.IsTrue(note.PreIsChanged());
            Assert.IsTrue(note.PreHasValue());
            note.SetPre("121");
            Assert.AreEqual(note.GetPre(), 121.0f);
            Assert.IsTrue(note.PreIsChanged());
            Assert.IsTrue(note.PreHasValue());
        }
        [Test]
        public void NoInitSetPreInt()
        {
            note.SetPre(120);
            Assert.AreEqual(note.GetPre(), 120.0f);
            Assert.IsTrue(note.PreIsChanged());
            Assert.IsTrue(note.PreHasValue());
            note.SetPre(121);
            Assert.AreEqual(note.GetPre(), 121.0f);
            Assert.IsTrue(note.PreIsChanged());
            Assert.IsTrue(note.PreHasValue());
        }
        [Test]
        public void NoInitSetPreFloat()
        {
            note.SetPre(120.0f);
            Assert.AreEqual(note.GetPre(), 120.0f);
            Assert.IsTrue(note.PreIsChanged());
            Assert.IsTrue(note.PreHasValue());
            note.SetPre(121.0f);
            Assert.AreEqual(note.GetPre(), 121.0f);
            Assert.IsTrue(note.PreIsChanged());
            Assert.IsTrue(note.PreHasValue());
        }


        [Test]
        public void NoInitSetAtPreStr()
        {
            note.SetAtPre("120.0");
            Assert.AreEqual(note.GetAtPre(), 120.0f);
            Assert.IsTrue(note.AtPreIsChanged());
            note.SetAtPre("121");
            Assert.AreEqual(note.GetAtPre(), 121.0f);
            Assert.IsTrue(note.AtPreIsChanged());
        }
        [Test]
        public void NoInitSetAtPreInt()
        {
            Assert.IsFalse(note.AtPreIsChanged());
            note.SetAtPre(120);
            Assert.AreEqual(note.GetAtPre(), 120.0f);
            Assert.IsTrue(note.AtPreIsChanged());
            note.SetAtPre(121);
            Assert.AreEqual(note.GetAtPre(), 121.0f);
            Assert.IsTrue(note.AtPreIsChanged());
        }
        [Test]
        public void NoInitSetAtPreFloat()
        {
            Assert.IsFalse(note.AtPreIsChanged());
            note.SetAtPre(120.0f);
            Assert.AreEqual(note.GetAtPre(), 120.0f);
            Assert.IsTrue(note.AtPreIsChanged());
            note.SetAtPre(121.0f);
            Assert.AreEqual(note.GetAtPre(), 121.0f);
            Assert.IsTrue(note.AtPreIsChanged());
        }


        [Test]
        public void NoInitSetAtFileName()
        {
            Assert.IsFalse(note.AtFileNameIsChanged());
            note.SetAtFileName("い");
            Assert.AreEqual(note.GetAtFileName(), "い");
            Assert.IsTrue(note.AtFileNameIsChanged());
            note.SetAtFileName("あ");
            Assert.AreEqual(note.GetAtFileName(), "あ");
            Assert.IsTrue(note.AtFileNameIsChanged());
        }


        [Test]
        public void NoInitSetAtAlias()
        {
            Assert.IsFalse(note.AtAliasIsChanged());
            note.SetAtAlias("い");
            Assert.AreEqual(note.GetAtAlias(), "い");
            Assert.IsTrue(note.AtAliasIsChanged());
            note.SetAtAlias("あ");
            Assert.AreEqual(note.GetAtAlias(), "あ");
            Assert.IsTrue(note.AtAliasIsChanged());
        }

        [Test]
        public void NoInitSetOveStr()
        {
            Assert.IsFalse(note.OveIsChanged());
            note.SetOve("120.0");
            Assert.AreEqual(note.GetOve(), 120.0f);
            Assert.IsTrue(note.OveIsChanged());
            note.SetOve("121");
            Assert.AreEqual(note.GetOve(), 121.0f);
            Assert.IsTrue(note.OveIsChanged());
        }
        [Test]
        public void NoInitSetOveInt()
        {
            Assert.IsFalse(note.OveIsChanged());
            note.SetOve(120);
            Assert.AreEqual(note.GetOve(), 120.0f);
            Assert.IsTrue(note.OveIsChanged());
            note.SetOve(121);
            Assert.AreEqual(note.GetOve(), 121.0f);
            Assert.IsTrue(note.OveIsChanged());
        }
        [Test]
        public void NoInitSetOveFloat()
        {
            Assert.IsFalse(note.OveIsChanged());
            note.SetOve(120.0f);
            Assert.AreEqual(note.GetOve(), 120.0f);
            Assert.IsTrue(note.OveIsChanged());
            note.SetOve(121.0f);
            Assert.AreEqual(note.GetOve(), 121.0f);
            Assert.IsTrue(note.OveIsChanged());
        }


        [Test]
        public void NoInitSetAtOveStr()
        {
            Assert.IsFalse(note.AtOveIsChanged());
            note.SetAtOve("120.0");
            Assert.AreEqual(note.GetAtOve(), 120.0f);
            Assert.IsTrue(note.AtOveIsChanged());
            note.SetAtOve("121");
            Assert.AreEqual(note.GetAtOve(), 121.0f);
            Assert.IsTrue(note.AtOveIsChanged());
        }
        [Test]
        public void NoInitSetAtOveInt()
        {
            Assert.IsFalse(note.AtOveIsChanged());
            note.SetAtOve(120);
            Assert.AreEqual(note.GetAtOve(), 120.0f);
            Assert.IsTrue(note.AtOveIsChanged());
            note.SetAtOve(121);
            Assert.AreEqual(note.GetAtOve(), 121.0f);
            Assert.IsTrue(note.AtOveIsChanged());
        }
        [Test]
        public void NoInitSetAtOveFloat()
        {
            Assert.IsFalse(note.AtOveIsChanged());
            note.SetAtOve(120.0f);
            Assert.AreEqual(note.GetAtOve(), 120.0f);
            Assert.IsTrue(note.AtOveIsChanged());
            note.SetAtOve(121.0f);
            Assert.AreEqual(note.GetAtOve(), 121.0f);
            Assert.IsTrue(note.AtOveIsChanged());
        }


        [Test]
        public void NoInitSetStpStr()
        {
            Assert.IsFalse(note.StpIsChanged());
            note.SetStp("120.0");
            Assert.AreEqual(note.GetStp(), 120.0f);
            Assert.IsTrue(note.StpIsChanged());
            note.SetStp("121");
            Assert.AreEqual(note.GetStp(), 121.0f);
            Assert.IsTrue(note.StpIsChanged());
        }
        [Test]
        public void NoInitSetStpInt()
        {
            Assert.IsFalse(note.StpIsChanged());
            note.SetStp(120);
            Assert.AreEqual(note.GetStp(), 120.0f);
            Assert.IsTrue(note.StpIsChanged());
            note.SetStp(121);
            Assert.AreEqual(note.GetStp(), 121.0f);
            Assert.IsTrue(note.StpIsChanged());
        }
        [Test]
        public void NoInitSetStpFloat()
        {
            Assert.IsFalse(note.StpIsChanged());
            note.SetStp(120.0f);
            Assert.AreEqual(note.GetStp(), 120.0f);
            Assert.IsTrue(note.StpIsChanged());
            note.SetStp(121.0f);
            Assert.AreEqual(note.GetStp(), 121.0f);
            Assert.IsTrue(note.StpIsChanged());
        }


        [Test]
        public void NoInitSetAtStpStr()
        {
            Assert.IsFalse(note.AtStpIsChanged());
            note.SetAtStp("120.0");
            Assert.AreEqual(note.GetAtStp(), 120.0f);
            Assert.IsTrue(note.AtStpIsChanged());
            note.SetAtStp("121");
            Assert.AreEqual(note.GetAtStp(), 121.0f);
            Assert.IsTrue(note.AtStpIsChanged());
        }
        [Test]
        public void NoInitSetAtStpInt()
        {
            Assert.IsFalse(note.AtStpIsChanged());
            note.SetAtStp(120);
            Assert.AreEqual(note.GetAtStp(), 120.0f);
            Assert.IsTrue(note.AtStpIsChanged());
            note.SetAtStp(121);
            Assert.AreEqual(note.GetAtStp(), 121.0f);
            Assert.IsTrue(note.AtStpIsChanged());
        }

        [Test]
        public void NoInitSetAtStpFloat()
        {
            Assert.IsFalse(note.AtStpIsChanged());
            note.SetAtStp(120.0f);
            Assert.AreEqual(note.GetAtStp(), 120.0f);
            Assert.IsTrue(note.AtStpIsChanged());
            note.SetAtStp(121.0f);
            Assert.AreEqual(note.GetAtStp(), 121.0f);
            Assert.IsTrue(note.AtStpIsChanged());
        }

        [Test]
        public void NoInitSetVelocityStr()
        {
            Assert.IsFalse(note.VelocityIsChanged());
            note.SetVelocity("480");
            Assert.AreEqual(note.GetVelocity(), 480);
            Assert.IsTrue(note.VelocityIsChanged());
            note.SetVelocity("240");
            Assert.AreEqual(note.GetVelocity(), 240);
            Assert.IsTrue(note.VelocityIsChanged());
        }
        [Test]
        public void NoInitSetVelocityInt()
        {
            Assert.IsFalse(note.VelocityIsChanged());
            note.SetVelocity(480);
            Assert.AreEqual(note.GetVelocity(), 480);
            Assert.IsTrue(note.VelocityIsChanged());
            note.SetVelocity(240);
            Assert.AreEqual(note.GetVelocity(), 240);
            Assert.IsTrue(note.VelocityIsChanged());
        }


        [Test]
        public void NoInitSetIntensityStr()
        {
            Assert.IsFalse(note.IntensityIsChanged());
            note.SetIntensity("480");
            Assert.AreEqual(note.GetIntensity(), 480);
            Assert.IsTrue(note.IntensityIsChanged());
            note.SetIntensity("240");
            Assert.AreEqual(note.GetIntensity(), 240);
            Assert.IsTrue(note.IntensityIsChanged());
        }
        [Test]
        public void NoInitSetIntensityInt()
        {
            Assert.IsFalse(note.IntensityIsChanged());
            note.SetIntensity(480);
            Assert.AreEqual(note.GetIntensity(), 480);
            Assert.IsTrue(note.IntensityIsChanged());
            note.SetIntensity(240);
            Assert.AreEqual(note.GetIntensity(), 240);
            Assert.IsTrue(note.IntensityIsChanged());
        }


        [Test]
        public void NoInitSetModStr()
        {
            Assert.IsFalse(note.ModIsChanged());
            note.SetMod("480");
            Assert.AreEqual(note.GetMod(), 480);
            Assert.IsTrue(note.ModIsChanged());
            note.SetMod("240");
            Assert.AreEqual(note.GetMod(), 240);
            Assert.IsTrue(note.ModIsChanged());
        }
        [Test]
        public void NoInitSetModInt()
        {
            Assert.IsFalse(note.ModIsChanged());
            note.SetMod(480);
            Assert.AreEqual(note.GetMod(), 480);
            Assert.IsTrue(note.ModIsChanged());
            note.SetMod(240);
            Assert.AreEqual(note.GetMod(), 240);
            Assert.IsTrue(note.ModIsChanged());
        }
        [Test]
        public void NoInitSetFlags()
        {
            Assert.IsFalse(note.FlagsIsChanged());
            note.SetFlags("い");
            Assert.AreEqual(note.GetFlags(), "い");
            Assert.IsTrue(note.FlagsIsChanged());
            note.SetFlags("あ");
            Assert.AreEqual(note.GetFlags(), "あ");
            Assert.IsTrue(note.FlagsIsChanged());
        }

        [Test]
        public void NoInitSetPitches()
        {
            Assert.IsFalse(note.PitchesIsChanged());
            note.SetPitches("0,1,2,3,4,5");
            Assert.AreEqual(note.GetPitches()[0], 0);
            Assert.AreEqual(note.GetPitches()[1], 1);
            Assert.AreEqual(note.GetPitches()[2], 2);
            Assert.AreEqual(note.GetPitches()[3], 3);
            Assert.AreEqual(note.GetPitches()[4], 4);
            Assert.AreEqual(note.GetPitches()[5], 5);
            Assert.AreEqual(note.GetPitches().Count, 6);
            Assert.IsTrue(note.PitchesIsChanged());
            note.SetPitches("6,7,8,9,10");
            Assert.AreEqual(note.GetPitches()[0], 6);
            Assert.AreEqual(note.GetPitches()[1], 7);
            Assert.AreEqual(note.GetPitches()[2], 8);
            Assert.AreEqual(note.GetPitches()[3], 9);
            Assert.AreEqual(note.GetPitches()[4], 10);
            Assert.AreEqual(note.GetPitches().Count, 5);
            Assert.IsTrue(note.PitchesIsChanged());
        }
        [Test]
        public void NoInitSetPbStartStr()
        {
            Assert.IsFalse(note.PbStartIsChanged());
            note.SetPbStart("120.0");
            Assert.AreEqual(note.GetPbStart(), 120.0f);
            Assert.IsTrue(note.PbStartIsChanged());
            note.SetPbStart("121");
            Assert.AreEqual(note.GetPbStart(), 121.0f);
            Assert.IsTrue(note.PbStartIsChanged());
        }
        [Test]
        public void NoInitSetPbStartInt()
        {
            Assert.IsFalse(note.PbStartIsChanged());
            note.SetPbStart(120);
            Assert.AreEqual(note.GetPbStart(), 120.0f);
            Assert.IsTrue(note.PbStartIsChanged());
            note.SetPbStart(121);
            Assert.AreEqual(note.GetPbStart(), 121.0f);
            Assert.IsTrue(note.PbStartIsChanged());
        }
        [Test]
        public void NoInitSetPbStartFloat()
        {
            Assert.IsFalse(note.PbStartIsChanged());
            note.SetPbStart(120.0f);
            Assert.AreEqual(note.GetPbStart(), 120.0f);
            Assert.IsTrue(note.PbStartIsChanged());
            note.SetPbStart(121.0f);
            Assert.AreEqual(note.GetPbStart(), 121.0f);
            Assert.IsTrue(note.PbStartIsChanged());
        }

        [Test]
        public void NoInitSetPbs()
        {
            Assert.IsFalse(note.PbsIsChanged());
            note.SetPbs("10;20");
            Assert.AreEqual(note.GetPbs(), "10;20");
            Assert.AreEqual(note.GetPbsTime(), 10);
            Assert.AreEqual(note.GetPbsHeight(), 20);
            Assert.IsTrue(note.PbsIsChanged());
            note.SetPbs("30;50");
            Assert.AreEqual(note.GetPbs(), "30;50");
            Assert.AreEqual(note.GetPbsTime(), 30);
            Assert.AreEqual(note.GetPbsHeight(), 50);
            Assert.IsTrue(note.PbsIsChanged());
        }
        [Test]
        public void NoInitSetPbw()
        {
            Assert.IsFalse(note.PbwIsChanged());
            note.SetPbw("0,1,2");
            Assert.AreEqual(note.GetPbw()[0], 0);
            Assert.AreEqual(note.GetPbw()[1], 1);
            Assert.AreEqual(note.GetPbw()[2], 2);
            Assert.AreEqual(note.GetPbw().Count, 3);
            Assert.IsTrue(note.PbwIsChanged());
            note.SetPbw("2,3");
            Assert.AreEqual(note.GetPbw()[0], 2);
            Assert.AreEqual(note.GetPbw()[1], 3);
            Assert.AreEqual(note.GetPbw().Count, 2);
            Assert.IsTrue(note.PbwIsChanged());
        }
        [Test]
        public void NoInitSetPby()
        {
            Assert.IsFalse(note.PbyIsChanged());
            note.SetPby("0,1,2,");
            Assert.AreEqual(note.GetPby()[0], 0);
            Assert.AreEqual(note.GetPby()[1], 1);
            Assert.AreEqual(note.GetPby()[2], 2);
            Assert.AreEqual(note.GetPby()[3], 0);
            Assert.AreEqual(note.GetPby().Count, 4);
            Assert.IsTrue(note.PbyIsChanged());
            note.SetPby("2,3");
            Assert.AreEqual(note.GetPby()[0], 2);
            Assert.AreEqual(note.GetPby()[1], 3);
            Assert.AreEqual(note.GetPby().Count, 2);
            Assert.IsTrue(note.PbyIsChanged());
        }
        [Test]
        public void NoInitSetPbm()
        {
            Assert.IsFalse(note.PbmIsChanged());
            note.SetPbm(",r,j");
            Assert.AreEqual(note.GetPbm()[0], "");
            Assert.AreEqual(note.GetPbm()[1], "r");
            Assert.AreEqual(note.GetPbm()[2], "j");
            Assert.AreEqual(note.GetPbm().Count, 3);
            Assert.IsTrue(note.PbmIsChanged());
            note.SetPbm("s,j");
            Assert.AreEqual(note.GetPbm()[0], "s");
            Assert.AreEqual(note.GetPbm()[1], "j");
            Assert.AreEqual(note.GetPbm().Count, 2);
            Assert.IsTrue(note.PbmIsChanged());
        }
        [Test]
        public void NoInitSetEnvelope()
        {
            Assert.IsFalse(note.EnvelopeIsChanged());
            note.SetEnvelope("0,5,30,100,100,100,100");
            Assert.AreEqual(note.GetEnvelope(), "0,5,30,100,100,100,100");
            Assert.AreEqual(note.envelope.GetP(1), 5.0f);
        }
        [Test]
        public void NoInitSetVibrato()
        {
            note.SetVibrato("0,1,2,30,30,30,30");
            Assert.AreEqual(note.GetVibrato(), "0,1,2,30,30,30,30,0");
            Assert.AreEqual(note.vibrato.Depth, 2);
        }
        [Test]
        public void NoInitSetLabel()
        {
            Assert.IsFalse(note.LabelIsChanged());
            note.SetLabel("い");
            Assert.AreEqual(note.GetLabel(), "い");
            Assert.IsTrue(note.LabelIsChanged());
            note.SetLabel("あ");
            Assert.AreEqual(note.GetLabel(), "あ");
            Assert.IsTrue(note.LabelIsChanged());
        }


        [Test]
        public void NoInitSetDirectStr()
        {
            Assert.IsFalse(note.DirectIsChanged());
            note.SetDirect("true");
            Assert.IsTrue(note.GetDirect());
            Assert.IsTrue(note.DirectIsChanged());
            note.SetDirect("false");
            Assert.IsFalse(note.GetDirect());
            Assert.IsTrue(note.DirectIsChanged());
            note.SetDirect("True");
            Assert.IsTrue(note.GetDirect());
            Assert.IsTrue(note.DirectIsChanged());
        }
        [Test]
        public void NoInitSetDirect()
        {
            Assert.IsFalse(note.DirectIsChanged());
            note.SetDirect(true);
            Assert.IsTrue(note.GetDirect());
            Assert.IsTrue(note.DirectIsChanged());
            note.SetDirect(false);
            Assert.IsFalse(note.GetDirect());
            Assert.IsTrue(note.DirectIsChanged());
        }
        [Test]
        public void NoInitSetRegion()
        {
            Assert.IsFalse(note.RegionIsChanged());
            note.SetRegion("い");
            Assert.AreEqual(note.GetRegion(), "い");
            Assert.IsTrue(note.RegionIsChanged());
            note.SetRegion("あ");
            Assert.AreEqual(note.GetRegion(), "あ");
            Assert.IsTrue(note.RegionIsChanged());
        }


        [Test]
        public void NoInitSetRegionEnd()
        {
            Assert.IsFalse(note.RegionEndIsChanged());
            note.SetRegionEnd("い");
            Assert.AreEqual(note.GetRegionEnd(), "い");
            Assert.IsTrue(note.RegionEndIsChanged());
            note.SetRegionEnd("あ");
            Assert.AreEqual(note.GetRegionEnd(), "あ");
            Assert.IsTrue(note.RegionEndIsChanged());
        }
    }
}
