using NUnit.Framework;

namespace Loop2Tasks.Tests
{
    [TestFixture]
    public class TasksTests
    {
        [TestCase(465780, 18)]
        [TestCase(598489, 20)]
        [TestCase(3501, 0)]
        public void Task1_ReturnsCorrectValue(int n, int expected)
        {
            var actual = Tasks.Task1(n);
            Assert.AreEqual(expected, actual, "Task1 returns incorrect value.");
        }

        [TestCase(465780, 18)]
        [TestCase(598489, 23)]
        [TestCase(35041, 9)]
        public void Task2_ReturnsCorrectValue(int n, int expected)
        {
            var actual = Tasks.Task2(n);
            Assert.AreEqual(expected, actual, "Task2 returns incorrect value.");
        }

        [TestCase(465780, 45678)]
        [TestCase(598489, 458899)]
        [TestCase(3501, 135)]
        public void Task3_ReturnsCorrectValue(int n, int expected)
        {
            var actual = Tasks.Task3(n);
            Assert.AreEqual(expected, actual, "Task3 returns incorrect value.");
        }
    }
}