using NUnit.Framework;
using ReturnStringWithNoVowels;

namespace ReturnStringNoVowelsTEST
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase("i am a test string, i dont have much to say about myself, being a string is hard!", " m  tst strng,  dnt hv mch t sy bt myslf, bng  strng s hrd!")]
        [TestCase("i am a test string, unlike my brother i have much to say, but they wont let me!", " m  tst strng, nlk my brthr  hv mch t sy, bt thy wnt lt m!")]
        [TestCase("i am a test string, much smaller!", " m  tst strng, mch smllr!")]
        [TestCase("i am eeeven smaller!", " m vn smllr!")]
        [TestCase("1234", "1234")]
        [TestCase("nt chngd", "nt chngd")]

        public void FeedStringReceiveStringWithNoVowels(string testString, string expected)
        {
            Assert.That(()=> Program.Disemvowelling(testString), Is.EqualTo(expected));
        }
    }
}