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

namespace TencentCloud.Nlp.V20190408.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class PosToken : AbstractModel
    {
        
        /// <summary>
        /// 起始位置
        /// </summary>
        [JsonProperty("BeginOffset")]
        public ulong? BeginOffset{ get; set; }

        /// <summary>
        /// 长度
        /// </summary>
        [JsonProperty("Length")]
        public ulong? Length{ get; set; }

        /// <summary>
        /// 词性
        /// </summary>
        [JsonProperty("Pos")]
        public string Pos{ get; set; }

        /// <summary>
        /// 基础词
        /// </summary>
        [JsonProperty("Word")]
        public string Word{ get; set; }


        /// <summary>
        /// 内部实现，用户禁止调用
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "BeginOffset", this.BeginOffset);
            this.SetParamSimple(map, prefix + "Length", this.Length);
            this.SetParamSimple(map, prefix + "Pos", this.Pos);
            this.SetParamSimple(map, prefix + "Word", this.Word);
        }
    }
}

