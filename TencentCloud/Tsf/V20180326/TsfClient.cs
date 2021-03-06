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

namespace TencentCloud.Tsf.V20180326
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Tsf.V20180326.Models;

   public class TsfClient : AbstractClient{

       private const string endpoint = "tsf.tencentcloudapi.com";
       private const string version = "2018-03-26";

        /// <summary>
        /// 构造client
        /// </summary>
        /// <param name="credential">认证信息实例</param>
        /// <param name="region"> 产品地域</param>
        public TsfClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        ///  构造client
        /// </summary>
        /// <param name="credential">认证信息实例</param>
        /// <param name="region">产品地域</param>
        /// <param name="profile">配置实例</param>
        public TsfClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// 添加云主机节点至TSF集群
        /// </summary>
        /// <param name="req">参考<see cref="AddInstancesRequest"/></param>
        /// <returns>参考<see cref="AddInstancesResponse"/>实例</returns>
        public async Task<AddInstancesResponse> AddInstances(AddInstancesRequest req)
        {
             JsonResponseModel<AddInstancesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "AddInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AddInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建应用
        /// </summary>
        /// <param name="req">参考<see cref="CreateApplicationRequest"/></param>
        /// <returns>参考<see cref="CreateApplicationResponse"/>实例</returns>
        public async Task<CreateApplicationResponse> CreateApplication(CreateApplicationRequest req)
        {
             JsonResponseModel<CreateApplicationResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateApplication");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateApplicationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建集群
        /// </summary>
        /// <param name="req">参考<see cref="CreateClusterRequest"/></param>
        /// <returns>参考<see cref="CreateClusterResponse"/>实例</returns>
        public async Task<CreateClusterResponse> CreateCluster(CreateClusterRequest req)
        {
             JsonResponseModel<CreateClusterResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateCluster");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateClusterResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建容器部署组
        /// </summary>
        /// <param name="req">参考<see cref="CreateContainGroupRequest"/></param>
        /// <returns>参考<see cref="CreateContainGroupResponse"/>实例</returns>
        public async Task<CreateContainGroupResponse> CreateContainGroup(CreateContainGroupRequest req)
        {
             JsonResponseModel<CreateContainGroupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateContainGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateContainGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建容器部署组
        /// </summary>
        /// <param name="req">参考<see cref="CreateGroupRequest"/></param>
        /// <returns>参考<see cref="CreateGroupResponse"/>实例</returns>
        public async Task<CreateGroupResponse> CreateGroup(CreateGroupRequest req)
        {
             JsonResponseModel<CreateGroupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 新增微服务
        /// </summary>
        /// <param name="req">参考<see cref="CreateMicroserviceRequest"/></param>
        /// <returns>参考<see cref="CreateMicroserviceResponse"/>实例</returns>
        public async Task<CreateMicroserviceResponse> CreateMicroservice(CreateMicroserviceRequest req)
        {
             JsonResponseModel<CreateMicroserviceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateMicroservice");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateMicroserviceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建命名空间
        /// </summary>
        /// <param name="req">参考<see cref="CreateNamespaceRequest"/></param>
        /// <returns>参考<see cref="CreateNamespaceResponse"/>实例</returns>
        public async Task<CreateNamespaceResponse> CreateNamespace(CreateNamespaceRequest req)
        {
             JsonResponseModel<CreateNamespaceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateNamespace");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateNamespaceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除应用
        /// </summary>
        /// <param name="req">参考<see cref="DeleteApplicationRequest"/></param>
        /// <returns>参考<see cref="DeleteApplicationResponse"/>实例</returns>
        public async Task<DeleteApplicationResponse> DeleteApplication(DeleteApplicationRequest req)
        {
             JsonResponseModel<DeleteApplicationResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteApplication");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteApplicationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除容器部署组
        /// </summary>
        /// <param name="req">参考<see cref="DeleteContainerGroupRequest"/></param>
        /// <returns>参考<see cref="DeleteContainerGroupResponse"/>实例</returns>
        public async Task<DeleteContainerGroupResponse> DeleteContainerGroup(DeleteContainerGroupRequest req)
        {
             JsonResponseModel<DeleteContainerGroupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteContainerGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteContainerGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除容器部署组
        /// </summary>
        /// <param name="req">参考<see cref="DeleteGroupRequest"/></param>
        /// <returns>参考<see cref="DeleteGroupResponse"/>实例</returns>
        public async Task<DeleteGroupResponse> DeleteGroup(DeleteGroupRequest req)
        {
             JsonResponseModel<DeleteGroupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 批量删除镜像版本
        /// </summary>
        /// <param name="req">参考<see cref="DeleteImageTagsRequest"/></param>
        /// <returns>参考<see cref="DeleteImageTagsResponse"/>实例</returns>
        public async Task<DeleteImageTagsResponse> DeleteImageTags(DeleteImageTagsRequest req)
        {
             JsonResponseModel<DeleteImageTagsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteImageTags");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteImageTagsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除微服务
        /// </summary>
        /// <param name="req">参考<see cref="DeleteMicroserviceRequest"/></param>
        /// <returns>参考<see cref="DeleteMicroserviceResponse"/>实例</returns>
        public async Task<DeleteMicroserviceResponse> DeleteMicroservice(DeleteMicroserviceRequest req)
        {
             JsonResponseModel<DeleteMicroserviceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteMicroservice");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteMicroserviceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除命名空间
        /// </summary>
        /// <param name="req">参考<see cref="DeleteNamespaceRequest"/></param>
        /// <returns>参考<see cref="DeleteNamespaceResponse"/>实例</returns>
        public async Task<DeleteNamespaceResponse> DeleteNamespace(DeleteNamespaceRequest req)
        {
             JsonResponseModel<DeleteNamespaceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteNamespace");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteNamespaceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 从软件仓库批量删除程序包。
        /// 一次最多支持删除1000个包，数量超过1000，返回UpperDeleteLimit错误。
        /// </summary>
        /// <param name="req">参考<see cref="DeletePkgsRequest"/></param>
        /// <returns>参考<see cref="DeletePkgsResponse"/>实例</returns>
        public async Task<DeletePkgsResponse> DeletePkgs(DeletePkgsRequest req)
        {
             JsonResponseModel<DeletePkgsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeletePkgs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeletePkgsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 部署容器应用
        /// </summary>
        /// <param name="req">参考<see cref="DeployContainerGroupRequest"/></param>
        /// <returns>参考<see cref="DeployContainerGroupResponse"/>实例</returns>
        public async Task<DeployContainerGroupResponse> DeployContainerGroup(DeployContainerGroupRequest req)
        {
             JsonResponseModel<DeployContainerGroupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeployContainerGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeployContainerGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 部署虚拟机部署组应用
        /// </summary>
        /// <param name="req">参考<see cref="DeployGroupRequest"/></param>
        /// <returns>参考<see cref="DeployGroupResponse"/>实例</returns>
        public async Task<DeployGroupResponse> DeployGroup(DeployGroupRequest req)
        {
             JsonResponseModel<DeployGroupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeployGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeployGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取应用详情
        /// </summary>
        /// <param name="req">参考<see cref="DescribeApplicationRequest"/></param>
        /// <returns>参考<see cref="DescribeApplicationResponse"/>实例</returns>
        public async Task<DescribeApplicationResponse> DescribeApplication(DescribeApplicationRequest req)
        {
             JsonResponseModel<DescribeApplicationResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeApplication");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeApplicationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取应用列表其它字段，如实例数量信息等
        /// </summary>
        /// <param name="req">参考<see cref="DescribeApplicationAttributeRequest"/></param>
        /// <returns>参考<see cref="DescribeApplicationAttributeResponse"/>实例</returns>
        public async Task<DescribeApplicationAttributeResponse> DescribeApplicationAttribute(DescribeApplicationAttributeRequest req)
        {
             JsonResponseModel<DescribeApplicationAttributeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeApplicationAttribute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeApplicationAttributeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取应用列表
        /// </summary>
        /// <param name="req">参考<see cref="DescribeApplicationsRequest"/></param>
        /// <returns>参考<see cref="DescribeApplicationsResponse"/>实例</returns>
        public async Task<DescribeApplicationsResponse> DescribeApplications(DescribeApplicationsRequest req)
        {
             JsonResponseModel<DescribeApplicationsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeApplications");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeApplicationsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询集群实例
        /// </summary>
        /// <param name="req">参考<see cref="DescribeClusterInstancesRequest"/></param>
        /// <returns>参考<see cref="DescribeClusterInstancesResponse"/>实例</returns>
        public async Task<DescribeClusterInstancesResponse> DescribeClusterInstances(DescribeClusterInstancesRequest req)
        {
             JsonResponseModel<DescribeClusterInstancesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeClusterInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeClusterInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        ///  容器部署组详情
        /// </summary>
        /// <param name="req">参考<see cref="DescribeContainerGroupDetailRequest"/></param>
        /// <returns>参考<see cref="DescribeContainerGroupDetailResponse"/>实例</returns>
        public async Task<DescribeContainerGroupDetailResponse> DescribeContainerGroupDetail(DescribeContainerGroupDetailRequest req)
        {
             JsonResponseModel<DescribeContainerGroupDetailResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeContainerGroupDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeContainerGroupDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 容器部署组列表
        /// </summary>
        /// <param name="req">参考<see cref="DescribeContainerGroupsRequest"/></param>
        /// <returns>参考<see cref="DescribeContainerGroupsResponse"/>实例</returns>
        public async Task<DescribeContainerGroupsResponse> DescribeContainerGroups(DescribeContainerGroupsRequest req)
        {
             JsonResponseModel<DescribeContainerGroupsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeContainerGroups");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeContainerGroupsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// TSF上传的程序包存放在腾讯云对象存储（COS）中，通过该API可以获取从COS下载程序包需要的信息，包括包所在的桶、存储路径、鉴权信息等，之后使用COS API（或SDK）进行下载。
        /// COS相关文档请查阅：https://cloud.tencent.com/document/product/436
        /// </summary>
        /// <param name="req">参考<see cref="DescribeDownloadInfoRequest"/></param>
        /// <returns>参考<see cref="DescribeDownloadInfoResponse"/>实例</returns>
        public async Task<DescribeDownloadInfoResponse> DescribeDownloadInfo(DescribeDownloadInfoRequest req)
        {
             JsonResponseModel<DescribeDownloadInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDownloadInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDownloadInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询虚拟机部署组详情
        /// </summary>
        /// <param name="req">参考<see cref="DescribeGroupRequest"/></param>
        /// <returns>参考<see cref="DescribeGroupResponse"/>实例</returns>
        public async Task<DescribeGroupResponse> DescribeGroup(DescribeGroupRequest req)
        {
             JsonResponseModel<DescribeGroupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询虚拟机部署组云主机列表
        /// </summary>
        /// <param name="req">参考<see cref="DescribeGroupInstancesRequest"/></param>
        /// <returns>参考<see cref="DescribeGroupInstancesResponse"/>实例</returns>
        public async Task<DescribeGroupInstancesResponse> DescribeGroupInstances(DescribeGroupInstancesRequest req)
        {
             JsonResponseModel<DescribeGroupInstancesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeGroupInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeGroupInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取虚拟机部署组列表
        /// </summary>
        /// <param name="req">参考<see cref="DescribeGroupsRequest"/></param>
        /// <returns>参考<see cref="DescribeGroupsResponse"/>实例</returns>
        public async Task<DescribeGroupsResponse> DescribeGroups(DescribeGroupsRequest req)
        {
             JsonResponseModel<DescribeGroupsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeGroups");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeGroupsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 镜像版本列表
        /// </summary>
        /// <param name="req">参考<see cref="DescribeImageTagsRequest"/></param>
        /// <returns>参考<see cref="DescribeImageTagsResponse"/>实例</returns>
        public async Task<DescribeImageTagsResponse> DescribeImageTags(DescribeImageTagsRequest req)
        {
             JsonResponseModel<DescribeImageTagsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeImageTags");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeImageTagsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询微服务详情
        /// </summary>
        /// <param name="req">参考<see cref="DescribeMicroserviceRequest"/></param>
        /// <returns>参考<see cref="DescribeMicroserviceResponse"/>实例</returns>
        public async Task<DescribeMicroserviceResponse> DescribeMicroservice(DescribeMicroserviceRequest req)
        {
             JsonResponseModel<DescribeMicroserviceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeMicroservice");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeMicroserviceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取微服务列表
        /// </summary>
        /// <param name="req">参考<see cref="DescribeMicroservicesRequest"/></param>
        /// <returns>参考<see cref="DescribeMicroservicesResponse"/>实例</returns>
        public async Task<DescribeMicroservicesResponse> DescribeMicroservices(DescribeMicroservicesRequest req)
        {
             JsonResponseModel<DescribeMicroservicesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeMicroservices");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeMicroservicesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 无
        /// </summary>
        /// <param name="req">参考<see cref="DescribePkgsRequest"/></param>
        /// <returns>参考<see cref="DescribePkgsResponse"/>实例</returns>
        public async Task<DescribePkgsResponse> DescribePkgs(DescribePkgsRequest req)
        {
             JsonResponseModel<DescribePkgsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribePkgs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePkgsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询简单应用列表
        /// </summary>
        /// <param name="req">参考<see cref="DescribeSimpleApplicationsRequest"/></param>
        /// <returns>参考<see cref="DescribeSimpleApplicationsResponse"/>实例</returns>
        public async Task<DescribeSimpleApplicationsResponse> DescribeSimpleApplications(DescribeSimpleApplicationsRequest req)
        {
             JsonResponseModel<DescribeSimpleApplicationsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeSimpleApplications");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSimpleApplicationsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询简单集群列表
        /// </summary>
        /// <param name="req">参考<see cref="DescribeSimpleClustersRequest"/></param>
        /// <returns>参考<see cref="DescribeSimpleClustersResponse"/>实例</returns>
        public async Task<DescribeSimpleClustersResponse> DescribeSimpleClusters(DescribeSimpleClustersRequest req)
        {
             JsonResponseModel<DescribeSimpleClustersResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeSimpleClusters");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSimpleClustersResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询简单部署组列表
        /// </summary>
        /// <param name="req">参考<see cref="DescribeSimpleGroupsRequest"/></param>
        /// <returns>参考<see cref="DescribeSimpleGroupsResponse"/>实例</returns>
        public async Task<DescribeSimpleGroupsResponse> DescribeSimpleGroups(DescribeSimpleGroupsRequest req)
        {
             JsonResponseModel<DescribeSimpleGroupsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeSimpleGroups");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSimpleGroupsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询简单命名空间列表 
        /// </summary>
        /// <param name="req">参考<see cref="DescribeSimpleNamespacesRequest"/></param>
        /// <returns>参考<see cref="DescribeSimpleNamespacesResponse"/>实例</returns>
        public async Task<DescribeSimpleNamespacesResponse> DescribeSimpleNamespaces(DescribeSimpleNamespacesRequest req)
        {
             JsonResponseModel<DescribeSimpleNamespacesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeSimpleNamespaces");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSimpleNamespacesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// TSF会将软件包上传到腾讯云对象存储（COS）。调用此接口获取上传信息，如目标地域，桶，包Id，存储路径，鉴权信息等，之后请使用COS API（或SDK）进行上传。
        /// COS相关文档请查阅：https://cloud.tencent.com/document/product/436
        /// </summary>
        /// <param name="req">参考<see cref="DescribeUploadInfoRequest"/></param>
        /// <returns>参考<see cref="DescribeUploadInfoResponse"/>实例</returns>
        public async Task<DescribeUploadInfoResponse> DescribeUploadInfo(DescribeUploadInfoRequest req)
        {
             JsonResponseModel<DescribeUploadInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeUploadInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeUploadInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 虚拟机部署组添加实例
        /// </summary>
        /// <param name="req">参考<see cref="ExpandGroupRequest"/></param>
        /// <returns>参考<see cref="ExpandGroupResponse"/>实例</returns>
        public async Task<ExpandGroupResponse> ExpandGroup(ExpandGroupRequest req)
        {
             JsonResponseModel<ExpandGroupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ExpandGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ExpandGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改容器部署组
        /// </summary>
        /// <param name="req">参考<see cref="ModifyContainerGroupRequest"/></param>
        /// <returns>参考<see cref="ModifyContainerGroupResponse"/>实例</returns>
        public async Task<ModifyContainerGroupResponse> ModifyContainerGroup(ModifyContainerGroupRequest req)
        {
             JsonResponseModel<ModifyContainerGroupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyContainerGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyContainerGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改容器部署组实例数
        /// </summary>
        /// <param name="req">参考<see cref="ModifyContainerReplicasRequest"/></param>
        /// <returns>参考<see cref="ModifyContainerReplicasResponse"/>实例</returns>
        public async Task<ModifyContainerReplicasResponse> ModifyContainerReplicas(ModifyContainerReplicasRequest req)
        {
             JsonResponseModel<ModifyContainerReplicasResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyContainerReplicas");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyContainerReplicasResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改微服务详情
        /// </summary>
        /// <param name="req">参考<see cref="ModifyMicroserviceRequest"/></param>
        /// <returns>参考<see cref="ModifyMicroserviceResponse"/>实例</returns>
        public async Task<ModifyMicroserviceResponse> ModifyMicroservice(ModifyMicroserviceRequest req)
        {
             JsonResponseModel<ModifyMicroserviceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyMicroservice");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyMicroserviceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 调用该接口和COS的上传接口后，需要调用此接口更新TSF中保存的程序包状态。
        /// 调用此接口完成后，才标志上传包流程结束。
        /// </summary>
        /// <param name="req">参考<see cref="ModifyUploadInfoRequest"/></param>
        /// <returns>参考<see cref="ModifyUploadInfoResponse"/>实例</returns>
        public async Task<ModifyUploadInfoResponse> ModifyUploadInfo(ModifyUploadInfoRequest req)
        {
             JsonResponseModel<ModifyUploadInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyUploadInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyUploadInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 从 TSF 集群中批量移除云主机节点
        /// </summary>
        /// <param name="req">参考<see cref="RemoveInstancesRequest"/></param>
        /// <returns>参考<see cref="RemoveInstancesResponse"/>实例</returns>
        public async Task<RemoveInstancesResponse> RemoveInstances(RemoveInstancesRequest req)
        {
             JsonResponseModel<RemoveInstancesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "RemoveInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RemoveInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 下线部署组所有机器实例
        /// </summary>
        /// <param name="req">参考<see cref="ShrinkGroupRequest"/></param>
        /// <returns>参考<see cref="ShrinkGroupResponse"/>实例</returns>
        public async Task<ShrinkGroupResponse> ShrinkGroup(ShrinkGroupRequest req)
        {
             JsonResponseModel<ShrinkGroupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ShrinkGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ShrinkGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 虚拟机部署组下线实例
        /// </summary>
        /// <param name="req">参考<see cref="ShrinkInstancesRequest"/></param>
        /// <returns>参考<see cref="ShrinkInstancesResponse"/>实例</returns>
        public async Task<ShrinkInstancesResponse> ShrinkInstances(ShrinkInstancesRequest req)
        {
             JsonResponseModel<ShrinkInstancesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ShrinkInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ShrinkInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 启动容器部署组
        /// </summary>
        /// <param name="req">参考<see cref="StartContainerGroupRequest"/></param>
        /// <returns>参考<see cref="StartContainerGroupResponse"/>实例</returns>
        public async Task<StartContainerGroupResponse> StartContainerGroup(StartContainerGroupRequest req)
        {
             JsonResponseModel<StartContainerGroupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "StartContainerGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<StartContainerGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 启动分组
        /// </summary>
        /// <param name="req">参考<see cref="StartGroupRequest"/></param>
        /// <returns>参考<see cref="StartGroupResponse"/>实例</returns>
        public async Task<StartGroupResponse> StartGroup(StartGroupRequest req)
        {
             JsonResponseModel<StartGroupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "StartGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<StartGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 停止容器部署组
        /// </summary>
        /// <param name="req">参考<see cref="StopContainerGroupRequest"/></param>
        /// <returns>参考<see cref="StopContainerGroupResponse"/>实例</returns>
        public async Task<StopContainerGroupResponse> StopContainerGroup(StopContainerGroupRequest req)
        {
             JsonResponseModel<StopContainerGroupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "StopContainerGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<StopContainerGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 停止虚拟机部署组
        /// </summary>
        /// <param name="req">参考<see cref="StopGroupRequest"/></param>
        /// <returns>参考<see cref="StopGroupResponse"/>实例</returns>
        public async Task<StopGroupResponse> StopGroup(StopGroupRequest req)
        {
             JsonResponseModel<StopGroupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "StopGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<StopGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
