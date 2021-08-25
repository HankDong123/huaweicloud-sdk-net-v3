using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Frs.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class AddFacesUrlReq 
    {

        /// <summary>
        /// 图片的URL路径，目前仅支持华为云上OBS的URL，且人脸识别服务有权限读取该OBS桶的数据。 开通读取权限的操作请参见服务授权。
        /// </summary>
        [JsonProperty("image_url", NullValueHandling = NullValueHandling.Ignore)]
        public string ImageUrl { get; set; }

        /// <summary>
        /// 根据用户自定义数据类型，填入相应的数值。 创建faceset时定义该字段，Json字符串不校验重复性，参考自定义字段。
        /// </summary>
        [JsonProperty("external_fields", NullValueHandling = NullValueHandling.Ignore)]
        public Object ExternalFields { get; set; }

        /// <summary>
        /// 用户指定的图片外部ID，与当前图像绑定。用户没提供，系统会生成一个。 该ID长度范围为1～36位，可以包含字母、数字、中划线或者下划线，不包含其他的特殊字符。
        /// </summary>
        [JsonProperty("external_image_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ExternalImageId { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AddFacesUrlReq {\n");
            sb.Append("  imageUrl: ").Append(ImageUrl).Append("\n");
            sb.Append("  externalFields: ").Append(ExternalFields).Append("\n");
            sb.Append("  externalImageId: ").Append(ExternalImageId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AddFacesUrlReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AddFacesUrlReq input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ImageUrl == input.ImageUrl ||
                    (this.ImageUrl != null &&
                    this.ImageUrl.Equals(input.ImageUrl))
                ) && 
                (
                    this.ExternalFields == input.ExternalFields ||
                    (this.ExternalFields != null &&
                    this.ExternalFields.Equals(input.ExternalFields))
                ) && 
                (
                    this.ExternalImageId == input.ExternalImageId ||
                    (this.ExternalImageId != null &&
                    this.ExternalImageId.Equals(input.ExternalImageId))
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
                if (this.ImageUrl != null)
                    hashCode = hashCode * 59 + this.ImageUrl.GetHashCode();
                if (this.ExternalFields != null)
                    hashCode = hashCode * 59 + this.ExternalFields.GetHashCode();
                if (this.ExternalImageId != null)
                    hashCode = hashCode * 59 + this.ExternalImageId.GetHashCode();
                return hashCode;
            }
        }
    }
}