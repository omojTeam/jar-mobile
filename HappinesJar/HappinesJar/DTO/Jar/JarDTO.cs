using HappinesJar.DTO.Cards;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace HappinesJar.Jar.DTO
{
    public class JarDTO
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("cardsPerDay")]
        public int CardsPerDay { get; set; }

        [JsonPropertyName("cardsLeftToday")]
        public int CardsLeftToday { get; set; }

        [JsonPropertyName("cardsLeft")]
        public int CardsLeft { get; set; }

        [JsonPropertyName("recipientEmail")]
        public string RecipientEmail { get; set; }

        [JsonPropertyName("cards")]
        public List<CardDTO> Cards { get; set; }
    }
}
