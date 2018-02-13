using System;
using Moq;
using Xunit;

namespace xunit_sample
{
	public interface ISomething {
		string ReturnSomething(IProduct product);
	}

	public class Something : ISomething
	{
		public string ReturnSomething(IProduct product)
		{
			return "something";
		}
	}

	public interface IProduct {
		string GetName();
	}

	public class Product : IProduct
	{
		public string GetName()
		{
			return "some name";
		}
	}

	public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
			var mockProduct = new Mock<IProduct>();

			var something = new Something();
			Assert.Equal("something", something.ReturnSomething(mockProduct.Object));
        }
    }
}
