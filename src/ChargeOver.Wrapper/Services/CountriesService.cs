using ChargeOver.Wrapper.Models;

namespace ChargeOver.Wrapper.Services
{
	public sealed class CountriesService : BaseService, ICountriesService
	{
		public CountriesService(IChargeOverApiProvider provider) : base(provider)
		{
		}

		/// <summary>
		/// Retrieve country list
		/// details: https://developer.chargeover.com/apidocs/rest/#list-country
		/// </summary>
		public IResponse<Country> RetrieveCountryList()
		{
			return GetList<Country>("country");
		}
	}
}
