using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.Bms.V1.Model;

namespace HuaweiCloud.SDK.Bms.V1
{
    public partial class BmsAsyncClient : Client
    {
        public static ClientBuilder<BmsAsyncClient> NewBuilder()
        {
            return new ClientBuilder<BmsAsyncClient>();
        }

        
        /// <summary>
        /// 裸金属服务器挂载云硬盘
        ///
        /// 裸金属服务器创建成功后，如果发现磁盘不够用或者当前磁盘不满足要求，可以将已有云硬盘挂载给裸金属服务器，作为数据盘使用
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
        /// </summary>
        public async Task<AttachBaremetalServerVolumeResponse> AttachBaremetalServerVolumeAsync(AttachBaremetalServerVolumeRequest attachBaremetalServerVolumeRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("server_id" , attachBaremetalServerVolumeRequest.ServerId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/baremetalservers/{server_id}/attachvolume",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", attachBaremetalServerVolumeRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<AttachBaremetalServerVolumeResponse>(response);
        }
        
        /// <summary>
        /// 批量添加裸金属服务器标签
        ///
        /// - 为指定裸金属服务器批量添加标签。
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
        /// </summary>
        public async Task<BatchCreateBaremetalServerTagsResponse> BatchCreateBaremetalServerTagsAsync(BatchCreateBaremetalServerTagsRequest batchCreateBaremetalServerTagsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("server_id" , batchCreateBaremetalServerTagsRequest.ServerId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/baremetalservers/{server_id}/tags/action",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchCreateBaremetalServerTagsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerializeNull<BatchCreateBaremetalServerTagsResponse>(response);
        }
        
        /// <summary>
        /// 批量删除l裸金属服务器标签
        ///
        /// - 为指定云服务器批量删除标签。
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
        /// </summary>
        public async Task<BatchDeleteBaremetalServerTagsResponse> BatchDeleteBaremetalServerTagsAsync(BatchDeleteBaremetalServerTagsRequest batchDeleteBaremetalServerTagsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("server_id" , batchDeleteBaremetalServerTagsRequest.ServerId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/baremetalservers/{server_id}/tags/action",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchDeleteBaremetalServerTagsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerializeNull<BatchDeleteBaremetalServerTagsResponse>(response);
        }
        
        /// <summary>
        /// 重启裸金属服务器
        ///
        /// 根据给定的裸金属服务器ID列表，批量重启裸金属服务器
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
        /// </summary>
        public async Task<BatchRebootBaremetalServersResponse> BatchRebootBaremetalServersAsync(BatchRebootBaremetalServersRequest batchRebootBaremetalServersRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/baremetalservers/action",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchRebootBaremetalServersRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<BatchRebootBaremetalServersResponse>(response);
        }
        
        /// <summary>
        /// 启动裸金属服务器
        ///
        /// 根据给定的裸金属服务器ID列表，批量启动裸金属服务器
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
        /// </summary>
        public async Task<BatchStartBaremetalServersResponse> BatchStartBaremetalServersAsync(BatchStartBaremetalServersRequest batchStartBaremetalServersRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/baremetalservers/action",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchStartBaremetalServersRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<BatchStartBaremetalServersResponse>(response);
        }
        
        /// <summary>
        /// 关闭裸金属服务器
        ///
        /// 根据给定的裸金属服务器ID列表，批量关闭裸金属服务器
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
        /// </summary>
        public async Task<BatchStopBaremetalServersResponse> BatchStopBaremetalServersAsync(BatchStopBaremetalServersRequest batchStopBaremetalServersRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/baremetalservers/action",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchStopBaremetalServersRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<BatchStopBaremetalServersResponse>(response);
        }
        
        /// <summary>
        /// 修改裸金属服务器名称
        ///
        /// 修改裸金属服务器名称
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
        /// </summary>
        public async Task<ChangeBaremetalServerNameResponse> ChangeBaremetalServerNameAsync(ChangeBaremetalServerNameRequest changeBaremetalServerNameRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("server_id" , changeBaremetalServerNameRequest.ServerId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/baremetalservers/{server_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", changeBaremetalServerNameRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<ChangeBaremetalServerNameResponse>(response);
        }
        
        /// <summary>
        /// 
        ///
        /// 切换裸金属服务器的操作系统。切换操作系统支持密码或者密钥注入，该接口支持企业项目细粒度权限的校验，具体细粒度请参见 bms:servers:changeOS
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
        /// </summary>
        public async Task<ChangeBaremetalServerOsResponse> ChangeBaremetalServerOsAsync(ChangeBaremetalServerOsRequest changeBaremetalServerOsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("server_id" , changeBaremetalServerOsRequest.ServerId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/baremetalservers/{server_id}/changeos",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", changeBaremetalServerOsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<ChangeBaremetalServerOsResponse>(response);
        }
        
        /// <summary>
        /// 创建裸金属服务器
        ///
        /// 创建一台或多台裸金属服务器,裸金属服务器的登录鉴权方式包括两种：密钥对、密码。为安全起见，推荐使用密钥对方式
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
        /// </summary>
        public async Task<CreateBareMetalServersResponse> CreateBareMetalServersAsync(CreateBareMetalServersRequest createBareMetalServersRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/baremetalservers",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createBareMetalServersRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateBareMetalServersResponse>(response);
        }
        
        /// <summary>
        /// Windows裸金属服务器清除密码
        ///
        /// 清除Windows裸金属服务器初始安装时系统生成的密码记录。清除密码后，不影响裸金属服务器密码登录功能，但不能再使用获取密码功能来查询该裸金属服务器密码。如果裸金属服务器是通过私有镜像创建的，请确保已安装Cloudbase-init。公共镜像默认已安装该软件
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteWindowsBareMetalServerPasswordResponse> DeleteWindowsBareMetalServerPasswordAsync(DeleteWindowsBareMetalServerPasswordRequest deleteWindowsBareMetalServerPasswordRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("server_id" , deleteWindowsBareMetalServerPasswordRequest.ServerId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/baremetalservers/{server_id}/os-server-password",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteWindowsBareMetalServerPasswordRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteWindowsBareMetalServerPasswordResponse>(response);
        }
        
        /// <summary>
        /// 裸金属服务器卸载云磁盘
        ///
        /// 将挂载至裸金属服务器中的磁盘卸载；对于挂载在系统盘盘位（也就是“/dev/sda”挂载点）上的磁盘，不允许执行卸载操作；对于挂载在数据盘盘位（非“/dev/sda”挂载点）上的磁盘，支持离线卸载和在线卸载（裸金属服务器处于“运行中”状态）磁盘
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
        /// </summary>
        public async Task<DetachBaremetalServerVolumeResponse> DetachBaremetalServerVolumeAsync(DetachBaremetalServerVolumeRequest detachBaremetalServerVolumeRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("server_id" , detachBaremetalServerVolumeRequest.ServerId.ToString());
            urlParam.Add("attachment_id" , detachBaremetalServerVolumeRequest.AttachmentId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/baremetalservers/{server_id}/detachvolume/{attachment_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", detachBaremetalServerVolumeRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerialize<DetachBaremetalServerVolumeResponse>(response);
        }
        
        /// <summary>
        /// 查询裸金属服务器详情
        ///
        /// 获取裸金属服务器详细信息，该接口支持查询裸金属服务器的计费方式，以及是否被冻结
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
        /// </summary>
        public async Task<ListBareMetalServerDetailsResponse> ListBareMetalServerDetailsAsync(ListBareMetalServerDetailsRequest listBareMetalServerDetailsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("server_id" , listBareMetalServerDetailsRequest.ServerId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/baremetalservers/{server_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listBareMetalServerDetailsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListBareMetalServerDetailsResponse>(response);
        }
        
        /// <summary>
        /// 查询裸金属服务器详情列表
        ///
        /// 用户根据设置的请求条件筛选裸金属服务器，并获取裸金属服务器的详细信息。该接口支持查询裸金属服务器计费方式，以及是否被冻结。
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
        /// </summary>
        public async Task<ListBareMetalServersResponse> ListBareMetalServersAsync(ListBareMetalServersRequest listBareMetalServersRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/baremetalservers/detail",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listBareMetalServersRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListBareMetalServersResponse>(response);
        }
        
        /// <summary>
        /// 查询规格详情和规格扩展信息列表
        ///
        /// 查询裸金属服务器的规格详情和规格的扩展信息。您可以调用此接口查询“baremetal:extBootType”参数取值，以确认某个规格是否支持快速发放
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
        /// </summary>
        public async Task<ListBaremetalFlavorDetailExtendsResponse> ListBaremetalFlavorDetailExtendsAsync(ListBaremetalFlavorDetailExtendsRequest listBaremetalFlavorDetailExtendsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/baremetalservers/flavors",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listBaremetalFlavorDetailExtendsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListBaremetalFlavorDetailExtendsResponse>(response);
        }
        
        /// <summary>
        /// 重装裸金属服务器操作系统
        ///
        /// 重装裸金属服务器的操作系统。快速发放裸金属服务器支持裸金属服务器数据盘不变的情况下，使用原镜像重装系统盘。重装操作系统支持密码或者密钥注入
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
        /// </summary>
        public async Task<ReinstallBaremetalServerOsResponse> ReinstallBaremetalServerOsAsync(ReinstallBaremetalServerOsRequest reinstallBaremetalServerOsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("server_id" , reinstallBaremetalServerOsRequest.ServerId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/baremetalservers/{server_id}/reinstallos",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", reinstallBaremetalServerOsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<ReinstallBaremetalServerOsResponse>(response);
        }
        
        /// <summary>
        /// 一键重置裸金属服务器密码
        ///
        /// 在裸金属服务器支持一键重置密码功能的前提下，重置裸金属服务器管理帐号（root用户或Administrator用户）的密码。可以通过6.10.1-查询是否支持一键重置密码API查询是否支持一键重置密码。
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
        /// </summary>
        public async Task<ResetPwdOneClickResponse> ResetPwdOneClickAsync(ResetPwdOneClickRequest resetPwdOneClickRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("server_id" , resetPwdOneClickRequest.ServerId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/baremetalservers/{server_id}/os-reset-password",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", resetPwdOneClickRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerializeNull<ResetPwdOneClickResponse>(response);
        }
        
        /// <summary>
        /// 查询裸金属服务器网卡信息
        ///
        /// 查询裸金属服务器的网卡信息，比如网卡的IP地址、MAC地址
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
        /// </summary>
        public async Task<ShowBaremetalServerInterfaceAttachmentsResponse> ShowBaremetalServerInterfaceAttachmentsAsync(ShowBaremetalServerInterfaceAttachmentsRequest showBaremetalServerInterfaceAttachmentsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("server_id" , showBaremetalServerInterfaceAttachmentsRequest.ServerId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/baremetalservers/{server_id}/os-interface",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showBaremetalServerInterfaceAttachmentsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowBaremetalServerInterfaceAttachmentsResponse>(response);
        }
        
        /// <summary>
        /// 查询裸金属服务器标签
        ///
        /// - 查询指定云服务器的标签信息。
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
        /// </summary>
        public async Task<ShowBaremetalServerTagsResponse> ShowBaremetalServerTagsAsync(ShowBaremetalServerTagsRequest showBaremetalServerTagsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("server_id" , showBaremetalServerTagsRequest.ServerId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/baremetalservers/{server_id}/tags",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showBaremetalServerTagsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowBaremetalServerTagsResponse>(response);
        }
        
        /// <summary>
        /// 查询裸金属服务器挂载的云硬盘信息
        ///
        /// 查询裸金属服务器挂载的磁盘信息
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
        /// </summary>
        public async Task<ShowBaremetalServerVolumeInfoResponse> ShowBaremetalServerVolumeInfoAsync(ShowBaremetalServerVolumeInfoRequest showBaremetalServerVolumeInfoRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("server_id" , showBaremetalServerVolumeInfoRequest.ServerId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/baremetalservers/{server_id}/os-volume_attachments",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showBaremetalServerVolumeInfoRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowBaremetalServerVolumeInfoResponse>(response);
        }
        
        /// <summary>
        /// 查询是否支持一键重置密码
        ///
        /// 查询是否支持一键重置密码
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
        /// </summary>
        public async Task<ShowResetPwdResponse> ShowResetPwdAsync(ShowResetPwdRequest showResetPwdRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("server_id" , showResetPwdRequest.ServerId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/baremetalservers/{server_id}/os-resetpwd-flag",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showResetPwdRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowResetPwdResponse>(response);
        }
        
        /// <summary>
        /// 查询租户配额
        ///
        /// 查询该租户下，所有资源的配额信息，包括已使用配额
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
        /// </summary>
        public async Task<ShowTenantQuotaResponse> ShowTenantQuotaAsync(ShowTenantQuotaRequest showTenantQuotaRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/baremetalservers/limits",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showTenantQuotaRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowTenantQuotaResponse>(response);
        }
        
        /// <summary>
        /// Windows裸金属服务器获取密码
        ///
        /// 获取Windows裸金属服务器初始安装时系统生成的管理员帐户（Administrator帐户或Cloudbase-init设置的帐户）随机密码。如果裸金属服务器是通过私有镜像创建的，请确保已安装Cloudbase-init。公共镜像默认已安装该软件
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
        /// </summary>
        public async Task<ShowWindowsBaremetalServerPwdResponse> ShowWindowsBaremetalServerPwdAsync(ShowWindowsBaremetalServerPwdRequest showWindowsBaremetalServerPwdRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("server_id" , showWindowsBaremetalServerPwdRequest.ServerId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/baremetalservers/{server_id}/os-server-password",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showWindowsBaremetalServerPwdRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowWindowsBaremetalServerPwdResponse>(response);
        }
        
        /// <summary>
        /// 更新裸金属服务器元数据
        ///
        /// 更新裸金属服务器元数据。如果元数据中没有待更新字段，则自动添加该字段。如果元数据中已存在待更新字段，则直接更新字段值；如果元数据中的字段不再请求参数中，则保持不变
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateBaremetalServerMetadataResponse> UpdateBaremetalServerMetadataAsync(UpdateBaremetalServerMetadataRequest updateBaremetalServerMetadataRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("server_id" , updateBaremetalServerMetadataRequest.ServerId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/baremetalservers/{server_id}/metadata",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateBaremetalServerMetadataRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<UpdateBaremetalServerMetadataResponse>(response);
        }
        
        /// <summary>
        /// 查询指定API版本信息
        ///
        /// 查询裸金属服务指定接口版本的信息
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
        /// </summary>
        public async Task<ShowSpecifiedVersionResponse> ShowSpecifiedVersionAsync(ShowSpecifiedVersionRequest showSpecifiedVersionRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("api_version" , showSpecifiedVersionRequest.ApiVersion.ToString());
            string urlPath = HttpUtils.AddUrlPath("/{api_version}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showSpecifiedVersionRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowSpecifiedVersionResponse>(response);
        }
        
        /// <summary>
        /// 查询Job状态
        ///
        /// 查询Job的执行状态。对于创建裸金属服务器物理机、挂卸卷等异步API，命令下发后，会返回job_id，通过job_id可以查询任务的执行状态
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
        /// </summary>
        public async Task<ShowJobInfosResponse> ShowJobInfosAsync(ShowJobInfosRequest showJobInfosRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id" , showJobInfosRequest.JobId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/jobs/{job_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showJobInfosRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowJobInfosResponse>(response);
        }
        
    }
}