using FundApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace FundApi.Controllers;

[ApiController]
[Route("[controller]/[action]")]
public class FundController : ControllerBase
{

    private readonly IFundService _fundService;

    private readonly ILogger<FundController> _logger;

    public FundController(ILogger<FundController> logger, IFundService fundService)
    {
        _logger = logger;
        _fundService = fundService;
    }

    [HttpGet(Name = "SearchFunds")]
    public async Task<Funds> SearchFunds(string search)
    {
        //validate search 
        return await _fundService.GetFunds(search);
    }
    
    [HttpGet(Name = "GetFundPrice")]
    public async Task<FundPrice> GetFundPrice(string symbol)
    {
        //validate symbol 
        return await _fundService.GetFundPrice(symbol);
    }
}
