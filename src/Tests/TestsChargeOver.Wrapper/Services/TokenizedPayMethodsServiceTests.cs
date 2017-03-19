using System;
using ChargeOver.Wrapper.Models;
using ChargeOver.Wrapper.Services;
using NUnit.Framework;

namespace TestsChargeOver.Wrapper.Services
{
	[TestFixture]
	public sealed class TokenizedPayMethodsServiceTests
	{
		private TokenizedPayMethodsService Sut{get;set;}

		[SetUp]
		public void SetUp()
		{
			Sut = new TokenizedPayMethodsService(new ChargeOverApiProvider(ChargeOverAPIConfiguration.Config));
		}

		[Test]
		public void should_call_StorePayMethodToken()
		{
			//arrange
			var request = new StorePayMethodToken
			{
				CustomerId = 1,
				Token = "cus_5tSkoQ6mDrXOMQ",
				Type = "customer",
			};
			//act
			var actual = Sut.StorePayMethodToken(request);
			//assert
			Assert.AreEqual(200, actual.Code);
			Assert.IsEmpty(actual.Message);
			Assert.AreEqual("OK", actual.Status);
		}

		[Test]
		public void should_call_DeleteTokenizedPayMethod()
		{
			//arrange
			var request = new int
			{
			};
			//act
			var actual = Sut.DeleteTokenizedPayMethod(request);
			//assert
			Assert.AreEqual(200, actual.Code);
			Assert.IsEmpty(actual.Message);
			Assert.AreEqual("OK", actual.Status);
		}
	}
}