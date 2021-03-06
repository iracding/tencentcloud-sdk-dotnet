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

namespace TencentCloud.Iotexplorer.V20190423
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Iotexplorer.V20190423.Models;

   public class IotexplorerClient : AbstractClient{

       private const string endpoint = "iotexplorer.tencentcloudapi.com";
       private const string version = "2019-04-23";

        /// <summary>
        /// 构造client
        /// </summary>
        /// <param name="credential">认证信息实例</param>
        /// <param name="region"> 产品地域</param>
        public IotexplorerClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        ///  构造client
        /// </summary>
        /// <param name="credential">认证信息实例</param>
        /// <param name="region">产品地域</param>
        /// <param name="profile">配置实例</param>
        public IotexplorerClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// 根据设备产品ID、设备名称，设置控制设备的属性数据。
        /// </summary>
        /// <param name="req">参考<see cref="ControlDeviceDataRequest"/></param>
        /// <returns>参考<see cref="ControlDeviceDataResponse"/>实例</returns>
        public async Task<ControlDeviceDataResponse> ControlDeviceData(ControlDeviceDataRequest req)
        {
             JsonResponseModel<ControlDeviceDataResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ControlDeviceData");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ControlDeviceDataResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 为用户提供新建项目的能力，用于集中管理产品和应用。
        /// </summary>
        /// <param name="req">参考<see cref="CreateProjectRequest"/></param>
        /// <returns>参考<see cref="CreateProjectResponse"/>实例</returns>
        public async Task<CreateProjectResponse> CreateProject(CreateProjectRequest req)
        {
             JsonResponseModel<CreateProjectResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateProject");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateProjectResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 为用户提供新建产品的能力，用于管理用户的设备
        /// </summary>
        /// <param name="req">参考<see cref="CreateStudioProductRequest"/></param>
        /// <returns>参考<see cref="CreateStudioProductResponse"/>实例</returns>
        public async Task<CreateStudioProductResponse> CreateStudioProduct(CreateStudioProductRequest req)
        {
             JsonResponseModel<CreateStudioProductResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateStudioProduct");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateStudioProductResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 提供删除某个项目的能力
        /// </summary>
        /// <param name="req">参考<see cref="DeleteProjectRequest"/></param>
        /// <returns>参考<see cref="DeleteProjectResponse"/>实例</returns>
        public async Task<DeleteProjectResponse> DeleteProject(DeleteProjectRequest req)
        {
             JsonResponseModel<DeleteProjectResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteProject");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteProjectResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 提供删除某个项目下产品的能力
        /// </summary>
        /// <param name="req">参考<see cref="DeleteStudioProductRequest"/></param>
        /// <returns>参考<see cref="DeleteStudioProductResponse"/>实例</returns>
        public async Task<DeleteStudioProductResponse> DeleteStudioProduct(DeleteStudioProductRequest req)
        {
             JsonResponseModel<DeleteStudioProductResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteStudioProduct");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteStudioProductResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 根据设备产品ID、设备名称，获取设备上报的属性数据。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeDeviceDataRequest"/></param>
        /// <returns>参考<see cref="DescribeDeviceDataResponse"/>实例</returns>
        public async Task<DescribeDeviceDataResponse> DescribeDeviceData(DescribeDeviceDataRequest req)
        {
             JsonResponseModel<DescribeDeviceDataResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDeviceData");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDeviceDataResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取设备在指定时间范围内上报的历史数据。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeDeviceDataHistoryRequest"/></param>
        /// <returns>参考<see cref="DescribeDeviceDataHistoryResponse"/>实例</returns>
        public async Task<DescribeDeviceDataHistoryResponse> DescribeDeviceDataHistory(DescribeDeviceDataHistoryRequest req)
        {
             JsonResponseModel<DescribeDeviceDataHistoryResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDeviceDataHistory");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDeviceDataHistoryResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询产品配置的数据模板信息
        /// </summary>
        /// <param name="req">参考<see cref="DescribeModelDefinitionRequest"/></param>
        /// <returns>参考<see cref="DescribeModelDefinitionResponse"/>实例</returns>
        public async Task<DescribeModelDefinitionResponse> DescribeModelDefinition(DescribeModelDefinitionRequest req)
        {
             JsonResponseModel<DescribeModelDefinitionResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeModelDefinition");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeModelDefinitionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询项目详情
        /// </summary>
        /// <param name="req">参考<see cref="DescribeProjectRequest"/></param>
        /// <returns>参考<see cref="DescribeProjectResponse"/>实例</returns>
        public async Task<DescribeProjectResponse> DescribeProject(DescribeProjectRequest req)
        {
             JsonResponseModel<DescribeProjectResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeProject");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeProjectResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 提供查看茶品详细信息的能力，包括产品的ID、数据协议、认证类型等重要参数
        /// </summary>
        /// <param name="req">参考<see cref="DescribeStudioProductRequest"/></param>
        /// <returns>参考<see cref="DescribeStudioProductResponse"/>实例</returns>
        public async Task<DescribeStudioProductResponse> DescribeStudioProduct(DescribeStudioProductRequest req)
        {
             JsonResponseModel<DescribeStudioProductResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeStudioProduct");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeStudioProductResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 提供查询用户所创建的项目列表查询功能。
        /// </summary>
        /// <param name="req">参考<see cref="GetProjectListRequest"/></param>
        /// <returns>参考<see cref="GetProjectListResponse"/>实例</returns>
        public async Task<GetProjectListResponse> GetProjectList(GetProjectListRequest req)
        {
             JsonResponseModel<GetProjectListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GetProjectList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetProjectListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 提供查询某个项目下所有产品信息的能力。
        /// </summary>
        /// <param name="req">参考<see cref="GetStudioProductListRequest"/></param>
        /// <returns>参考<see cref="GetStudioProductListResponse"/>实例</returns>
        public async Task<GetStudioProductListResponse> GetStudioProductList(GetStudioProductListRequest req)
        {
             JsonResponseModel<GetStudioProductListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GetStudioProductList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetStudioProductListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 提供修改产品的数据模板的能力
        /// </summary>
        /// <param name="req">参考<see cref="ModifyModelDefinitionRequest"/></param>
        /// <returns>参考<see cref="ModifyModelDefinitionResponse"/>实例</returns>
        public async Task<ModifyModelDefinitionResponse> ModifyModelDefinition(ModifyModelDefinitionRequest req)
        {
             JsonResponseModel<ModifyModelDefinitionResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyModelDefinition");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyModelDefinitionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改项目
        /// </summary>
        /// <param name="req">参考<see cref="ModifyProjectRequest"/></param>
        /// <returns>参考<see cref="ModifyProjectResponse"/>实例</returns>
        public async Task<ModifyProjectResponse> ModifyProject(ModifyProjectRequest req)
        {
             JsonResponseModel<ModifyProjectResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyProject");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyProjectResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 提供修改产品的名称和描述等信息的能力
        /// </summary>
        /// <param name="req">参考<see cref="ModifyStudioProductRequest"/></param>
        /// <returns>参考<see cref="ModifyStudioProductResponse"/>实例</returns>
        public async Task<ModifyStudioProductResponse> ModifyStudioProduct(ModifyStudioProductRequest req)
        {
             JsonResponseModel<ModifyStudioProductResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyStudioProduct");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyStudioProductResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 产品开发完成并测试通过后，通过发布产品将产品设置为发布状态
        /// </summary>
        /// <param name="req">参考<see cref="ReleaseStudioProductRequest"/></param>
        /// <returns>参考<see cref="ReleaseStudioProductResponse"/>实例</returns>
        public async Task<ReleaseStudioProductResponse> ReleaseStudioProduct(ReleaseStudioProductRequest req)
        {
             JsonResponseModel<ReleaseStudioProductResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ReleaseStudioProduct");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ReleaseStudioProductResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 提供根据产品名称查找产品的能力
        /// </summary>
        /// <param name="req">参考<see cref="SearchStudioProductRequest"/></param>
        /// <returns>参考<see cref="SearchStudioProductResponse"/>实例</returns>
        public async Task<SearchStudioProductResponse> SearchStudioProduct(SearchStudioProductRequest req)
        {
             JsonResponseModel<SearchStudioProductResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "SearchStudioProduct");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SearchStudioProductResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
