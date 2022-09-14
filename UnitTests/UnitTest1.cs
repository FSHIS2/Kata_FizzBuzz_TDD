using FizzBuzz;

namespace UnitTests;

[TestClass]
public class UnitTest1
{
    private readonly Program execute = new Program();
    
    [TestMethod]
    public void ShouldReturnFizz_WhenNumberIsMultipleOf_3()
    {
        Assert.AreEqual("Fizz", execute.FizzBuzz(3));
    }

    [TestMethod]
    public void ShouldReturnBuzz_WhenNumberIsMultipleOf_5()
    {
        Assert.AreEqual("Buzz", execute.FizzBuzz(5));
    }

    [TestMethod]
    public void ShouldReturnFizzBuzz_WhenNumberIsMultipleOf_3_And_5()
    {
        Assert.AreEqual("FizzBuzz", execute.FizzBuzz(15));
    }

    [TestMethod]
    public void ShouldReturnNothing_WhenNumberIsNotMultipleOf_3_And_5()
    {
        Assert.AreEqual("", execute.FizzBuzz(1));
    }
}