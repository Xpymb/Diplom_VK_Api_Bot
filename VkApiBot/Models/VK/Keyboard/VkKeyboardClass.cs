﻿using System;
using System.Text.Json.Serialization;

namespace VkApiBot.Models.VK.Keyboard
{
    [Serializable]
    public class VkKeyboardClass
    {
        [JsonPropertyName("one_time")]
        public bool OneTime { get; set; }

        [JsonPropertyName("buttons")]
        public Button[][] Buttons { get; set; }
    }

    [Serializable]
    public class Button
    {
        [JsonPropertyName("action")]
        public Action Action { get; set; }

        [JsonPropertyName("color")]
        public string Color { get; set; }
    }

    [Serializable]
    public class Action
    {
        [JsonPropertyName("type")]
        public string ActionType { get; set; }

        [JsonPropertyName("payload")]
        public string Payload { get; set; }

        [JsonPropertyName("label")]
        public string Label { get; set; }

        [JsonPropertyName("link")]
        public string Link { get; set; }

        [JsonPropertyName("hash")]
        public string Hash { get; set; }

        [JsonPropertyName("app_id")]
        public string AppId { get; set; }

        [JsonPropertyName("owner_id")]
        public string OwnerId { get; set; }
    }
}
