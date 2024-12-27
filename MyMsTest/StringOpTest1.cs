using Demo;
namespace MyMsTest
{
    [TestClass]
    public sealed class StringOpTest1
    {
        [TestMethod]
        // Counts the no of vowels in the string
        [DataRow("hello", 2)]
        [DataRow("world", 1)]
        [DataRow("MSTest", 1)]
        [DataRow("DataRow", 3)]
        [DataRow("AEIOU", 5)]
        [DataRow("bcdfg", 0)]
        [DataRow("", 0)]
        [DataRow(null, 0)]
        public void CountVowels_ReturnsExpectedResult(string input, int expectedCount)
        {
            // Act
            int actualCount =StringOp.CountVowels(input);

            // Assert
            Assert.AreEqual(expectedCount, actualCount,
                $"Input: \"{input}\" should have {expectedCount} vowels");
        }
    }

}
