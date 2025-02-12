using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Elb.V2.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class DeleteLoadbalancerRequest 
    {

        /// <summary>
        /// 负载均衡器id
        /// </summary>
        [SDKProperty("loadbalancer_id", IsPath = true)]
        [JsonProperty("loadbalancer_id", NullValueHandling = NullValueHandling.Ignore)]
        public string LoadbalancerId { get; set; }

        /// <summary>
        /// （不再支持）级联删除负载均衡器
        /// </summary>
        [SDKProperty("cascade", IsQuery = true)]
        [JsonProperty("cascade", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Cascade { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeleteLoadbalancerRequest {\n");
            sb.Append("  loadbalancerId: ").Append(LoadbalancerId).Append("\n");
            sb.Append("  cascade: ").Append(Cascade).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DeleteLoadbalancerRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DeleteLoadbalancerRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.LoadbalancerId == input.LoadbalancerId ||
                    (this.LoadbalancerId != null &&
                    this.LoadbalancerId.Equals(input.LoadbalancerId))
                ) && 
                (
                    this.Cascade == input.Cascade ||
                    (this.Cascade != null &&
                    this.Cascade.Equals(input.Cascade))
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
                if (this.LoadbalancerId != null)
                    hashCode = hashCode * 59 + this.LoadbalancerId.GetHashCode();
                if (this.Cascade != null)
                    hashCode = hashCode * 59 + this.Cascade.GetHashCode();
                return hashCode;
            }
        }
    }
}
