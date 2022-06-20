namespace FundApi.Services;

public interface IFundService
{
    Task<Funds> GetFunds(string search);
    Task<FundPrice> GetFundPrice(string symbol);
}