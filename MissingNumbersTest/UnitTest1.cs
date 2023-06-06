using Microsoft.VisualStudio.TestTools.UnitTesting;
using MissingNumbersLibrary;
namespace MissingNumbersTest;

[TestClass]
public class UnitTestMissingNumbers
{
    [TestMethod]
    public void TestMissingNumbersNth1()
    {
        
        List<int> input = new List<int>(){4, 3, 6, 2, 1, 7};
        int toEq = 5;

        int result = MissingNumbers.getMissingNumber(input, 1);
        Assert.AreEqual(result, toEq);
    }

    [TestMethod]
    public void TestMissingNumbersNth2()
    {
        
        List<int> input = new List<int>(){4, 3, 6, 2, 1, 7, 9};
        int toEq = 8;

        int result = MissingNumbers.getMissingNumber(input, 2);
        Assert.AreEqual(result, toEq);
    }

    [TestMethod]
    public void TestMissingNumbersNth3()
    {
        
        List<int> input = new List<int>(){4, 3, 6, 2, 1, 7, 9};
        int toEq = 10;

        int result = MissingNumbers.getMissingNumber(input, 3);
        Assert.AreEqual(result, toEq);
    }

    [TestMethod]
    public void TestMissingNumbersNth5()
    {
        
        List<int> input = new List<int>(){4, 20, 3, 6, 2, 1, 7, 9, 15, 18};
        int toEq = 12;

        int result = MissingNumbers.getMissingNumber(input, 5);
        Assert.AreEqual(result, toEq);
    }
}