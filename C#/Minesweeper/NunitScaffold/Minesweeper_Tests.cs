using NUnit.Framework;

namespace NUnitScaffold
{
    public class Tests
    {
        

        [SetUp]
        public void SetUp()
        {
            
        }

        [Test]
        public void GetLengthShouldReturn4()
        {
            var ms = new MineSweeper(4, 4,8);
            Assert.That(ms.length(), Is.EqualTo(16));
        }
        

        [Test]
        public void PlayZeroZeroShouldBeEmptyString()
        {
            var ms = new MineSweeper(4, 4,8);
            Assert.That(ms.Play(0,0), Is.EqualTo("*"));
            Assert.That(ms.Play(0,1), Is.EqualTo("*"));

            Assert.That(ms.Play(0,2), Is.EqualTo("*"));
            Assert.That(ms.Play(1,0), Is.EqualTo(""));
        }


        [Test]
        public void sdjfksjdakfjdsk()
        {
            var ms = new MineSweeper(4, 4,8);
            Assert.That(ms.Play(0,1), Is.EqualTo("1"));
        }





    }
}
