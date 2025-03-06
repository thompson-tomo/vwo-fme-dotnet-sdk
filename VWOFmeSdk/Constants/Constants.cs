#pragma warning disable 1587
/**
 * Copyright 2024-2025 Wingify Software Pvt. Ltd.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *    http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */
#pragma warning restore 1587

using System;

namespace VWOFmeSdk.Constants
{
    public static class Constants
    {
        public const string PLATFORM = "server";

        public const int MAX_TRAFFIC_PERCENT = 100;
        public const int MAX_TRAFFIC_VALUE = 10000;
        public const string STATUS_RUNNING = "RUNNING";

        public const int SEED_VALUE = 1;
        public const int MAX_EVENTS_PER_REQUEST = 5000;
        public const long DEFAULT_REQUEST_TIME_INTERVAL = 600; // 10 * 60 (secs) = 600 secs i.e. 10 minutes
        public const int DEFAULT_EVENTS_PER_REQUEST = 100;
        public const string SDK_NAME = "vwo-fme-dotnet-sdk";
        public const int SETTINGS_EXPIRY = 10000000; // Changed from long to int
        public const int SETTINGS_TIMEOUT = 50000; // Changed from long to int

        public const string HOST_NAME = "dev.visualwebsiteoptimizer.com";
        public const string SETTINGS_ENDPOINT = "/server-side/v2-settings";
        public const string WEBHOOK_SETTINGS_ENDPOINT = "/server-side/v2-pull";

        public const string VWO_FS_ENVIRONMENT = "vwo_fs_environment";
        public const string HTTPS_PROTOCOL = "https";

        public const int RANDOM_ALGO = 1;
        
        public const string VWO_META_MEG_KEY = "_vwo_meta_meg_";
    }
}
