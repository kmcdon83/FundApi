using Newtonsoft.Json;

namespace FundApi;

public class Funds
{
    public int count { get; set; }
    
    [JsonProperty("result")]
    public List<Fund>? funds { get; set; }
    
}
