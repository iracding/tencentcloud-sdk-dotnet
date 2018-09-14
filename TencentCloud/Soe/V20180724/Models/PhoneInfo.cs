/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */

namespace TencentCloud.Soe.V20180724.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class PhoneInfo : AbstractModel
    {
        
        /// <summary>
        /// 当前音节语音起始时间点，单位为ms
        /// </summary>
        [JsonProperty("MemBeginTime")]
        public long? MemBeginTime{ get; set; }

        /// <summary>
        /// 当前音节语音终止时间点，单位为ms
        /// </summary>
        [JsonProperty("MemEndTime")]
        public long? MemEndTime{ get; set; }

        /// <summary>
        /// 音节发音准确度，取值范围[-1, 100]，当取-1时指完全不匹配
        /// </summary>
        [JsonProperty("PronAccuracy")]
        public float? PronAccuracy{ get; set; }

        /// <summary>
        /// 当前音节是否检测为重音
        /// </summary>
        [JsonProperty("DetectedStress")]
        public bool? DetectedStress{ get; set; }

        /// <summary>
        /// 当前音节
        /// </summary>
        [JsonProperty("Phone")]
        public string Phone{ get; set; }

        /// <summary>
        /// 当前音节是否应为重音
        /// </summary>
        [JsonProperty("Stress")]
        public bool? Stress{ get; set; }


        /// <summary>
        /// 内部实现，用户禁止调用
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "MemBeginTime", this.MemBeginTime);
            this.SetParamSimple(map, prefix + "MemEndTime", this.MemEndTime);
            this.SetParamSimple(map, prefix + "PronAccuracy", this.PronAccuracy);
            this.SetParamSimple(map, prefix + "DetectedStress", this.DetectedStress);
            this.SetParamSimple(map, prefix + "Phone", this.Phone);
            this.SetParamSimple(map, prefix + "Stress", this.Stress);
        }
    }
}

