using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Sis.V1.Model
{
    /// <summary>
    /// 整体发音打分
    /// </summary>
    public class Pronunciation 
    {

        /// <summary>
        /// 发音质量综合得分 0-100
        /// </summary>
        [JsonProperty("score", NullValueHandling = NullValueHandling.Ignore)]
        public float? Score { get; set; }

        /// <summary>
        /// 发音质量好坏 0-100
        /// </summary>
        [JsonProperty("gop", NullValueHandling = NullValueHandling.Ignore)]
        public float? Gop { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Pronunciation {\n");
            sb.Append("  score: ").Append(Score).Append("\n");
            sb.Append("  gop: ").Append(Gop).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as Pronunciation);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(Pronunciation input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Score == input.Score ||
                    (this.Score != null &&
                    this.Score.Equals(input.Score))
                ) && 
                (
                    this.Gop == input.Gop ||
                    (this.Gop != null &&
                    this.Gop.Equals(input.Gop))
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
                if (this.Score != null)
                    hashCode = hashCode * 59 + this.Score.GetHashCode();
                if (this.Gop != null)
                    hashCode = hashCode * 59 + this.Gop.GetHashCode();
                return hashCode;
            }
        }
    }
}
