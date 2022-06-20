using Newtonsoft.Json;

namespace FundApi;

public class FundPrice
{
  [JsonProperty("c")]
  public double currentPrice { get; set; }

  [JsonProperty("h")]
  public double highPriceOfDay { get; set; }      
  
  [JsonProperty("l")]
  public double lowPriceOfDay { get; set; }
      
  [JsonProperty("o")]
  public double openPrice { get; set; }
  
  [JsonProperty("pc")]
  public string previousClosePrice { get; set; }

  [JsonProperty("t")]
  public long time { get; set; }
}
