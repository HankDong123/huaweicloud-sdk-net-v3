using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ocr.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class WebImageRequestBody 
    {

        /// <summary>
        /// 与url二选一  图像数据，base64编码，要求base64编码后大小不超过10MB。图片最小边不小于15px，最长边不超过8192px，支持JPEG、JPG、PNG、BMP、TIFF、GIF、WEBP格式。  图片文件Base64编码字符串，点击[这里](https://support.huaweicloud.com/ocr_faq/ocr_01_0032.html)查看详细获取方式。   
        /// </summary>
        [JsonProperty("image", NullValueHandling = NullValueHandling.Ignore)]
        public string Image { get; set; }

        /// <summary>
        /// 与image二选一  图片的URL路径，目前支持：  - 公网http/https url  - OBS提供的url，使用OBS数据需要进行授权。包括对服务授权、临时授权、匿名公开授权，详情参见[配置OBS访问权限](https://support.huaweicloud.com/api-ocr/ocr_03_0132.html)。  &gt; 说明：  - 接口响应时间依赖于图片的下载时间，如果图片下载时间过长，会返回接口调用失败。  - 请保证被检测图片所在的存储服务稳定可靠，推荐使用OBS服务存储图片数据。 
        /// </summary>
        [JsonProperty("url", NullValueHandling = NullValueHandling.Ignore)]
        public string Url { get; set; }

        /// <summary>
        /// 图片朝向检测开关，可选值包括：  - true：检测图片朝向;  - false：不检测图片朝向。  &gt; 说明：  - 支持任意角度的图片朝向检测。未传入该参数时默认为false，即不检测图片朝向。 
        /// </summary>
        [JsonProperty("detect_direction", NullValueHandling = NullValueHandling.Ignore)]
        public bool? DetectDirection { get; set; }

        /// <summary>
        /// 结构化数据提取参数列表，目前只支持联系人信息、图像宽高，其入参值分别为\&quot;contact_info\&quot;，\&quot;image_size\&quot;，若该字段为空列表或缺失该字段，默认不提取。 
        /// </summary>
        [JsonProperty("extract_type", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> ExtractType { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WebImageRequestBody {\n");
            sb.Append("  image: ").Append(Image).Append("\n");
            sb.Append("  url: ").Append(Url).Append("\n");
            sb.Append("  detectDirection: ").Append(DetectDirection).Append("\n");
            sb.Append("  extractType: ").Append(ExtractType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as WebImageRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(WebImageRequestBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Image == input.Image ||
                    (this.Image != null &&
                    this.Image.Equals(input.Image))
                ) && 
                (
                    this.Url == input.Url ||
                    (this.Url != null &&
                    this.Url.Equals(input.Url))
                ) && 
                (
                    this.DetectDirection == input.DetectDirection ||
                    (this.DetectDirection != null &&
                    this.DetectDirection.Equals(input.DetectDirection))
                ) && 
                (
                    this.ExtractType == input.ExtractType ||
                    this.ExtractType != null &&
                    input.ExtractType != null &&
                    this.ExtractType.SequenceEqual(input.ExtractType)
                );
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Image != null)
                    hashCode = hashCode * 59 + this.Image.GetHashCode();
                if (this.Url != null)
                    hashCode = hashCode * 59 + this.Url.GetHashCode();
                if (this.DetectDirection != null)
                    hashCode = hashCode * 59 + this.DetectDirection.GetHashCode();
                if (this.ExtractType != null)
                    hashCode = hashCode * 59 + this.ExtractType.GetHashCode();
                return hashCode;
            }
        }
    }
}
