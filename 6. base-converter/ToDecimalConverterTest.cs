using NUnit.Framework;

[TestFixture]
public class ToDecimalConverterTest
{
	[TestCase("1", 3, ExpectedResult = 1)]
	[TestCase("2", 3, ExpectedResult = 2)]
	[TestCase("10", 3, ExpectedResult = 3)]
	[TestCase("11", 4, ExpectedResult = 5)]
	[TestCase("100", 10, ExpectedResult = 100)]
	[TestCase("112", 3, ExpectedResult = 14)]
	[TestCase("222", 3, ExpectedResult = 26)]
	[TestCase("1122000120", 3, ExpectedResult = 32091)]
	[TestCase("9", 16, ExpectedResult = 9)]
	[TestCase("10", 16, ExpectedResult = 16)]
	[TestCase("AA", 16, ExpectedResult = 170)]
	[TestCase("634223", 7, ExpectedResult = 109532)]
	[TestCase("carrot", 3, ExpectedResult = 0)]
	[TestCase("3", 17, ExpectedResult = 0)]
	[TestCase("6", 2, ExpectedResult = 0)]
	[TestCase("9", 3, ExpectedResult = 0)]
	[TestCase("124578", 5, ExpectedResult = 0)]
	[TestCase("abc1z", 11, ExpectedResult = 0)]
	public int ConvertValueToDecimal(string value, int fromBase)
	{
		return ToDecimalConverter.ConvertToDecimal(value, fromBase);
	}
}