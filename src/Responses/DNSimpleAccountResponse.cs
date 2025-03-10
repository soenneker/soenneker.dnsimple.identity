﻿using System;
using System.Text.Json.Serialization;

namespace Soenneker.DNSimple.Identity.Responses;

public record DNSimpleAccountResponse
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("email")]
    public string Email { get; set; }

    [JsonPropertyName("plan_identifier")]
    public string PlanIdentifier { get; set; }

    [JsonPropertyName("created_at")]
    public DateTime CreatedAt { get; set; }

    [JsonPropertyName("updated_at")]
    public DateTime UpdatedAt { get; set; }
}