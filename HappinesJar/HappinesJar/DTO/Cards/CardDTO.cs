using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace HappinesJar.DTO.Cards
{
    public class CardDTO
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("text")]
        public string Text { get; set; }
    }
}
