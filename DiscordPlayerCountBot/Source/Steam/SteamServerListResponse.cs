﻿using Newtonsoft.Json;

namespace PlayerCountBot
{
    public class SteamServerListResponse
    {
        [JsonProperty]
        public SteamServerListSubClass response { get; }

        public SteamServerListResponse()
        {
            response = new SteamServerListSubClass();
        }

        public SteamApiResponseData GetServerDataByPort(string port)
        {
            return response.GetAddressDataByPort(port);
        }
    }
}
