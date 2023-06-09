// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace S2Search.SFTPGo.Client.AutoRest.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class SSHBinding
    {
        /// <summary>
        /// Initializes a new instance of the SSHBinding class.
        /// </summary>
        public SSHBinding()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SSHBinding class.
        /// </summary>
        /// <param name="address">TCP address the server listen on</param>
        /// <param name="port">the port used for serving requests</param>
        /// <param name="applyProxyConfig">apply the proxy configuration, if
        /// any</param>
        public SSHBinding(string address = default(string), int? port = default(int?), bool? applyProxyConfig = default(bool?))
        {
            Address = address;
            Port = port;
            ApplyProxyConfig = applyProxyConfig;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets TCP address the server listen on
        /// </summary>
        [JsonProperty(PropertyName = "address")]
        public string Address { get; set; }

        /// <summary>
        /// Gets or sets the port used for serving requests
        /// </summary>
        [JsonProperty(PropertyName = "port")]
        public int? Port { get; set; }

        /// <summary>
        /// Gets or sets apply the proxy configuration, if any
        /// </summary>
        [JsonProperty(PropertyName = "apply_proxy_config")]
        public bool? ApplyProxyConfig { get; set; }

    }
}
