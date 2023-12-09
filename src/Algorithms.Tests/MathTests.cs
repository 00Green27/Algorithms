using Xunit;
using Xunit.Sdk;

namespace Algorithms;

public class MathTests
{
	[Theory]
	[InlineData(48, 60, 12)]
	[InlineData(63, 81, 9)]
	[InlineData(242, 132, 22)]
	[InlineData(2625, 8100, 75)]
	[InlineData(999, 0, 999)]
	public void Gsd(int a, int b, int gsd)
	{
		var result = Math.Gsd(a, b);
		Assert.Equal(gsd, result);
	}

	[Theory]
	[InlineData(0, false)]
	[InlineData(1, false)]
	[InlineData(2, true)]
	[InlineData(3, true)]
	[InlineData(4, false)]
	[InlineData(2023, false)]
	[InlineData(2027, true)]
	public void IsPrime(int n, bool expected)
	{
		var result = Math.IsPrime(n);

		Assert.Equal(expected, result);
	}
}
