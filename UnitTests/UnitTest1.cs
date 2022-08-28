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
}