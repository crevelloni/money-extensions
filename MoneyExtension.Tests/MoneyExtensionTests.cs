namespace MoneyExtension.Tests;

[TestClass]
public class MoneyEtensionTests
{
    [TestMethod]
    public void ShouldConvertDecimalToInt()
    {

        decimal value = 1.23m;
        var result = value.ToCents();
        Assert.AreEqual(123, result);
        value = 1.2m;
        result = value.ToCents();
        Assert.AreEqual(120, result);
        value = 1.00m;
        result = value.ToCents();
        Assert.AreEqual(100, result);
        value = 1.0m;
        result = value.ToCents();
        Assert.AreEqual(100, result);
        value = 1m;
        result = value.ToCents();
        Assert.AreEqual(100, result);
        value = 0.99m;
        result = value.ToCents();
        Assert.AreEqual(99, result);
        value = 0.9m;
        result = value.ToCents();
        Assert.AreEqual(90, result);
        value = 0.00m;
        result = value.ToCents();
        Assert.AreEqual(0, result);
        value = 0m;
        result = value.ToCents();
        Assert.AreEqual(0, result);
        value = -1.23m;
        result = value.ToCents();
        Assert.AreEqual(0, result);
        value = -1.2m;
        result = value.ToCents();
        Assert.AreEqual(0, result);
        value = -1.00m;
        result = value.ToCents();
        Assert.AreEqual(0, result);
        value = -1.0m;
        result = value.ToCents();
        Assert.AreEqual(0, result);
        value = -1m;
        result = value.ToCents();
        Assert.AreEqual(0, result);
        value = -0.99m;
        result = value.ToCents();
        Assert.AreEqual(0, result);
        value = -0.9m;
        result = value.ToCents();
        Assert.AreEqual(0, result);
        value = -0.00m;
        result = value.ToCents();
        Assert.AreEqual(0, result);
        value = -0m;
        result = value.ToCents();
        Assert.AreEqual(0, result);
    }
}