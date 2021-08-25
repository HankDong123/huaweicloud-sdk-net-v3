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
    public class DetectFace 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("bounding_box", NullValueHandling = NullValueHandling.Ignore)]
        public BoundingBox BoundingBox { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("attributes", NullValueHandling = NullValueHandling.Ignore)]
        public Attributes Attributes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("landmark", NullValueHandling = NullValueHandling.Ignore)]
        public Landmark Landmark { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DetectFace {\n");
            sb.Append("  boundingBox: ").Append(BoundingBox).Append("\n");
            sb.Append("  attributes: ").Append(Attributes).Append("\n");
            sb.Append("  landmark: ").Append(Landmark).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DetectFace);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DetectFace input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.BoundingBox == input.BoundingBox ||
                    (this.BoundingBox != null &&
                    this.BoundingBox.Equals(input.BoundingBox))
                ) && 
                (
                    this.Attributes == input.Attributes ||
                    (this.Attributes != null &&
                    this.Attributes.Equals(input.Attributes))
                ) && 
                (
                    this.Landmark == input.Landmark ||
                    (this.Landmark != null &&
                    this.Landmark.Equals(input.Landmark))
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
                if (this.BoundingBox != null)
                    hashCode = hashCode * 59 + this.BoundingBox.GetHashCode();
                if (this.Attributes != null)
                    hashCode = hashCode * 59 + this.Attributes.GetHashCode();
                if (this.Landmark != null)
                    hashCode = hashCode * 59 + this.Landmark.GetHashCode();
                return hashCode;
            }
        }
    }
}