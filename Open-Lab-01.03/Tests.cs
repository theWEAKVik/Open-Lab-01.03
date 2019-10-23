using NUnit.Framework;

namespace Open_Lab_01._03
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void Addition([Range(-10, 10)] int number)
        {
            var exercise = new Exercise();
            Assert.That(exercise.Addition(number), Is.EqualTo(number + 1));
        }
    }
}