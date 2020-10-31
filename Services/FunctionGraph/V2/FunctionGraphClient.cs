using System.Net.Http;
using System.Collections.Generic;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.FunctionGraph.V2.Model;

namespace HuaweiCloud.SDK.FunctionGraph.V2
{
    public partial class FunctionGraphClient : Client
    {
        public static ClientBuilder<FunctionGraphClient> NewBuilder()
        {
            return new ClientBuilder<FunctionGraphClient>();
        }

        
        /// <summary>
        /// 异步执行函数。
        /// </summary>
        public AsyncInvokeFunctionResponse AsyncInvokeFunction(AsyncInvokeFunctionRequest asyncInvokeFunctionRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("function_urn" , asyncInvokeFunctionRequest.FunctionUrn.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/functions/{function_urn}/invocations-async",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", asyncInvokeFunctionRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<AsyncInvokeFunctionResponse>(response);
        }
        
        /// <summary>
        /// 创建函数。
        /// </summary>
        public CreateFunctionResponse CreateFunction(CreateFunctionRequest createFunctionRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/functions",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createFunctionRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<CreateFunctionResponse>(response);
        }
        
        /// <summary>
        /// 发布函数版本。
        /// </summary>
        public CreateFunctionVersionResponse CreateFunctionVersion(CreateFunctionVersionRequest createFunctionVersionRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("function_urn" , createFunctionVersionRequest.FunctionUrn.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/functions/{function_urn}/versions",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createFunctionVersionRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<CreateFunctionVersionResponse>(response);
        }
        
        /// <summary>
        /// 创建函数版本别名。
        /// </summary>
        public CreateVersionAliasResponse CreateVersionAlias(CreateVersionAliasRequest createVersionAliasRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("function_urn" , createVersionAliasRequest.FunctionUrn.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/functions/{function_urn}/aliases",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createVersionAliasRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<CreateVersionAliasResponse>(response);
        }
        
        /// <summary>
        /// 删除函数/版本。
        /// </summary>
        public DeleteFunctionResponse DeleteFunction(DeleteFunctionRequest deleteFunctionRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("function_urn" , deleteFunctionRequest.FunctionUrn.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/functions/{function_urn}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, deleteFunctionRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteFunctionResponse>(response);
        }
        
        /// <summary>
        /// 删除函数版本别名。
        /// </summary>
        public DeleteVersionAliasResponse DeleteVersionAlias(DeleteVersionAliasRequest deleteVersionAliasRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("function_urn" , deleteVersionAliasRequest.FunctionUrn.ToString());
            urlParam.Add("name" , deleteVersionAliasRequest.Name.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/functions/{function_urn}/aliases/{name}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, deleteVersionAliasRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteVersionAliasResponse>(response);
        }
        
        /// <summary>
        /// 同步执行函数。
        /// </summary>
        public InvokeFunctionResponse InvokeFunction(InvokeFunctionRequest invokeFunctionRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("function_urn" , invokeFunctionRequest.FunctionUrn.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/functions/{function_urn}/invocations",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", invokeFunctionRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<InvokeFunctionResponse>(response);
        }
        
        /// <summary>
        /// 获取指定时间段的函数运行指标
        /// </summary>
        public ListFunctionStatisticsResponse ListFunctionStatistics(ListFunctionStatisticsRequest listFunctionStatisticsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("func_urn" , listFunctionStatisticsRequest.FuncUrn.ToString());
            urlParam.Add("period" , listFunctionStatisticsRequest.Period.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/functions/{func_urn}/statistics/{period}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, listFunctionStatisticsRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListFunctionStatisticsResponse>(response);
        }
        
        /// <summary>
        /// 获取指定函数的版本列表。
        /// </summary>
        public ListFunctionVersionsResponse ListFunctionVersions(ListFunctionVersionsRequest listFunctionVersionsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("function_urn" , listFunctionVersionsRequest.FunctionUrn.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/functions/{function_urn}/versions",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, listFunctionVersionsRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListFunctionVersionsResponse>(response);
        }
        
        /// <summary>
        /// 获取函数列表
        /// </summary>
        public ListFunctionsResponse ListFunctions(ListFunctionsRequest listFunctionsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/functions",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, listFunctionsRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListFunctionsResponse>(response);
        }
        
        /// <summary>
        /// 查询租户配额
        /// </summary>
        public ListQuotasResponse ListQuotas(ListQuotasRequest listQuotasRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/quotas",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, listQuotasRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListQuotasResponse>(response);
        }
        
        /// <summary>
        /// 租户函数统计信息
        /// </summary>
        public ListStatisticsResponse ListStatistics(ListStatisticsRequest listStatisticsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/functions/statistics",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, listStatisticsRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListStatisticsResponse>(response);
        }
        
        /// <summary>
        /// 获取指定函数所有版本别名列表。
        /// </summary>
        public ListVersionAliasesResponse ListVersionAliases(ListVersionAliasesRequest listVersionAliasesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("function_urn" , listVersionAliasesRequest.FunctionUrn.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/functions/{function_urn}/aliases",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, listVersionAliasesRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            ListVersionAliasesResponse listVersionAliasesResponse = JsonUtils.DeSerializeNull<ListVersionAliasesResponse>(response);
            listVersionAliasesResponse.Body = JsonUtils.DeSerializeList<ListVersionAliasResult>(response);
            return listVersionAliasesResponse;
        }
        
        /// <summary>
        /// 获取指定函数代码。
        /// </summary>
        public ShowFunctionCodeResponse ShowFunctionCode(ShowFunctionCodeRequest showFunctionCodeRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("function_urn" , showFunctionCodeRequest.FunctionUrn.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/functions/{function_urn}/code",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, showFunctionCodeRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowFunctionCodeResponse>(response);
        }
        
        /// <summary>
        /// 获取函数的metadata。
        /// </summary>
        public ShowFunctionConfigResponse ShowFunctionConfig(ShowFunctionConfigRequest showFunctionConfigRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("function_urn" , showFunctionConfigRequest.FunctionUrn.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/functions/{function_urn}/config",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, showFunctionConfigRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowFunctionConfigResponse>(response);
        }
        
        /// <summary>
        /// 获取函数版本的指定别名信息。
        /// </summary>
        public ShowVersionAliasResponse ShowVersionAlias(ShowVersionAliasRequest showVersionAliasRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("function_urn" , showVersionAliasRequest.FunctionUrn.ToString());
            urlParam.Add("name" , showVersionAliasRequest.Name.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/functions/{function_urn}/aliases/{name}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, showVersionAliasRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowVersionAliasResponse>(response);
        }
        
        /// <summary>
        /// 修改函数代码。
        /// </summary>
        public UpdateFunctionCodeResponse UpdateFunctionCode(UpdateFunctionCodeRequest updateFunctionCodeRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("function_urn" , updateFunctionCodeRequest.FunctionUrn.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/functions/{function_urn}/code",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateFunctionCodeRequest);
            HttpResponseMessage response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerialize<UpdateFunctionCodeResponse>(response);
        }
        
        /// <summary>
        /// 修改函数的metadata信息。
        /// </summary>
        public UpdateFunctionConfigResponse UpdateFunctionConfig(UpdateFunctionConfigRequest updateFunctionConfigRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("function_urn" , updateFunctionConfigRequest.FunctionUrn.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/functions/{function_urn}/config",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateFunctionConfigRequest);
            HttpResponseMessage response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerialize<UpdateFunctionConfigResponse>(response);
        }
        
        /// <summary>
        /// 修改函数版本别名信息。
        /// </summary>
        public UpdateVersionAliasResponse UpdateVersionAlias(UpdateVersionAliasRequest updateVersionAliasRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("function_urn" , updateVersionAliasRequest.FunctionUrn.ToString());
            urlParam.Add("name" , updateVersionAliasRequest.Name.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/functions/{function_urn}/aliases/{name}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateVersionAliasRequest);
            HttpResponseMessage response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerialize<UpdateVersionAliasResponse>(response);
        }
        
        /// <summary>
        /// 删除指定函数的所有触发器。
        /// </summary>
        public BatchDeleteFunctionTriggersResponse BatchDeleteFunctionTriggers(BatchDeleteFunctionTriggersRequest batchDeleteFunctionTriggersRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("function_urn" , batchDeleteFunctionTriggersRequest.FunctionUrn.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/triggers/{function_urn}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, batchDeleteFunctionTriggersRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            return JsonUtils.DeSerializeNull<BatchDeleteFunctionTriggersResponse>(response);
        }
        
        /// <summary>
        /// 创建触发器。
        /// </summary>
        public CreateFunctionTriggerResponse CreateFunctionTrigger(CreateFunctionTriggerRequest createFunctionTriggerRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("function_urn" , createFunctionTriggerRequest.FunctionUrn.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/triggers/{function_urn}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createFunctionTriggerRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<CreateFunctionTriggerResponse>(response);
        }
        
        /// <summary>
        /// 删除触发器。
        /// </summary>
        public DeleteFunctionTriggerResponse DeleteFunctionTrigger(DeleteFunctionTriggerRequest deleteFunctionTriggerRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("function_urn" , deleteFunctionTriggerRequest.FunctionUrn.ToString());
            urlParam.Add("trigger_type_code" , deleteFunctionTriggerRequest.TriggerTypeCode.ToString());
            urlParam.Add("triggerId" , deleteFunctionTriggerRequest.TriggerId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/triggers/{function_urn}/{trigger_type_code}/{triggerId}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, deleteFunctionTriggerRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteFunctionTriggerResponse>(response);
        }
        
        /// <summary>
        /// 获取指定函数的所有触发器。
        /// </summary>
        public ListFunctionTriggersResponse ListFunctionTriggers(ListFunctionTriggersRequest listFunctionTriggersRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("function_urn" , listFunctionTriggersRequest.FunctionUrn.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/triggers/{function_urn}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, listFunctionTriggersRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            ListFunctionTriggersResponse listFunctionTriggersResponse = JsonUtils.DeSerializeNull<ListFunctionTriggersResponse>(response);
            listFunctionTriggersResponse.Body = JsonUtils.DeSerializeList<ListFunctionTriggerResult>(response);
            return listFunctionTriggersResponse;
        }
        
        /// <summary>
        /// 获取指定触发器的信息。
        /// </summary>
        public ShowFunctionTriggerResponse ShowFunctionTrigger(ShowFunctionTriggerRequest showFunctionTriggerRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("function_urn" , showFunctionTriggerRequest.FunctionUrn.ToString());
            urlParam.Add("trigger_type_code" , showFunctionTriggerRequest.TriggerTypeCode.ToString());
            urlParam.Add("triggerId" , showFunctionTriggerRequest.TriggerId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/triggers/{function_urn}/{trigger_type_code}/{triggerId}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, showFunctionTriggerRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowFunctionTriggerResponse>(response);
        }
        
        /// <summary>
        /// 更新触发器
        /// </summary>
        public UpdateTriggerResponse UpdateTrigger(UpdateTriggerRequest updateTriggerRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("function_urn" , updateTriggerRequest.FunctionUrn.ToString());
            urlParam.Add("trigger_type_code" , updateTriggerRequest.TriggerTypeCode.ToString());
            urlParam.Add("triggerId" , updateTriggerRequest.TriggerId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/triggers/{function_urn}/{trigger_type_code}/{triggerId}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateTriggerRequest);
            HttpResponseMessage response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerializeNull<UpdateTriggerResponse>(response);
        }
        
    }
}