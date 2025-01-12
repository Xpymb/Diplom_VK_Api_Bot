﻿using System;

namespace VkApiBot.Models
{
    public static class AppSettings
    {
        public static ulong GroupId { get; private set; }
        public static string Token { get; private set; }
        public static string ApiVersion { get; private set; } = "5.131";
        public static string AdminId { get; private set; }
        public static string CallbackForm { get; private set; } = "https://docs.google.com/forms/d/e/1FAIpQLSdSlKu181UUls4rd9vA5xEZrDw154NAi3zEQdlw_yVq6dF1tQ/viewform";

        public static void SetToken(string token)
        {
            Token = token;
        }

        public static void SetGroupId(string groupId)
        {
            GroupId = Convert.ToUInt64(groupId);
        }

        public static void SetApiVersion(string apiVersion)
        {
            ApiVersion = apiVersion;
        }

        public static void SetAdminId(string adminId)
        {
            AdminId = adminId;
        }

        public static void SetCallbackForm(string url)
        {
            CallbackForm = url;
        }
    }
}