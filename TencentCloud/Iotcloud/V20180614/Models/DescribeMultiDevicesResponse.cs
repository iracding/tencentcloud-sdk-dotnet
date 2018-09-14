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

namespace TencentCloud.Iotcloud.V20180614.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeMultiDevicesResponse : AbstractModel
    {
        
        /// <summary>
        /// 任务 ID，由批量创建设备接口返回
        /// </summary>
        [JsonProperty("TaskId")]
        public string TaskId{ get; set; }

        /// <summary>
        /// 设备详细信息列表
        /// </summary>
        [JsonProperty("DevicesInfo")]
        public MultiDevicesInfo[] DevicesInfo{ get; set; }

        /// <summary>
        /// 该任务创建设备的总数
        /// </summary>
        [JsonProperty("TotalDevNum")]
        public ulong? TotalDevNum{ get; set; }

        /// <summary>
        /// 唯一请求ID，每次请求都会返回。定位问题时需要提供该次请求的RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// 内部实现，用户禁止调用
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TaskId", this.TaskId);
            this.SetParamArrayObj(map, prefix + "DevicesInfo.", this.DevicesInfo);
            this.SetParamSimple(map, prefix + "TotalDevNum", this.TotalDevNum);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

