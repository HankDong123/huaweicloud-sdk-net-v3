using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cdn.V1.Model
{
    /// <summary>
    /// 设置证书请求体
    /// </summary>
    public class HttpPutBody 
    {

        /// <summary>
        /// HTTPS证书是否启用。（on：开启，off：关闭）
        /// </summary>
        [JsonProperty("https_status", NullValueHandling = NullValueHandling.Ignore)]
        public string HttpsStatus { get; set; }

        /// <summary>
        /// 证书名字。（长度限制为3-32字符）。当证书开启时必传。
        /// </summary>
        [JsonProperty("certificate_name", NullValueHandling = NullValueHandling.Ignore)]
        public string CertificateName { get; set; }

        /// <summary>
        /// HTTPS协议使用的证书内容，当证书开启时必传。取值范围：PEM编码格式。
        /// </summary>
        [JsonProperty("certificate_value", NullValueHandling = NullValueHandling.Ignore)]
        public string CertificateValue { get; set; }

        /// <summary>
        /// HTTPS协议使用的私钥，当证书开启时必传。取值范围：PEM编码格式。
        /// </summary>
        [JsonProperty("private_key", NullValueHandling = NullValueHandling.Ignore)]
        public string PrivateKey { get; set; }

        /// <summary>
        /// 证书来源。1：代表华为云托管证书；0：表示自有证书。 默认值0。当证书开启时必传。
        /// </summary>
        [JsonProperty("certificate_source", NullValueHandling = NullValueHandling.Ignore)]
        public int? CertificateSource { get; set; }

        /// <summary>
        /// 是否使用HTTP2.0。（on：是，off：否。）,默认关闭，https_status&#x3D;off时，该值不生效。
        /// </summary>
        [JsonProperty("http2_status", NullValueHandling = NullValueHandling.Ignore)]
        public string Http2Status { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class HttpPutBody {\n");
            sb.Append("  httpsStatus: ").Append(HttpsStatus).Append("\n");
            sb.Append("  certificateName: ").Append(CertificateName).Append("\n");
            sb.Append("  certificateValue: ").Append(CertificateValue).Append("\n");
            sb.Append("  privateKey: ").Append(PrivateKey).Append("\n");
            sb.Append("  certificateSource: ").Append(CertificateSource).Append("\n");
            sb.Append("  http2Status: ").Append(Http2Status).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as HttpPutBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(HttpPutBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.HttpsStatus == input.HttpsStatus ||
                    (this.HttpsStatus != null &&
                    this.HttpsStatus.Equals(input.HttpsStatus))
                ) && 
                (
                    this.CertificateName == input.CertificateName ||
                    (this.CertificateName != null &&
                    this.CertificateName.Equals(input.CertificateName))
                ) && 
                (
                    this.CertificateValue == input.CertificateValue ||
                    (this.CertificateValue != null &&
                    this.CertificateValue.Equals(input.CertificateValue))
                ) && 
                (
                    this.PrivateKey == input.PrivateKey ||
                    (this.PrivateKey != null &&
                    this.PrivateKey.Equals(input.PrivateKey))
                ) && 
                (
                    this.CertificateSource == input.CertificateSource ||
                    (this.CertificateSource != null &&
                    this.CertificateSource.Equals(input.CertificateSource))
                ) && 
                (
                    this.Http2Status == input.Http2Status ||
                    (this.Http2Status != null &&
                    this.Http2Status.Equals(input.Http2Status))
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
                if (this.HttpsStatus != null)
                    hashCode = hashCode * 59 + this.HttpsStatus.GetHashCode();
                if (this.CertificateName != null)
                    hashCode = hashCode * 59 + this.CertificateName.GetHashCode();
                if (this.CertificateValue != null)
                    hashCode = hashCode * 59 + this.CertificateValue.GetHashCode();
                if (this.PrivateKey != null)
                    hashCode = hashCode * 59 + this.PrivateKey.GetHashCode();
                if (this.CertificateSource != null)
                    hashCode = hashCode * 59 + this.CertificateSource.GetHashCode();
                if (this.Http2Status != null)
                    hashCode = hashCode * 59 + this.Http2Status.GetHashCode();
                return hashCode;
            }
        }
    }
}
