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

namespace VWOFmeSdk.Enums
{
    public enum UrlEnum
    {
        EVENTS,
        ATTRIBUTE_CHECK,
        GET_USER_DATA,
        BATCH_EVENTS
    }

    public static class UrlEnumExtensions
    {
        public static string GetUrl(this UrlEnum urlEnum)
        {
            switch (urlEnum)
            {
                case UrlEnum.EVENTS:
                    return "/events/t";
                case UrlEnum.ATTRIBUTE_CHECK:
                    return "/check-attribute";
                case UrlEnum.GET_USER_DATA:
                    return "/get-user-details";
                case UrlEnum.BATCH_EVENTS:
                    return "/server-side/batch-events-v2";
                default:
                    throw new ArgumentOutOfRangeException(nameof(urlEnum), urlEnum, null);
            }
        }
    }
}
