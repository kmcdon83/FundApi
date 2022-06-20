using System.Net;
using Flurl;
using Flurl.Http;

namespace FundApi.Services;

public class FundService : IFundService
{
    private static string API_URI = "https://finnhub.io/api/v1/";
    private static string API_KEY = "###TOKEN###";

    public async Task<Funds> GetFunds(string search)
    {
        var funds = await API_URI
            .AppendPathSegment("search")
            .SetQueryParams(new { q = search, token = API_KEY })
            .GetAsync()
            .ReceiveJson<Funds>();
        return funds;
    }

    public async Task<FundPrice> GetFundPrice(string symbol)
    {
        var fundPrice = await API_URI
            .AppendPathSegment("quote")
            .SetQueryParams(new { symbol = symbol, token = API_KEY })
            .GetAsync()
            .ReceiveJson<FundPrice>();
        return fundPrice;
    }
}