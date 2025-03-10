using System.Text.Json.Serialization;

namespace Soenneker.DNSimple.Identity.Responses;

public record DNSimpleDataResponse
{
    [JsonPropertyName("user")]
    public DNSimpleUserResponse? User { get; set; }

    [JsonPropertyName("account")]
    public DNSimpleAccountResponse? Account { get; set; }
}