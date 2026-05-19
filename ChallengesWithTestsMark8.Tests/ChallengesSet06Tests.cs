using System;
using System.Collections.Generic;
using Xunit;

namespace ChallengesWithTestsMark8.Tests;

public class ChallengesSet06Tests
{
    [Theory]
    [InlineData(new[] { "alpha", "bravo", "charlie" }, "alpha", true, true)]
    [InlineData(new[] { "alpha", "bravo", "charlie" }, "alpha", false, true)]
    [InlineData(new[] { "alpha", "bravo", "charlie" }, "bravo", true, true)]
    [InlineData(new[] { "alpha", "bravo", "charlie" }, "charlie", true, true)]
    [InlineData(new[] { "Alpha", "bravo", "charlie" }, "alpha", true, true)]
    [InlineData(new[] { "Alpha", "braVo", "charlie" }, "bravo", true, true)]
    [InlineData(new[] { "Alpha", "bravo", "chArlie" }, "charlie", true, true)]
    [InlineData(new[] { "AlPha", "alpha", "bravo", "charlie" }, "alpha", false, true)]
    [InlineData(new[] { "AlPha", "bravo", "charlie" }, "alpha", false, false)]
    [InlineData(new[] { "alpha", "bravo", "charlie" }, "delta", true, false)]
    [InlineData(new[] { null, "bravo", "charlie" }, "braVo", false, false)]
    [InlineData(new[] { null, "bravo", "chArlie" }, "charliE", false, false)]
    [InlineData(new[] { null, null, "charlie" }, "bravo", true, false)]
    [InlineData(null, "alpha", true, false)]
    public void CollectionContainsWord(IEnumerable<string> words, string word, bool ignoreCase, bool expected)
    {
        // Arrange
        var challenger = new ChallengesSet06();

        // Act
        var actual = challenger.CollectionContainsWord(words, word, ignoreCase);

        // Assert
        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData(2, true)]
    [InlineData(3, true)]
    [InlineData(5, true)]
    [InlineData(1523, true)]
    [InlineData(26357, true)]
    [InlineData(37117, true)]
    [InlineData(83791, true)]
    [InlineData(91199, true)]
    [InlineData(91387, true)]
    [InlineData(91909, true)]
    [InlineData(99991, true)]
    [InlineData(1, false)]
    [InlineData(4, false)]
    [InlineData(2000, false)]
    [InlineData(10011, false)]
    [InlineData(99561, false)]
    [InlineData(99987, false)]
    [InlineData(0, false)]
    [InlineData(-1, false)]
    [InlineData(-5, false)]
    [InlineData(-101, false)]
    [InlineData(-99991, false)]
    public void IsPrimeNumber(int number, bool expected)
    {
        // Arrange
        var challenger = new ChallengesSet06();

        // Act
        var actual = challenger.IsPrimeNumber(number);

        // Assert
        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData("aaaa", -1)]
    [InlineData("aaa", -1)]
    [InlineData("aa", -1)]
    [InlineData("a", 0)]
    [InlineData("", -1)]
    [InlineData("ab", 1)]
    [InlineData("abb", 0)]
    [InlineData("aba", 1)]
    [InlineData("aab", 2)]
    [InlineData("aabaa", 2)]
    [InlineData("aabbc", 4)]
    [InlineData("aabcc", 2)]
    [InlineData("aabbcddee", 4)]
    [InlineData("aaabbbcdddeee", 6)]
    [InlineData("aaabbbcdddeeeffg", 15)]
    [InlineData("abbbccdddeeeffgg", 0)]
    public void LastUniqueIndex(string str, int expected)
    {
        // Arrange
        var challenger = new ChallengesSet06();

        // Act
        var actual = challenger.IndexOfLastUniqueLetter(str);

        // Assert
        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData(new[] { 1, 2, 2, 3, 4, 5 }, 2)]
    [InlineData(new[] { 10, 3, 1, 1, 1, 5, 1 }, 3)]
    [InlineData(new[] { 1, 2, 2, 3, 3, 3, 3, 2, 5 }, 4)]
    [InlineData(new[] { 1, 2, 2, 3, 3, 3, 3 }, 4)]
    [InlineData(new[] { 1, 2, 2, 3, 2 }, 2)]
    [InlineData(new[] { 3, 3, 3, 2, 2 }, 3)]
    [InlineData(new[] { 1, 3, 2, 3, 3, 3, 3 }, 4)]
    public void MaxConsecutiveCount(int[] numbers, int expected)
    {
        // Arrange
        var challenger = new ChallengesSet06();

        // Act
        var actual = challenger.MaxConsecutiveCount(numbers);

        // Assert
        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData(new[] { 1d, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 }, 4, new[] { 4d, 8, 12, 16 })]
    [InlineData(new[] { 1d, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 }, 3, new[] { 3d, 6, 9, 12, 15 })]
    [InlineData(new[] { 1d, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 }, 2,
        new[] { 2d, 4, 6, 8, 10, 12, 14, 16 })]
    [InlineData(new[] { 1d, 2, 3, 4, 5 }, 1, new[] { 1d, 2, 3, 4, 5 })]
    [InlineData(new[] { 1d, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 }, 8, new[] { 8d, 16 })]
    [InlineData(new[] { 1d, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 }, 10, new[] { 10d })]
    [InlineData(new[] { 1d, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 }, 20, new double[] { })]
    [InlineData(new[] { 1d, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 }, -2, new double[] { })]
    [InlineData(new[] { 1d, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 }, 4, new[] { 4d, 8, 12 })]
    [InlineData(new[] { 1d, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 }, 4, new[] { 4d, 8 })]
    [InlineData(new[] { 1d, 2, 3, 4, 5, 6, 7 }, 4, new[] { 4d })]
    [InlineData(new[] { 1d }, 1, new[] { 1d })]
    [InlineData(new[] { 1d }, -1, new double[] { })]
    [InlineData(new double[] { }, 0, new double[] { })]
    [InlineData(new double[] { }, 1, new double[] { })]
    [InlineData(null, 0, new double[] { })]
    [InlineData(null, 1, new double[] { })]
    public void GetEveryNthElement_List(double[] numbers, int n, double[] expected)
    {
        // Arrange
        var challenger = new ChallengesSet06();
        var numbersAsList = numbers == null ? null : new List<double>(numbers);

        // Act
        var actual = challenger.GetEveryNthElement(numbersAsList, n);

        // Assert
        Assert.Equal(expected.Length, actual.Length);
        for (var i = 0; i < expected.Length; i++) Assert.Equal(Math.Round(expected[i], 4), Math.Round(actual[i], 4));
    }
}