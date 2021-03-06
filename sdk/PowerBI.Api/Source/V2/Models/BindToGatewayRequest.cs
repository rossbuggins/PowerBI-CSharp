// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.PowerBI.Api.V2.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The bind dataset to gateway request
    /// </summary>
    public partial class BindToGatewayRequest
    {
        /// <summary>
        /// Initializes a new instance of the BindToGatewayRequest class.
        /// </summary>
        public BindToGatewayRequest()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the BindToGatewayRequest class.
        /// </summary>
        /// <param name="gatewayObjectId">The gateway id</param>
        public BindToGatewayRequest(string gatewayObjectId = default(string))
        {
            GatewayObjectId = gatewayObjectId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the gateway id
        /// </summary>
        [JsonProperty(PropertyName = "gatewayObjectId")]
        public string GatewayObjectId { get; set; }

    }
}
