using System.Text.Json.Serialization;

namespace Soenneker.DNSimple.Identity.Responses;

public record DNSimpleWhoamiResponse
{
    [JsonPropertyName("data")]
    public DNSimpleDataResponse Data { get; set; } = null!;
}