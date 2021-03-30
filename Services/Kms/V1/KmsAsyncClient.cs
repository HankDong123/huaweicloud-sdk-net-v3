using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.Kms.V1.Model;

namespace HuaweiCloud.SDK.Kms.V1
{
    public partial class KmsAsyncClient : Client
    {
        public static ClientBuilder<KmsAsyncClient> NewBuilder()
        {
            return new ClientBuilder<KmsAsyncClient>();
        }

        
        /// <summary>
        /// 批量添加删除密钥标签
        /// </summary>
        public async Task<BatchCreateKmsTagsResponse> BatchCreateKmsTagsAsync(BatchCreateKmsTagsRequest batchCreateKmsTagsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("key_id" , batchCreateKmsTagsRequest.KeyId.ToString());
            urlParam.Add("version_id" , batchCreateKmsTagsRequest.VersionId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/{version_id}/{project_id}/kms/{key_id}/tags/action",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchCreateKmsTagsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerializeNull<BatchCreateKmsTagsResponse>(response);
        }
        
        /// <summary>
        /// 撤销授权
        /// </summary>
        public async Task<CancelGrantResponse> CancelGrantAsync(CancelGrantRequest cancelGrantRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("version_id" , cancelGrantRequest.VersionId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/{version_id}/{project_id}/kms/revoke-grant",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", cancelGrantRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerializeNull<CancelGrantResponse>(response);
        }
        
        /// <summary>
        /// 取消计划删除密钥
        /// </summary>
        public async Task<CancelKeyDeletionResponse> CancelKeyDeletionAsync(CancelKeyDeletionRequest cancelKeyDeletionRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("version_id" , cancelKeyDeletionRequest.VersionId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/{version_id}/{project_id}/kms/cancel-key-deletion",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", cancelKeyDeletionRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CancelKeyDeletionResponse>(response);
        }
        
        /// <summary>
        /// 退役授权
        /// </summary>
        public async Task<CancelSelfGrantResponse> CancelSelfGrantAsync(CancelSelfGrantRequest cancelSelfGrantRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("version_id" , cancelSelfGrantRequest.VersionId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/{version_id}/{project_id}/kms/retire-grant",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", cancelSelfGrantRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerializeNull<CancelSelfGrantResponse>(response);
        }
        
        /// <summary>
        /// 创建数据密钥
        /// </summary>
        public async Task<CreateDatakeyResponse> CreateDatakeyAsync(CreateDatakeyRequest createDatakeyRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("version_id" , createDatakeyRequest.VersionId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/{version_id}/{project_id}/kms/create-datakey",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createDatakeyRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateDatakeyResponse>(response);
        }
        
        /// <summary>
        /// 创建不含明文数据密钥
        /// </summary>
        public async Task<CreateDatakeyWithoutPlaintextResponse> CreateDatakeyWithoutPlaintextAsync(CreateDatakeyWithoutPlaintextRequest createDatakeyWithoutPlaintextRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("version_id" , createDatakeyWithoutPlaintextRequest.VersionId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/{version_id}/{project_id}/kms/create-datakey-without-plaintext",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createDatakeyWithoutPlaintextRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateDatakeyWithoutPlaintextResponse>(response);
        }
        
        /// <summary>
        /// 创建授权
        /// </summary>
        public async Task<CreateGrantResponse> CreateGrantAsync(CreateGrantRequest createGrantRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("version_id" , createGrantRequest.VersionId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/{version_id}/{project_id}/kms/create-grant",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createGrantRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateGrantResponse>(response);
        }
        
        /// <summary>
        /// 创建密钥
        /// </summary>
        public async Task<CreateKeyResponse> CreateKeyAsync(CreateKeyRequest createKeyRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("version_id" , createKeyRequest.VersionId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/{version_id}/{project_id}/kms/create-key",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createKeyRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateKeyResponse>(response);
        }
        
        /// <summary>
        /// 添加密钥标签
        /// </summary>
        public async Task<CreateKmsTagResponse> CreateKmsTagAsync(CreateKmsTagRequest createKmsTagRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("version_id" , createKmsTagRequest.VersionId.ToString());
            urlParam.Add("key_id" , createKmsTagRequest.KeyId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/{version_id}/{project_id}/kms/{key_id}/tags",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createKmsTagRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerializeNull<CreateKmsTagResponse>(response);
        }
        
        /// <summary>
        /// 获取密钥导入参数
        /// </summary>
        public async Task<CreateParametersForImportResponse> CreateParametersForImportAsync(CreateParametersForImportRequest createParametersForImportRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("version_id" , createParametersForImportRequest.VersionId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/{version_id}/{project_id}/kms/get-parameters-for-import",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createParametersForImportRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateParametersForImportResponse>(response);
        }
        
        /// <summary>
        /// 创建随机数
        /// </summary>
        public async Task<CreateRandomResponse> CreateRandomAsync(CreateRandomRequest createRandomRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("version_id" , createRandomRequest.VersionId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/{version_id}/{project_id}/kms/gen-random",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createRandomRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateRandomResponse>(response);
        }
        
        /// <summary>
        /// 创建凭据
        /// </summary>
        public async Task<CreateSecretResponse> CreateSecretAsync(CreateSecretRequest createSecretRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/secrets",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createSecretRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateSecretResponse>(response);
        }
        
        /// <summary>
        /// 创建凭据版本
        /// </summary>
        public async Task<CreateSecretVersionResponse> CreateSecretVersionAsync(CreateSecretVersionRequest createSecretVersionRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("secret_id" , createSecretVersionRequest.SecretId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/secrets/{secret_id}/versions",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createSecretVersionRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateSecretVersionResponse>(response);
        }
        
        /// <summary>
        /// 解密数据
        /// </summary>
        public async Task<DecryptDataResponse> DecryptDataAsync(DecryptDataRequest decryptDataRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("version_id" , decryptDataRequest.VersionId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/{version_id}/{project_id}/kms/decrypt-data",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", decryptDataRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<DecryptDataResponse>(response);
        }
        
        /// <summary>
        /// 解密数据密钥
        /// </summary>
        public async Task<DecryptDatakeyResponse> DecryptDatakeyAsync(DecryptDatakeyRequest decryptDatakeyRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("version_id" , decryptDatakeyRequest.VersionId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/{version_id}/{project_id}/kms/decrypt-datakey",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", decryptDatakeyRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<DecryptDatakeyResponse>(response);
        }
        
        /// <summary>
        /// 删除密钥材料
        /// </summary>
        public async Task<DeleteImportedKeyMaterialResponse> DeleteImportedKeyMaterialAsync(DeleteImportedKeyMaterialRequest deleteImportedKeyMaterialRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("version_id" , deleteImportedKeyMaterialRequest.VersionId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/{version_id}/{project_id}/kms/delete-imported-key-material",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", deleteImportedKeyMaterialRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerializeNull<DeleteImportedKeyMaterialResponse>(response);
        }
        
        /// <summary>
        /// 计划删除密钥
        /// </summary>
        public async Task<DeleteKeyResponse> DeleteKeyAsync(DeleteKeyRequest deleteKeyRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("version_id" , deleteKeyRequest.VersionId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/{version_id}/{project_id}/kms/schedule-key-deletion",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", deleteKeyRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<DeleteKeyResponse>(response);
        }
        
        /// <summary>
        /// 立即删除凭据
        /// </summary>
        public async Task<DeleteSecretResponse> DeleteSecretAsync(DeleteSecretRequest deleteSecretRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("secret_id" , deleteSecretRequest.SecretId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/secrets/{secret_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteSecretRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteSecretResponse>(response);
        }
        
        /// <summary>
        /// 创建凭据的定时删除任务
        /// </summary>
        public async Task<DeleteSecretForScheduleResponse> DeleteSecretForScheduleAsync(DeleteSecretForScheduleRequest deleteSecretForScheduleRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("secret_id" , deleteSecretForScheduleRequest.SecretId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/secrets/{secret_id}/scheduled-deleted-tasks/create",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", deleteSecretForScheduleRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<DeleteSecretForScheduleResponse>(response);
        }
        
        /// <summary>
        /// 删除凭据的版本状态
        /// </summary>
        public async Task<DeleteSecretStageResponse> DeleteSecretStageAsync(DeleteSecretStageRequest deleteSecretStageRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("secret_id" , deleteSecretStageRequest.SecretId.ToString());
            urlParam.Add("stage_name" , deleteSecretStageRequest.StageName.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/secrets/{secret_id}/stages/{stage_name}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteSecretStageRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteSecretStageResponse>(response);
        }
        
        /// <summary>
        /// 删除密钥标签
        /// </summary>
        public async Task<DeleteTagResponse> DeleteTagAsync(DeleteTagRequest deleteTagRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("key_id" , deleteTagRequest.KeyId.ToString());
            urlParam.Add("key" , deleteTagRequest.Key.ToString());
            urlParam.Add("version_id" , deleteTagRequest.VersionId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/{version_id}/{project_id}/kms/{key_id}/tags/{key}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteTagRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteTagResponse>(response);
        }
        
        /// <summary>
        /// 禁用密钥
        /// </summary>
        public async Task<DisableKeyResponse> DisableKeyAsync(DisableKeyRequest disableKeyRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("version_id" , disableKeyRequest.VersionId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/{version_id}/{project_id}/kms/disable-key",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", disableKeyRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<DisableKeyResponse>(response);
        }
        
        /// <summary>
        /// 关闭密钥轮换
        /// </summary>
        public async Task<DisableKeyRotationResponse> DisableKeyRotationAsync(DisableKeyRotationRequest disableKeyRotationRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("version_id" , disableKeyRotationRequest.VersionId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/{version_id}/{project_id}/kms/disable-key-rotation",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", disableKeyRotationRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerializeNull<DisableKeyRotationResponse>(response);
        }
        
        /// <summary>
        /// 启用密钥
        /// </summary>
        public async Task<EnableKeyResponse> EnableKeyAsync(EnableKeyRequest enableKeyRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("version_id" , enableKeyRequest.VersionId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/{version_id}/{project_id}/kms/enable-key",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", enableKeyRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<EnableKeyResponse>(response);
        }
        
        /// <summary>
        /// 开启密钥轮换
        /// </summary>
        public async Task<EnableKeyRotationResponse> EnableKeyRotationAsync(EnableKeyRotationRequest enableKeyRotationRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("version_id" , enableKeyRotationRequest.VersionId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/{version_id}/{project_id}/kms/enable-key-rotation",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", enableKeyRotationRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerializeNull<EnableKeyRotationResponse>(response);
        }
        
        /// <summary>
        /// 加密数据
        /// </summary>
        public async Task<EncryptDataResponse> EncryptDataAsync(EncryptDataRequest encryptDataRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("version_id" , encryptDataRequest.VersionId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/{version_id}/{project_id}/kms/encrypt-data",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", encryptDataRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<EncryptDataResponse>(response);
        }
        
        /// <summary>
        /// 加密数据密钥
        /// </summary>
        public async Task<EncryptDatakeyResponse> EncryptDatakeyAsync(EncryptDatakeyRequest encryptDatakeyRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("version_id" , encryptDatakeyRequest.VersionId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/{version_id}/{project_id}/kms/encrypt-datakey",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", encryptDatakeyRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<EncryptDatakeyResponse>(response);
        }
        
        /// <summary>
        /// 导入密钥材料
        /// </summary>
        public async Task<ImportKeyMaterialResponse> ImportKeyMaterialAsync(ImportKeyMaterialRequest importKeyMaterialRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("version_id" , importKeyMaterialRequest.VersionId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/{version_id}/{project_id}/kms/import-key-material",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", importKeyMaterialRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerializeNull<ImportKeyMaterialResponse>(response);
        }
        
        /// <summary>
        /// 查询授权列表
        /// </summary>
        public async Task<ListGrantsResponse> ListGrantsAsync(ListGrantsRequest listGrantsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("version_id" , listGrantsRequest.VersionId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/{version_id}/{project_id}/kms/list-grants",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listGrantsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<ListGrantsResponse>(response);
        }
        
        /// <summary>
        /// 查询密钥信息
        /// </summary>
        public async Task<ListKeyDetailResponse> ListKeyDetailAsync(ListKeyDetailRequest listKeyDetailRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("version_id" , listKeyDetailRequest.VersionId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/{version_id}/{project_id}/kms/describe-key",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listKeyDetailRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<ListKeyDetailResponse>(response);
        }
        
        /// <summary>
        /// 查询密钥列表
        /// </summary>
        public async Task<ListKeysResponse> ListKeysAsync(ListKeysRequest listKeysRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("version_id" , listKeysRequest.VersionId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/{version_id}/{project_id}/kms/list-keys",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listKeysRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<ListKeysResponse>(response);
        }
        
        /// <summary>
        /// 查询密钥实例
        /// </summary>
        public async Task<ListKmsByTagsResponse> ListKmsByTagsAsync(ListKmsByTagsRequest listKmsByTagsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_instances" , listKmsByTagsRequest.ResourceInstances.ToString());
            urlParam.Add("version_id" , listKmsByTagsRequest.VersionId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/{version_id}/{project_id}/kms/{resource_instances}/action",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listKmsByTagsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<ListKmsByTagsResponse>(response);
        }
        
        /// <summary>
        /// 查询项目标签
        /// </summary>
        public async Task<ListKmsTagsResponse> ListKmsTagsAsync(ListKmsTagsRequest listKmsTagsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("version_id" , listKmsTagsRequest.VersionId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/{version_id}/{project_id}/kms/tags",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listKmsTagsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListKmsTagsResponse>(response);
        }
        
        /// <summary>
        /// 查询可退役授权列表
        /// </summary>
        public async Task<ListRetirableGrantsResponse> ListRetirableGrantsAsync(ListRetirableGrantsRequest listRetirableGrantsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("version_id" , listRetirableGrantsRequest.VersionId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/{version_id}/{project_id}/kms/list-retirable-grants",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listRetirableGrantsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<ListRetirableGrantsResponse>(response);
        }
        
        /// <summary>
        /// 查询凭据的版本状态
        /// </summary>
        public async Task<ListSecretStageResponse> ListSecretStageAsync(ListSecretStageRequest listSecretStageRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("secret_id" , listSecretStageRequest.SecretId.ToString());
            urlParam.Add("stage_name" , listSecretStageRequest.StageName.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/secrets/{secret_id}/stages/{stage_name}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSecretStageRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListSecretStageResponse>(response);
        }
        
        /// <summary>
        /// 查询凭据的版本列表
        /// </summary>
        public async Task<ListSecretVersionsResponse> ListSecretVersionsAsync(ListSecretVersionsRequest listSecretVersionsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("secret_id" , listSecretVersionsRequest.SecretId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/secrets/{secret_id}/versions",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSecretVersionsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListSecretVersionsResponse>(response);
        }
        
        /// <summary>
        /// 查询凭据列表
        /// </summary>
        public async Task<ListSecretsResponse> ListSecretsAsync(ListSecretsRequest listSecretsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/secrets",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSecretsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListSecretsResponse>(response);
        }
        
        /// <summary>
        /// 取消凭据的定时删除任务
        /// </summary>
        public async Task<RestoreSecretResponse> RestoreSecretAsync(RestoreSecretRequest restoreSecretRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("secret_id" , restoreSecretRequest.SecretId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/secrets/{secret_id}/scheduled-deleted-tasks/cancel",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", restoreSecretRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<RestoreSecretResponse>(response);
        }
        
        /// <summary>
        /// 查询密钥轮换状态
        /// </summary>
        public async Task<ShowKeyRotationStatusResponse> ShowKeyRotationStatusAsync(ShowKeyRotationStatusRequest showKeyRotationStatusRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("version_id" , showKeyRotationStatusRequest.VersionId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/{version_id}/{project_id}/kms/get-key-rotation-status",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", showKeyRotationStatusRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<ShowKeyRotationStatusResponse>(response);
        }
        
        /// <summary>
        /// 查询密钥标签
        /// </summary>
        public async Task<ShowKmsTagsResponse> ShowKmsTagsAsync(ShowKmsTagsRequest showKmsTagsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("version_id" , showKmsTagsRequest.VersionId.ToString());
            urlParam.Add("key_id" , showKmsTagsRequest.KeyId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/{version_id}/{project_id}/kms/{key_id}/tags",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showKmsTagsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowKmsTagsResponse>(response);
        }
        
        /// <summary>
        /// 查询凭据
        /// </summary>
        public async Task<ShowSecretResponse> ShowSecretAsync(ShowSecretRequest showSecretRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("secret_id" , showSecretRequest.SecretId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/secrets/{secret_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showSecretRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowSecretResponse>(response);
        }
        
        /// <summary>
        /// 查询凭据的版本与凭据值
        /// </summary>
        public async Task<ShowSecretVersionResponse> ShowSecretVersionAsync(ShowSecretVersionRequest showSecretVersionRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("secret_id" , showSecretVersionRequest.SecretId.ToString());
            urlParam.Add("version_id" , showSecretVersionRequest.VersionId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/secrets/{secret_id}/versions/{version_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showSecretVersionRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowSecretVersionResponse>(response);
        }
        
        /// <summary>
        /// 查询实例数
        /// </summary>
        public async Task<ShowUserInstancesResponse> ShowUserInstancesAsync(ShowUserInstancesRequest showUserInstancesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("version_id" , showUserInstancesRequest.VersionId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/{version_id}/{project_id}/kms/user-instances",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showUserInstancesRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowUserInstancesResponse>(response);
        }
        
        /// <summary>
        /// 查询配额
        /// </summary>
        public async Task<ShowUserQuotasResponse> ShowUserQuotasAsync(ShowUserQuotasRequest showUserQuotasRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("version_id" , showUserQuotasRequest.VersionId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/{version_id}/{project_id}/kms/user-quotas",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showUserQuotasRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowUserQuotasResponse>(response);
        }
        
        /// <summary>
        /// 修改密钥别名
        /// </summary>
        public async Task<UpdateKeyAliasResponse> UpdateKeyAliasAsync(UpdateKeyAliasRequest updateKeyAliasRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("version_id" , updateKeyAliasRequest.VersionId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/{version_id}/{project_id}/kms/update-key-alias",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateKeyAliasRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<UpdateKeyAliasResponse>(response);
        }
        
        /// <summary>
        /// 修改密钥描述
        /// </summary>
        public async Task<UpdateKeyDescriptionResponse> UpdateKeyDescriptionAsync(UpdateKeyDescriptionRequest updateKeyDescriptionRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("version_id" , updateKeyDescriptionRequest.VersionId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/{version_id}/{project_id}/kms/update-key-description",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateKeyDescriptionRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<UpdateKeyDescriptionResponse>(response);
        }
        
        /// <summary>
        /// 修改密钥轮换周期
        /// </summary>
        public async Task<UpdateKeyRotationIntervalResponse> UpdateKeyRotationIntervalAsync(UpdateKeyRotationIntervalRequest updateKeyRotationIntervalRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("version_id" , updateKeyRotationIntervalRequest.VersionId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/{version_id}/{project_id}/kms/update-key-rotation-interval",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateKeyRotationIntervalRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerializeNull<UpdateKeyRotationIntervalResponse>(response);
        }
        
        /// <summary>
        /// 更新凭据
        /// </summary>
        public async Task<UpdateSecretResponse> UpdateSecretAsync(UpdateSecretRequest updateSecretRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("secret_id" , updateSecretRequest.SecretId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/secrets/{secret_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateSecretRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<UpdateSecretResponse>(response);
        }
        
        /// <summary>
        /// 更新凭据的版本状态
        /// </summary>
        public async Task<UpdateSecretStageResponse> UpdateSecretStageAsync(UpdateSecretStageRequest updateSecretStageRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("secret_id" , updateSecretStageRequest.SecretId.ToString());
            urlParam.Add("stage_name" , updateSecretStageRequest.StageName.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/secrets/{secret_id}/stages/{stage_name}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateSecretStageRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<UpdateSecretStageResponse>(response);
        }
        
        /// <summary>
        /// 查询指定版本信息
        /// </summary>
        public async Task<ShowVersionResponse> ShowVersionAsync(ShowVersionRequest showVersionRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("version_id" , showVersionRequest.VersionId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/{version_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showVersionRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowVersionResponse>(response);
        }
        
        /// <summary>
        /// 查询版本信息列表
        /// </summary>
        public async Task<ShowVersionsResponse> ShowVersionsAsync(ShowVersionsRequest showVersionsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showVersionsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowVersionsResponse>(response);
        }
        
    }
}