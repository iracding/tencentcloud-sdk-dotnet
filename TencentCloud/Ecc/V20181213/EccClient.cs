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

namespace TencentCloud.Ecc.V20181213
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Ecc.V20181213.Models;

   public class EccClient : AbstractClient{

       private const string endpoint = "ecc.tencentcloudapi.com";
       private const string version = "2018-12-13";

        /// <summary>
        /// 构造client
        /// </summary>
        /// <param name="credential">认证信息实例</param>
        /// <param name="region"> 产品地域</param>
        public EccClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        ///  构造client
        /// </summary>
        /// <param name="credential">认证信息实例</param>
        /// <param name="region">产品地域</param>
        /// <param name="profile">配置实例</param>
        public EccClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// 接口请求域名： ecc.tencentcloudapi.com 
        /// 纯文本英语作文批改
        /// </summary>
        /// <param name="req">参考<see cref="ECCRequest"/></param>
        /// <returns>参考<see cref="ECCResponse"/>实例</returns>
        public async Task<ECCResponse> ECC(ECCRequest req)
        {
             JsonResponseModel<ECCResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ECC");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ECCResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// https://ecc.tencentcloudapi.com/?Action=EHOCR
        /// 作文识别
        /// </summary>
        /// <param name="req">参考<see cref="EHOCRRequest"/></param>
        /// <returns>参考<see cref="EHOCRResponse"/>实例</returns>
        public async Task<EHOCRResponse> EHOCR(EHOCRRequest req)
        {
             JsonResponseModel<EHOCRResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "EHOCR");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<EHOCRResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
